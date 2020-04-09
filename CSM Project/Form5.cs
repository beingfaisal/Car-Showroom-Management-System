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
    public partial class SaleManCtrl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=CSM;Integrated Security=True");
        string mainEmpID,EmpId,empStatus;
        public SaleManCtrl()
        {
            InitializeComponent();
            gridFill();
            this.CenterToScreen();
        }
        public SaleManCtrl(string id)
        {
            InitializeComponent();
            gridFill();
            mainEmpID = id;
            EmpId = "";
            empStatus = "";
            this.CenterToScreen();
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
                if(fire == string.Empty)
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

        private void empGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = empGrid.Rows[rowIndex];

            nameBox.Text = Convert.ToString(row.Cells[1].Value);
            pinBox.Text = Convert.ToString(row.Cells[2].Value);
            contactBox.Text = Convert.ToString(row.Cells[3].Value);
            addressBox.Text = Convert.ToString(row.Cells[4].Value);
            emailBox.Text = Convert.ToString(row.Cells[5].Value);
            EmpId = Convert.ToString(row.Cells[0].Value);
            empStatus = Convert.ToString(row.Cells[8].Value);

        }
        private void clearRows()
        {
            nameBox.Text = "";
            pinBox.Text = "";
            contactBox.Text = "";
            addressBox.Text = "";
            emailBox.Text = "";
        }

        

        private async void hireBtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            string name = nameBox.Text;
            string pin = pinBox.Text;
            string contact = contactBox.Text;
            string address = addressBox.Text;
            string email = emailBox.Text;

            if (name == string.Empty || contact == string.Empty || address == string.Empty || email == string.Empty || pin == string.Empty)
            {
                hireBtn.BackColor = Color.Red;
                await Task.Delay(1500);
                hireBtn.BackColor = SystemColors.Control;
            }
            else
            {
                con.Open();
                //this block is used to generate new employee id by getting id from database just the digit part
                string getEmpIdQuery = "Select max(substring(employee.employee_ID,3,len(EMPLOYEE.EMPLOYEE_ID))) from employee where EMPLOYEE_DESIGNATION = 'Salesman' ";
                SqlCommand getEmpIdCmd = new SqlCommand(getEmpIdQuery, con);
                SqlDataAdapter empIdAdapter = new SqlDataAdapter(getEmpIdCmd);
                DataSet empIdDataSet = new DataSet();
                empIdAdapter.Fill(empIdDataSet);
                string id;
                if ((empIdDataSet.Tables[0].Rows.Count) > 0)
                {
                    id = Convert.ToString(empIdDataSet.Tables[0].Rows[0].ItemArray[0]);
                }
                else
                {
                    id = string.Empty;
                }
                string newEmpID = idGenerator(id); //function that generates the Order_ID

                //this block of code is used to add new employees
                string newEmpQuery = "INSERT INTO EMPLOYEE(EMPLOYEE_ID,EMPLOYEE_NAME,EMPLOYEE_PASSWORD,EMPLOYEE_CONTACT,EMPLOYEE_ADDRESS,EMPLOYEE_EMAIL,EMPLOYEE_DESIGNATION,EMPLOYEE_HIREDATE,EMPLOYEE_STATUS,EMPLOYEE_SALES) VALUES(@id,@name,@password,@contact,@address,@email,'Salesman',(CONVERT(DATE, GETDATE())),'Working',0)";
                SqlCommand newEmpCmd = new SqlCommand(newEmpQuery, con);
                newEmpCmd.Parameters.AddWithValue("@id", newEmpID);
                newEmpCmd.Parameters.AddWithValue("@name", name);
                newEmpCmd.Parameters.AddWithValue("@contact", contact);
                newEmpCmd.Parameters.AddWithValue("@address", address);
                newEmpCmd.Parameters.AddWithValue("@email", email);
                newEmpCmd.Parameters.AddWithValue("@password", pin);
                newEmpCmd.ExecuteNonQuery();

                con.Close();
                gridFill();
                clearRows();
            }
        }


        private async void updateBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string name = nameBox.Text;
            string pin = pinBox.Text;
            string contact = contactBox.Text;
            string address = addressBox.Text;
            string email = emailBox.Text;
            string employeeId = EmpId;

            if (EmpId == "")
            {
                updateBtn.BackColor = Color.Red;
                await Task.Delay(1500);
                updateBtn.BackColor = SystemColors.Control;
            }
            else
            {
                con.Open();
                string updateEmpQuery = "Update employee set EMPLOYEE_Name = @newName, EMPLOYEE_Password = @newPin, EMPLOYEE_Contact = @newContact, EMPLOYEE_Address = @newAddress, EMPLOYEE_Email = @newEmail  where EMPLOYEE_ID = @updateId";
                SqlCommand updateEmpCMD = new SqlCommand(updateEmpQuery, con);
                updateEmpCMD.Parameters.AddWithValue("@newName", name);
                updateEmpCMD.Parameters.AddWithValue("@newPin", pin);
                updateEmpCMD.Parameters.AddWithValue("@newContact", contact);
                updateEmpCMD.Parameters.AddWithValue("@newAddress", address);
                updateEmpCMD.Parameters.AddWithValue("@newEmail", email);
                updateEmpCMD.Parameters.AddWithValue("@updateId", employeeId);
                updateEmpCMD.ExecuteNonQuery();
                con.Close();
                gridFill();
                clearRows();
            }
        }

        private async void fireBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (EmpId == "" || empStatus == "Fired")
            {
                fireBtn.BackColor = Color.Red;
                await Task.Delay(1500);
                fireBtn.BackColor = SystemColors.Control;
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
                clearRows();
            }
        }

        private void viewBtn_MouseClick(object sender, MouseEventArgs e)
        {
            gridFill();
            clearRows();
        }

        private void viewFireBtn_MouseClick(object sender, MouseEventArgs e)
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

        private void viewHireBtn_MouseClick(object sender, MouseEventArgs e)
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

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new Manager_Menu(mainEmpID).Show();
            this.Hide();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

       

        private string idGenerator(string id)
        {
            string digits, letters;
            letters = "SM";
            if (id == string.Empty)
            {
                digits = "000";
            }
            else
            {
                digits = new string(id.Where(char.IsDigit).ToArray());
            }
            int number;
            int.TryParse(digits, out number);
            string new_id = letters + (++number).ToString("D3");

            return new_id;
        }
    }
}
