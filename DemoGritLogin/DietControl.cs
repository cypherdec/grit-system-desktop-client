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
    public partial class DietControl : UserControl
    {
        string fnametest;

        public DietControl()
        {
            InitializeComponent();
        }

        private void DietControl_Load(object sender, EventArgs e)
        {
            
        }

        public string LabelText
        {
            get { return lblTestname.Text; }
            set { lblTestname.Text = value; }
        }
    }
}
