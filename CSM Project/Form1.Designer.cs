namespace CSM_Project
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logBtn = new System.Windows.Forms.Button();
            this.namePnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pinLbl = new System.Windows.Forms.Label();
            this.lockImage = new System.Windows.Forms.PictureBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.circularPictureBox1 = new CSM_Project.CircularPictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.namePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.pinPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(914, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.logBtn);
            this.bunifuGradientPanel1.Controls.Add(this.namePnl);
            this.bunifuGradientPanel1.Controls.Add(this.pinPnl);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(232, 147);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(508, 389);
            this.bunifuGradientPanel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "SIGN IN";
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.White;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.Black;
            this.logBtn.Location = new System.Drawing.Point(204, 300);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(100, 43);
            this.logBtn.TabIndex = 38;
            this.logBtn.Text = "LOG IN";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            this.logBtn.MouseEnter += new System.EventHandler(this.logBtn_MouseEnter);
            this.logBtn.MouseLeave += new System.EventHandler(this.logBtn_MouseLeave);
            // 
            // namePnl
            // 
            this.namePnl.BackColor = System.Drawing.Color.White;
            this.namePnl.Controls.Add(this.label2);
            this.namePnl.Controls.Add(this.userLbl);
            this.namePnl.Controls.Add(this.userImage);
            this.namePnl.Controls.Add(this.nameBox);
            this.namePnl.Location = new System.Drawing.Point(104, 140);
            this.namePnl.Name = "namePnl";
            this.namePnl.Size = new System.Drawing.Size(301, 51);
            this.namePnl.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(190, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Wrong ID/PIN";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.Transparent;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.Red;
            this.userLbl.Location = new System.Drawing.Point(272, 9);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(19, 29);
            this.userLbl.TabIndex = 41;
            this.userLbl.Text = "!";
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(0, 0);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(52, 51);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 24;
            this.userImage.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(58, 12);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(229, 26);
            this.nameBox.TabIndex = 25;
            this.nameBox.Text = "Username";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.White;
            this.pinPnl.Controls.Add(this.label3);
            this.pinPnl.Controls.Add(this.pinLbl);
            this.pinPnl.Controls.Add(this.lockImage);
            this.pinPnl.Controls.Add(this.pinBox);
            this.pinPnl.Location = new System.Drawing.Point(104, 207);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Size = new System.Drawing.Size(301, 51);
            this.pinPnl.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(190, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Wrong ID/PIN";
            // 
            // pinLbl
            // 
            this.pinLbl.AutoSize = true;
            this.pinLbl.BackColor = System.Drawing.Color.Transparent;
            this.pinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLbl.ForeColor = System.Drawing.Color.Red;
            this.pinLbl.Location = new System.Drawing.Point(272, 10);
            this.pinLbl.Name = "pinLbl";
            this.pinLbl.Size = new System.Drawing.Size(19, 29);
            this.pinLbl.TabIndex = 42;
            this.pinLbl.Text = "!";
            // 
            // lockImage
            // 
            this.lockImage.BackColor = System.Drawing.Color.White;
            this.lockImage.Image = ((System.Drawing.Image)(resources.GetObject("lockImage.Image")));
            this.lockImage.Location = new System.Drawing.Point(0, 0);
            this.lockImage.Name = "lockImage";
            this.lockImage.Size = new System.Drawing.Size(52, 51);
            this.lockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockImage.TabIndex = 24;
            this.lockImage.TabStop = false;
            // 
            // pinBox
            // 
            this.pinBox.BackColor = System.Drawing.Color.White;
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.ForeColor = System.Drawing.Color.Black;
            this.pinBox.Location = new System.Drawing.Point(58, 13);
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(229, 26);
            this.pinBox.TabIndex = 18;
            this.pinBox.Text = "Password";
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.BackgroundImage")));
            this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circularPictureBox1.Location = new System.Drawing.Point(411, 55);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox1.TabIndex = 40;
            this.circularPictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 653);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.namePnl.ResumeLayout(false);
            this.namePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pinLbl;
        private System.Windows.Forms.PictureBox lockImage;
        private System.Windows.Forms.TextBox pinBox;
        private CircularPictureBox circularPictureBox1;
    }
}

