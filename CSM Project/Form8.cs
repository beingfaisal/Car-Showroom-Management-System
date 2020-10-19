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
    public partial class Form8 : Form
    {
        string OrderID,userID;
        bool isPurchase;
        public Form8(string empID)
        {
            InitializeComponent();
            purchGridFill();
            userID = empID;
        }
            
        private void purchGridFill()
        {
            viewCarGrid.Columns[3].Visible = true;
            viewCarGrid.Columns[4].Visible = false;
            isPurchase = true;

            redundantData.con.Open();
            string saleQuery = "Select STOCK_PAYMENT.ORDER_ID, CAR.CAR_NAME,EMPLOYEE.EMPLOYEE_NAME,MANUFACTURER.MANUFACTURER_NAME,MANUF_ORDER.BILL, STOCK_PAYMENT.PAYMENT_DATE from STOCK_PAYMENT inner join MANUF_ORDER on STOCK_PAYMENT.ORDER_ID = MANUF_ORDER.ORDER_ID inner join CAR on MANUF_ORDER.CAR_ID = CAR.CAR_ID inner join EMPLOYEE on MANUF_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID inner join MANUFACTURER on MANUF_ORDER.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID";
            SqlCommand viewCarCmd = new SqlCommand(saleQuery, redundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string PaymentID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string CarName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string EmployeeName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string ManufacturerName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Bill = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Date = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DateTime newDate = Convert.ToDateTime(Date).Date;

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = PaymentID;
                pushData.Cells[1].Value = CarName;
                pushData.Cells[2].Value = EmployeeName;
                pushData.Cells[3].Value = ManufacturerName;
                pushData.Cells[5].Value = Bill;
                pushData.Cells[6].Value = newDate;

                viewCarGrid.Rows.Add(pushData);

            }

            redundantData.con.Close();
        }

        private void salesGridFill()
        {
            viewCarGrid.Columns[3].Visible = false;
            viewCarGrid.Columns[4].Visible = true ;
            isPurchase = false;

            redundantData.con.Open();
            string purchQuery = "Select SELL_PAYMENT.ORDER_ID, CAR.CAR_NAME, EMPLOYEE.EMPLOYEE_NAME, CUSTOMER.CUSTOMER_NAME,CUSTOMER_ORDER.BILL, SELL_PAYMENT.PAYMENT_DATE from SELL_PAYMENT inner join CUSTOMER_ORDER on SELL_PAYMENT.ORDER_ID = CUSTOMER_ORDER.ORDER_ID inner join CAR on CUSTOMER_ORDER.CAR_ID = CAR.CAR_ID inner join EMPLOYEE on CUSTOMER_ORDER.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID inner join CUSTOMER on CUSTOMER_ORDER.CUSTOMER_CNIC = CUSTOMER.CUSTOMER_CNIC";
            SqlCommand viewCarCmd = new SqlCommand(purchQuery, redundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string PaymentID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string CarName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string EmployeeName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string CustomerName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Bill = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Date = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DateTime newDate = Convert.ToDateTime(Date).Date;

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = PaymentID;
                pushData.Cells[1].Value = CarName;
                pushData.Cells[2].Value = EmployeeName;
                pushData.Cells[4].Value = CustomerName;
                pushData.Cells[5].Value = Bill;
                pushData.Cells[6].Value = newDate;

                viewCarGrid.Rows.Add(pushData);

            }

            redundantData.con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            salesGridFill();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            purchGridFill();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (Form9 uu = new Form9(OrderID, isPurchase, userID, false))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Normal;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                    formBackground.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
                formBackground.Hide();
            }
        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            OrderID = Convert.ToString(row.Cells[0].Value);
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

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Manager_Menu(userID).Show();
        }
    }
    
}
