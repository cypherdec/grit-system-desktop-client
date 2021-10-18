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
    public partial class ManageClientControl : UserControl
    {

        protected override Point ScrollToControl(Control activeControl)  //disable auto scroll with method override 
        {
            return DisplayRectangle.Location;  
        }
       

        public ManageClientControl()
        {
            InitializeComponent();
            GetData();
            fillCoaches();
        }

        private void fillCoaches()
        {
            DAO data = new DAO();
            List<CoachModel> coaches = data.GetAllCoaches();

            List<string> names = new List<string>();

            foreach (CoachModel coach in coaches)
            {
                string name = coach.FirstName + " " + coach.LastName;
                names.Add(name);
            }

            cbxCoaches.DataSource = names;
        }


        private void GetData() //get data from database and fill grid  view 
        {
            

            DAO data = new DAO();
            List<ClientModel> clients = data.GetAllClients();

            gridViewClients.DataSource = clients; //fill grid view with clients table data 


            //since we use abstract base user class, the columns are out of order
            gridViewClients.Columns[0].HeaderText = "Client ID";
            gridViewClients.Columns[1].HeaderText = "Gender";
            gridViewClients.Columns[2].HeaderText = "Date Of Birth";
            gridViewClients.Columns[3].HeaderText = "Assigned Coach";
            gridViewClients.Columns[4].HeaderText = "First Name";
            gridViewClients.Columns[5].HeaderText = "Last Name";
            gridViewClients.Columns[6].HeaderText = "Telephone";
            gridViewClients.Columns[7].HeaderText = "Email";

            //manually rearrange columns

            gridViewClients.Columns[0].DisplayIndex = 1;
            gridViewClients.Columns[4].DisplayIndex = 2;
            gridViewClients.Columns[5].DisplayIndex = 3;
            gridViewClients.Columns[1].DisplayIndex = 4;
            gridViewClients.Columns[2].DisplayIndex = 5;
            gridViewClients.Columns[6].DisplayIndex = 6;
            gridViewClients.Columns[7].DisplayIndex = 7;
            gridViewClients.Columns[3].DisplayIndex = 8;

            gridViewClients.Columns[8].Visible = false;
            gridViewClients.Columns[0].Visible = false;
        }

        private void btnEditClient_Click(object sender, EventArgs e) //fill textboxes with client data 
        {
            lblEditClientID.Text = gridViewClients.CurrentRow.Cells[0].Value.ToString(); //invisible lbl to hold client id 
            string gender = gridViewClients.CurrentRow.Cells[1].Value.ToString();
            string coach = gridViewClients.CurrentRow.Cells[3].Value.ToString();
            txtEditFname.Text =gridViewClients.CurrentRow.Cells[4].Value.ToString();
            txtEditLname.Text = gridViewClients.CurrentRow.Cells[5].Value.ToString();
            txtEditEmail.Text = gridViewClients.CurrentRow.Cells[7].Value.ToString();
            cbxEditGender.SelectedIndex = cbxEditGender.FindStringExact(gender);
            txtEditTele.Text = gridViewClients.CurrentRow.Cells[6].Value.ToString();
            dtEditDOB.Value = DateTime.Parse(gridViewClients.CurrentRow.Cells[2].Value.ToString());
            cbxCoaches.SelectedIndex = cbxCoaches.FindStringExact(coach);
                
        }

        private void btnUpdateClient_Click(object sender, EventArgs e) //create client object and send details to database controller method 
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();

            client.ClientID =  Int32.Parse(lblEditClientID.Text.ToString());
            client.FirstName = txtEditFname.Text;
            client.LastName = txtEditLname.Text;
            client.gender = cbxEditGender.SelectedItem.ToString();
            client.Tele = txtEditTele.Text;
            client.Date = dtEditDOB.Value;
            client.Email = txtEditEmail.Text.ToString();
            client.AssignedCoach = cbxCoaches.SelectedItem.ToString();

            if (data.UpdateClient(client))
            {
                MessageBox.Show("Successfully Updated");
                GetData();
            }
            else
            {
                MessageBox.Show("Error updating client");
            }
            

        }

        private void btnDeleteClient_Click(object sender, EventArgs e) //show confirmation box before deleting 
        {
            string clientid = gridViewClients.CurrentRow.Cells[0].Value.ToString();
            string name = gridViewClients.CurrentRow.Cells[3].Value.ToString() + " " + gridViewClients.CurrentRow.Cells[4].Value.ToString();

            var confirmResult = MessageBox.Show("Are you sure to delete this client, " +name + " and all their progress records?", "Confirm Delete!", MessageBoxButtons.YesNo);                                      

            if (confirmResult == DialogResult.Yes)
            {
                DAO data = new DAO();
                ClientModel client = new ClientModel();
                try
                {
                    client.ClientID = Int32.Parse(clientid);
                    if (data.DeleteClient(client))
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
                    MessageBox.Show("no coach selected");
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
