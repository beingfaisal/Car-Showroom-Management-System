using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public partial class LogInForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        public LogInForm()
        {
            InitializeComponent();
            LblVanish();
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {

            if (nameBox.Text == "Username")
            {
                nameBox.Text = "";
            }

            namePnl.BackColor = Color.Black;
            nameBox.BackColor = Color.Black;
            nameBox.ForeColor = Color.White;
            userImage.BackColor = Color.Black;
            lockImage.BackColor = Color.White;
            LblVanish();

        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Username";
            }
            namePnl.BackColor = Color.White;
            nameBox.BackColor = Color.White;
            nameBox.ForeColor = Color.Black;
            userImage.BackColor = Color.White;

        }
        private void pinBox_Enter(object sender, EventArgs e)
        {
            if (pinBox.Text == "Password")
            {
                pinBox.Text = "";
            }
            pinPnl.BackColor = Color.Black;
            pinBox.BackColor = Color.Black;
            pinBox.ForeColor = Color.White;
            lockImage.BackColor = Color.Black;
            userImage.BackColor = Color.White;
            LblVanish();


        }
        private void pinBox_Leave(object sender, EventArgs e)
        {
            if (pinBox.Text == "")
            {
                pinBox.Text = "Password";
            }

            pinPnl.BackColor = Color.White;
            pinBox.BackColor = Color.White;
            pinBox.ForeColor = Color.Black;
            lockImage.BackColor = Color.White;

        }
        private void logBtn_MouseEnter(object sender, EventArgs e)
        {
            logBtn.BackColor = Color.FromArgb(34, 36, 49);
            logBtn.ForeColor = Color.White;
        }

        private void logBtn_MouseLeave(object sender, EventArgs e)
        {
            logBtn.BackColor = Color.White;
            logBtn.ForeColor = Color.Black;
        }



        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.White;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string empID, empDesgination, empPin;
            empID = nameBox.Text;
            empPin = pinBox.Text;

            string logQuery = "select * from employee where employee_id = @id and EMPLOYEE_PASSWORD = @pin and employee_status = @work";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", empID);
            logCmd.Parameters.AddWithValue("@pin", empPin);
            logCmd.Parameters.AddWithValue("@work", "Working");

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            if ((LogSet.Tables[0].Rows.Count) > 0)
            {
                empDesgination = Convert.ToString(LogSet.Tables[0].Rows[0].ItemArray[6]);
                if (empDesgination.ToLower() == "salesman")
                {
                    new SMMenu(empID).Show();
                    this.Hide();
                }
                else if (empDesgination.ToLower() == "manager")
                {
                    new Manager_Menu(empID).Show();
                    this.Hide();
                }
            }
            else
            {
                LblVisible();
                nameBox.Text = "";
                pinBox.Text = "";
            }

            con.Close();
        }


        private void LblVisible()
        {
            userLbl.Visible = true;
            pinLbl.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            userImage.BackColor = Color.Red;
            lockImage.BackColor = Color.Red;
        }
        private void LblVanish()
        {
            userLbl.Visible = false;
            pinLbl.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
    }
}
