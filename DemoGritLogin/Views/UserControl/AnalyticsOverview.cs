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
    public partial class AnalyticsOverview : UserControl
    {
        public AnalyticsOverview()
        {
            InitializeComponent();
        }


        private void AnalyticsOverview_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DAO data = new DAO();
            List<CoachModel> coaches = data.GetAllCoaches();
            List<ClientModel> clients = data.GetAllClients();
            List<FoodModel> foods = data.GetAllFoods();
            List<ProgressModel> progresses = data.GetAllProgresses();

            lblClientsNo.Text = clients.Count.ToString();
            lblCoachNo.Text = coaches.Count.ToString();
            lblProgressNo.Text = progresses.Count.ToString();
            lblFoodNo.Text = foods.Count.ToString();

        }
    }
}
