using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public partial class CustomSuccessBox : Form
    {
        public CustomSuccessBox()
        {
            InitializeComponent();
        }
        static CustomSuccessBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text)
        {
            MsgBox = new CustomSuccessBox();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = "OK";
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }
    }
}
