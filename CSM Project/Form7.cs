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
   
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string mainEmpID, EmpId, empStatus;
   
        
        public Form7()
        {
            InitializeComponent();
            gridFill();

        }
        public Form7(string id)
        {
            InitializeComponent();
            gridFill();
            mainEmpID = id;
        }
        private void gridFill()
        {
            con.Open();
            SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman'", con);
            SqlDataAdapter empAdapter = new SqlDataAdapter(getEmpCmd);
            DataSet empDataset = new DataSet();
            empAdapter.Fill(empDataset);

            empGrid.Rows.Clear();
            for (int i = 0; i < (empDataset.Tables[0].Rows.Count); i++)
            {
                string id = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[0]);
                string name = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[1]);
                string pin = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[2]);
                string contact = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[3]);
                string address = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[4]);
                string email = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[5]);
                string designation = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[6]);
                string hire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[7]);
                string fire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[8]);
                string status = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[9]);
                string sales = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[10]);

                DateTime hireDate = (Convert.ToDateTime(hire)).Date;
                if (fire == string.Empty)
                {
                    fire = "---";
                }

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(empGrid);
                pushData.Cells[0].Value = id;
                pushData.Cells[1].Value = name;
                pushData.Cells[2].Value = pin;
                pushData.Cells[3].Value = contact;
                pushData.Cells[4].Value = address;
                pushData.Cells[5].Value = email;
                pushData.Cells[6].Value = hireDate;
                pushData.Cells[7].Value = fire;
                pushData.Cells[8].Value = status;
                pushData.Cells[9].Value = sales;
                empGrid.Rows.Add(pushData);

            }
            con.Close();
        }
        private void fireEmp()
        {
            if (EmpId == "" || empStatus == "Fired")
            {

            }
            else
            {
                con.Open();
                string fireQuery = "Update employee set EMPLOYEE_Status = 'Fired',Employee_FIREDATE = CONVERT(DATE, GETDATE()) where EMPLOYEE_ID = @id";
                SqlCommand fireCmd = new SqlCommand(fireQuery, con);
                fireCmd.Parameters.AddWithValue("@id", EmpId);
                fireCmd.ExecuteNonQuery();
                con.Close();
                gridFill();

            }
        }

        private void hireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            hireEmpPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void hireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            hireEmpPanel.BackColor = Color.Transparent;
        }

        private void updateEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            updateEmpPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void updateEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            updateEmpPanel.BackColor = Color.Transparent;
        }

        private void firEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            firEmpPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void firEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            firEmpPanel.BackColor = Color.Transparent;
        }

        private void rehireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            rehireEmpPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void rehireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            rehireEmpPanel.BackColor = Color.Transparent;
        }

        private void viewHiredPanel_MouseEnter(object sender, EventArgs e)
        {
            viewHiredPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void viewHiredPanel_MouseLeave(object sender, EventArgs e)
        {
            viewHiredPanel.BackColor = Color.Transparent;
        }
        private void viewFiredPanel_MouseClick(object sender, MouseEventArgs e)
        {
            con.Open();
            SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman' and employee_status = 'fired'", con);
            SqlDataAdapter empAdapter = new SqlDataAdapter(getEmpCmd);
            DataSet empDataset = new DataSet();
            empAdapter.Fill(empDataset);

            empGrid.Rows.Clear();
            for (int i = 0; i < (empDataset.Tables[0].Rows.Count); i++)
            {
                string id = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[0]);
                string name = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[1]);
                string pin = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[2]);
                string contact = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[3]);
                string address = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[4]);
                string email = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[5]);
                string designation = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[6]);
                string hire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[7]);
                string fire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[8]);
                string status = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[9]);
                string sales = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[10]);

                DateTime hireDate = (Convert.ToDateTime(hire)).Date;
                if (fire == string.Empty)
                {
                    fire = "---";
                }

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(empGrid);
                pushData.Cells[0].Value = id;
                pushData.Cells[1].Value = name;
                pushData.Cells[2].Value = pin;
                pushData.Cells[3].Value = contact;
                pushData.Cells[4].Value = address;
                pushData.Cells[5].Value = email;
                pushData.Cells[6].Value = hireDate;
                pushData.Cells[7].Value = fire;
                pushData.Cells[8].Value = status;
                pushData.Cells[9].Value = sales;
                empGrid.Rows.Add(pushData);

            }
            con.Close();
        }

        private void viewFiredPanel_MouseEnter(object sender, EventArgs e)
        {
            viewFiredPanel.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void viewFiredPanel_MouseLeave(object sender, EventArgs e)
        {
            viewFiredPanel.BackColor = Color.Transparent;
        }
        private void viewHiredPanel_MouseClick(object sender, MouseEventArgs e)
        {
            con.Open();
            SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman' and employee_status = 'working'", con);
            SqlDataAdapter empAdapter = new SqlDataAdapter(getEmpCmd);
            DataSet empDataset = new DataSet();
            empAdapter.Fill(empDataset);

            empGrid.Rows.Clear();
            for (int i = 0; i < (empDataset.Tables[0].Rows.Count); i++)
            {
                string id = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[0]);
                string name = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[1]);
                string pin = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[2]);
                string contact = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[3]);
                string address = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[4]);
                string email = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[5]);
                string designation = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[6]);
                string hire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[7]);
                string fire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[8]);
                string status = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[9]);
                string sales = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[10]);

                DateTime hireDate = (Convert.ToDateTime(hire)).Date;
                if (fire == string.Empty)
                {
                    fire = "---";
                }

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(empGrid);
                pushData.Cells[0].Value = id;
                pushData.Cells[1].Value = name;
                pushData.Cells[2].Value = pin;
                pushData.Cells[3].Value = contact;
                pushData.Cells[4].Value = address;
                pushData.Cells[5].Value = email;
                pushData.Cells[6].Value = hireDate;
                pushData.Cells[7].Value = fire;
                pushData.Cells[8].Value = status;
                pushData.Cells[9].Value = sales;
                empGrid.Rows.Add(pushData);

            }
            con.Close();
        }
      
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(54, 54, 56);
        }

        private void hireEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SaleManCtrl(mainEmpID).Show();
            this.Hide();
        }

        private void updateEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SaleManCtrl().Show();
            this.Hide();
        }

        private void firEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            fireEmp();
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }
    }
}