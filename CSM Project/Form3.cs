using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public partial class Manager_Menu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string empId;
        public Manager_Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public Manager_Menu(string id)
        {
            InitializeComponent();
            empId = id;
            this.CenterToScreen();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void SmmBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new empControl(empId).Show();
            this.Hide();

        }

        private void carCtrlBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new SMMenu(empId).Show();
            this.Hide();
        }

       
    }
}
