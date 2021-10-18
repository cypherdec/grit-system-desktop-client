using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GritLibrary.Models;
using DemoGritLogin.Services;

namespace DemoGritLogin
{
    public partial class AnalyticsControl : UserControl
    {
        public AnalyticsControl()
        {
            InitializeComponent();
           
        }
       
        private void AnalyticsControl_Load(object sender, EventArgs e)
        {
            analyticsOverview1.BringToFront();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            buttonPanel.Top = btnOverview.Top;
            buttonPanel.Left = btnOverview.Left;
            analyticsOverview1.BringToFront();
        }

        private void btnCoachAnalytics_Click(object sender, EventArgs e)
        {
            buttonPanel.Top = btnCoachAnalytics.Top;
            buttonPanel.Left = btnCoachAnalytics.Left;
            analyticsCoach1.BringToFront();
        }

        private void btnClientAnalytics_Click(object sender, EventArgs e)
        {
            buttonPanel.Top = btnClientAnalytics.Top;
            buttonPanel.Left = btnClientAnalytics.Left;
            analyticsClient1.BringToFront();
        }

        private void btnProgressAnalytics_Click(object sender, EventArgs e)
        {
            buttonPanel.Top = btnProgressAnalytics.Top;
            buttonPanel.Left = btnProgressAnalytics.Left;
            analyticsProgress1.BringToFront();
        }
    }
}
