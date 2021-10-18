using DemoGritLogin.Controllers;
using DemoGritLogin.Models;
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
    public partial class ManageFoodControl : UserControl
    {
        public ManageFoodControl()
        {
            InitializeComponent();
        }

        private void ManageFoodControl_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           GetData();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            lblFoodID.Text = gridViewFoods.CurrentRow.Cells[0].Value.ToString(); //invisible lbl to hold client id 
            string gender = gridViewFoods.CurrentRow.Cells[1].Value.ToString();
            txtFoodName.Text = gridViewFoods.CurrentRow.Cells[2].Value.ToString();
            txtProtein.Text = gridViewFoods.CurrentRow.Cells[3].Value.ToString();
            txtFat.SelectedIndex = gridViewFoods.FindStringExact(gender);
            txtCarbs.Text = gridViewFoods.CurrentRow.Cells[5}.Value.ToString();
        }

        private void btnNewFood_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveNewFood_Click(object sender, EventArgs e)
        {

        }


        private void GetData()
        {
            DatabaseController data = new DatabaseController();
            List<FoodModel> foods = data.GetAllFoods();

            gridViewFoods.DataSource = foods; //fill grid view with foods table data 


            gridViewFoods.Columns[0].HeaderText = "Food ID";
            gridViewFoods.Columns[1].HeaderText = "Food Name";
            gridViewFoods.Columns[2].HeaderText = "Food Type";
            gridViewFoods.Columns[3].HeaderText = "Protien";
            gridViewFoods.Columns[4].HeaderText = "Fat";
            gridViewFoods.Columns[5].HeaderText = "Carbs";
            gridViewFoods.Columns[6].HeaderText = "Calories";

          
        }

    }
}
