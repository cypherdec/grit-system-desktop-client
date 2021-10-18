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
    public partial class AnalyticsCoach : UserControl
    {
        private List<CoachModel> coaches;
        private List<ClientModel> clients;
        private List<ProgressModel> progresses;
        public AnalyticsCoach()
        {
            InitializeComponent();
        }

        private void AnalyticsCoach_Load(object sender, EventArgs e)
        {
            LoadData();
            FillTable();
        }

        private void LoadData()  //load data from database 
        {
            DAO data = new DAO();
            coaches = data.GetAllCoaches();
            clients = data.GetAllClients();
            progresses = data.GetAllProgresses();

        }

        private void FillTable()  //fill gridview with database data 
        {
            List<CoachClientDTO> coachClientDTOs = new List<CoachClientDTO>();  //model class to send to front end 

            string name;
            int clientsCount;

            foreach(CoachModel coach in coaches) //get all clients for each coach 
            {
                name = coach.FirstName + " " + coach.LastName;

                List<ClientModel> coachClients = new List<ClientModel>(); 

                foreach(ClientModel client in clients) //add clients of each cpach  to list 
                {
                    if(client.AssignedCoach == name)
                    {
                        coachClients.Add(client);
                    }
                }

                clientsCount = coachClients.Count;  //number of clients 

                CoachClientDTO coachClientDTO = new CoachClientDTO();

                coachClientDTO.CoachName = name;
                coachClientDTO.ClientNo = clientsCount;

                coachClientDTOs.Add(coachClientDTO);
            }

            gridViewCoaches.DataSource = coachClientDTOs; //set grid view datasource 

            gridViewCoaches.Columns[0].HeaderText = "Coach Name"; //change table headings 
            gridViewCoaches.Columns[1].HeaderText = "Number Of Clients";

        }

        private void gridViewCoaches_CellClick(object sender, DataGridViewCellEventArgs e)  //get analyic data for each coach when cell is clicked 
        {
            string name = gridViewCoaches.CurrentRow.Cells[0].Value.ToString();

            int weightLossCount = 0;
            int weightGainCount = 0;
            int progressCount = 0;

            int change=0;
            string clientName="";
            string bestGoal="";

            List<ClientModel> coachClients = new List<ClientModel>();  //list of clients of coach 

            List<ProgressModel> clientProgress = new List<ProgressModel>(); //list of progress for each client;

            foreach (ClientModel client in clients)  //list of clients for selected coach 
            {
                if (client.AssignedCoach == name)
                {
                    coachClients.Add(client);                     
                }
            }

            foreach (ClientModel clientModel in coachClients) //get progress data for each client of coach 
            {
                clientProgress.Clear();  //clear progress list for each client before ading new data 

                int tempGain = 0;
                int tempLoss = 0;
                int clientID = clientModel.ClientID;

                foreach(ProgressModel progress in progresses)  //get number of logged progresses 
                {
                    if(progress.ClientID == clientID)
                    {                        
                        clientProgress.Add(progress);
                        progressCount = progressCount + 1; 
                    }
                }

                ProgressModel p1 = clientProgress.First();  //get first and last progress record for each client 
                ProgressModel p2 = clientProgress.Last();
                                                
                foreach (ProgressModel countP in clientProgress)  //get initial and current weight and compare chang 
                {                    
                    if (countP.TrainingGoal == "Weight Gain")  // client change for weight gain 
                    {
                        if (p1.CurrentWeight < p2.CurrentWeight)
                        {
                            int tempChange = p2.CurrentWeight - p1.CurrentWeight;  //get change in weight 

                            if(tempChange > change) //see if change in current clients weight is greater than stored value 
                            {
                                change = tempChange;
                                clientName = clientModel.FirstName + " " + clientModel.LastName;
                                bestGoal = "Weight Gain";
                            }
                        }

                        tempGain = tempGain + 1;
                    }
                    else
                    {
                        if (p1.CurrentWeight > p2.CurrentWeight)   //client change for weight loss 
                        {
                            int tempChange = p1.CurrentWeight - p2.CurrentWeight;

                            if (tempChange > change)
                            {
                                change = tempChange;
                                clientName = clientModel.FirstName + " " + clientModel.LastName;
                                bestGoal = "Weight Loss";
                            }
                        }

                        tempLoss = tempLoss + 1;
                    }
                }

                int progressLogs = progressCount / coachClients.Count; //average number of progress logs 
                lblProgressLogs.Text = progressLogs.ToString();

                if(weightGainCount < tempGain)  //get value for most hired training program 
                {
                    weightGainCount = tempGain;
                }

                if(weightLossCount < tempLoss)
                {
                    weightLossCount = tempLoss;
                }

            }            

            if (weightLossCount > weightGainCount)  //set most hired for training program 
            {
                lblHiredFor.Text = "Weight Loss (" + weightLossCount.ToString() + ")";
            }
            else
            {
                lblHiredFor.Text = "Weight Gain (" + weightGainCount.ToString() + ")";
            }

            FillClientDetails(coachClients);  //send client and progress data to FillClientDetails method 

            lblImprovement.Text = clientName + " " + "(" + bestGoal + " / " + "Change : " + change.ToString() + " kg" + ")";
        }

        private void FillClientDetails(List<ClientModel> coachClients)
        {
            List<CoachClientDetailsDTO> coachClientDetails = new List<CoachClientDetailsDTO>(); //empty details model list for display in table 

            foreach(ClientModel client in coachClients)  //get details for each client and 
            {
                int clientID = client.ClientID;
                string name = client.FirstName + " " + client.LastName;

                List<ProgressModel> clientProgress = new List<ProgressModel>();

                foreach (ProgressModel progress in progresses)  //get progresses for each client 
                {
                    if (progress.ClientID == clientID)
                    {
                        clientProgress.Add(progress);
                    }
                }

                ProgressModel p1 = clientProgress.First(); //get initial and current progress data 
                ProgressModel p2 = clientProgress.Last();

                string trainingGoal = p1.TrainingGoal;
                int start = p1.CurrentWeight;
                int end = p2.CurrentWeight;

                CoachClientDetailsDTO detailsDTO = new CoachClientDetailsDTO(); //create new details object and add to list 
                detailsDTO.ClientName = name;
                detailsDTO.TrainingGoal = trainingGoal;
                detailsDTO.InitialWeight = start;
                detailsDTO.CurrentWeight = end;
                detailsDTO.ProgressCount = clientProgress.Count();

                coachClientDetails.Add(detailsDTO);

            }

            gridViewCoachClients.DataSource = coachClientDetails; //bind details list to gridview 

            gridViewCoachClients.Columns[0].HeaderText = "Client Name";
            gridViewCoachClients.Columns[1].HeaderText = "Training Goal";
            gridViewCoachClients.Columns[2].HeaderText = "Initial Weight";
            gridViewCoachClients.Columns[3].HeaderText = "Current Weight";
            gridViewCoachClients.Columns[4].HeaderText = "Progress Count";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            FillTable();
        }
    }
}
