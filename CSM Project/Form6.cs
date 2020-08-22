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
    public partial class carCtrl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string empID;
        bool mLicenceFlag, mNameFlag, mAddressFlag, mContactFlag, mEmailFlag;
        bool cIDFlag, cNameFlag, cModelFlag, cCompanyFlag, cPriceFlag;
        public carCtrl()
        {
            InitializeComponent();
        }
        public carCtrl(string id)
        {
            InitializeComponent();
            pictureVanish();
            emptyChecker();
            empID = id;
        }

        private void emptyChecker()
        {
            if (licenseBox.Text == "")  mLicenceFlag = true;
            if (nameBox.Text == "")   mNameFlag = true;
            if (contactBox.Text == "") mContactFlag = true;
            if(addressBox.Text == "") mAddressFlag = true;
            if (emailBox.Text == "") mEmailFlag = true;

            if (cIDBox.Text == "") cIDFlag = true;
            if (cNameBox.Text == "") cNameFlag = true;
            if (cModelBox.Text == "") cModelFlag = true;
            if (cCmpyBox.Text == "") cCompanyFlag = true;
            if (cPriceBox.Text == "") cPriceFlag = true;

        }
        private void pictureVanish()
        {
            manufLicenseErrorIcon.Visible = false;
            manufNameErrorIcon.Visible = false;
            manufContactErrorIcon.Visible = false;
            manufAddressErrorIcon.Visible = false;
            manufEmailErrorIcon.Visible = false;

            carIDErrorIcon.Visible = false;
            carNameErrorIcon.Visible = false;
            carModelErrorIcon.Visible = false;
            carCompanyErrorIcon.Visible = false;
            carPriceErrorIcon.Visible = false;
        }
        private void clearRows()
        {
            licenseBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            addressBox.Text = "";
            contactBox.Text = "";

            cIDBox.Text = "";
            cNameBox.Text = "";
            cModelBox.Text = "";
            cCmpyBox.Text = "";
            cPriceBox.Text = "";
        }

        private void buyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            bool isOldSeller = false;
            bool isnewSeller = true;
            
            string manfID = licenseBox.Text;
            string manfName = nameBox.Text;
            string manfEmail = emailBox.Text;
            string manfAddress = addressBox.Text;
            string manfContact = contactBox.Text;

            string carID = cIDBox.Text;
            string carName = cNameBox.Text;
            string carModel = cModelBox.Text;
            string carCompany = cCmpyBox.Text;
            string carPrice = cPriceBox.Text;

            if ((mLicenceFlag || mNameFlag || mContactFlag || mAddressFlag || mEmailFlag
                || cIDFlag || cNameFlag || cModelFlag || cPriceFlag || cCompanyFlag) == true)
            {
                if (mLicenceFlag) manufLicenseErrorIcon.Visible = true;
                if (mNameFlag) manufNameErrorIcon.Visible = true;
                if (mContactFlag) manufContactErrorIcon.Visible = true;
                if (mAddressFlag) manufAddressErrorIcon.Visible = true;
                if (mEmailFlag) manufEmailErrorIcon.Visible = true;

                if (cIDFlag) carIDErrorIcon.Visible = true;
                if (cNameFlag) carNameErrorIcon.Visible = true;
                if (cModelFlag) carModelErrorIcon.Visible = true;
                if (cCompanyFlag) carCompanyErrorIcon.Visible = true;
                if (cPriceFlag) carPriceErrorIcon.Visible = true;

                CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information and fill fields to their Rquired Limit.", "OK");

            }
            else
            {
                //this block of code will check whether the car id is valid or not
                con.Open();
                string cIDCheckQuery = "select * from car where car_ID = @id";
                SqlCommand cIDCheckCMD = new SqlCommand(cIDCheckQuery, con);
                cIDCheckCMD.Parameters.AddWithValue("@id", carID);
                SqlDataAdapter cIDCheckAdapter = new SqlDataAdapter(cIDCheckCMD);
                DataSet cIDCheckSet = new DataSet();
                cIDCheckAdapter.Fill(cIDCheckSet);
                con.Close();
                if(cIDCheckSet.Tables[0].Rows.Count > 0)
                {
                    CustomMsgBox.Show("The Entered Car ID is incorrect.\nPlease recheck it","OK");
                    carIDErrorIcon.Visible = true;
                }
                else //if it is valid then validating manufacturer
                {

                    //this piece of code checks whether the primary key of manufacturer is repeated or not
                    con.Open();
                    string mIDCheckQuery = "select * from manufacturer where MANUFACTURER_ID = @id";
                    SqlCommand mIDCheckCMD = new SqlCommand(mIDCheckQuery, con);
                    mIDCheckCMD.Parameters.AddWithValue("@id", manfID);
                    SqlDataAdapter mIDCheckAdapter = new SqlDataAdapter(mIDCheckCMD);
                    DataSet mIDCheckSet = new DataSet();
                    mIDCheckAdapter.Fill(mIDCheckSet);
                    con.Close();

                    if (mIDCheckSet.Tables[0].Rows.Count > 0)
                    {
                        isnewSeller = false;
                        //now we will check whether the cnic matches with the name
                        con.Open();     //if manufacturer id is repeated then checking name
                        string nameCheckQuery = "select * from manufacturer where manufacturer_name = @name and manufacturer_id = @id";
                        SqlCommand nameCheckCMD = new SqlCommand(nameCheckQuery, con);
                        nameCheckCMD.Parameters.AddWithValue("@name", manfName);
                        nameCheckCMD.Parameters.AddWithValue("@id", manfID);
                        SqlDataAdapter nameCheckAdapter = new SqlDataAdapter(nameCheckCMD);
                        DataSet nameCheckSet = new DataSet();
                        nameCheckAdapter.Fill(nameCheckSet);
                        con.Close();
                        if (nameCheckSet.Tables[0].Rows.Count > 0) isOldSeller = true;
                        else
                        {
                            CustomMsgBox.Show("The Given Manufacturer's License/Name are invalid. Please recheck them or inform developer", "OK");
                            manufLicenseErrorIcon.Visible = manufNameErrorIcon.Visible = true;
                        }
                    }
                    if (isnewSeller)
                    {
                        //this block of code will check whether the manufacturer email is valid or not as it is also a unique value
                        con.Open();
                        string mEmailCheckQuery = "select * from manufacturer where manufacturer_email = @email";
                        SqlCommand mEmailCheckCMD = new SqlCommand(mEmailCheckQuery, con);
                        mEmailCheckCMD.Parameters.AddWithValue("@email", manfEmail);
                        SqlDataAdapter mEmailCheckAdapter = new SqlDataAdapter(mEmailCheckCMD);
                        DataSet mEmailCheckSet = new DataSet();
                        mEmailCheckAdapter.Fill(mEmailCheckSet);
                        con.Close();
                        if (mEmailCheckSet.Tables[0].Rows.Count == 0)
                        {
                            con.Open();
                            //this block of code adds a new dealer or manufacturer
                            string manufAddQuery = "INSERT INTO MANUFACTURER(MANUFACTURER_ID,MANUFACTURER_NAME,MANUFACTURER_CONTACT,MANUFACTURER_EMAIL,MANUFACTURER_ADDRESS) Values(@id,@name,@contact,@email,@address)";
                            SqlCommand manufAddCMD = new SqlCommand(manufAddQuery, con);
                            manufAddCMD.Parameters.AddWithValue("@id", manfID);
                            manufAddCMD.Parameters.AddWithValue("@name", manfName);
                            manufAddCMD.Parameters.AddWithValue("@email", manfEmail);
                            manufAddCMD.Parameters.AddWithValue("@address", manfAddress);
                            manufAddCMD.Parameters.AddWithValue("@contact", manfContact);
                            manufAddCMD.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            isnewSeller = false; //so that it doesnt go ahead storing data and getting an exception
                            CustomMsgBox.Show("The given Email is invalid.\nPlease recheck it", "OK");
                            manufEmailErrorIcon.Visible = true;

                        }
                    }

                    if (isOldSeller || isnewSeller)
                    {
                        con.Open();

                        //this block of code adds new car
                        string carAddQuery = "INSERT INTO CAR(CAR_ID,CAR_NAME,CAR_MODEL,CAR_COMPANY,CAR_STATUS,CAR_PRICE) Values(@cID,@cName,@cModel,@cCompany,'Available',@cPrice)";
                        SqlCommand carAddCMD = new SqlCommand(carAddQuery, con);
                        carAddCMD.Parameters.AddWithValue("@cID", carID);
                        carAddCMD.Parameters.AddWithValue("@cName", carName);
                        carAddCMD.Parameters.AddWithValue("@cModel", carModel);
                        carAddCMD.Parameters.AddWithValue("@cCompany", carCompany);
                        carAddCMD.Parameters.AddWithValue("@cPrice", carPrice);
                        carAddCMD.ExecuteNonQuery();

                        //this block is used to generate new order id by getting id from database just the digit part
                        string getOrderQuery = "Select max(substring(manuf_order.ORDER_ID,4,len(manuf_order.order_id))) from MANUF_ORDER ";
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

                        //this block of code adds a new order given to the manufacturer
                        string addOrderQuery = "INSERT INTO MANUF_ORDER(ORDER_ID,EMPLOYEE_ID,CAR_ID,MANUFACTURER_ID,ORDER_DATE,BILL) Values(@orderID,@empID,@carID,@manfID,getdate(),@bill)";
                        SqlCommand addOrderCMD = new SqlCommand(addOrderQuery, con);
                        addOrderCMD.Parameters.AddWithValue("@orderID", OrderID);
                        addOrderCMD.Parameters.AddWithValue("@empID", empID);
                        addOrderCMD.Parameters.AddWithValue("@carID", carID);
                        addOrderCMD.Parameters.AddWithValue("@manfID", manfID);
                        addOrderCMD.Parameters.AddWithValue("@bill", carPrice);
                        addOrderCMD.ExecuteNonQuery();

                        //this block of code generates the payment for the purchase
                        string addBill = "INSERT INTO STOCK_PAYMENT(ORDER_ID,PAYMENT_DATE) Values(@id,getdate())";
                        SqlCommand addBillCMD = new SqlCommand(addBill, con);
                        addBillCMD.Parameters.AddWithValue("@id", OrderID);
                        addBillCMD.ExecuteNonQuery();

                        //this block of code adds the new car into the stock
                        string addStock = "INSERT INTO Stock(Order_ID,Car_ID,REC_DATE) Values(@oID,@cID,getdate())";
                        SqlCommand addStockCMD = new SqlCommand(addStock, con);
                        addStockCMD.Parameters.AddWithValue("@oID", OrderID);
                        addStockCMD.Parameters.AddWithValue("@cID", carID);
                        addStockCMD.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Success");
                        clearRows();
                    }
                }
                
                
               
            }
                
        }
        
        
        //Basic Styling of Textboxes
        private void licenseBox_Enter(object sender, EventArgs e)
        {
            manufLicenseErrorIcon.Visible = false;
            licenseBox.BorderStyle = BorderStyle.None;
            licenseBox.BackColor = Color.FromArgb(34, 36, 49);
            licenseBox.ForeColor = Color.White;
        }
        private void licenseBox_Leave(object sender, EventArgs e)
        {
            if (licenseBox.Text == "")
            {
                manufLicenseErrorIcon.Visible = true;
                mLicenceFlag = true;
            }
            else
            {
                manufLicenseErrorIcon.Visible = false;
                mLicenceFlag = false;
            }
            manufLicenseErrorIcon.BackColor = Color.Transparent;
            licenseBox.BorderStyle = BorderStyle.Fixed3D;
            licenseBox.BackColor = Color.White;
            licenseBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            manufNameErrorIcon.Visible = false;
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.ForeColor = Color.White;
        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                manufNameErrorIcon.Visible = true;
                mNameFlag = true;
            }
            else
            {
                manufNameErrorIcon.Visible = false;
                mNameFlag = false;
            }
            manufNameErrorIcon.BackColor = Color.Transparent;
            nameBox.BorderStyle = BorderStyle.Fixed3D;
            nameBox.BackColor = Color.White;
            nameBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void contactBox_Enter(object sender, EventArgs e)
        {
            manufContactErrorIcon.Visible = false;
            contactBox.BorderStyle = BorderStyle.None;
            contactBox.BackColor = Color.FromArgb(34, 36, 49);
            contactBox.ForeColor = Color.White;
        }
        private void contactBox_Leave(object sender, EventArgs e)
        {
            if (contactBox.Text == "" || contactBox.Text.Length != 11)
            {
                manufContactErrorIcon.Visible = true;
                mContactFlag = true;
            }
            else
            {
                manufContactErrorIcon.Visible = false;
                mContactFlag = false;
            }
            manufContactErrorIcon.BackColor = Color.Transparent;
            contactBox.BorderStyle = BorderStyle.Fixed3D;
            contactBox.BackColor = Color.White;
            contactBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            manufAddressErrorIcon.Visible = false;
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.BackColor = Color.FromArgb(34, 36, 49);
            addressBox.ForeColor = Color.White;
        }
        private void addressBox_Leave(object sender, EventArgs e)
        {
            if (addressBox.Text == "")
            {
                manufAddressErrorIcon.Visible = true;
                mAddressFlag = true;
            }
            else
            {
                manufAddressErrorIcon.Visible = false;
                mAddressFlag = false;
            }
            manufAddressErrorIcon.BackColor = Color.Transparent;
            addressBox.BorderStyle = BorderStyle.Fixed3D;
            addressBox.BackColor = Color.White;
            addressBox.ForeColor = Color.FromArgb(77, 74, 82);
        }
      
        private void emailBox_Enter(object sender, EventArgs e)
        {
            manufEmailErrorIcon.Visible = false;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.BackColor = Color.FromArgb(34, 36, 49);
            emailBox.ForeColor = Color.White;
        }
        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                manufEmailErrorIcon.Visible = true;
                mEmailFlag = true;
            }
            else
            {
                manufEmailErrorIcon.Visible = false;
                mEmailFlag = false;
            }
            manufEmailErrorIcon.BackColor = Color.Transparent;
            emailBox.BorderStyle = BorderStyle.Fixed3D;
            emailBox.BackColor = Color.White;
            emailBox.ForeColor = Color.FromArgb(77, 74, 82);
        }



        private void cIDBox_Enter(object sender, EventArgs e)
        {
            carIDErrorIcon.Visible = false;
            cIDBox.BorderStyle = BorderStyle.None;
            cIDBox.BackColor = Color.FromArgb(34, 36, 49);
            cIDBox.ForeColor = Color.White;
        }
        private void cIDBox_Leave(object sender, EventArgs e)
        {
            if (cIDBox.Text == "")
            {
                carIDErrorIcon.Visible = true;
                cIDFlag = true;
            }
            else
            {
                carIDErrorIcon.Visible = false;
                cIDFlag = false;
            }
            carIDErrorIcon.BackColor = Color.Transparent;
            cIDBox.BorderStyle = BorderStyle.Fixed3D;
            cIDBox.BackColor = Color.White;
            cIDBox.ForeColor = Color.FromArgb(77, 74, 82);
        }
     
        private void cNameBox_Enter(object sender, EventArgs e)
        {
            carNameErrorIcon.Visible = false;
            cNameBox.BorderStyle = BorderStyle.None;
            cNameBox.BackColor = Color.FromArgb(34, 36, 49);
            cNameBox.ForeColor = Color.White;
        }
        private void cNameBox_Leave(object sender, EventArgs e)
        {
            if (cNameBox.Text == "")
            {
                carNameErrorIcon.Visible = true;
                cNameFlag = true;
            }
            else
            {
                carNameErrorIcon.Visible = false;
                cNameFlag = false;
            }
            carIDErrorIcon.BackColor = Color.Transparent;
            cNameBox.BorderStyle = BorderStyle.Fixed3D;
            cNameBox.BackColor = Color.White;
            cNameBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void cModelBox_Enter(object sender, EventArgs e)
        {
            carModelErrorIcon.Visible = false;
            cModelBox.BorderStyle = BorderStyle.None;
            cModelBox.BackColor = Color.FromArgb(34, 36, 49);
            cModelBox.ForeColor = Color.White;
        }
        private void cModelBox_Leave(object sender, EventArgs e)
        {
            if (cModelBox.Text == "" || cModelBox.Text.Length != 4)
            {
                carModelErrorIcon.Visible = true;
                cModelFlag = true;
            }
            else
            {
                carModelErrorIcon.Visible = false;
                cModelFlag = false;
            }
            carModelErrorIcon.BackColor = Color.Transparent;
            cModelBox.BorderStyle = BorderStyle.Fixed3D;
            cModelBox.BackColor = Color.White;
            cModelBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void cCmpyBox_Enter(object sender, EventArgs e)
        {
            carCompanyErrorIcon.Visible = false;
            cCmpyBox.BorderStyle = BorderStyle.None;
            cCmpyBox.BackColor = Color.FromArgb(34, 36, 49);
            cCmpyBox.ForeColor = Color.White;
        }
        private void cCmpyBox_Leave(object sender, EventArgs e)
        {
            if (cCmpyBox.Text == "")
            {
                carCompanyErrorIcon.Visible = true;
                cCompanyFlag = true;
            }
            else
            {
                carCompanyErrorIcon.Visible = false;
                cCompanyFlag = false;
            }
            carCompanyErrorIcon.BackColor = Color.Transparent;
            cCmpyBox.BorderStyle = BorderStyle.Fixed3D;
            cCmpyBox.BackColor = Color.White;
            cCmpyBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        private void cPriceBox_Enter(object sender, EventArgs e)
        {
            carPriceErrorIcon.Visible = false;
            cPriceBox.BorderStyle = BorderStyle.None;
            cPriceBox.BackColor = Color.FromArgb(34, 36, 49);
            cPriceBox.ForeColor = Color.White;
        }
        private void cPriceBox_Leave(object sender, EventArgs e)
        {
            if (cPriceBox.Text == "")
            {
                carPriceErrorIcon.Visible = true;
                cPriceFlag = true;
            }
            else
            {
                carPriceErrorIcon.Visible = false;
                cPriceFlag = false;
            }
            carPriceErrorIcon.BackColor = Color.Transparent;
            cPriceBox.BorderStyle = BorderStyle.Fixed3D;
            cPriceBox.BackColor = Color.White;
            cPriceBox.ForeColor = Color.FromArgb(77, 74, 82);
        }

        
        //Code for validating each input
        private void licenseBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
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
        private void emailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '@')
                || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }
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


        private void cNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }
        private void cCmpyBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void cPriceBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void cModelBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buyBtn_MouseEnter(object sender, EventArgs e)
        {
            buyBtn.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void buyBtn_MouseLeave(object sender, EventArgs e)
        {
            buyBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void cIDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }



        //Back Button and Exit Button Styling
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new SMMenu(empID).Show();
            this.Hide();
        }
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
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
            exitBtn.ForeColor = Color.Red;
        }

        private string idGenerator(string id)
        {
            string digits, letters;
            letters = "MOD";
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
