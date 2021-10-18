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
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoGritLogin
{
    public partial class AnalyticsProgress : UserControl
    {

        private List<ClientModel> clients;
        private List<ProgressModel> progresses;

        public AnalyticsProgress()
        {
            InitializeComponent();
        }

        private void AnalyticsProgress_Load(object sender, EventArgs e)
        {
            LoadData();
            FillTrainingGoal();
            GetAverages();
            FillProgressUpdate();
        }

        private void LoadData()  //load data from database 
        {
            DAO data = new DAO();
            clients = data.GetAllClients();
            progresses = data.GetAllProgresses();
        }

        private void GetAverages()
        {
            int count = 0;  //base values 
            int height1 = 0;
            int weight1 = 0;
            int weight2 = 0;

            foreach (ClientModel client in clients)
            {
                count++; 

                int clientID = client.ClientID;

                List<ProgressModel> clientProgress = new List<ProgressModel>();

                foreach (ProgressModel p in progresses)
                {
                    if (p.ClientID == clientID)
                    {
                        clientProgress.Add(p); //get list of progresses for each client
                    }
                }

                ProgressModel p1 = clientProgress.LastOrDefault();  //get last progress record for each client
                ProgressModel p2 = clientProgress.FirstOrDefault(); //get first record 

                if(p1 !=null && p2 != null) //null check
                {
                    height1 = height1 + p1.CurrentHeight;
                    weight1 = weight1 + p1.CurrentWeight;
                    weight2 = weight2 + p2.CurrentWeight;
                }                
            }

            height1 = height1 / count; //calculate averages
            weight1 = weight1 / count;
            weight2 = weight2 / count;

            lblHeight.Text = height1.ToString() + " cm";  //display data in UI 
            lblWeight1.Text = weight1.ToString() + " kg";
            lblWeight2.Text = weight2.ToString() + " kg";
        }

        private void FillTrainingGoal() //get BMI of each client 
        {

            int under = 0; //base values
            int normal = 0;
            int over = 0;

            BMIAnalysisChart.Series[0].Points.Clear();

            foreach (ClientModel client in clients)
            {
                int clientID = client.ClientID;

                List<ProgressModel> clientProgress = new List<ProgressModel>();

                foreach (ProgressModel p in progresses)
                {
                    if (p.ClientID == clientID)
                    {
                        clientProgress.Add(p); //get progress list for each client
                    }
                }

                string bmi = "";
                ProgressModel progress = clientProgress.LastOrDefault();
                if(progress != null) //null check
                {
                    bmi = progress.BmiRating;
                }

                if (bmi == "Underweight") //count instances 
                {
                    under++;
                }
                else if(bmi == "Normal Weight")
                {
                    normal++;
                }
                else
                {
                    over++;
                }
            }

            BMIAnalysisChart.Series["BMI"].Points.Add((int)under).LegendText = "Underweight";
            BMIAnalysisChart.Series["BMI"].Points.Add((int)normal).LegendText = "Normal Weight";
            BMIAnalysisChart.Series["BMI"].Points.Add((int)over).LegendText = "Overweight";
        }

        private void FillProgressUpdate()
        {
            int sunday = 0;
            int monday = 0;
            int tuesday = 0;
            int wednesday = 0;
            int thursday = 0;
            int friday = 0;
            int saturday = 0;

            ProgressDisChart.Series[0].Points.Clear();

            foreach (ProgressModel p in progresses)  //find day of week 
            {
                string day = p.CurrentDate.DayOfWeek.ToString(); //get day of week form date             

                if (day == "Sunday")
                {
                    sunday++;
                }
                else if (day == "Monday")
                {
                    monday++;
                }
                else if (day == "Tuesday")
                {
                    tuesday++;
                }
                else if (day == "Wednesday")
                {
                    wednesday++;
                }
                else if (day == "Thursday")
                {
                    thursday++;
                }
                else if (day == "Friday")
                {
                    friday++;
                }
                else if (day == "Saturday")
                {
                    saturday++;
                }

            }

            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Sunday", sunday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Monday", monday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Tuesday", tuesday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Wednesday", wednesday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Thursday", thursday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Friday", friday);
            ProgressDisChart.Series["Progress Logs"].Points.AddXY("Saturday", saturday);
        }

        private void cbxRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            int past = 0;
            DAO data = new DAO();

            if (cbxRecords.SelectedIndex == -1)  //how many records user wants to see
            {
                past = 0;
            }
            else if (cbxRecords.SelectedIndex == 0)
            {
                past = 0;
            }
            else if (cbxRecords.SelectedIndex == 1)
            {
                past = 1;
            }
            else if (cbxRecords.SelectedIndex == 2)
            {
                past = 3;
            }
            else if (cbxRecords.SelectedIndex == 3)
            {
                past = 6;
            }
            else if (cbxRecords.SelectedIndex == 4)
            {
                past = 12;
            }

            clients = data.GetAllClients();

            progresses = data.GetAnalyticsClientProgresses(past); //filter by date range 

            FillTrainingGoal();
            GetAverages();
            FillProgressUpdate();
        }
    }
}
