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

        public Form10()
        {
            InitializeComponent();
            gridFill();
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
                string paidAmount = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[2]);
                string recAmount = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[3]);
                string totalPaid = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[4]);
                string totalRec = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[5]);
                string isPayment = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[6]);
                string payDate = Convert.ToString(accountAllData.Tables[0].Rows[i].ItemArray[7]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                if(manufOrder.Count() < 1)
                {
                    pushData.Cells[0].Value = custOrder;
                    pushData.Cells[1].Value = recAmount;
                    pushData.Cells[3].Value = "SALE";

                }
                else
                {
                    pushData.Cells[0].Value = manufOrder;
                    pushData.Cells[1].Value = paidAmount;
                    pushData.Cells[3].Value = "Purchase";
                }

                pushData.Cells[2].Value = Convert.ToDateTime(payDate).Date;
                

                viewCarGrid.Rows.Add(pushData);

            }

            con.Close();
        }



    }
}
