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
    public partial class ManageControl : UserControl
    {
        public ManageControl()
        {
            InitializeComponent();
        }

        //show and hide user controls based on user input 

        private void btnCoachHome_Click(object sender, EventArgs e)
        {
            buttonPanel.Width = btnCoachHome.Width;
            buttonPanel.Left = btnCoachHome.Left;
            coachControl1.BringToFront();
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            buttonPanel.Width = btnManageClients.Width;
            buttonPanel.Left = btnManageClients.Left;
            manageClientControl2.BringToFront();
        }

        private void btnManageNutrtion_Click(object sender, EventArgs e)
        {
            buttonPanel.Width = btnManageNutrition.Width;
            buttonPanel.Left = btnManageNutrition.Left;
            manageNutritionControl1.BringToFront();

        }

        private void ManageControl_Load(object sender, EventArgs e)
        {
            coachControl1.BringToFront();
        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            buttonPanel.Width = btnManageAdd.Width;
            buttonPanel.Left = btnManageAdd.Left;
            clientControl1.BringToFront();
        }
    }
}
