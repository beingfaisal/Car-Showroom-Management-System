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
    public partial class SMMenu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string empId ="";
        string CarID = "";
        string C_Status = "";
        public SMMenu()
        {
            InitializeComponent();
            gridFill();
            this.CenterToScreen();
        }
        public SMMenu(string id)
        {
            InitializeComponent();
            this.CenterToScreen();
            gridFill();
            empId = id;
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if((empId[0].ToString() + empId[1].ToString()).ToUpper() == "MG" )
            {
                //this means that the user is manager
                new Manager_Menu(empId).Show();
                this.Hide();
            }
            else
            {
                new LogInForm().Show();
                this.Hide();
            }
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            string id = Convert.ToString(row.Cells[5].Value);
            string status = Convert.ToString(row.Cells[4].Value);
            CarID = id;
            C_Status = status;
        }

        private void gridFill()
        {
            con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR", con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }
            
            con.Close();
        }

        private void viewAvailable()
        {
            con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR where car_status = 'Available'", con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }
            con.Close();
        }

        private void viewSold()
        {
            con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR where car_status = 'Sold'", con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }
            con.Close();
        }

        private void buyCar()
        {
            con.Open();
            string checkEmpQuery = "select employee_designation from employee where employee_id = @id";
            SqlCommand checkEmpCmd = new SqlCommand(checkEmpQuery, con);
            checkEmpCmd.Parameters.AddWithValue("@id", empId);
            SqlDataAdapter checkEmpAdapter = new SqlDataAdapter(checkEmpCmd);
            DataSet empData = new DataSet();
            checkEmpAdapter.Fill(empData);

            string empDesig = Convert.ToString(empData.Tables[0].Rows[0].ItemArray[0]);
            con.Close();
            if (empDesig.ToLower() == "manager")
            {
                new carCtrl(empId).Show();
                this.Hide();
            }
            else if (empDesig.ToLower() == "salesman")
            {
                CustomMsgBox.Show("You do not have Administrator Privilages.\nFor Addition of new stock inform higher authority.","OK");
            }
        }

        private void carSell()
        {
            string id, status;
            id = CarID;
            status = C_Status;
            if (status == "")
            {
                CustomMsgBox.Show("No Stock Remaining.\nContact Higher Authority.", "OK");
            }
            else if (status.ToLower() == "available")
            {
                new CarSell(empId, CarID).Show();
                this.Hide();
            }
            else if (status.ToLower() == "sold")
            {
                CustomMsgBox.Show("This Car has already been Sold.\nSelect Another.", "OK");
            }
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            carSell();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            buyCar();
        }

        private void viewSoldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            viewSold();
        }

        private void viewAvailPanel_MouseClick(object sender, MouseEventArgs e)
        {
            viewAvailable();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.White;
            exitBtn.ForeColor = Color.Red;
        }

        private void sellCarPanel_MouseEnter(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void sellCarPanel_MouseLeave(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.Transparent;
        }

        private void buyCarPanel_MouseEnter(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void buyCarPanel_MouseLeave(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.Transparent;
        }

        private void viewSoldPanel_MouseEnter(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void viewSoldPanel_MouseLeave(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.Transparent;
        }

        private void viewAvailPanel_MouseEnter(object sender, EventArgs e)
        {
            viewAvailPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void viewAvailPanel_MouseLeave(object sender, EventArgs e)
        {
            viewAvailPanel.BackColor = Color.Transparent;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }
    }
}
