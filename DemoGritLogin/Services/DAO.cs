using GritLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGritLogin.Services
{
    public class DAO : IDAO  //implement IDAO interface 
    {
        //connection string to mysql databse 
        MySqlConnection connection = new MySqlConnection(@"server=localhost;user id=sandy; password=Sandulno1; pooling=false; persistsecurityinfo=True;database=gritappdb");

        public bool SaveNewClientAndProgressInfo(ClientModel client, ProgressModel progress) //save a new client and intitial progress details when registering 
        {
            try
            {
                connection.Open();

                //save client info to client table 
                MySqlCommand saveCommand = new MySqlCommand("INSERT INTO dbClients (FirstName, LastName, Gender, Tele, DOB, Email, Password, AssignedCoach) VALUES (@fname, @lname, @gender, @tele, @dob, @email, @password, @coach)");

                //parameterized query to prevent sql injection
                saveCommand.Parameters.AddWithValue("@fname", client.FirstName);
                saveCommand.Parameters.AddWithValue("@lname", client.LastName);
                saveCommand.Parameters.AddWithValue("@gender", client.gender);
                saveCommand.Parameters.AddWithValue("@tele", client.Tele);
                saveCommand.Parameters.AddWithValue("@email", client.Email);
                saveCommand.Parameters.AddWithValue("@password", client.Password);
                saveCommand.Parameters.AddWithValue("@coach", client.AssignedCoach);
                saveCommand.Parameters.Add("@dob", MySqlDbType.Date).Value = client.Date;
                saveCommand.Connection = connection;
                saveCommand.ExecuteNonQuery();
                connection.Close();


                connection.Open();
                //get clientID from clients table 
                MySqlCommand getClientIDCommand = new MySqlCommand("SELECT clientID, FirstName, LastName FROM dbClients WHERE FirstName = @fname AND LastName=@lname");

                getClientIDCommand.Parameters.AddWithValue("@fname", client.FirstName);
                getClientIDCommand.Parameters.AddWithValue("@lname", client.LastName);

                getClientIDCommand.Connection = connection;

                MySqlDataReader clientIDDataReader = getClientIDCommand.ExecuteReader();

                while (clientIDDataReader.Read())
                {
                    client.ClientID = (int)clientIDDataReader["clientID"];
                }

                connection.Close();


                connection.Open();

                //save client progress info to progress table
                MySqlCommand saveProgressCommand = new MySqlCommand("INSERT INTO dbProgress (clientID, CurrentWeight, Height, BMI, BMI_Rating, TrainingGoal, CurrentDate) VALUES (" + client.ClientID + ", @cweight, @height, @bmi, @bmirating, @tgoal, @cdate)");

                saveProgressCommand.Parameters.AddWithValue("@cweight", progress.CurrentWeight);
                saveProgressCommand.Parameters.AddWithValue("@height", progress.CurrentHeight);
                saveProgressCommand.Parameters.AddWithValue("@bmi", progress.BMI);
                saveProgressCommand.Parameters.AddWithValue("@bmirating", progress.BmiRating);
                saveProgressCommand.Parameters.AddWithValue("@tgoal", progress.TrainingGoal);
                saveProgressCommand.Parameters.Add("@cdate", MySqlDbType.Date).Value = progress.CurrentDate;

                saveProgressCommand.Connection = connection;
                saveProgressCommand.ExecuteNonQuery();


                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public bool UpdateClientProgress(ProgressModel progress) //update client progress 
        {
            try
            {
                connection.Open();

                //save client progress info to progress table
                MySqlCommand saveUpdatedProgressCommand = new MySqlCommand("INSERT INTO dbProgress (clientID, CurrentWeight, Height, BMI, BMI_Rating, TrainingGoal, CurrentDate) VALUES (@cid, @cweight, @height, @bmi, @bmirating, @tgoal, @cdate)");

                saveUpdatedProgressCommand.Parameters.AddWithValue("@cid", progress.ClientID);
                saveUpdatedProgressCommand.Parameters.AddWithValue("@cweight", progress.CurrentWeight);
                saveUpdatedProgressCommand.Parameters.AddWithValue("@height", progress.CurrentHeight);
                saveUpdatedProgressCommand.Parameters.AddWithValue("@bmi", progress.BMI);
                saveUpdatedProgressCommand.Parameters.AddWithValue("@bmirating", progress.BmiRating);
                saveUpdatedProgressCommand.Parameters.AddWithValue("@tgoal", progress.TrainingGoal);
                saveUpdatedProgressCommand.Parameters.Add("@cdate", MySqlDbType.Date).Value = progress.CurrentDate;

                saveUpdatedProgressCommand.Connection = connection;

                saveUpdatedProgressCommand.ExecuteNonQuery();

                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }
        }

        public bool CheckIfClientIsRegistered(ClientModel client) //check if client has already registered to avoid errrors or duplicates
        {
            //check if the user has already been registered in the system
            //get clientID from clients table 
            MySqlCommand checkClientCommand = new MySqlCommand("SELECT FirstName, LastName FROM dbClients WHERE FirstName = @fname AND LastName=@lname");

            checkClientCommand.Parameters.AddWithValue("@fname", client.FirstName);
            checkClientCommand.Parameters.AddWithValue("@lname", client.LastName);

            checkClientCommand.Connection = connection;
            connection.Open();

            MySqlDataReader checkClientDataReader = checkClientCommand.ExecuteReader();

            if (checkClientDataReader.HasRows)
            {
                connection.Close();
                return true;

            }
            else
            {
                connection.Close();
                return false;
            }


        }

        public AutoCompleteStringCollection Auto()  //get data from clients table to get autocomplete source
        {
            connection.Open();
            MySqlCommand autocompleteCommand = new MySqlCommand("SELECT FirstName, LastName FROM dbClients");
            autocompleteCommand.Connection = connection;

            MySqlDataReader odr = autocompleteCommand.ExecuteReader();
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            while (odr.Read())
            {

                autoText.Add(String.Format("{0},{1}", odr["FirstName"], odr["LastName"]));  //combine first and last name with a , 

            }

            connection.Close();
            odr.Dispose();
            autocompleteCommand.Dispose();
            connection.Dispose();

            MySqlConnection.ClearPool(connection);
            MySqlConnection.ClearAllPools();

            return autoText;
        }

        public ClientModel GetClientDataFromSearch(ClientModel client) //get client data using search bar 
        {

            MySqlCommand checkClientCommand = new MySqlCommand("SELECT * FROM dbClients WHERE FirstName = @fname AND LastName=@lname");

            checkClientCommand.Parameters.AddWithValue("@fname", client.FirstName);
            checkClientCommand.Parameters.AddWithValue("@lname", client.LastName);

            checkClientCommand.Connection = connection;
            connection.Open();

            MySqlDataReader checkClientDataReader = checkClientCommand.ExecuteReader();

            if (checkClientDataReader.HasRows)
            {
                while (checkClientDataReader.Read())
                {
                    client.ClientID = (int)checkClientDataReader["clientID"];
                    client.FirstName = (string)checkClientDataReader["FirstName"];
                    client.LastName = (string)checkClientDataReader["LastName"];
                    client.gender = (string)checkClientDataReader["Gender"];
                    client.Tele = (string)checkClientDataReader["Tele"];
                    client.Date = (DateTime)checkClientDataReader["DOB"];
                    client.Email = (string)checkClientDataReader["Email"];
                    client.Password = (string)checkClientDataReader["Password"];
                    client.AssignedCoach = (string)checkClientDataReader["AssignedCoach"];
                }

                connection.Close();
                return client;

            }
            else
            {
                connection.Close();
                return client;
            }

        }

        public ProgressModel GetProgressDataFromClientID(int id) //get latest progress data for client
        {

            MySqlCommand ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress WHERE ClientID = @id ORDER BY CurrentDate ASC");

            ProgressCommand.Parameters.AddWithValue("@id", id);

            ProgressCommand.Connection = connection;
            connection.Open();

            ProgressModel progress = new ProgressModel();

            MySqlDataReader progressDataReader = ProgressCommand.ExecuteReader();

            if (progressDataReader.HasRows)
            {

                while (progressDataReader.Read())
                {
                    progress.ProgressID = (int)progressDataReader["progressID"];
                    progress.CurrentWeight = (int)progressDataReader["CurrentWeight"];
                    progress.CurrentHeight = (int)progressDataReader["Height"];
                    progress.BMI = (float)progressDataReader["BMI"];
                    progress.BmiRating = (string)progressDataReader["BMI_Rating"];
                    progress.TrainingGoal = (string)progressDataReader["TrainingGoal"];
                    progress.CurrentDate = (DateTime)progressDataReader["CurrentDate"];
                }


                connection.Close();
                return progress;

            }
            else
            {
                connection.Close();
                return progress;
            }
        }

        public List<ProgressModel> GetClientProgresses(int id, int pastRecords) //get a list of all progress data for a selected client 
        {
            DateTime past = DateTime.Now.AddMonths(-pastRecords);

            MySqlCommand ProgressCommand = new MySqlCommand();

            if (pastRecords == 0) //see all records
            {
                ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress WHERE ClientID = @id ORDER BY CurrentDate ASC");
            }
            else//filter records 
            {
                ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress WHERE ClientID = @id AND CurrentDate>@time ORDER BY CurrentDate ASC");
            }

            ProgressCommand.Parameters.AddWithValue("@time", past);
            ProgressCommand.Parameters.AddWithValue("@id", id);

            ProgressCommand.Connection = connection;
            connection.Open();


            List<ProgressModel> progresses = new List<ProgressModel>();

            MySqlDataReader progressDataReader = ProgressCommand.ExecuteReader();

            while (progressDataReader.HasRows)
            {
                while (progressDataReader.Read())
                {
                    ProgressModel progress = new ProgressModel();

                    progress.ProgressID = (int)progressDataReader["progressID"];
                    progress.CurrentWeight = (int)progressDataReader["CurrentWeight"];
                    progress.CurrentHeight = (int)progressDataReader["Height"];
                    progress.BMI = (float)progressDataReader["BMI"];
                    progress.BmiRating = (string)progressDataReader["BMI_Rating"];
                    progress.TrainingGoal = (string)progressDataReader["TrainingGoal"];
                    progress.CurrentDate = (DateTime)progressDataReader["CurrentDate"];

                    progresses.Add(progress);
                }
                connection.Close();
            }
            return progresses;
        }

        public List<ProgressModel> GetAnalyticsClientProgresses(int pastRecords) //get a list of all progress data for a selected client 
        {
            DateTime past = DateTime.Now.AddMonths(-pastRecords);

            MySqlCommand ProgressCommand = new MySqlCommand();

            if (pastRecords == 0) //see all records
            {
                ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress ORDER BY CurrentDate ASC");
            }
            else//filter records 
            {
                ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress WHERE  CurrentDate>@time ORDER BY CurrentDate ASC");
            }

            ProgressCommand.Parameters.AddWithValue("@time", past);

            ProgressCommand.Connection = connection;
            connection.Open();


            List<ProgressModel> progresses = new List<ProgressModel>();

            MySqlDataReader progressAnalyticsDataReader = ProgressCommand.ExecuteReader();

            while (progressAnalyticsDataReader.HasRows)
            {
                while (progressAnalyticsDataReader.Read())
                {
                    ProgressModel progress = new ProgressModel();

                    progress.ProgressID = (int)progressAnalyticsDataReader["progressID"];
                    progress.ClientID = (int)progressAnalyticsDataReader["ClientID"];
                    progress.CurrentWeight = (int)progressAnalyticsDataReader["CurrentWeight"];
                    progress.CurrentHeight = (int)progressAnalyticsDataReader["Height"];
                    progress.BMI = (float)progressAnalyticsDataReader["BMI"];
                    progress.BmiRating = (string)progressAnalyticsDataReader["BMI_Rating"];
                    progress.TrainingGoal = (string)progressAnalyticsDataReader["TrainingGoal"];
                    progress.CurrentDate = (DateTime)progressAnalyticsDataReader["CurrentDate"];

                    progresses.Add(progress);
                }
                connection.Close();
            }
            return progresses;
        }

        public List<ProgressModel> GetAllProgresses() //get a list of all progress data for all clients
        {          
            MySqlCommand ProgressCommand = new MySqlCommand();
            ProgressCommand = new MySqlCommand("SELECT * FROM dbProgress ORDER BY CurrentDate ASC");
           
            ProgressCommand.Connection = connection;
            connection.Open();

            List<ProgressModel> progresses = new List<ProgressModel>();

            MySqlDataReader progressDataReader = ProgressCommand.ExecuteReader();

            while (progressDataReader.HasRows)
            {
                while (progressDataReader.Read())
                {
                    ProgressModel progress = new ProgressModel();

                    progress.ProgressID = (int)progressDataReader["progressID"];
                    progress.ClientID = (int)progressDataReader["ClientID"];
                    progress.CurrentWeight = (int)progressDataReader["CurrentWeight"];
                    progress.CurrentHeight = (int)progressDataReader["Height"];
                    progress.BMI = (float)progressDataReader["BMI"];
                    progress.BmiRating = (string)progressDataReader["BMI_Rating"];
                    progress.TrainingGoal = (string)progressDataReader["TrainingGoal"];
                    progress.CurrentDate = (DateTime)progressDataReader["CurrentDate"];

                    progresses.Add(progress);
                }
                connection.Close();
            }
            return progresses;
        }

        public List<ClientModel> GetAllClients() //gets a list of all registered clients
        {
            MySqlCommand checkClientCommand = new MySqlCommand("SELECT * FROM dbClients");

            List<ClientModel> clients = new List<ClientModel>();

            checkClientCommand.Connection = connection;
            connection.Open();

            MySqlDataReader checkClientDataReader = checkClientCommand.ExecuteReader();

            while (checkClientDataReader.HasRows)
            {
                while (checkClientDataReader.Read())
                {
                    ClientModel client = new ClientModel();

                    client.ClientID = (int)checkClientDataReader["clientID"];
                    client.FirstName = (string)checkClientDataReader["FirstName"];
                    client.LastName = (string)checkClientDataReader["LastName"];
                    client.gender = (string)checkClientDataReader["Gender"];
                    client.Tele = (string)checkClientDataReader["Tele"];
                    client.Date = (DateTime)checkClientDataReader["DOB"];
                    client.Email = (string)checkClientDataReader["Email"];
                    client.Password = (string)checkClientDataReader["Password"];
                    client.AssignedCoach = (string)checkClientDataReader["AssignedCoach"];


                    clients.Add(client);
                }
                connection.Close();
            }
            return clients;
        }

        public CoachModel CoachLogin(CoachModel coach) //checks coach login credentials 
        {
            MySqlCommand coachLoginCommand = new MySqlCommand("SELECT * FROM dbCoaches WHERE Email = @email AND Password=@password");

            coachLoginCommand.Parameters.AddWithValue("@email", coach.Email);
            coachLoginCommand.Parameters.AddWithValue("@password", coach.Password);

            coachLoginCommand.Connection = connection;
            connection.Open();

            MySqlDataReader checkLogin = coachLoginCommand.ExecuteReader();

            while (checkLogin.Read())
            {
                coach.CoachID = (int)checkLogin["coachId"];
                coach.FirstName = (string)checkLogin["FirstName"];
                coach.LastName = (string)checkLogin["LastName"];
                coach.Tele = (string)checkLogin["Tele"];
                coach.Email = (string)checkLogin["Email"];
                coach.Password = (string)checkLogin["Password"];
            }

            connection.Close();
            return coach;


        }

        public bool UpdateClient(ClientModel client) //update client info 
        {
            try
            {
                connection.Open();


                MySqlCommand updateCommand = new MySqlCommand("UPDATE dbClients SET FirstName=@fname, LastName=@lname, Gender=@gender, Tele=@tele, DOB=@dob, Email=@email, AssignedCoach=@coach WHERE clientID = @id");

                //parameterized query to prevent sql injection
                updateCommand.Parameters.AddWithValue("@id", client.ClientID);
                updateCommand.Parameters.AddWithValue("@fname", client.FirstName);
                updateCommand.Parameters.AddWithValue("@lname", client.LastName);
                updateCommand.Parameters.AddWithValue("@gender", client.gender);
                updateCommand.Parameters.AddWithValue("@tele", client.Tele);
                updateCommand.Parameters.AddWithValue("@email", client.Email);
                updateCommand.Parameters.AddWithValue("@coach", client.AssignedCoach);
                updateCommand.Parameters.Add("@dob", MySqlDbType.Date).Value = client.Date;
                updateCommand.Connection = connection;
                updateCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public bool DeleteClient(ClientModel client) //delete client and their progress 
        {

            try
            {
                connection.Open();


                MySqlCommand deleteClientCommand = new MySqlCommand("DELETE FROM dbclients WHERE clientID = @id");

                //parameterized query to prevent sql injection
                deleteClientCommand.Parameters.AddWithValue("@id", client.ClientID);

                deleteClientCommand.Connection = connection;
                deleteClientCommand.ExecuteNonQuery();
                connection.Close();

                connection.Open();


                MySqlCommand deleteCommand = new MySqlCommand("DELETE  FROM dbProgress WHERE clientID = @id");

                //parameterized query to prevent sql injection
                deleteCommand.Parameters.AddWithValue("@id", client.ClientID);

                deleteCommand.Connection = connection;
                deleteCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public List<CoachModel> GetAllCoaches() //get all coaches in a list
        {
            MySqlCommand getCoachCommand = new MySqlCommand("SELECT * FROM dbCoaches");

            List<CoachModel> coaches = new List<CoachModel>();

            getCoachCommand.Connection = connection;
            connection.Open();

            MySqlDataReader getCoachDataReader = getCoachCommand.ExecuteReader();

            while (getCoachDataReader.HasRows)
            {
                while (getCoachDataReader.Read())
                {
                    CoachModel coach = new CoachModel();

                    coach.CoachID = (int)getCoachDataReader["coachId"];
                    coach.FirstName = (string)getCoachDataReader["FirstName"];
                    coach.LastName = (string)getCoachDataReader["LastName"];
                    coach.Tele = (string)getCoachDataReader["Tele"];
                    coach.Email = (string)getCoachDataReader["Email"];
                    coach.Password = (string)getCoachDataReader["Password"];

                    coaches.Add(coach);
                }
                connection.Close();
            }
            return coaches;
        }

        public bool DeleteCoach(CoachModel coach) //delelete a coach 
        {
            try
            {
                connection.Open();


                MySqlCommand deleteCoachCommand = new MySqlCommand("DELETE FROM dbcoaches WHERE coachID = @id");

                //parameterized query to prevent sql injection
                deleteCoachCommand.Parameters.AddWithValue("@id", coach.CoachID);

                deleteCoachCommand.Connection = connection;
                deleteCoachCommand.ExecuteNonQuery();
                connection.Close();


                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public bool SaveNewCoach(CoachModel coach) //save a new coach 
        {
            try
            {
                connection.Open();

                //save client info to client table 
                MySqlCommand saveCoachCommand = new MySqlCommand("INSERT INTO dbCoaches (FirstName, LastName, Tele, Email, Password) VALUES (@fname, @lname, @tele, @email, @pass)");

                //parameterized query to prevent sql injection
                saveCoachCommand.Parameters.AddWithValue("@fname", coach.FirstName);
                saveCoachCommand.Parameters.AddWithValue("@lname", coach.LastName);
                saveCoachCommand.Parameters.AddWithValue("@tele", coach.Tele);
                saveCoachCommand.Parameters.AddWithValue("@email", coach.Email);
                saveCoachCommand.Parameters.AddWithValue("@pass", coach.Password);
                saveCoachCommand.Connection = connection;
                saveCoachCommand.ExecuteNonQuery();

                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }


        }

        public bool UpdateCoachLogin(CoachModel coach) //update coach 
        {
            try
            {
                connection.Open();


                MySqlCommand updateCoachCommand = new MySqlCommand("UPDATE dbCoaches SET Password=@pass WHERE Email = @email");

                //parameterized query to prevent sql injection
                updateCoachCommand.Parameters.AddWithValue("@email", coach.Email);
                updateCoachCommand.Parameters.AddWithValue("@pass", coach.Password);


                updateCoachCommand.Connection = connection;
                updateCoachCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }
        }

        public List<FoodModel> GetAllFoods() //get all foods in a list
        {
            MySqlCommand getFoodsCommand = new MySqlCommand("SELECT * FROM dbFood");

            List<FoodModel> foods = new List<FoodModel>();

            getFoodsCommand.Connection = connection;
            connection.Open();

            MySqlDataReader getFoodDataReader = getFoodsCommand.ExecuteReader();

            while (getFoodDataReader.HasRows)
            {
                while (getFoodDataReader.Read())
                {
                    FoodModel food = new FoodModel();

                    food.FoodID = (int)getFoodDataReader["FoodID"];
                    food.FoodName = (string)getFoodDataReader["FoodName"];
                    food.FoodType = (string)getFoodDataReader["FoodType"];
                    food.Protein = (float)getFoodDataReader["Protein"];
                    food.Fat = (float)getFoodDataReader["Fat"];
                    food.Carbs = (float)getFoodDataReader["Carbs"];
                    food.Calories = (float)getFoodDataReader["Calories"];

                    foods.Add(food);
                }
                connection.Close();
            }
            return foods;
        }

        public bool UpdateFood(FoodModel food) //update food 
        {
            try
            {
                connection.Open();


                MySqlCommand updateFoodCommand = new MySqlCommand("UPDATE dbFood SET FoodName=@fname, FoodType=@ftype, Protein=@protein, Fat=@fat, Carbs=@carbs, Calories=@calories  WHERE FoodID = @id");

                //parameterized query to prevent sql injection
                updateFoodCommand.Parameters.AddWithValue("@id", food.FoodID);
                updateFoodCommand.Parameters.AddWithValue("@fname", food.FoodName);
                updateFoodCommand.Parameters.AddWithValue("@ftype", food.FoodType);
                updateFoodCommand.Parameters.AddWithValue("@protein", food.Protein);
                updateFoodCommand.Parameters.AddWithValue("@fat", food.Fat);
                updateFoodCommand.Parameters.AddWithValue("@carbs", food.Carbs);
                updateFoodCommand.Parameters.AddWithValue("@calories", food.Calories);

                updateFoodCommand.Connection = connection;
                updateFoodCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }
        }

        public bool SaveFood(FoodModel food) // save a new food  
        {
            try
            {
                connection.Open();



                MySqlCommand saveFoodCommand = new MySqlCommand("INSERT INTO dbFood(FoodName, FoodType, Protein, Fat, Carbs, Calories) VALUES(@fname, @ftype, @protein, @fat, @carbs, @calories)");

                //parameterized query to prevent sql injection
                saveFoodCommand.Parameters.AddWithValue("@fname", food.FoodName);
                saveFoodCommand.Parameters.AddWithValue("@ftype", food.FoodType);
                saveFoodCommand.Parameters.AddWithValue("@protein", food.Protein);
                saveFoodCommand.Parameters.AddWithValue("@fat", food.Fat);
                saveFoodCommand.Parameters.AddWithValue("@carbs", food.Carbs);
                saveFoodCommand.Parameters.AddWithValue("@calories", food.Calories);

                saveFoodCommand.Connection = connection;
                saveFoodCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public bool DeleteFood(FoodModel food) // delete a food
        {
            try
            {
                connection.Open();

                MySqlCommand deleteFoodCommand = new MySqlCommand("DELETE FROM dbfood WHERE foodID = @id");

                //parameterized query to prevent sql injection
                deleteFoodCommand.Parameters.AddWithValue("@id", food.FoodID);

                deleteFoodCommand.Connection = connection;
                deleteFoodCommand.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
                return false;
            }

        }

        public List<FoodModel> GetAllOfAType(string type)
        {
            MySqlCommand getProteinsCommand = new MySqlCommand("SELECT * FROM dbFood WHERE FoodType = @type");
            getProteinsCommand.Parameters.AddWithValue("@type", type);

            List<FoodModel> proteins = new List<FoodModel>();

            getProteinsCommand.Connection = connection;
            connection.Open();

            MySqlDataReader getProteinsDataReader = getProteinsCommand.ExecuteReader();

            while (getProteinsDataReader.HasRows)
            {
                while (getProteinsDataReader.Read())
                {
                    FoodModel food = new FoodModel();

                    food.FoodID = (int)getProteinsDataReader["FoodID"];
                    food.FoodName = (string)getProteinsDataReader["FoodName"];
                    food.FoodType = (string)getProteinsDataReader["FoodType"];
                    food.Protein = (float)getProteinsDataReader["Protein"];
                    food.Fat = (float)getProteinsDataReader["Fat"];
                    food.Carbs = (float)getProteinsDataReader["Carbs"];
                    food.Calories = (float)getProteinsDataReader["Calories"];

                    proteins.Add(food);
                }
                connection.Close();
            }
            return proteins;
        } //get all foods of a type in a list 

        public FoodModel GetFoodAmount(string name)
        {
            MySqlCommand getFoodCommand = new MySqlCommand("SELECT * FROM dbFood WHERE FoodName = @name");
            getFoodCommand.Parameters.AddWithValue("@name", name);
            FoodModel food = new FoodModel();

            getFoodCommand.Connection = connection;
            connection.Open();

            MySqlDataReader getFoodDataReader = getFoodCommand.ExecuteReader();

            while (getFoodDataReader.HasRows)
            {

                while (getFoodDataReader.Read())
                {
                    food.FoodID = (int)getFoodDataReader["FoodID"];
                    food.FoodName = (string)getFoodDataReader["FoodName"];
                    food.FoodType = (string)getFoodDataReader["FoodType"];
                    food.Protein = (float)getFoodDataReader["Protein"];
                    food.Fat = (float)getFoodDataReader["Fat"];
                    food.Carbs = (float)getFoodDataReader["Carbs"];
                    food.Calories = (float)getFoodDataReader["Calories"];

                }
                connection.Close();
            }


            return food;
        } // get amount of macros for a food 

        public bool SaveMealPlan(int id, string jsonString)
        {
            try
            {
                connection.Open();



                //save meal info as json to meal table 
                MySqlCommand saveMealCommand = new MySqlCommand("INSERT INTO dbMeals (clientID, mealString, date) VALUES (@clientID, @meal, @date) ON DUPLICATE KEY UPDATE mealString = @meal, date = @date  ");

                //parameterized query to prevent sql injection
                saveMealCommand.Parameters.AddWithValue("@clientID", id);
                saveMealCommand.Parameters.AddWithValue("@meal", jsonString);
                saveMealCommand.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now;
                saveMealCommand.Connection = connection;
                saveMealCommand.ExecuteNonQuery();

                connection.Close();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error, could not save meal plan: " + e.ToString());
                Console.WriteLine("error " + e.Message);
                return false;
            }
        }

    }
}

    