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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string mainEmpID,EmpId,empStatus;
        public SaleManCtrl()
        {
            InitializeComponent();
        }
        public SaleManCtrl(string id)
        {
            InitializeComponent();
            mainEmpID = id;
            EmpId = "";
            empStatus = "";
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
            }
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
