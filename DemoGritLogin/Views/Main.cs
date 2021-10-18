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
    public partial class frmHome : Form
    {
        bool isMax;
        private bool _Moving = false;
        private Point _Offset;
        public string coachEmail;

        //2031, 1163


        static frmHome _homeInstance; //form object instance
        public static frmHome Instance //singleton pattern to make sure only one home form is created 
        {
            get
            {
                if(_homeInstance == null)
                {
                    _homeInstance = new frmHome();
                }
                return _homeInstance;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _homeInstance = this; //create home form 

            btnLogout.Visible = false;
            lblMainEmail.Visible = false;
            btnAnalytics.Visible = false;

            LoginControl login = new LoginControl();
            LoginControl.Controls.Add(login); //changes manage button to open login control on form load and after logout              

        }

        public string CoachEmail
        {
            get { return coachEmail; }
            set { coachEmail = value; }
        }

        public Label LabelEmail 
        {
            get { return lblMainEmail; }
            set { lblMainEmail = value; }
        }
       
        public LoginControl LoginControl //instance of login control 
        {
            get { return loginControl1; }
            set { loginControl1 = value; }
        }

        public Button LogoutButton //instance of logout button 
        {
            get { return btnLogout; }
            set { btnLogout = value; }
        }

        public Button AnalyticsButton
        {
            get { return btnAnalytics; }
            set { btnAnalytics = value; }
        }       
       
        public frmHome()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            homeControl1.BringToFront();
        }

        

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.BackgroundImage = DemoGritLogin.Properties.Resources.exit_highlight;
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.BackgroundImage = DemoGritLogin.Properties.Resources.exit_normal;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbResize_Click(object sender, EventArgs e)
        {
            if (!isMax)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
                pbResize.BackgroundImage = DemoGritLogin.Properties.Resources.compress;

            }
            else if (isMax)
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
                pbResize.BackgroundImage = DemoGritLogin.Properties.Resources.enlarge;
            }
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

     

        private void btnDiet_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDiet.Height;
            SidePanel.Top = btnDiet.Top;
            nutritionControl1.BringToFront();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbResize_MouseHover(object sender, EventArgs e)
        {
            pbResize.BackColor = Color.DimGray;
        }

        private void pbResize_MouseLeave(object sender, EventArgs e)
        {
            pbResize.BackColor = Color.Black;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProgress.Height;
            SidePanel.Top = btnProgress.Top;
            progressControl1.BringToFront();
        }

        private void pbMinimize_MouseHover(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.DimGray;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Black;
        }

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            _Moving = true;
            _Offset = new Point(e.X, e.Y);
        }

        private void pnTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                _Moving = false;
            }
        }

        private void pnTop_MouseMove(object sender, MouseEventArgs e) //move form with mouse without form border 
        {
            if (_Moving)
            {
                Point newlocation = this.Location;
                newlocation.X += e.X - _Offset.X;
                newlocation.Y += e.Y - _Offset.Y;
                this.Location = newlocation;
            }

        }

        private void btnManage_Click(object sender, EventArgs e)
        {            
            SidePanel.Height = btnManage.Height;
            SidePanel.Top = btnManage.Top;
            loginControl1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            LoginControl.Controls["LoginControl"].BringToFront();  //singleton instance of login control 
            LoginControl.Controls["LoginControl"].Dock = DockStyle.Fill; //reset to dock fill, else will be gap in border

            btnLogout.Visible = false; //clear UI to logout state 
            lblMainEmail.Visible = false;
            btnAnalytics.Visible = false;

            SidePanel.Height = btnManage.Height;
            SidePanel.Top = btnManage.Top;
            loginControl1.BringToFront(); //login control component in main form;

            
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAnalytics.Height;
            SidePanel.Top = btnAnalytics.Top;
            analyticsControl1.BringToFront();
        }
    }
}
