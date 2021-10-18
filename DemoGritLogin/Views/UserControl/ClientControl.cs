using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DemoGritLogin.Services;
using GritLibrary.Models;

namespace DemoGritLogin
{
    public partial class ClientControl : UserControl
    {
        // variables for bmi calculation
        private double weight;
        private double height;
        private double bmi;
        private String bmiRating;
       
         //bool values to validate text fields
        private bool fnameValidation = false;
        private bool lnameValidation = false;
        private bool emailValidation = false;
        private bool genderValidation = false; 
        private bool tgoalValidation = false;
        private bool teleValidation = false;
        private bool DOBvalidation = false;
        
        
        //bool value to check if all fields are filled in 
        private bool textValidation = false;
       
        //bool values to validate numeric fields
        private bool weightValidation = false;
        private bool heightValidation = false;
        
        //bool value to check if all numeric fields are valid and fillled in
        private bool numValidation = false;



        public ClientControl()
        {
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            //hides save button until all fields are validated
            fillCoaches();
            btnSave.Hide();
            cbxCoaches.Visible = false;
            lblCoach.Visible = false;
        }
        
        private void cbxGender_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : -1;
            Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : new SolidBrush(cbxGender.ForeColor);
            e.DrawBackground();
            if (index != -1)
            {
                e.Graphics.DrawString(cbxGender.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        } //changes background and font colour of combo boxes 

        private void cbxTgoal_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : -1;
            Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : new SolidBrush(cbxTgoal.ForeColor);
            e.DrawBackground();
            if (index != -1)
            {
                e.Graphics.DrawString(cbxTgoal.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }       
        
        private void ClearFields() //clears coponents after succesfully saving data
        {
            txtFname.Clear();
            txtLname.Clear();
            cbxGender.SelectedIndex = -1;
            txtTele.Clear();
            txtEmail.Clear();
            txtCweight.Clear();
            txtHeight.Clear();
            txtBmi.Clear();
            txtBmiRating.Clear();
            cbxTgoal.SelectedIndex = -1;
            dtCdate.ResetText();
        }

        private void ValidateNumfields() //validates number fields to make sure they are filled in appropiately
        {
            if (string.IsNullOrWhiteSpace(txtCweight.Text))
            {
                weightValidation = false;
                errorProvider1.SetError(txtCweight, "Please enter your weight");

            }
            else if (!string.IsNullOrWhiteSpace(txtCweight.Text) || weightValidation == false)
            {
                try
                {                    
                    double valid = Double.Parse(txtCweight.Text);
                    weightValidation = true;
                    errorProvider1.SetError(txtCweight, null);
                }
                catch (Exception )
                {
                    weightValidation = false;
                    errorProvider1.SetError(txtCweight, "please enter a valid weight in kg");
                }
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                heightValidation = false; 
                errorProvider1.SetError(txtHeight, "Please enter your height");
            }
            else if (!string.IsNullOrWhiteSpace(txtHeight.Text) || heightValidation == false)
            {
                try
                {
                    double valid = Double.Parse(txtHeight.Text);
                    errorProvider1.SetError(txtHeight, null);
                    heightValidation = true;
                }
                catch (Exception )
                {
                    heightValidation = false;
                    errorProvider1.SetError(txtHeight, "please enter a valid height in cm");
                }
            }
        }

        private void ValidateTextFields() //validates text fields to make sure they are filled in appropiately
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                errorProvider1.SetError(txtFname, "Please enter your First Name");
                fnameValidation = false;
            }
            else
            {
                errorProvider1.SetError(txtFname, null);
                fnameValidation = true;
            }

            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                errorProvider1.SetError(txtLname, "Please enter your Last Name");
                lnameValidation = false;
            }
            else
            {
                errorProvider1.SetError(txtLname, null);
                lnameValidation = true;
            } 
            
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please enter your Email");
                emailValidation = false;
            }
            else
            {
                errorProvider1.SetError(txtLname, null);
                emailValidation = true;
            }

