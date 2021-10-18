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
    public partial class AnalyticsClient : UserControl
    {
        private List<ClientModel> clients;
        private List<ProgressModel> progresses;

        public AnalyticsClient()
        {
            InitializeComponent();
        }

        private void AnalyticsClient_Load(object sender, EventArgs e)
        {
            LoadData();
            FillAge();
            FillTrainingGoal();
            FillGender();
            FillDate();
        }

        private void LoadData()  //load data from database 
        {
            DAO data = new DAO();
            clients = data.GetAllClients();
            progresses = data.GetAllProgresses();
        }

        private void FillAge()  //get ages of all clients 
        {
            int below18 = 0;
            int from18to29 = 0;
            int from30to49 = 0;
            int above50 = 0;

            AgeBreakdownChart.Series[0].Points.Clear();            

            foreach (ClientModel client in clients)
            {                
                DateTime getAge = client.Date;

                //calculate date of client 
                int age = DateTime.Now.Year - getAge.Year; 

                if (DateTime.Now.DayOfYear < getAge.DayOfYear) 
                {
                    age = age - 1;
                }

                if (age < 18) //find age range 
                {
                    below18++;
                }
                else if (18 <= age && age < 30)
                {
                    from18to29++;
                }
                else if (30 <= age && age < 50)
                {
                    from30to49++;
                }
                else if ( age >= 50)
                {
                    above50++;
                }     
            }
            //add sections to pie chart 
            AgeBreakdownChart.Series["Age"].Points.Add((int)below18).LegendText = "below 18";
            AgeBreakdownChart.Series["Age"].Points.Add((int)from18to29).LegendText = "18 to 29";
            AgeBreakdownChart.Series["Age"].Points.Add((int)from30to49).LegendText = "30 to 49";
            AgeBreakdownChart.Series["Age"].Points.Add((int)above50).LegendText = "above 50";
        }

        private void FillTrainingGoal() //get training goal of each client 
        {
            int wgain = 0;
            int wloss= 0;

            TrainingGoalChart.Series[0].Points.Clear();

            foreach (ClientModel client in clients) //for each loop evaluates each client in list 
            {
                int clientID = client.ClientID;

                List<ProgressModel> clientProgress = new List<ProgressModel>();

                foreach(ProgressModel p in progresses) //get progress records of client 
                {
                    if(p.ClientID == clientID)
                    {
                        clientProgress.Add(p);
                    }
                }            

                ProgressModel progress = clientProgress.LastOrDefault(); //get last record
                string goal = "";

                if(progress != null)
                {
                    goal = progress.TrainingGoal;
                }

                if (goal == "Weight Gain") //evaluate training goal 
                {
                    wgain++;
                }
                else if (goal == "Weight Loss")
                {
                    wloss++;
                }
            }
            // add data to chart 
            TrainingGoalChart.Series["Goal"].Points.Add((int)wgain).LegendText = "Weight Gain";
            TrainingGoalChart.Series["Goal"].Points.Add((int)wloss).LegendText = "Weight Loss";
        }

        private void FillGender()  //get gender of each client 
        {

            int male = 0;
            int female = 0;

            GenderAnalysisChart.Series[0].Points.Clear();

            foreach (ClientModel client in clients)
            {
                if(client.gender == "Male")
                {
                    male++;
                }
                else
                {
                    female++;
                }

            }

            GenderAnalysisChart.Series["Gender"].Points.Add((int)male).LegendText = "Male";
            GenderAnalysisChart.Series["Gender"].Points.Add((int)female).LegendText = "Female";
        }

        private void FillDate() //get date of registration for each client 
        {
            int count=0;
            DateTime datex = DateTime.Now.AddDays(1);

            DateChart.Series[0].Points.Clear();

            foreach (ClientModel client in clients)
            {
                int clientID = client.ClientID;

                List<ProgressModel> clientProgress = new List<ProgressModel>();

                foreach (ProgressModel p in progresses)
                {
                    if (p.ClientID == clientID)
                    {
                        clientProgress.Add(p);
                    }
                }

                ProgressModel progress = clientProgress.FirstOrDefault();

                if(progress != null)  //null check 
                {
                    DateTime date = progress.CurrentDate;

                    if (datex == date) //get number of clients who registered on the date
                    {
                        count++;
                    }
                    else
                    {
                        datex = date;
                    }
                }
                

                count++;
                DateChart.Series["Registration"].Points.AddXY(datex,count);
            }            
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

            FillAge();
            FillTrainingGoal();
            FillGender();
            FillDate();
        }
    }
}
