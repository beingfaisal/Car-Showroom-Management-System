namespace CSM_Project
{
    partial class CarSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(12, 18);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 35);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(59, 18);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 35);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(75, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer\'s Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(75, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer\'s CNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F);
            this.label4.Location = new System.Drawing.Point(75, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer\'s Contact";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(78, 95);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 25);
            this.nameBox.TabIndex = 14;
            // 
            // cnicBox
            // 
            this.cnicBox.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.cnicBox.Location = new System.Drawing.Point(78, 152);
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(154, 25);
            this.cnicBox.TabIndex = 15;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.addressBox.Location = new System.Drawing.Point(78, 211);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(154, 25);
            this.addressBox.TabIndex = 16;
            // 
            // contactBox
            // 
            this.contactBox.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.contactBox.Location = new System.Drawing.Point(78, 271);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(154, 25);
            this.contactBox.TabIndex = 17;
            // 
            // sellBtn
            // 
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellBtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.Location = new System.Drawing.Point(105, 325);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(100, 43);
            this.sellBtn.TabIndex = 20;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellBtn_MouseClick);
            // 
            // CarSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.cnicBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "CarSell";
            this.Text = "Sell Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Button sellBtn;
    }
}