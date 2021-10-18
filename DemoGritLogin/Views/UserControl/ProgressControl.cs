using DemoGritLogin.Services;
using GritLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoGritLogin
{
    public partial class ProgressControl : UserControl
    {
       
        protected override Point ScrollToControl(Control activeControl) //disable auto scroll with method override 
        {
            return DisplayRectangle.Location;   
        }

        private string lname;
        private string fname;
        private string getBMIRating;
        private decimal getWeight;
        private decimal getHeight;
        private decimal getBMI;
        private string getTrainingGoal;
        private string getGender;
        private DateTime getAge;
        private int age;
     
        // variables for bmi calculation
        private double height;
        private double weight;
        private double bmi;
        private String bmiRating;
        
        //bool values to validate text fields
        private bool tgoalValidation = false;

        //bool value to check if all fields are filled in 
        private bool textValidation = false;

        //bool values to validate numeric fields
        private bool weightValidation = false;
        private bool heightValidation = false;
        
        //bool value to check if all numeric fields are valid and fillled in
        private bool numValidation = false;

        public ProgressControl()
        {
            InitializeComponent();
        }

        private void ProgressControl_Load(object sender, EventArgs e)
        {
            AutoComleteSearch();
            btnSaveProgress.Hide();
            gbxUProgress.Hide();
        }

        private void AutoComleteSearch() //get autocomplete text for search box
        {

            try
            {
                DAO data  = new DAO();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = data.Auto();
            }
            catch
            {
                MessageBox.Show("error, check database connection");
            }
        }



        private void btnSearch_Click(object sender, EventArgs e) //search database for user and siaply details 
        {
            SplitName();


            if (lname == null || fname == null)
            {

                MessageBox.Show("Please enter a valid client name");
            }
            else
            {
                GetData();
                SetAge();
                SetDetails();
                FillChart();
                gbxUProgress.Show();
            }
        }

        private void SplitName() //split name in search box to first nae and last name 
        {
            if (txtSearch.Text.Contains(','))//checking if textbox has 2 values
            {
                string[] arryval = txtSearch.Text.Split(',');//split values with ‘,’  
                int j = arryval.Length;
                int i = 0;
                for (i = 0; i < j; i++)
                {
                    lname = arryval[i];
                    fname = arryval[0];
                }
            }
            else
            {
                lname = null;
                fname = null;
                MessageBox.Show("this user is not registered");
            }
        }

        private void GetData() //get data form database and fill gridview 
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();  //crate new client model 

            client.FirstName = fname;
            client.LastName = lname;

            ClientModel getClient = data.GetClientDataFromSearch(client);  //get client from database using first and last name 

            ProgressModel progress = data.GetProgressDataFromClientID(getClient.ClientID); //get progress records for client 

            if (getClient != null && progress != null)
            {
                lblfname.Text = getClient.FirstName;
                lblLname.Text = getClient.LastName;
                lblLname.Left = lblfname.Right; //align labels side by side and fit to name

                labelID.Text = getClient.ClientID.ToString();

                getAge = getClient.Date;
                getGender = getClient.gender;
                getHeight = progress.CurrentHeight;
                getWeight = progress.CurrentWeight;
                getBMI = (decimal)progress.BMI;
                getBMIRating = progress.BmiRating;
                getTrainingGoal = progress.TrainingGoal;

            }
            else
            {
                MessageBox.Show("error, check database connection");
            }
        }

        private void SetAge() //calculate age using dob
        {
            age = 0;
            age = DateTime.Now.Year - getAge.Year;
            if (DateTime.Now.DayOfYear < getAge.DayOfYear)
                age = age - 1;

        }

        private void FillChart() //filter database request based on range of progress needed 
        {
            int clientID = Int32.Parse(labelID.Text);
            int past = 0;
            DAO data = new DAO();

            if (cbxRecords.SelectedIndex == -1)  //how many records user wants to see
            {
                past = 0;
            }
            else if (cbxRecords.SelectedIndex == 0)
            {
                past = 0;
            }
            else if (cbxRecords.SelectedIndex == 1)
            {
                past = 1;
            }
            else if (cbxRecords.SelectedIndex == 2)
            {
                past = 3;
            }
            else if (cbxRecords.SelectedIndex == 3)
            {
                past = 6;
            }
            else if (cbxRecords.SelectedIndex == 4)
            {
                past = 12;
            }

            List<ProgressModel> progresses = data.GetClientProgresses(clientID,past); //sends client id and number of records to controller

            ProgressChart.Series["Progress"].Points.Clear(); //clears chart to avoid clutter 

            foreach (var progress in progresses)  //gets weight and date of progress data 
            {
                ProgressChart.Series["Progress"].Points.AddXY(progress.CurrentDate, progress.CurrentWeight); // add points to graph 
            }


        }

        private void SetDetails() //show details in labels and textboxes 
        {
            labelAge.Text = age.ToString();
            labelHeight.Text = getHeight.ToString();
            labelWeight.Text = getWeight.ToString();
            labelBMI.Text = getBMI.ToString();
            LabelBmiRating.Text = getBMIRating.ToString();
            labelTrain.Text = getTrainingGoal.ToString();

            txtUHeight.Text = getHeight.ToString();
            txtUWeight.Text = getWeight.ToString();
            try
            {
                CalculateBMI();
            }
            catch
            {

            }

            cbxUTraining.SelectedIndex = cbxUTraining.FindStringExact(getTrainingGoal);


            lblfname.Show();
            lblLname.Show();
        }

        private void btnSaveProgress_Click(object sender, EventArgs e) //save progress to database 
        {

            ValidateTextFields();
            ValidateNumfields();
            TextValidationCheck();
            NumValidationCheck();

            if (textValidation == true && numValidation == true)
            {               
                //resets validation to avoid errors 
                ResetNumValidation();
                ResetTextValidation();

                //saves data to database and clears all fields

                SaveInfo();
                ClearFields();

                //update form after new progress
                GetData();
                SetAge();
                SetDetails();
                FillChart();
                gbxUProgress.Show();
            }
        }

        private void ClearFields() //clears coponents after succesfully saving data
        {
            txtUWeight.Clear();
            txtUHeight.Clear();
            txtUBMI.Clear();
            txtUBMIRating.Clear();
            cbxUTraining.SelectedIndex = -1;
        }

        private void ValidateNumfields()  //validates number fields to make sure they are filled in appropiately
        {
          

            if (string.IsNullOrWhiteSpace(txtUWeight.Text))
            {
                weightValidation = false;
                errorProvider1.SetError(txtUWeight, "Please Enter Weight");

            }
            else if (!string.IsNullOrWhiteSpace(txtUWeight.Text) || weightValidation == false)
            {
                try
                {
                    double valid = Double.Parse(txtUWeight.Text);
                    weightValidation = true;
                }
                catch (Exception)
                {
                    weightValidation = false;
                    errorProvider1.SetError(txtUWeight, "please enter a valid weight in kg");
                }
            }

            if (string.IsNullOrWhiteSpace(txtUHeight.Text))
            {
                heightValidation = false;
                errorProvider1.SetError(txtUHeight, "Please Enter Height");
            }
            else if (!string.IsNullOrWhiteSpace(txtHeight.Text) || heightValidation == false)
            {
                try
                {
                    double valid = Double.Parse(txtUHeight.Text);
                    heightValidation = true;
                }
                catch (Exception)
                {
                    heightValidation = false;
                    errorProvider1.SetError(txtUHeight, "please enter a valid height in cm");
                }
            }
        }

        private void ValidateTextFields()  //validates text fields to make sure they are filled in appropiately
        {
          

            if (cbxUTraining.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxUTraining, "please enter a valid height in cm");
                tgoalValidation = false;
            }
            else
            {
                tgoalValidation = true;
            }

        }

        private void TextValidationCheck()  //check if text validation is successful 
        {
          

            if (tgoalValidation == true )
            {
                textValidation = true;
            }
            else
            {
                textValidation = false;
            }
        }

        private void NumValidationCheck() //check if numeric validation is successful 
        {
           
            if (heightValidation == true && weightValidation == true)
            {
                numValidation = true;
            }
            else
            {
                numValidation = false;
            }
        }

        private void ResetTextValidation() //resets text validation
        {
           
            tgoalValidation = false;
        }

        private void ResetNumValidation() //resets numeric validation
        {
           

            heightValidation = false;
            weightValidation = false;

        }

        private void SaveInfo() //save info to database 
        {
            DAO data = new DAO();
            ProgressModel progress = new ProgressModel();

            progress.ClientID = Int32.Parse(labelID.Text);
            progress.CurrentWeight = int.Parse(txtUWeight.Text);
            progress.CurrentHeight = int.Parse(txtUHeight.Text);
            progress.BMI = float.Parse(txtUBMI.Text);
            progress.BmiRating = txtUBMIRating.Text;
            progress.TrainingGoal = cbxUTraining.SelectedItem.ToString();
            progress.CurrentDate = txtUDate.Value;

            if (data.UpdateClientProgress(progress))
            {
                MessageBox.Show("data saved");
            }
            else
            {
                MessageBox.Show("error saving data");
            }

        }

        private void CalculateBMI()  //method to calculate bmi and assign a rating
        {
          

            height = Double.Parse(txtUHeight.Text);
            weight = Double.Parse(txtUWeight.Text);
            height = height / 100;
            bmi = weight / (height * height);



            if (bmi < 18.5)
            {
                bmiRating = "Underweight";
            }
            else if (bmi < 24.9)
            {
                bmiRating = "Normal Weight";
            }
            else if (bmi < 29.9)
            {
                bmiRating = "Overweight";
            }
            else
            {
                bmiRating = "Obese";
            }


            txtUBMIRating.Text = bmiRating;
            txtUBMI.Text = bmi.ToString("0.00");
        }

        private void txtUWeight_TextChanged(object sender, EventArgs e)  //validates fields and calculates bmi value dyamically as the user types
        {
            if(txtUWeight.Text != "")
            {
              
                ValidateNumfields();
                NumValidationCheck();
                if (numValidation == true)
                {
                    CalculateBMI();
                    btnSaveProgress.Show();
                    ResetNumValidation();
                }
                else
                {
                    btnSaveProgress.Hide();
                }
            }
        }

        private void txtUHeight_TextChanged(object sender, EventArgs e)
        {
            if (txtUHeight.Text != "")
            {
                //validates fields and calculates bmi value dyamically as the user types
                ValidateNumfields();
                NumValidationCheck();
                if (numValidation == true)
                {
                    CalculateBMI();
                    btnSaveProgress.Show();
                    ResetNumValidation();
                }
                else
                {
                    btnSaveProgress.Hide();
                }
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            AutoComleteSearch();
        }

        private void gbxUProgress_Enter(object sender, EventArgs e)
        {

        }
    }
}
