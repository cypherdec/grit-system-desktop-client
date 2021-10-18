using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GritLibrary.Models;
using DemoGritLogin.Services;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using DemoGritLogin.Models;
using System.Net.Mail;
using System.Net;
using Newtonsoft.Json;

namespace DemoGritLogin
{
    public partial class NutritionControl : UserControl
    {

        protected override Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;   //disable auto scroll with method override 
        }



        private string lname;
        private string fname;
        private string getBMIRating;
        private decimal getWeight;
        private decimal getHeight;
        private decimal getBMI;
        private string getTrainingGoal;
        private string getGender;
        private DateTime getAge;
        private int age;

        private int proteinGrams;
        private int fatGrams;
        private int carbsGrams;
        private int totalCalories;

        bool isRecipe = false;


        public NutritionControl()
        {
            InitializeComponent();
            lblfname.Hide();
            lblLname.Hide();
            NutritionChart.Hide();
            gbxPlanner.Hide();

            pbxLogo.Hide();
            btnPrint.Visible = false;

        }

        private void AutoComleteSearch() //get autocomplete text for search box
        {

            try
            {
                DAO data = new DAO();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = data.Auto();
            }
            catch {
                MessageBox.Show("error, check database connection");
            }
        }

        private void NutritionControl_Load(object sender, EventArgs e)
        {
            AutoComleteSearch();   
        }

        private void SplitName() //splits name in search field to first name and last name
        {
            if (txtSearch.Text.Contains(','))//checking if textbox has 2 values
            {
                string[] arryval = txtSearch.Text.Split(',');//split values with ‘,’  
                int j = arryval.Length;
                int i = 0;
                for (i = 0; i < j; i++)
                {
                    lname = arryval[i];
                    fname = arryval[0];
                }
            }
            else
            {
                MessageBox.Show("this user is not registered");
            }
        }

        private void GetData() //get data from database for specified client 
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();

            client.FirstName = fname;
            client.LastName = lname;

            ClientModel getClient = data.GetClientDataFromSearch(client);

            ProgressModel progress = data.GetProgressDataFromClientID(getClient.ClientID);