            if (cbxGender.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxGender, "please select a gender");
                genderValidation = false;
            }
            else
            {
                errorProvider1.SetError(cbxGender, null);
                genderValidation = true;
            }            
            
            if (cbxTgoal.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxTgoal, "Please select a training goal");
                tgoalValidation = false;
            }
            else
            {
                errorProvider1.SetError(cbxTgoal, null);
                tgoalValidation = true;
            }

            if (string.IsNullOrWhiteSpace(txtTele.Text))
            {
                errorProvider1.SetError(txtTele, "Please enter a telephone number");
                teleValidation = false;
            }
            
            else if (!string.IsNullOrWhiteSpace(txtTele.Text))
            {
                try
                {
                    int valid = Convert.ToInt32(txtTele.Text);
                    errorProvider1.SetError(txtTele, null);
                    teleValidation = true;
                }
                catch (Exception )
                {
                    teleValidation = false;
                    errorProvider1.SetError(txtTele, "Please enter a valid telephone number");
                }
            }
            if (dtDOB.Value == dtCdate.Value)
            {
                DOBvalidation = false;
                errorProvider1.SetError(dtCdate, "Please select a DOB");
            }
            else
            {
                errorProvider1.SetError(dtCdate, null);
                DOBvalidation = true;
            }

        }

        private void TextValidationCheck() //check if text validation is successful 
        {
            if (fnameValidation==true && lnameValidation ==true && emailValidation ==true && genderValidation==true && tgoalValidation == true && teleValidation==true && DOBvalidation==true)
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
            fnameValidation = false;
            lnameValidation = false;
            genderValidation = false;
            tgoalValidation = false;
            teleValidation = false;
        }

        private void ResetNumValidation() //resets numeric validation
        {
            heightValidation = false;
            weightValidation = false;            
        }

        private void SaveInfo() //save info to database 
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();
            ProgressModel progress = new ProgressModel();

            client.FirstName = txtFname.Text;
            client.LastName = txtLname.Text;
            client.gender = cbxGender.SelectedItem.ToString();
            client.Tele = txtTele.Text;
            client.Date = dtDOB.Value;
            client.AssignedCoach = cbxCoaches.SelectedItem.ToString();
            client.Email = txtEmail.Text;

            client.Password = "test123"; //default password for new accounts 

            progress.CurrentWeight = int.Parse(txtCweight.Text);
            progress.CurrentHeight = int.Parse(txtHeight.Text);
            progress.BMI = float.Parse(txtBmi.Text);
            progress.BmiRating = txtBmiRating.Text;
            progress.TrainingGoal = cbxTgoal.SelectedItem.ToString();
            progress.CurrentDate = dtCdate.Value;

            if (data.SaveNewClientAndProgressInfo(client, progress))  //boolean check to see if success 
            {
                MessageBox.Show("data saved");
            }
            else
            {
                MessageBox.Show("error saving data");
            }           
            
        }

        private bool CheckInfo() //make sure user isnt already registered
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();
            client.FirstName = txtFname.Text;
            client.LastName = txtLname.Text;

            if (data.CheckIfClientIsRegistered(client))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void CalculateBMI() //method to calculate bmi and assign a rating
        {
            height = Double.Parse(txtHeight.Text);
            weight = Double.Parse(txtCweight.Text);
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


            txtBmiRating.Text = bmiRating;
            txtBmi.Text = bmi.ToString("0.00");
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validates all fields before saving

            ValidateTextFields();
            ValidateNumfields();
            TextValidationCheck();
            NumValidationCheck();
            
            if (textValidation == true && numValidation == true)
            {
                //check if user is already registered 
                if (CheckInfo())
                {
                    MessageBox.Show("this user is already registered");
                }
                else 
                {
                    //resets validation to avoid errors 
                    ResetNumValidation();
                    ResetTextValidation();

                    //saves data to database and clears all fields

                    if(cbxCoaches.SelectedIndex.ToString() == null)
                    {
                        MessageBox.Show("Please select a coach");
                    }
                    else
                    {
                        SaveInfo();
                        ClearFields();
                        btnSave.Hide();
                        cbxCoaches.Visible = false;
                        lblCoach.Visible = false;
                    }


                }                
            }
            else
            {
                MessageBox.Show("please ensure all fields are filled in");
            }
                    
        }

        private void fillCoaches()
        {
            DAO data = new DAO();
            List<CoachModel> coaches = data.GetAllCoaches();

            List<string> names = new List<string>();

            foreach(CoachModel coach in coaches)
            {
                string name = coach.FirstName + " " + coach.LastName;
                names.Add(name);
            }

            cbxCoaches.DataSource = names;
        }

        private void txtCweight_TextChanged(object sender, EventArgs e)  //validates fields and calculates bmi value dyamically as the user types
        {           
            if(txtCweight.Text != "")
            {
               
                ValidateNumfields();
                NumValidationCheck();
                if (numValidation == true)
                {
                    CalculateBMI();
                    cbxCoaches.Visible = true;
                    lblCoach.Visible = true;
                    btnSave.Show();
                    ResetNumValidation();
                    ResetTextValidation();
                }
                else
                {
                    btnSave.Hide();
                }
            }

            
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if(txtHeight.Text != ""){
                //validates fields and calculates bmi value dyamically as the user types
                ValidateNumfields();
                NumValidationCheck();
                if (numValidation == true)
                {
                    CalculateBMI();
                    cbxCoaches.Visible = true;
                    lblCoach.Visible = true;
                    btnSave.Show();
                    ResetNumValidation();
                    ResetTextValidation();
                    
                }
                else
                {
                    btnSave.Hide();
                }
            }

           
        }
    }
}
