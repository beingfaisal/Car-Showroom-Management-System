using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public partial class CarSell : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string empId,carID;
        bool nameFlag, cnicFlag, addressFlag, contactFlag;

        public CarSell()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public CarSell(string id)
        {
            InitializeComponent();
            empId = id;
            this.CenterToScreen();
        }
        public CarSell(string id,string carid)
        {
            InitializeComponent();
            empId = id;
            carID = carid;
            this.CenterToScreen();
            pictureVanish();
            startChecker();
        }

        private void pictureVanish()
        {
            nameBoxErrorIcon.Visible = false;
            cnicBoxErrorIcon.Visible = false;
            addressBoxErrorIcon.Visible = false;
            contactBoxErrorIcon.Visible = false;
        }

        private void startChecker()
        {
            if (nameBox.Text == "")
            {
                nameFlag = true;
            }

            if (cnicBox.Text == "")
            {
                cnicFlag = true;
            }
            if (addressBox.Text == "")
            {
                addressFlag = true;
            }

            if (contactBox.Text == "")
            {
                contactFlag = true;
            }
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new SMMenu(empId).Show();
            this.Hide();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.Red;
        }

        private void sellBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string cust_name, cust_cnic, cust_address, cust_contact;
            cust_name = nameBox.Text;
            cust_cnic = cnicBox.Text;
            cust_address = addressBox.Text;
            cust_contact = contactBox.Text;
            if ((nameFlag || cnicFlag || addressFlag || contactFlag) == true)
            {
                if (nameFlag) nameBoxErrorIcon.Visible = true;
                if (cnicFlag) cnicBoxErrorIcon.Visible = true;
                if (addressFlag) addressBoxErrorIcon.Visible = true;
                if (contactFlag) contactBoxErrorIcon.Visible = true;

                CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information and fill fields to required information.", "OK");
            }
            else
            {
                //this piece of code checks whether the primary key is repeated or not
                con.Open();
                string cnicCheckQuery = "select * from customer where customer_cnic = @id";
                SqlCommand cnicCheckCMD = new SqlCommand(cnicCheckQuery, con);
                cnicCheckCMD.Parameters.AddWithValue("@id",cust_cnic);
                SqlDataAdapter cnicCheckAdapter = new SqlDataAdapter(cnicCheckCMD);
                DataSet cnicCheckSet = new DataSet();
                cnicCheckAdapter.Fill(cnicCheckSet);
                con.Close();

                if ((cnicCheckSet.Tables[0].Rows.Count) > 0)
                {
                    CustomMsgBox.Show("The given CNIC already exists. Please recheck CNIC of customer or inform manager.", "OK");
                }
                else  //here starts the real process in selling a car
                {
                    //this block is used to insert the values in the column of customer
                    con.Open();
                    string insertQuery = "Insert into CUSTOMER(CUSTOMER_CNIC,CUSTOMER_NAME,CUSTOMER_CONTACT,CUSTOMER_ADDRESS) VALUES(@cnic,@name,@contact,@address)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@cnic", cust_cnic);
                    cmd.Parameters.AddWithValue("@name", cust_name);
                    cmd.Parameters.AddWithValue("@contact", cust_contact);
                    cmd.Parameters.AddWithValue("@address", cust_address);
                    cmd.ExecuteNonQuery();

                    //this block is used to generate new order id by getting id from database just the digit part
                    string getOrderQuery = "Select max(substring(CUSTOMER_ORDER.ORDER_ID,4,len(customer_order.order_id))) from CUSTOMER_ORDER ";
                    SqlCommand getCmd = new SqlCommand(getOrderQuery, con);
                    SqlDataAdapter orderAdapter = new SqlDataAdapter(getCmd);
                    DataSet orderData = new DataSet();
                    orderAdapter.Fill(orderData);
                    string id;
                    if ((orderData.Tables[0].Rows.Count) > 0)
                    {
                        id = Convert.ToString(orderData.Tables[0].Rows[0].ItemArray[0]);
                    }
                    else
                    {
                        id = string.Empty;
                    }
                    string OrderID = idGenerator(id); //function that generates the Order_ID

                    //this block of code gets the price of car from database and increases it by 10%
                    string getPriceQuery = "Select car.car_price from car where car.car_id = @id";
                    SqlCommand getPriceCmd = new SqlCommand(getPriceQuery, con);
                    getPriceCmd.Parameters.AddWithValue("@id", carID);
                    SqlDataAdapter priceAdapter = new SqlDataAdapter(getPriceCmd);
                    DataSet priceData = new DataSet();
                    priceAdapter.Fill(priceData);
                    int price = Convert.ToInt32(priceData.Tables[0].Rows[0].ItemArray[0]);
                    int newBill = price + ((price * 10) / 100);

                    //this block of code is used to store data for the order given by customer
                    string upOrderQuery = "Insert into Customer_Order(order_id,employee_id,car_id,customer_cnic,order_date,bill) values(@Oid,@EmpID,@CiD,@cnic,getDate(),@bill)";
                    SqlCommand upCMD = new SqlCommand(upOrderQuery, con);
                    upCMD.Parameters.AddWithValue("@Oid", OrderID);
                    upCMD.Parameters.AddWithValue("@EmpID", empId);
                    upCMD.Parameters.AddWithValue("@CiD", carID);
                    upCMD.Parameters.AddWithValue("@cnic", cust_cnic);
                    upCMD.Parameters.AddWithValue("@bill", newBill);
                    upCMD.ExecuteNonQuery();

                    //this block of code is used to store data about the payment of sold car
                    string paymentQuery = "insert into SELL_PAYMENT(Order_ID,payment_Date) values(@order,getDate())";
                    SqlCommand paymentCMD = new SqlCommand(paymentQuery, con);
                    paymentCMD.Parameters.AddWithValue("@order", OrderID);
                    paymentCMD.ExecuteNonQuery();

                    //this block of code runs query that changes the status of car from available to sold
                    string updateCarQuery = "update Car set car.car_status='Sold' where car_id = @carid";
                    SqlCommand updateCMD = new SqlCommand(updateCarQuery, con);
                    updateCMD.Parameters.AddWithValue("@carid", carID);
                    updateCMD.ExecuteNonQuery();

                    //this block of Code will update the number of sales for that employee
                    string updateSalesQuery = "Update employee set EMPLOYEE_SALES = (Employee_sales+1) where EMPLOYEE_ID = @id";
                    SqlCommand updateSaleCMD = new SqlCommand(updateSalesQuery, con);
                    updateSaleCMD.Parameters.AddWithValue("@id", empId);
                    updateSaleCMD.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("success");
                    this.Close();

                    nameBox.Text = "";
                    cnicBox.Text = "";
                    addressBox.Text = "";
                    contactBox.Text = "";
            }   }
        }

        // This Block Contains the code for when does the focus comes into the textboxes
        private void nameBox_Enter(object sender, EventArgs e)
        {
            nameBoxErrorIcon.BackColor = Color.FromArgb(77, 74, 82);
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = Color.FromArgb(77, 74, 82);
            nameBox.ForeColor = Color.White;
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if(nameBox.Text == "")
            {
                nameBoxErrorIcon.Visible = true;
                nameFlag = true;
            }
            else
            {
                nameBoxErrorIcon.Visible = false;
                nameFlag = false;
            }
            nameBoxErrorIcon.BackColor = Color.Transparent;
            nameBox.BorderStyle = BorderStyle.Fixed3D;
            nameBox.BackColor = Color.White;
            nameBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void cnicBox_Enter(object sender, EventArgs e)
        {
            cnicBoxErrorIcon.BackColor = Color.FromArgb(77, 74, 82);
            cnicBox.BorderStyle = BorderStyle.None;
            cnicBox.BackColor = Color.FromArgb(77, 74, 82);
            cnicBox.ForeColor = Color.White;
        }

        private void cnicBox_Leave(object sender, EventArgs e)
        {
            if((cnicBox.Text == "") || (cnicBox.Text.Length != 13))
            {
                cnicBoxErrorIcon.Visible = true;
                cnicFlag = true;
            }
            else if(cnicBox.Text.Length == 13)
            {
                cnicBoxErrorIcon.Visible = false;
                cnicFlag = false;
            }
            cnicBoxErrorIcon.BackColor = Color.Transparent;
            cnicBox.BorderStyle = BorderStyle.Fixed3D;
            cnicBox.BackColor = Color.White;
            cnicBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            addressBoxErrorIcon.BackColor = Color.FromArgb(77, 74, 82);
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.BackColor = Color.FromArgb(77, 74, 82);
            addressBox.ForeColor = Color.White;
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            if(addressBox.Text == "")
            {
                addressBoxErrorIcon.Visible = true;
                addressFlag = true;
            }
            else
            {
                addressBoxErrorIcon.Visible = false;
                addressFlag = false;
            }
            addressBoxErrorIcon.BackColor = Color.Transparent;
            addressBox.BorderStyle = BorderStyle.Fixed3D;
            addressBox.BackColor = Color.White;
            addressBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void contactBox_Enter(object sender, EventArgs e)
        {
            contactBox.BackColor = Color.FromArgb(77, 74, 82);
            contactBox.BorderStyle = BorderStyle.None;
            contactBox.BackColor = Color.FromArgb(77, 74, 82);
            contactBox.ForeColor = Color.White;
        }

        private void contactBox_Leave(object sender, EventArgs e)
        {
            if((contactBox.Text == "") || ((contactBox.Text.Length) != 11 ))
            {
                contactBoxErrorIcon.Visible = true;
                contactFlag = true;
            }
            else if(contactBox.Text.Length == 11)
            {
                contactBoxErrorIcon.Visible = false;
                contactFlag = false;
            }
            contactBoxErrorIcon.BackColor = Color.Transparent;
            contactBox.BorderStyle = BorderStyle.Fixed3D;
            contactBox.BackColor = Color.White;
            contactBox.ForeColor = Color.FromArgb(77, 74, 82);
        }




        //this code will help in validating the input

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }

        private void contactBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '/') 
                || (e.KeyChar == '#') || (e.KeyChar == ',') || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }

        }

        private void cnicBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }


        private string idGenerator(string id)
        {
            string digits,letters;
            letters = "COD";
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
            string new_id = letters + (++number).ToString("D4");
            
            return new_id;
        }

    }
}