            if (getClient != null && progress != null)
            {
                lblfname.Text = getClient.FirstName;
                lblLname.Text = getClient.LastName;
                lblLname.Left = lblfname.Right; //align labels side by side and fit to name
                lblEmail.Text = getClient.Email;

                labelID.Text = getClient.ClientID.ToString();

                getAge = getClient.Date;
                getGender = getClient.gender;
                getHeight = progress.CurrentHeight;
                getWeight = progress.CurrentWeight;
                getBMI = (decimal)progress.BMI;
                getBMIRating = progress.BmiRating;
                getTrainingGoal = progress.TrainingGoal;

            }
            else
            {
                MessageBox.Show("error, check database connection");
            }
        }

        private void SetAge() //calculate age of clietn based on DOB
        {
            age = 0;
            age = DateTime.Now.Year - getAge.Year;
            if (DateTime.Now.DayOfYear < getAge.DayOfYear)
                age = age - 1;

        }

        private void SetDetails() //set client details in labels 
        {
            labelAge.Text = age.ToString();
            labelHeight.Text = getHeight.ToString();
            labelWeight.Text = getWeight.ToString();
            labelBMI.Text = getBMI.ToString();
            LabelBmiRating.Text = getBMIRating.ToString();
            labelTrain.Text = getTrainingGoal.ToString();

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");

            lblfname.Show();
            lblLname.Show();
            gbxPlanner.Show();
            btnPrint.Visible = true;

            LoadRecipe();

            gbxPlanner.Show();
            gbxTogleMeal.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e) //search for client and show details 
        {

            SplitName();


            if (lname == "" || fname == "")
            {

                MessageBox.Show("this user is not registered");
            }
            else
            {
                // CheckValidity();
                GetData();
                SetAge();
                SetDetails();
                CalculateCalories();
                FillComboBox();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            AutoComleteSearch();
        }

        private void CalculateCalories() //calculate nutrition for client and fill pie chart
        {
            string protein;
            string carbs;
            string fat;
            decimal tdc; //total daily calories 
            decimal weightInPounds = getWeight + (decimal)2.205;

            if (getGender == "Male")  //get total daily calories for a male 
            {
                tdc = ((decimal)13.397 * getWeight) + ((decimal)4.799 * getHeight) - ((decimal)5.677 * age) + (decimal)88.362;
            }
            else //get total daily calories for a female 
            {
                tdc = ((decimal)9.247 * getWeight) + ((decimal)3.098 * getHeight) - ((decimal)3.098 * age) + (decimal)447.593;
            }

            if (getTrainingGoal == "Weight Loss")  // for weight loss, reduce 10% of daily calories 
            {
                tdc = tdc - (tdc / 10);
            }
            else // for weight gain, add 10% extra of daily calories 
            {
                tdc = tdc + (tdc / 10);
            }

            // macro amounts based off the journal of medical health US
            //calculate amount in grams of macros and how many calories 
            proteinGrams = (int)weightInPounds; 
            int proteinCalories = proteinGrams * 4;
            fatGrams = (int)((int)weightInPounds * 0.5);
            int fatCalories = fatGrams * 9;
            int carbsCalories = (int)(tdc - (fatCalories + proteinCalories));
            carbsGrams = carbsCalories / 4;
            int daily = (int)tdc;

            totalCalories = daily; //format data into string formats for display 
            protein = proteinGrams.ToString() + " grams " + "   (" + proteinCalories.ToString() + " calories " + ")";
            fat = fatGrams.ToString() + " grams " + "   (" + fatCalories.ToString() + " calories " + ")";
            carbs = carbsGrams.ToString() + " grams " + "   (" + carbsCalories.ToString() + " calories " + ")";

            lblCalories.Text = daily.ToString() + " Calories"; //set values to textboxes 
            lblProtein.Text = protein;
            lblFat.Text = fat;
            lblCarbs.Text = carbs;

            NutritionChart.Series[0].Points.Clear(); //fill pie chart with maco nutrient data

            NutritionChart.Series["Nutrition"].Points.Add((int)proteinGrams).LegendText = "protein";
            NutritionChart.Series["Nutrition"].Points.Add((int)fatGrams).LegendText = "fat";
            NutritionChart.Series["Nutrition"].Points.Add((int)carbsGrams).LegendText = "carbs";


            NutritionChart.Show();
        }    

        private int GetAmount(string name) //gets amount of macros and returns how many grams of food to take to obtain macros 
        {
            float amount = 0;

            DAO data = new DAO();
            FoodModel food = data.GetFoodAmount(name);

            if (food.FoodType == "Protein")
            {
                amount = float.Parse(proteinGrams.ToString()) / food.Protein;
            }
            else if (food.FoodType == "Fat")
            {
                amount = float.Parse(fatGrams.ToString()) / food.Fat;
            }
            else if (food.FoodType == "Carb")
            {
                amount = float.Parse(carbsGrams.ToString()) / food.Carbs;
            }

            amount = amount / 3;

            int intAmount = (int)amount;

            return intAmount;
        }

        private void btnPrint_Click(object sender, EventArgs e)  //print nutrition report and save 
        {
            this.Cursor = Cursors.WaitCursor; //show wait cursor for visual feedback while process executes 

            string fileName = "";

            paneldetails.AutoSize = true;
            paneldetails.Refresh();
            pbxLogo.Show();  //show logo 

            btnPrint.Hide();  //hide  buttons to clean up form before mailing to client 
            btnViewRecipe.Hide();
            btnShowPlanner.Hide();
            btnShowRecipe.Hide();
            pnlToggleRecipe.Hide();
            gridViewRecipes.ClearSelection();

            using (Bitmap bmp = new Bitmap(paneldetails.Width, paneldetails.Height))  //create new bitmap image of panel containing nutrition details 
            {

                paneldetails.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

                fileName = lblfname.Text + "_" + lblLname.Text + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") + ".png";
                bmp.Save(@"C://Users//sandu//Pictures//GritFiles//" + fileName, ImageFormat.Png); // make sure path exists!

            }

            btnPrint.Show();
            btnViewRecipe.Show();
            btnShowPlanner.Show();
            btnShowRecipe.Show();
            pnlToggleRecipe.Show();

            pbxLogo.Hide();
            paneldetails.AutoSize = false;
            paneldetails.Refresh();

            WaitSeconds(3000); //wait till file is available 

            string dir = @"C://Users//sandu//Pictures//GritFiles//" + fileName;

            string deletePath = "C:\\Users\\sandu\\Pictures\\GritFiles" + fileName;

            SendEmail(dir, deletePath);  //send email 
            SaveMealPlan();

            this.Cursor = Cursors.Default;
        }

        private void SaveMealPlan()
        {
            string jsonString;
            int clientID = int.Parse(labelID.Text);

            if (isRecipe) //create recipe json object 
            {
                List<RecipeDTO> recipeDTOs = gridViewRecipes.DataSource as List<RecipeDTO>;

                ClientRecipeDTO clientRecipeDTO = new ClientRecipeDTO();

                clientRecipeDTO.meal1 = recipeDTOs[0].Title; //get values from list and assign to object 
                clientRecipeDTO.meal2 = recipeDTOs[1].Title;
                clientRecipeDTO.meal3 = recipeDTOs[2].Title;

                clientRecipeDTO.mealurl1 = recipeDTOs[0].Url;
                clientRecipeDTO.mealurl2 = recipeDTOs[1].Url;
                clientRecipeDTO.mealurl3 = recipeDTOs[2].Url;

                jsonString = JsonConvert.SerializeObject(clientRecipeDTO);               

            }
            else //create custom meal plan json object 
            {
                MealDTO mealDTO = new MealDTO();

                //if no food selected, set as empty string with ?? ""
                mealDTO.proteinName1 = cbxProtein.SelectedItem?.ToString() ?? ""; 
                mealDTO.proteinName2 = cbxProtein2.SelectedItem?.ToString() ?? "";
                mealDTO.proteinName3 = cbxProtein3.SelectedItem?.ToString() ?? "";
                
                //replace g (for grams) in the label with empty string
                mealDTO.proteinAmount1 = lblProteinAmount.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.proteinAmount2 = lblProteinAmount2.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.proteinAmount3 = lblProteinAmount3.Text?.Replace("g", string.Empty) ?? "";

                mealDTO.carbName1 = cbxCarbs.SelectedItem?.ToString() ?? "";
                mealDTO.carbName2 = cbxCarbs2.SelectedItem?.ToString() ?? "";
                mealDTO.carbName3 = cbxCarbs3.SelectedItem?.ToString() ?? "";

                mealDTO.carbsAmount1 = lblCarbsAmount.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.carbsAmount2 = lblCarbsAmount2.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.carbsAmount3 = lblCarbsAmount3.Text?.Replace("g", string.Empty) ?? "";

                mealDTO.fatName1 = cbxFat.SelectedItem?.ToString() ?? "";
                mealDTO.fatName2 = cbxFat2.SelectedItem?.ToString() ?? "";
                mealDTO.fatName3 = cbxFat3.SelectedItem?.ToString() ?? "";

                mealDTO.fatAmount1 = lblFatAmount.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.fatAmount2 = lblFatAmount2.Text?.Replace("g", string.Empty) ?? "";
                mealDTO.fatAmount3 = lblFatAmount3.Text?.Replace("g", string.Empty) ?? "";

                jsonString = JsonConvert.SerializeObject(mealDTO);
            }

            DAO dao = new DAO();

            dao.SaveMealPlan(clientID, jsonString);

        }  //save meal plan to database 

        private void SendEmail(string path, string deletePath)
        {
            string address = lblEmail.Text.ToString();
            List<RecipeDTO> recipeDTOs = gridViewRecipes.DataSource as List<RecipeDTO>;  //get list of displayed recipes 

            MailMessage mailMessage = new MailMessage(Environment.GetEnvironmentVariable("email"), address);  // from and to address, get users address from database 
            mailMessage.Subject = "GRIT Nutrition Plan";           

            if (isRecipe) //if recipe tab is selected, send recipe links 
            {
                string url1 = "<a href=" + recipeDTOs[0].Url + "> " + recipeDTOs[0].Title + " </a>";  //construct href link with recipe url and title 
                string url2 = "<a href=" + recipeDTOs[1].Url + "> " + recipeDTOs[1].Title + " </a>";
                string url3 = "<a href=" + recipeDTOs[2].Url + "> " + recipeDTOs[2].Title + " </a>";

               mailMessage.Body = "Your Nutrition plan is attached. <br> <br> Recipe Links: <br><br>"  + url1 + "<br><br>" + url2 + "<br><br>" + url3;   //add links as html 
               mailMessage.IsBodyHtml = true;
            }
            else
            {
                mailMessage.Body = "Your Nutrition plan is attached ";
            }

            Attachment attachment = new Attachment(path);
            attachment.Name = "GRITNutritionPlan.png";  // rename attachment
            mailMessage.Attachments.Add(attachment);

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = Environment.GetEnvironmentVariable("email"),
                    Password = Environment.GetEnvironmentVariable("emailpass")
                }; //email credentials KEEP HIDDEN 
                try
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credential;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(mailMessage);
                    MessageBox.Show("sent email to " + address);

                    try
                    {
                        File.Delete(deletePath); //delete file after emailing 
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("could not delete file " + e.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error, Email could not be sent, please check network connection");
                }
            }
        } //send email to client 

        private void WaitSeconds(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        } //timer to wait specified seconds 

        private async void LoadRecipe()  //get recipe from api 
        {
            try
            {
                Root root = await GetRecipesFromAPI(); //async request to get data from api 

                List<RecipeDTO> recipeDTOs = GetList(root); //get list of recipes from root model 

                gridViewRecipes.Show();

                FillData(recipeDTOs);   //fill grid view with recipes  
            }
            catch (Exception e) //if errror occours
            {
                MessageBox.Show("Unable to access web services" + e);
            }
        }

        private void FillData(List<RecipeDTO> recipeDTOs)  //fill grid view with recipe data
        {
            gridViewRecipes.DataSource = recipeDTOs;      
            gridViewRecipes.Columns[0].HeaderText = "Recipe";

        }

        private List<RecipeDTO> GetList(Root root) //get list of recipes from API Root 
        {
            List<RecipeDTO> recipeDTOs = new List<RecipeDTO>();

            lblRcals.Text = root.Nutrients.Calories.ToString() + "g";  //display nutrition data for recipes
            lblRprotein.Text = root.Nutrients.Protein.ToString() + "g";
            lblRfat.Text = root.Nutrients.Fat.ToString() + "g";
            lblRcarbs.Text = root.Nutrients.Carbohydrates.ToString() + "g";
                            
            foreach (Meal m in root.Meals)
            {
                RecipeDTO recipeDTO = new RecipeDTO();

                recipeDTO.ID = m.ID;
                recipeDTO.Title = m.Title;
                recipeDTO.Url = m.SourceUrl;

                recipeDTOs.Add(recipeDTO);
            }      

            return recipeDTOs;
        }

        private async Task<Root> GetRecipesFromAPI() //get recipes based on caloric breakdown from API
        {
            string calories = totalCalories.ToString();//calories for client 
            
            //modify url for api request 
            string url = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/mealplans/generate?timeFrame=day&targetCalories=" + calories;
            Root root = new Root();

            var client = new HttpClient();
            var request = new HttpRequestMessage //new api request
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "x-rapidapi-key", Environment.GetEnvironmentVariable("api-key") },
                    { "x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request)) //get api response 
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
             
                root = JToken.Parse(body).ToObject<Root>(); //parse json to root object
            }
            return root;
        }

        private async Task<RecipeRoot> GetRecipeSummary(string id)  //get recipe summary for a recipe 
        {
            string url = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/" + id + "/summary";
            RecipeRoot recipe = new RecipeRoot();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "x-rapidapi-key", Environment.GetEnvironmentVariable("api-key") },
                    { "x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                recipe = JToken.Parse(body).ToObject<RecipeRoot>(); //parse request JSon to RecipeRoot object 
            }

            return recipe;
        }

        private void btnShowPlanner_Click(object sender, EventArgs e)
        {
            pnlToggleRecipe.Left = btnShowPlanner.Left;
            pnlToggleRecipe.Width = btnShowPlanner.Width;
            gbxPlanner.Show();
            gbxTogleMeal.Hide();
            isRecipe = false;
        } //show planner panel 

        private void btnShowRecipe_Click(object sender, EventArgs e)
        {
            pnlToggleRecipe.Left = btnShowRecipe.Left;
            pnlToggleRecipe.Width = btnShowRecipe.Width;
            gbxPlanner.Hide();
            gbxTogleMeal.Show();
            isRecipe = true;
        } //show recipe panel 

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {

            RecipeDTO recipeDTO = gridViewRecipes.CurrentRow.DataBoundItem as RecipeDTO; //get selected recipe 

            string url = recipeDTO.Url;

            Process.Start(url);
        }  //open selected recipe in browser 
        private void FillComboBox() //fill combobox with food items from database 
        {
            DAO data = new DAO();

            //get list of foods of the same type 
            List<FoodModel> proteins = data.GetAllOfAType("Protein");  
            List<FoodModel> fats = data.GetAllOfAType("Fat");
            List<FoodModel> carbs = data.GetAllOfAType("Carb");

            foreach (FoodModel protein in proteins) //fill combobox with protein type foods
            {
                string name = protein.FoodName;
                cbxProtein.Items.Add(name);  //add food to combobox
                cbxProtein2.Items.Add(name);
                cbxProtein3.Items.Add(name);
            }

            foreach (FoodModel fat in fats)
            {
                string name = fat.FoodName;
                cbxFat.Items.Add(name);
                cbxFat2.Items.Add(name);
                cbxFat3.Items.Add(name);
            }
            foreach (FoodModel carb in carbs)
            {
                string name = carb.FoodName;
                cbxCarbs.Items.Add(name);
                cbxCarbs2.Items.Add(name);
                cbxCarbs3.Items.Add(name);
            }
        }


        private void cbxProtein_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxProtein.SelectedItem.ToString();

            lblProteinAmount.Text = GetAmount(name).ToString() + " g";

        } //calculate amount of protein needed as user selects form combobox

        private void cbxFat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxFat.SelectedItem.ToString();

            lblFatAmount.Text = GetAmount(name).ToString() + " g";
        } //calculate amount of fat needed as user selects form combobox

        private void cbxCarbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxCarbs.SelectedItem.ToString();

            lblCarbsAmount.Text = GetAmount(name).ToString() + " g";
        } //calculate amount of carbs needed as user selects form combobox

        private void cbxProtein2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxProtein2.SelectedItem.ToString();

            lblProteinAmount2.Text = GetAmount(name).ToString() + " g";
        }

        private void cbxProtein3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxProtein3.SelectedItem.ToString();

            lblProteinAmount3.Text = GetAmount(name).ToString() + " g";
        }

        private void cbxFat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxFat2.SelectedItem.ToString();

            lblFatAmount2.Text = GetAmount(name).ToString() + " g";
        }

        private void cbxFat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxFat3.SelectedItem.ToString();

            lblFatAmount3.Text = GetAmount(name).ToString() + " g";
        }

        private void cbxCarbs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxCarbs2.SelectedItem.ToString();

            lblCarbsAmount2.Text = GetAmount(name).ToString() + " g";
        }

        private void cbxCarbs3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxCarbs3.SelectedItem.ToString();

            lblCarbsAmount3.Text = GetAmount(name).ToString() + " g";
        }
    }


}


