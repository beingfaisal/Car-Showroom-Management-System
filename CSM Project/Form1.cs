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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            LblVanish();

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(),Color.FromArgb(102,102,102),Color.White);
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (nameBox.Text == "Username")
            {
                nameBox.Text = "";
            }
            namePnl.BorderStyle = BorderStyle.FixedSingle;
            namePnl.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.ForeColor = Color.White;
            userImage.BackColor = Color.FromArgb(34, 36, 49);
            lockImage.BackColor = Color.White;
            LblVanish();

        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(),Color.White,Color.FromArgb(102, 102, 102));

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
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(),Color.Silver,Color.White);
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (pinBox.Text == "Password")
            {
                pinBox.Text = "";
                pinBox.PasswordChar = '*';
            }
            pinPnl.BorderStyle = BorderStyle.FixedSingle;
            pinPnl.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.ForeColor = Color.White;
            lockImage.BackColor = Color.FromArgb(34, 36, 49);
            userImage.BackColor = Color.White;
            LblVanish();
        }
        private void pinBox_Leave(object sender, EventArgs e)
        {
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(),Color.White, Color.FromArgb(102, 102, 102));
            if (pinBox.Text == "")
            {
                pinBox.Text = "Password";
                pinBox.PasswordChar = '\0';
            }
            pinPnl.BackColor = Color.White;
            pinBox.BackColor = Color.White;
            pinBox.ForeColor = Color.Black;
            lockImage.BackColor = Color.White;
        }
        private void logBtn_MouseEnter(object sender, EventArgs e)
        {
            logBtn.FlatAppearance.BorderColor = Color.White;
            logBtn.FlatAppearance.BorderSize = 1;
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
            redundantData.con.Open();
            string empID, empDesgination, empPin;
            empID = nameBox.Text;
            empPin = pinBox.Text;

            string logQuery = "select * from employee where employee_id = @id and EMPLOYEE_PASSWORD = @pin and employee_status = @work";

            SqlCommand logCmd = new SqlCommand(logQuery, redundantData.con);
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
                userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(),Color.FromArgb(102, 102, 102),Color.White);
                lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.FromArgb(102, 102, 102), Color.White);
                LblVisible();
                if (pinBox.Text != "Password")
                    pinBox.Text = "";
            }

            redundantData.con.Close();
        }


        private void LblVisible()
        {
            nameErrorIcon.Visible = true;
            pinErrorIcon.Visible = true;
            userImage.BackColor = Color.Red;
            lockImage.BackColor = Color.Red;
            CustomMsgBox.Show("Wrong Name/Password. \nPlease Recheck it immediately", "OK");
        }
        private void LblVanish()
        {
            nameErrorIcon.Visible = false;
            pinErrorIcon.Visible = false;
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in Alphabets or Digits.", "OK");
                e.Handled = true;
            }
        }

        private void pinBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in Digits only.", "OK");
                e.Handled = true;
            }
        }
    }
}

