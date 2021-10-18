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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DAO data = new DAO();
            CoachModel coach = new CoachModel();

            /*coach.Email = txtLoginEmail.Text;
            coach.Password = txtLoginPassword.Text;*/

            coach.Email = "cav@gmail.com";  // for testing 
            coach.Password = "123";


            if (data.CoachLogin(coach).FirstName != null)
            {      
                txtLoginEmail.Clear();  //clear fields after successful login 
                txtLoginPassword.Clear();

                if (!frmHome.Instance.LoginControl.Controls.ContainsKey("ManageControl")) //check to see if user hasnt already logged in
                {
                    ManageControl mc = new ManageControl();
                    frmHome.Instance.LoginControl.Controls.Add(mc); //changes manage button to open ManageControl if already logged in  
                    mc.Dock = DockStyle.Fill; //set dock to fill          
                    
                }
                //set data and perform actions in othr forms using singleton 
                frmHome.Instance.LoginControl.Controls["ManageControl"].BringToFront(); //brings manage control to front 
                frmHome.Instance.LogoutButton.Visible = true;
                frmHome.Instance.AnalyticsButton.Visible = true;
                frmHome.Instance.CoachEmail = coach.Email;
                frmHome.Instance.LabelEmail.Visible = true;
                frmHome.Instance.LabelEmail.Text = "Welcome " + coach.FirstName + " " + coach.LastName ;

                CoachControl.Instance.TestLabel.Text = coach.Email;

            }
            else
            {
                MessageBox.Show("invalid login credentials");
            }
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
       
    }
}
