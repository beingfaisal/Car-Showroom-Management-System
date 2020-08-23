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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        public LogInForm()
        {
            InitializeComponent();
            LblVanish();

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            userImage.Image = ReplaceColor((Image)userImage.Image.Clone(),Color.FromArgb(102,102,102),Color.White,100);

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
            userImage.Image = ReplaceColor((Image)userImage.Image.Clone(),Color.White,Color.FromArgb(102, 102, 102), 100);

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
            lockImage.Image = ReplaceColor(
            (Image)lockImage.Image.Clone(),
            Color.Silver,
            Color.White,
            100);

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
            lockImage.Image = ReplaceColor((Image)lockImage.Image.Clone(),Color.White, Color.FromArgb(102, 102, 102),100);
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
                userImage.Image = ReplaceColor((Image)userImage.Image.Clone(),Color.FromArgb(102, 102, 102),Color.White,100);
                lockImage.Image = ReplaceColor((Image)lockImage.Image.Clone(), Color.FromArgb(102, 102, 102), Color.White, 100);
                LblVisible();
                if (pinBox.Text != "Password")
                    pinBox.Text = "";
            }

            con.Close();
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

        public Image ReplaceColor(Image _image, Color _colorOld, Color _colorNew, int _tolerance)
        {
            Bitmap bmap = (Bitmap)_image.Clone();

            Color c;
            int iR_Min, iR_Max;
            int iG_Min, iG_Max;
            int iB_Min, iB_Max;

            //Defining Tolerance
            //R
            iR_Min = Math.Max((int)_colorOld.R - _tolerance, 0);
            iR_Max = Math.Min((int)_colorOld.R + _tolerance, 255);

            //G
            iG_Min = Math.Max((int)_colorOld.G - _tolerance, 0);
            iG_Max = Math.Min((int)_colorOld.G + _tolerance, 255);

            //B
            iB_Min = Math.Max((int)_colorOld.B - _tolerance, 0);
            iB_Max = Math.Min((int)_colorOld.B + _tolerance, 255);


            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);


                    //Determinig Color Match
                    if (
                        (c.R >= iR_Min && c.R <= iR_Max) &&
                        (c.G >= iG_Min && c.G <= iG_Max) &&
                        (c.B >= iB_Min && c.B <= iB_Max)
                    )
                        if (_colorNew == Color.Transparent)
                            bmap.SetPixel(x, y, Color.FromArgb(0,
                              _colorNew.R,
                              _colorNew.G,
                              _colorNew.B));
                        else
                            bmap.SetPixel(x, y, Color.FromArgb(c.A,
                              _colorNew.R,
                              _colorNew.G,
                              _colorNew.B));
                }
            }
            return (Image)bmap.Clone();
        }




    }
}

