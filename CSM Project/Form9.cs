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
    public partial class Form9 : Form
    {
        string idOrder = "\0";
        string userID;
        bool fromAccount;
        bool isPurch = true;
        public Form9(string orderID, bool isPurchase,string empID,bool fromAcc)
        {
            InitializeComponent();
            idOrder = orderID;
            isPurch = isPurchase;
            userID = empID;
            gridfill();
            fromAccount = fromAcc;
        }

        void gridfill()
        {
            string carInfoQuery = "\0";
            string cust_manufQuery = "\0";
            string empInfoQuery = "\0";
            string orderInfoQuery = "\0";

            if (isPurch)
            {
                carInfoQuery = " Select CAR.CAR_NAME,CAR.CAR_ID,CAR.CAR_MODEL,CAR.CAR_COMPANY FROM MANUF_ORDER " +
                    "INNER JOIN STOCK_PAYMENT ON MANUF_ORDER.ORDER_ID = STOCK_PAYMENT.ORDER_ID" +
                    " INNER JOIN CAR ON MANUF_ORDER.CAR_ID = CAR.CAR_ID WHERE STOCK_PAYMENT.ORDER_ID = @id";

                cust_manufQuery = "SELECT MANUFACTURER.MANUFACTURER_NAME, MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_CONTACT," +
                    " MANUFACTURER.MANUFACTURER_ADDRESS FROM STOCK_PAYMENT " +
                    "INNER JOIN MANUF_ORDER ON STOCK_PAYMENT.ORDER_ID = MANUF_ORDER.ORDER_ID " +
                    "INNER JOIN MANUFACTURER ON MANUF_ORDER.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID " +
                    "WHERE STOCK_PAYMENT.ORDER_ID =@id ";


                empInfoQuery = "Select EMPLOYEE.EMPLOYEE_ID, EMPLOYEE.EMPLOYEE_NAME, EMPLOYEE.EMPLOYEE_CONTACT, EMPLOYEE.EMPLOYEE_DESIGNATION" +
                    " FROM STOCK_PAYMENT" +
                    " INNER JOIN MANUF_ORDER ON STOCK_PAYMENT.ORDER_ID = MANUF_ORDER.ORDER_ID " +
                    "INNER JOIN EMPLOYEE ON MANUF_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID " +
                    "WHERE STOCK_PAYMENT.ORDER_ID =@id ";


                orderInfoQuery = "SELECT MANUF_ORDER.ORDER_ID, MANUF_ORDER.BILL, MANUF_ORDER.ORDER_DATE  " +
                    "FROM MANUF_ORDER " +
                    "INNER JOIN STOCK_PAYMENT ON STOCK_PAYMENT.ORDER_ID = MANUF_ORDER.ORDER_ID " +
                    "WHERE STOCK_PAYMENT.ORDER_ID = @id";

            }
            else
            {
                carInfoQuery = "Select	CAR.CAR_NAME, CAR.CAR_ID, CAR.CAR_MODEL, CAR.CAR_COMPANY FROM CUSTOMER_ORDER " +
                    "INNER JOIN SELL_PAYMENT ON SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID " +
                    "INNER JOIN CAR ON CUSTOMER_ORDER.CAR_ID = CAR.CAR_ID WHERE CUSTOMER_ORDER.ORDER_ID = @id";


                cust_manufQuery = "SELECT CUSTOMER.CUSTOMER_NAME, CUSTOMER.CUSTOMER_CNIC,CUSTOMER.CUSTOMER_CONTACT,CUSTOMER.CUSTOMER_ADDRESS " +
                    "FROM SELL_PAYMENT " +
                    "INNER JOIN CUSTOMER_ORDER ON SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID " +
                    "INNER JOIN CUSTOMER ON CUSTOMER_ORDER.CUSTOMER_CNIC = CUSTOMER.CUSTOMER_CNIC WHERE SELL_PAYMENT.ORDER_ID = @id ";


                empInfoQuery = "Select EMPLOYEE.EMPLOYEE_ID, EMPLOYEE.EMPLOYEE_NAME, EMPLOYEE.EMPLOYEE_CONTACT, EMPLOYEE.EMPLOYEE_DESIGNATION" +
                    " FROM SELL_PAYMENT" +
                    " INNER JOIN CUSTOMER_ORDER ON SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID " +
                    "INNER JOIN EMPLOYEE ON CUSTOMER_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID " +
                    "WHERE SELL_PAYMENT.ORDER_ID =@id ";

                orderInfoQuery = "SELECT CUSTOMER_ORDER.ORDER_ID, CUSTOMER_ORDER.BILL, CUSTOMER_ORDER.ORDER_DATE  " +
                    "FROM CUSTOMER_ORDER " +
                    "INNER JOIN SELL_PAYMENT ON SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID " +
                    "WHERE SELL_PAYMENT.ORDER_ID = @id";



            }
            redundantData.con.Open();

            //Data for Car
            SqlCommand carInfoCmd = new SqlCommand(carInfoQuery, redundantData.con);
            carInfoCmd.Parameters.AddWithValue("@id", idOrder);
            SqlDataAdapter carInfoAdapter = new SqlDataAdapter(carInfoCmd);
            DataSet carInfoData = new DataSet();
            carInfoAdapter.Fill(carInfoData);

            carNameLbl.Text = Convert.ToString(carInfoData.Tables[0].Rows[0].ItemArray[0]);
            carIDLbl.Text = Convert.ToString(carInfoData.Tables[0].Rows[0].ItemArray[1]);
            carCompanyLbl.Text = Convert.ToString(carInfoData.Tables[0].Rows[0].ItemArray[2]);
            carModelLbl.Text = Convert.ToString(carInfoData.Tables[0].Rows[0].ItemArray[3]);


            //Data for Employee
            SqlCommand empInfoCmd = new SqlCommand(empInfoQuery, redundantData.con);
            empInfoCmd.Parameters.AddWithValue("@id", idOrder);
            SqlDataAdapter empInfoAdapter = new SqlDataAdapter(empInfoCmd);
            DataSet empInfoData = new DataSet();
            empInfoAdapter.Fill(empInfoData);

            empIDLbl.Text = Convert.ToString(empInfoData.Tables[0].Rows[0].ItemArray[0]);
            empNameLbl.Text = Convert.ToString(empInfoData.Tables[0].Rows[0].ItemArray[1]);
            empContactLbl.Text = Convert.ToString(empInfoData.Tables[0].Rows[0].ItemArray[2]);
            empDesignationLbl.Text = Convert.ToString(empInfoData.Tables[0].Rows[0].ItemArray[3]);

            //Data for Customer or Seller
            SqlCommand sellerCustInfoCmd = new SqlCommand(cust_manufQuery, redundantData.con);
            sellerCustInfoCmd.Parameters.AddWithValue("@id", idOrder);
            SqlDataAdapter sellerCustInfoAdapter = new SqlDataAdapter(sellerCustInfoCmd);
            DataSet sellerCustInfoData = new DataSet();
            sellerCustInfoAdapter.Fill(sellerCustInfoData);

            sellerNameLbl.Text = Convert.ToString(sellerCustInfoData.Tables[0].Rows[0].ItemArray[0]);
            sellerIDLbl.Text = Convert.ToString(sellerCustInfoData.Tables[0].Rows[0].ItemArray[1]);
            sellerContactLbl.Text = Convert.ToString(sellerCustInfoData.Tables[0].Rows[0].ItemArray[2]);
            sellerAddressLbl.Text = Convert.ToString(sellerCustInfoData.Tables[0].Rows[0].ItemArray[3]);

            //Data for Order info
            SqlCommand orderInfoCmd = new SqlCommand(orderInfoQuery, redundantData.con);
            orderInfoCmd.Parameters.AddWithValue("@id", idOrder);
            SqlDataAdapter orderInfoAdapter = new SqlDataAdapter(orderInfoCmd);
            DataSet orderInfoData = new DataSet();
            orderInfoAdapter.Fill(orderInfoData);

            orderIDLbl.Text = Convert.ToString(orderInfoData.Tables[0].Rows[0].ItemArray[0]);
            orderBillLbl.Text = Convert.ToString(orderInfoData.Tables[0].Rows[0].ItemArray[1]);
            orderDateLbl.Text = Convert.ToString(orderInfoData.Tables[0].Rows[0].ItemArray[2]);



            redundantData.con.Close();


        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //if (fromAccount)
            //    new Form10(userID).Show();
            //else
            //    new Form8(userID).Show();
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
    }
}
