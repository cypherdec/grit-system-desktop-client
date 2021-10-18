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
    public partial class ManageNutritionControl : UserControl
    {
        public ManageNutritionControl()
        {
            InitializeComponent();
        }

        private void ManageNutritionControl_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)  //refresh data if changes arent showing up 
        {
            GetData();
        }

        private void btnEditFood_Click(object sender, EventArgs e) //prepare form for edit function 
        {
            lblEditFoodID.Text = gridViewNutrition.CurrentRow.Cells[0].Value.ToString(); //invisible lbl to hold food id 
            string foodType = gridViewNutrition.CurrentRow.Cells[2].Value.ToString();

            txtEditFoodName.Text = gridViewNutrition.CurrentRow.Cells[1].Value.ToString();
            cbxFoodType.SelectedIndex = cbxFoodType.FindStringExact(foodType);
            txtEditProtein.Text = gridViewNutrition.CurrentRow.Cells[3].Value.ToString();
            txtEditFat.Text = gridViewNutrition.CurrentRow.Cells[4].Value.ToString();
            txtEditCarbs.Text = gridViewNutrition.CurrentRow.Cells[5].Value.ToString();
            txtEditCalories.Text = gridViewNutrition.CurrentRow.Cells[6].Value.ToString();

            btnSaveEditFood.BringToFront();
        }

        private void btnAddFood_Click(object sender, EventArgs e) //prepare form for add function 
        {
            ClearTextboxes();
            btnSaveNewFood.BringToFront();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e) // delete selected food item
        {
            string foodid = gridViewNutrition.CurrentRow.Cells[0].Value.ToString();
            string name = gridViewNutrition.CurrentRow.Cells[1].Value.ToString();

            var confirmResult = MessageBox.Show("Are you sure to delete this food : " + name + " ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                DAO data = new DAO();
                FoodModel food = new FoodModel();
                try
                {
                    food.FoodID = Int32.Parse(foodid);
                    if (data.DeleteFood(food))
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
                    MessageBox.Show("no food selected");
                }
            }
        }

        private void btnSaveNewFood_Click(object sender, EventArgs e) //save food to database 
        {
            DAO data = new DAO();
            FoodModel food = new FoodModel();

            food.FoodName = txtEditFoodName.Text;
            food.FoodType = cbxFoodType.SelectedItem.ToString();
            food.Protein = float.Parse(txtEditProtein.Text);
            food.Fat = float.Parse(txtEditFat.Text);
            food.Carbs = float.Parse(txtEditCarbs.Text);
            food.Calories = float.Parse(txtEditCalories.Text);

            if (data.SaveFood(food))
            {
                MessageBox.Show("Successfuly Saved");
                ClearTextboxes();
                GetData();
            }
            else
            {
                MessageBox.Show("error, unable to save");
            }
        }

        private void btnSaveEditFood_Click(object sender, EventArgs e) //update food with edited details 
        {
            DAO data = new DAO();
            FoodModel food = new FoodModel();

            food.FoodID = int.Parse(lblEditFoodID.Text);
            food.FoodName = txtEditFoodName.Text;
            food.FoodType = cbxFoodType.SelectedItem.ToString();
            food.Protein = float.Parse(txtEditProtein.Text);
            food.Fat = float.Parse(txtEditFat.Text);
            food.Carbs = float.Parse(txtEditCarbs.Text);
            food.Calories = float.Parse(txtEditCalories.Text);

            if (data.UpdateFood(food))
            {
                MessageBox.Show("Successfuly edited");
                ClearTextboxes();
                GetData();
            }
            else{
                MessageBox.Show("error, unable to update");
            }

        }

        private void GetData() //get data from database and fill grid view 
        {
            DAO data = new DAO();
            List<FoodModel> foods= data.GetAllFoods();

            gridViewNutrition.DataSource = foods; //fill grid view with food table data 

            gridViewNutrition.Columns[0].HeaderText = "Food ID";
            gridViewNutrition.Columns[1].HeaderText = "Food Name";
            gridViewNutrition.Columns[2].HeaderText = "Food Type";
            gridViewNutrition.Columns[3].HeaderText = "Protein";
            gridViewNutrition.Columns[4].HeaderText = "Fat";
            gridViewNutrition.Columns[5].HeaderText = "Carbs";
            gridViewNutrition.Columns[6].HeaderText = "Calories";

            gridViewNutrition.Columns[0].Visible = false;

        }


        private void ClearTextboxes() //clear textboxes to clean up form 
        {
            txtEditFoodName.Clear();
            cbxFoodType.SelectedIndex = -1;
            txtEditProtein.Clear();
            txtEditFat.Clear();
            txtEditCarbs.Clear();
            txtEditCalories.Clear();

        }

       
    }
}
