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
   
    public partial class empControl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string mainEmpID;
       
        redundantData.empInfo empUpdateInfo = new redundantData.empInfo("");
       
        
        public empControl()
        {
            InitializeComponent();
            gridFill();

        }
        public empControl(string id)
        {
            InitializeComponent();
            gridFill();
            mainEmpID = id;
            
        }
        private void gridFill()
        {
            bool isFired = false;
            DateTime fireDate = default(DateTime);
            con.Open();
            SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman' order by employee_designation", con);
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
                    isFired = false;
                    fire = "---";
                }
                else
                {
                    isFired = true;
                    fireDate = (Convert.ToDateTime(fire)).Date;
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
                if (isFired) pushData.Cells[7].Value = fireDate;
                else pushData.Cells[7].Value = fire;
                pushData.Cells[8].Value = status;
                pushData.Cells[9].Value = sales;
                empGrid.Rows.Add(pushData);

            }
            con.Close();
        }
        private void fireEmp()
        {
            if (empUpdateInfo.status == "Fired")
            {
                CustomMsgBox.Show("The selected employee is already fired.\nPlease Select Valid Employee.", "OK");
            }
            else
            {

                if (empUpdateInfo.id == "")
                {
                    CustomMsgBox.Show("Please Select the Employee you want to fire.", "OK");
                }
                else
                {
                    con.Open();
                    string fireQuery = "Update employee set EMPLOYEE_Status = 'Fired',Employee_FIREDATE = CONVERT(DATE, GETDATE()) where EMPLOYEE_ID = @id";
                    SqlCommand fireCmd = new SqlCommand(fireQuery, con);
                    fireCmd.Parameters.AddWithValue("@id", empUpdateInfo.id);
                    fireCmd.ExecuteNonQuery();
                    con.Close();
                    gridFill();

                }
            }
            
        }
        private void rehireEmp()
        {
            if (empUpdateInfo.status == "Working")
            {
                CustomMsgBox.Show("The selected employee is already Working.\nPlease Select Valid Employee.", "OK");
            }
            else
            {

                if (empUpdateInfo.id == "")
                {
                    CustomMsgBox.Show("Please Select the Employee you want to Hire.", "OK");
                }
                else
                {
                    con.Open();
                    string fireQuery = "Update employee set EMPLOYEE_Status = 'Working',Employee_HIREDATE = CONVERT(DATE, GETDATE()),Employee_firedate = NULL where EMPLOYEE_ID = @id";
                    SqlCommand fireCmd = new SqlCommand(fireQuery, con);
                    fireCmd.Parameters.AddWithValue("@id", empUpdateInfo.id);
                    fireCmd.ExecuteNonQuery();
                    con.Close();
                    gridFill();

                }
            }
        }

        private void hireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            hireEmpPanel.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void hireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            hireEmpPanel.BackColor = Color.Transparent;
        }
        private void hireEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SaleManCtrl(mainEmpID).Show();
            this.Hide();
        }



        private void updateEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            updateEmpPanel.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void updateEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            updateEmpPanel.BackColor = Color.Transparent;
        }
        private void updateEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SaleManCtrl(empUpdateInfo).Show();
            this.Hide();
        }
       


        private void firEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            firEmpPanel.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void firEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            firEmpPanel.BackColor = Color.Transparent;
        }
        private void firEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            fireEmp();
        }




        private void rehireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            rehireEmpPanel.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void rehireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            rehireEmpPanel.BackColor = Color.Transparent;
        }



        //private void viewHiredPanel_MouseEnter(object sender, EventArgs e)
        //{
        //    viewHiredPanel.BackColor = Color.FromArgb(64, 64, 64);
        //}
        //private void viewHiredPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    viewHiredPanel.BackColor = Color.Transparent;
        //}
        //private void viewHiredPanel_MouseClick(object sender, MouseEventArgs e)
        //{
        //    bool isFired = false;
        //    DateTime fireDate = default(DateTime);
        //    con.Open();
        //    SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman' and employee_status = 'working'", con);
        //    SqlDataAdapter empAdapter = new SqlDataAdapter(getEmpCmd);
        //    DataSet empDataset = new DataSet();
        //    empAdapter.Fill(empDataset);

        //    empGrid.Rows.Clear();
        //    for (int i = 0; i < (empDataset.Tables[0].Rows.Count); i++)
        //    {
        //        string id = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[0]);
        //        string name = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[1]);
        //        string pin = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[2]);
        //        string contact = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[3]);
        //        string address = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[4]);
        //        string email = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[5]);
        //        string designation = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[6]);
        //        string hire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[7]);
        //        string fire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[8]);
        //        string status = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[9]);
        //        string sales = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[10]);

        //        DateTime hireDate = (Convert.ToDateTime(hire)).Date;
        //        if (fire == string.Empty)
        //        {
        //            isFired = false;
        //            fire = "---";
        //        }
        //        else
        //        {
        //            isFired = true;
        //            fireDate = (Convert.ToDateTime(fire)).Date;
        //        }

        //        DataGridViewRow pushData = new DataGridViewRow();
        //        pushData.CreateCells(empGrid);
        //        pushData.Cells[0].Value = id;
        //        pushData.Cells[1].Value = name;
        //        pushData.Cells[2].Value = pin;
        //        pushData.Cells[3].Value = contact;
        //        pushData.Cells[4].Value = address;
        //        pushData.Cells[5].Value = email;
        //        pushData.Cells[6].Value = hireDate;
        //        if (isFired) pushData.Cells[7].Value = fireDate;
        //        else pushData.Cells[7].Value = fire;
        //        pushData.Cells[8].Value = status;
        //        pushData.Cells[9].Value = sales;
        //        empGrid.Rows.Add(pushData);

        //    }
        //    con.Close();
        //}




        //private void viewFiredPanel_MouseEnter(object sender, EventArgs e)
        //{
        //    viewFiredPanel.BackColor = Color.FromArgb(64, 64, 64);
        //}
        //private void viewFiredPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    viewFiredPanel.BackColor = Color.Transparent;
        //}
        //private void viewFiredPanel_MouseClick(object sender, MouseEventArgs e)
        //{
        //    bool isFired = false;
        //    DateTime fireDate = default(DateTime);
        //    con.Open();
        //    SqlCommand getEmpCmd = new SqlCommand("select * from employee where employee_designation = 'salesman' and employee_status = 'fired'", con);
        //    SqlDataAdapter empAdapter = new SqlDataAdapter(getEmpCmd);
        //    DataSet empDataset = new DataSet();
        //    empAdapter.Fill(empDataset);

        //    empGrid.Rows.Clear();
        //    for (int i = 0; i < (empDataset.Tables[0].Rows.Count); i++)
        //    {
        //        string id = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[0]);
        //        string name = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[1]);
        //        string pin = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[2]);
        //        string contact = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[3]);
        //        string address = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[4]);
        //        string email = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[5]);
        //        string designation = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[6]);
        //        string hire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[7]);
        //        string fire = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[8]);
        //        string status = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[9]);
        //        string sales = Convert.ToString(empDataset.Tables[0].Rows[i].ItemArray[10]);

        //        DateTime hireDate = (Convert.ToDateTime(hire)).Date;
        //        if (fire == string.Empty)
        //        {
        //            isFired = false;
        //            fire = "---";
        //        }
        //        else
        //        {
        //            isFired = true;
        //            fireDate = (Convert.ToDateTime(fire)).Date;
        //        }
        //        DataGridViewRow pushData = new DataGridViewRow();
        //        pushData.CreateCells(empGrid);
        //        pushData.Cells[0].Value = id;
        //        pushData.Cells[1].Value = name;
        //        pushData.Cells[2].Value = pin;
        //        pushData.Cells[3].Value = contact;
        //        pushData.Cells[4].Value = address;
        //        pushData.Cells[5].Value = email;
        //        pushData.Cells[6].Value = hireDate;
        //        if(isFired) pushData.Cells[7].Value = fireDate;
        //        else pushData.Cells[7].Value = fire;
        //        pushData.Cells[8].Value = status;
        //        pushData.Cells[9].Value = sales;
        //        empGrid.Rows.Add(pushData);

        //    }
        //    con.Close();
        //}



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
        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new Manager_Menu(mainEmpID).Show();
            this.Hide();
        }

        private void empGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = empGrid.Rows[rowIndex];

            empUpdateInfo.name = Convert.ToString(row.Cells[1].Value);
            empUpdateInfo.pin = Convert.ToString(row.Cells[2].Value);
            empUpdateInfo.contact = Convert.ToString(row.Cells[3].Value);
            empUpdateInfo.address = Convert.ToString(row.Cells[4].Value);
            empUpdateInfo.email = Convert.ToString(row.Cells[5].Value);
            empUpdateInfo.id = Convert.ToString(row.Cells[0].Value);
            empUpdateInfo.status = Convert.ToString(row.Cells[8].Value);
        }

        private void rehireEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            rehireEmp();
        }

   

        private void empControl_Load(object sender, EventArgs e)
        {

        }
    }
}