using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoGritLogin.Services;
using GritLibrary.Models;

namespace DemoGritLogin
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            CountRegistered();
        }

        public void HomeControl_Load(object sender, EventArgs e) //show total number of clients and date 
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDay.Text = DateTime.Now.DayOfWeek.ToString();
            CountRegistered();
        }

        private void CountRegistered() //get total number of registered clients and display in home screen
        {
            DAO data = new DAO();

            try
            {
                List<ClientModel> clients = data.GetAllClients();
                int clientsNum = clients.Count;
                txtRegistered.Text = clientsNum.ToString();
            }
            catch
            {
                lblRegistered.Hide();
                txtRegistered.Text = "unable to connect to database";
            }

            lblRegistered.Left = txtRegistered.Right;
            
        }

       
    }
}
