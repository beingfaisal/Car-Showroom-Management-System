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

    
        private void carCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SMMenu(empId).Show();
            this.Hide();
        }

        private void empCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new empControl(empId).Show();
            this.Hide();
        }

        private void carCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            carCtrlPanel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void carCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            carCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void empCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            empCtrlPanel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void empCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            empCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void salesCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            salesCtrlPanel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void salesCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            salesCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void accountCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            accountCtrlPanel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void accountCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            accountCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }
    }
}
