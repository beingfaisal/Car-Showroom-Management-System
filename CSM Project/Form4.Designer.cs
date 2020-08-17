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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSell));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.nameBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.cnicBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.addressBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.contactBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameExpLbl = new System.Windows.Forms.Label();
            this.cnicExpLbl = new System.Windows.Forms.Label();
            this.addressExpLbl = new System.Windows.Forms.Label();
            this.contactExpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnicBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNIC Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact Number";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Gray;
            this.nameBox.Location = new System.Drawing.Point(40, 154);
            this.nameBox.MaxLength = 25;
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 28);
            this.nameBox.TabIndex = 14;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // cnicBox
            // 
            this.cnicBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cnicBox.ForeColor = System.Drawing.Color.Gray;
            this.cnicBox.Location = new System.Drawing.Point(40, 244);
            this.cnicBox.MaxLength = 13;
            this.cnicBox.Multiline = true;
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(300, 28);
            this.cnicBox.TabIndex = 15;
            this.cnicBox.Enter += new System.EventHandler(this.cnicBox_Enter);
            this.cnicBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnicBox_KeyPress);
            this.cnicBox.Leave += new System.EventHandler(this.cnicBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.addressBox.ForeColor = System.Drawing.Color.Gray;
            this.addressBox.Location = new System.Drawing.Point(421, 154);
            this.addressBox.MaxLength = 50;
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(300, 28);
            this.addressBox.TabIndex = 16;
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox_KeyPress);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // contactBox
            // 
            this.contactBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.contactBox.ForeColor = System.Drawing.Color.Gray;
            this.contactBox.Location = new System.Drawing.Point(421, 244);
            this.contactBox.MaxLength = 11;
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(300, 28);
            this.contactBox.TabIndex = 17;
            this.contactBox.Enter += new System.EventHandler(this.contactBox_Enter);
            this.contactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactBox_KeyPress);
            this.contactBox.Leave += new System.EventHandler(this.contactBox_Leave);
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.White;
            this.sellBtn.Location = new System.Drawing.Point(302, 328);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(100, 43);
            this.sellBtn.TabIndex = 20;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellBtn_MouseClick);
            this.sellBtn.MouseEnter += new System.EventHandler(this.sellBtn_MouseEnter);
            this.sellBtn.MouseLeave += new System.EventHandler(this.sellBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(718, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(224, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(297, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Customer\'s Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 79);
            this.panel1.TabIndex = 41;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 79);
            this.backBtn.TabIndex = 41;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // nameBoxErrorIcon
            // 
            this.nameBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameBoxErrorIcon.BackgroundImage")));
            this.nameBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nameBoxErrorIcon.Location = new System.Drawing.Point(317, 156);
            this.nameBoxErrorIcon.Name = "nameBoxErrorIcon";
            this.nameBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.nameBoxErrorIcon.TabIndex = 42;
            this.nameBoxErrorIcon.TabStop = false;
            // 
            // cnicBoxErrorIcon
            // 
            this.cnicBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.cnicBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnicBoxErrorIcon.BackgroundImage")));
            this.cnicBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cnicBoxErrorIcon.Location = new System.Drawing.Point(317, 246);
            this.cnicBoxErrorIcon.Name = "cnicBoxErrorIcon";
            this.cnicBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.cnicBoxErrorIcon.TabIndex = 43;
            this.cnicBoxErrorIcon.TabStop = false;
            // 
            // addressBoxErrorIcon
            // 
            this.addressBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.addressBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressBoxErrorIcon.BackgroundImage")));
            this.addressBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addressBoxErrorIcon.Location = new System.Drawing.Point(698, 156);
            this.addressBoxErrorIcon.Name = "addressBoxErrorIcon";
            this.addressBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.addressBoxErrorIcon.TabIndex = 44;
            this.addressBoxErrorIcon.TabStop = false;
            // 
            // contactBoxErrorIcon
            // 
            this.contactBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.contactBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactBoxErrorIcon.BackgroundImage")));
            this.contactBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contactBoxErrorIcon.Location = new System.Drawing.Point(698, 246);
            this.contactBoxErrorIcon.Name = "contactBoxErrorIcon";
            this.contactBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.contactBoxErrorIcon.TabIndex = 45;
            this.contactBoxErrorIcon.TabStop = false;
            // 
            // nameExpLbl
            // 
            this.nameExpLbl.AutoSize = true;
            this.nameExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.nameExpLbl.Location = new System.Drawing.Point(151, 182);
            this.nameExpLbl.Name = "nameExpLbl";
            this.nameExpLbl.Size = new System.Drawing.Size(189, 14);
            this.nameExpLbl.TabIndex = 46;
            this.nameExpLbl.Text = "e.g. Ali Ahmad (Max 25 Char)";
            // 
            // cnicExpLbl
            // 
            this.cnicExpLbl.AutoSize = true;
            this.cnicExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.cnicExpLbl.Location = new System.Drawing.Point(122, 272);
            this.cnicExpLbl.Name = "cnicExpLbl";
            this.cnicExpLbl.Size = new System.Drawing.Size(218, 14);
            this.cnicExpLbl.TabIndex = 47;
            this.cnicExpLbl.Text = "e.g. 34302-1234567-8 (13 Digits)";
            // 
            // addressExpLbl
            // 
            this.addressExpLbl.AutoSize = true;
            this.addressExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.addressExpLbl.Location = new System.Drawing.Point(476, 182);
            this.addressExpLbl.Name = "addressExpLbl";
            this.addressExpLbl.Size = new System.Drawing.Size(245, 14);
            this.addressExpLbl.TabIndex = 48;
            this.addressExpLbl.Text = "e.g. Street #11 Lahore (Max 50 Char)";
            // 
            // contactExpLbl
            // 
            this.contactExpLbl.AutoSize = true;
            this.contactExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.contactExpLbl.Location = new System.Drawing.Point(524, 272);
            this.contactExpLbl.Name = "contactExpLbl";
            this.contactExpLbl.Size = new System.Drawing.Size(197, 14);
            this.contactExpLbl.TabIndex = 49;
            this.contactExpLbl.Text = "e.g. 0321-1234567 (11 Digits)";
            // 
            // CarSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 408);
            this.Controls.Add(this.contactExpLbl);
            this.Controls.Add(this.addressExpLbl);
            this.Controls.Add(this.cnicExpLbl);
            this.Controls.Add(this.nameExpLbl);
            this.Controls.Add(this.contactBoxErrorIcon);
            this.Controls.Add(this.addressBoxErrorIcon);
            this.Controls.Add(this.cnicBoxErrorIcon);
            this.Controls.Add(this.nameBoxErrorIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Car";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnicBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox nameBoxErrorIcon;
        private System.Windows.Forms.PictureBox cnicBoxErrorIcon;
        private System.Windows.Forms.PictureBox addressBoxErrorIcon;
        private System.Windows.Forms.PictureBox contactBoxErrorIcon;
        private System.Windows.Forms.Label nameExpLbl;
        private System.Windows.Forms.Label cnicExpLbl;
        private System.Windows.Forms.Label addressExpLbl;
        private System.Windows.Forms.Label contactExpLbl;
        private System.Windows.Forms.Button backBtn;
    }
}