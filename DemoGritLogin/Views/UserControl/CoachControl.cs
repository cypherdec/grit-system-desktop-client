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

namespace DemoGritLogin
{
    public partial class CoachControl : UserControl
    {
        string coachEmail;

        public CoachControl()
        {
            InitializeComponent();
        }

        static CoachControl _coachInstance; //form object instance
        public static CoachControl Instance //singleton pattern to make sure only one home form is created 
        {
            get 
            {
                if (_coachInstance == null)
                {
                    _coachInstance = new CoachControl();
                }
                return _coachInstance;
            }          
        }

        public string CoachEmail
        {
            get { return coachEmail; }
            set { coachEmail = value; }
        }

        public Label TestLabel
        {
            get { return lblCoachEmail; }
            set { lblCoachEmail = value; }
        }

        private void CoachControl_Load(object sender, EventArgs e)
        {
            _coachInstance = this; //create coach control form 
            GetData();
        }

        private void btnRefreshCoach_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAddNewCoach_Click(object sender, EventArgs e)
        {
            AddCoach();
            GetData();
        }

        private void btnUpdateLogin_Click(object sender, EventArgs e)
        {
            UpdateLogin();
            GetData();
        }

        private void GetData() //get data from database and fill grid view 
        {
            DAO data = new DAO();
            List<CoachModel> coaches = data.GetAllCoaches();

            gridViewCoaches.DataSource = coaches; //fill grid view with coaches table data 

            //since we use abstract base user class, the columns are out of order

            gridViewCoaches.Columns[0].HeaderText = "Coach ID";
            gridViewCoaches.Columns[1].HeaderText = "First Name";
            gridViewCoaches.Columns[2].HeaderText = "Last Name";
            gridViewCoaches.Columns[3].HeaderText = "Telephone";
            gridViewCoaches.Columns[4].HeaderText = "Email";
            gridViewCoaches.Columns[5].HeaderText = "Password";

            //manually rearrange columns

            gridViewCoaches.Columns[1].DisplayIndex = 1;
            gridViewCoaches.Columns[2].DisplayIndex = 2;
            gridViewCoaches.Columns[3].DisplayIndex = 3;
            gridViewCoaches.Columns[4].DisplayIndex = 4;

            gridViewCoaches.Columns[5].Visible = false; //hide columns for security
            gridViewCoaches.Columns[0].Visible = false;
        }

        private void btnDeleteCoach_Click(object sender, EventArgs e) //delete coach 
        {
            DAO data = new DAO();
            List<CoachModel> coaches = data.GetAllCoaches();

            if(coaches.Count == 1)
            {
                MessageBox.Show("Must have at least one coach registered in the system");
            }
            else
            {
                //get id and full name of selected coach
                string coachID = gridViewCoaches.CurrentRow.Cells[0].Value.ToString(); 
                string name = gridViewCoaches.CurrentRow.Cells[1].Value.ToString() + " " + gridViewCoaches.CurrentRow.Cells[2].Value.ToString();

                //confirmation box 
                var confirmResult = MessageBox.Show("Are you sure you want to delete this coach : " + name + " ?", "Confirm Delete!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    CoachModel coach = new CoachModel();
                    try
                    {
                        coach.CoachID = Int32.Parse(coachID);
                        if (data.DeleteCoach(coach))
                        {
                            GetData();
                            MessageBox.Show("Successfuly deleted");
                        }
                        else
                        {
                            MessageBox.Show("error, unable to delete");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("no coach selected");
                    }
                }
            }
        }

        private void AddCoach() //add a new coach 
        {
            DAO data = new DAO();
            CoachModel coach = new CoachModel();

            string firstName = txtNewCoachFname.Text;
            string lastName = txtNewCoachLname.Text;
            string tele = txtNewCoachTele.Text;
            string email = txtNewCoachEmail.Text;
            string password = txtNewCoachPass.Text;

            if (firstName != "" && lastName != "" && tele != "" && email != "" && password != "")
            {
                coach.FirstName = firstName;
                coach.LastName = lastName;
                coach.Tele = tele;
                coach.Email = email;
                coach.Password = password;

                if (data.SaveNewCoach(coach))
                {
                    MessageBox.Show("Successfuly saved");
                    txtNewCoachFname.Clear();
                    txtNewCoachLname.Clear();
                    txtNewCoachTele.Clear();
                    txtNewCoachEmail.Clear();
                    txtNewCoachPass.Clear();
                }
                else
                {
                    MessageBox.Show("error, unable to save");
                }
            }
            else
            {
                MessageBox.Show("Please fil in all fields");
            }            
        }

        private void UpdateLogin() //update login details 
        {
            CoachModel coach = new CoachModel();

            DAO data = new DAO();

            coach.Email = lblCoachEmail.Text;
            coach.Password = txtUpdateCurrentPass.Text;

            if (data.CoachLogin(coach).LastName != null)
            {
                if (txtUpdateNewPass.Text == txtUpdateConfirmPass.Text)
                {
                    coach.Password = txtUpdateNewPass.Text;
                    if (data.UpdateCoachLogin(coach))
                    {
                        MessageBox.Show("Successfully updated");

                        txtUpdateConfirmPass.Clear();
                        txtUpdateCurrentPass.Clear();
                        txtUpdateNewPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("error, unable to update");
                    }
                }
                else
                {
                    MessageBox.Show("new password does not match with confirm passsword");
                }
                
            }
            else
            {
                MessageBox.Show("invalid password");
            }

        }


    }
}
