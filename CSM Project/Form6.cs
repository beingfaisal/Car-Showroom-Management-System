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
        SqlConnection con = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=CSM;Integrated Security=True");
        string empID;
        public carCtrl()
        {
            InitializeComponent();
        }
        public carCtrl(string id)
        {
            InitializeComponent();
            empID = id;
        }


        private void buyBtn_MouseClick(object sender, MouseEventArgs e)
        {
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
            clearRows();
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

        private void clearRows()
        {
            licenseBox.Text = "";
            nameBox.Text= "";
            emailBox.Text = "";
            addressBox.Text = "";
            contactBox.Text = "";

            cIDBox.Text = "";
            cNameBox.Text = "";
            cModelBox.Text = "";
            cCmpyBox.Text = "";
            cPriceBox.Text = "";
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new SMMenu(empID).Show();
            this.Hide();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
