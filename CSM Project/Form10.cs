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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQUHHL3\\MSSQLSERVER01;Initial Catalog=CSM;Integrated Security=True");
        string userID,OrderID,isPurch;
        public Form10(string id)
        {
            InitializeComponent();
            gridFill();
            cashCollector();
            userID = id;
        }

        private void gridFill()
        {
            con.Open();
            SqlCommand accountAllCmd = new SqlCommand("select * from Account", con);
            SqlDataAdapter accountAllAdapter = new SqlDataAdapter(accountAllCmd);
            DataSet accountAllData = new DataSet();
            accountAllAdapter.Fill(accountAllData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (accountAllData.Tables[0].Rows.Count); i++)
            {
                string manufOrder = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[0]);
                string custOrder = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[1]);
                string Amount = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                if(manufOrder.Count() < 1)
                {
                    pushData.Cells[0].Value = custOrder;
                    pushData.Cells[3].Value = "Sale";

                }
                else
                {
                    pushData.Cells[0].Value = manufOrder;
                    pushData.Cells[3].Value = "Purchase";
                }

                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;
                

                viewCarGrid.Rows.Add(pushData);

            }

            con.Close();
        }



        void checkSale()
        {
            con.Open();
            SqlCommand accountAllCmd = new SqlCommand("select * from Account where IS_PAID = 'FALSE'", con);
            SqlDataAdapter accountAllAdapter = new SqlDataAdapter(accountAllCmd);
            DataSet accountAllData = new DataSet();
            accountAllAdapter.Fill(accountAllData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (accountAllData.Tables[0].Rows.Count); i++)
            {
                string custOrder = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[1]);
                string Amount = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = custOrder;
                pushData.Cells[3].Value = "Sale";

                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;


                viewCarGrid.Rows.Add(pushData);

            }

            con.Close();
        }

        void checkPurch()
        {
            con.Open();
            SqlCommand accountAllCmd = new SqlCommand("select * from Account where IS_PAID = 'TRUE'", con);
            SqlDataAdapter accountAllAdapter = new SqlDataAdapter(accountAllCmd);
            DataSet accountAllData = new DataSet();
            accountAllAdapter.Fill(accountAllData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (accountAllData.Tables[0].Rows.Count); i++)
            {
                string manfOrder = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[0]);
                string Amount = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[2]);
                string isPayment = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[3]);
                string payDate = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[4]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);

                pushData.Cells[0].Value = manfOrder;
                pushData.Cells[3].Value = "Purchase";

                pushData.Cells[1].Value = Amount;
                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;


                viewCarGrid.Rows.Add(pushData);

            }

            con.Close();
        }

        private void cashCollector()
        {
            con.Open();
            SqlCommand recAmountCmd = new SqlCommand("select sum(Account.Amount) from Account where Account.IS_PAID = 'FALSE' ", con);
            SqlDataAdapter recAmountAdapter = new SqlDataAdapter(recAmountCmd);
            DataSet recAmountData = new DataSet();
            recAmountAdapter.Fill(recAmountData);
            string amountRecieved = Convert.ToString(recAmountData.Tables[0].Rows[0].ItemArray[0]);

            SqlCommand spentAmountCmd = new SqlCommand("select sum(Account.Amount) from Account where Account.IS_PAID = 'TRUE' ", con);
            SqlDataAdapter spentAmountAdapter = new SqlDataAdapter(spentAmountCmd);
            DataSet spentAmountData = new DataSet();
            spentAmountAdapter.Fill(spentAmountData);
            string amountSpent = Convert.ToString(spentAmountData.Tables[0].Rows[0].ItemArray[0]);

            SqlCommand netAmountCmd = new SqlCommand("SELECT (SELECT SUM(ACCOUNT.AMOUNT) FROM ACCOUNT WHERE ACCOUNT.IS_PAID = 'FALSE') - (SELECT SUM(ACCOUNT.AMOUNT) FROM ACCOUNT WHERE ACCOUNT.IS_PAID = 'TRUE')", con);
            SqlDataAdapter netAmountAdapter = new SqlDataAdapter(netAmountCmd);
            DataSet netAmountData = new DataSet();
            netAmountAdapter.Fill(netAmountData);
            string amountNet = Convert.ToString(netAmountData.Tables[0].Rows[0].ItemArray[0]);

            con.Close();

            amountRecLbl.Text = amountRecieved;
            amountSpentLbl.Text = amountSpent;
            netAmountLbl.Text = amountNet;
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            checkSale();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            checkPurch();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            gridFill();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new Manager_Menu(userID).Show();
            this.Hide();

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

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Transparent;

        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);

        }

        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isPurchase;
            if (isPurch == "Sale")
            {
                isPurchase = false;
            }
            else
                isPurchase = true;



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

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;

        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = viewCarGrid.Rows[rowIndex];

            OrderID = Convert.ToString(row.Cells[0].Value);
            isPurch = Convert.ToString(row.Cells[3].Value);

        }
    }
}
