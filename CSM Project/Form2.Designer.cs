namespace CSM_Project
{
    partial class SMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyCarPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sellCarPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.viewAvailPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.viewSoldPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.viewCarGrid = new System.Windows.Forms.DataGridView();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buyCarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sellCarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.viewAvailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.viewSoldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buyCarPanel
            // 
            this.buyCarPanel.BackColor = System.Drawing.Color.Transparent;
            this.buyCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyCarPanel.Controls.Add(this.label5);
            this.buyCarPanel.Controls.Add(this.pictureBox3);
            this.buyCarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyCarPanel.Location = new System.Drawing.Point(0, 201);
            this.buyCarPanel.Name = "buyCarPanel";
            this.buyCarPanel.Size = new System.Drawing.Size(197, 90);
            this.buyCarPanel.TabIndex = 33;
            this.buyCarPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buyCarPanel_MouseClick);
            this.buyCarPanel.MouseEnter += new System.EventHandler(this.buyCarPanel_MouseEnter);
            this.buyCarPanel.MouseLeave += new System.EventHandler(this.buyCarPanel_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Buy Car";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buyCarPanel_MouseClick);
            this.label5.MouseEnter += new System.EventHandler(this.buyCarPanel_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.buyCarPanel_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(12, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 69);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // sellCarPanel
            // 
            this.sellCarPanel.BackColor = System.Drawing.Color.Transparent;
            this.sellCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellCarPanel.Controls.Add(this.pictureBox6);
            this.sellCarPanel.Controls.Add(this.label9);
            this.sellCarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellCarPanel.Location = new System.Drawing.Point(0, 111);
            this.sellCarPanel.Name = "sellCarPanel";
            this.sellCarPanel.Size = new System.Drawing.Size(197, 90);
            this.sellCarPanel.TabIndex = 32;
            this.sellCarPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellCarPanel_MouseClick);
            this.sellCarPanel.MouseEnter += new System.EventHandler(this.sellCarPanel_MouseEnter);
            this.sellCarPanel.MouseLeave += new System.EventHandler(this.sellCarPanel_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(12, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(69, 70);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sell Car";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellCarPanel_MouseClick);
            this.label9.MouseEnter += new System.EventHandler(this.sellCarPanel_MouseEnter);
            this.label9.MouseLeave += new System.EventHandler(this.sellCarPanel_MouseLeave);
            // 
            // viewAvailPanel
            // 
            this.viewAvailPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewAvailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAvailPanel.Controls.Add(this.label8);
            this.viewAvailPanel.Controls.Add(this.pictureBox5);
            this.viewAvailPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAvailPanel.Location = new System.Drawing.Point(0, 380);
            this.viewAvailPanel.Name = "viewAvailPanel";
            this.viewAvailPanel.Size = new System.Drawing.Size(197, 90);
            this.viewAvailPanel.TabIndex = 34;
            this.viewAvailPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAvailPanel_MouseClick);
            this.viewAvailPanel.MouseEnter += new System.EventHandler(this.viewAvailPanel_MouseEnter);
            this.viewAvailPanel.MouseLeave += new System.EventHandler(this.viewAvailPanel_MouseLeave);
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(78, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 55);
            this.label8.TabIndex = 30;
            this.label8.Text = "Available Cars";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAvailPanel_MouseClick);
            this.label8.MouseEnter += new System.EventHandler(this.viewAvailPanel_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.viewAvailPanel_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(11, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 70);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // viewSoldPanel
            // 
            this.viewSoldPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewSoldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewSoldPanel.Controls.Add(this.label7);
            this.viewSoldPanel.Controls.Add(this.pictureBox4);
            this.viewSoldPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSoldPanel.Location = new System.Drawing.Point(1, 290);
            this.viewSoldPanel.Name = "viewSoldPanel";
            this.viewSoldPanel.Size = new System.Drawing.Size(197, 90);
            this.viewSoldPanel.TabIndex = 35;
            this.viewSoldPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewSoldPanel_MouseClick);
            this.viewSoldPanel.MouseEnter += new System.EventHandler(this.viewSoldPanel_MouseEnter);
            this.viewSoldPanel.MouseLeave += new System.EventHandler(this.viewSoldPanel_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sold Cars";
            this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewSoldPanel_MouseClick);
            this.label7.MouseEnter += new System.EventHandler(this.viewSoldPanel_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.viewSoldPanel_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(11, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 69);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // viewCarGrid
            // 
            this.viewCarGrid.AllowUserToAddRows = false;
            this.viewCarGrid.AllowUserToDeleteRows = false;
            this.viewCarGrid.AllowUserToResizeColumns = false;
            this.viewCarGrid.AllowUserToResizeRows = false;
            this.viewCarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewCarGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewCarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewCarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewCarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameC,
            this.Model,
            this.company,
            this.Price,
            this.Status,
            this.CAR_ID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.viewCarGrid.EnableHeadersVisualStyles = false;
            this.viewCarGrid.GridColor = System.Drawing.Color.White;
            this.viewCarGrid.Location = new System.Drawing.Point(198, 159);
            this.viewCarGrid.Name = "viewCarGrid";
            this.viewCarGrid.ReadOnly = true;
            this.viewCarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewCarGrid.RowHeadersVisible = false;
            this.viewCarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCarGrid.Size = new System.Drawing.Size(812, 366);
            this.viewCarGrid.TabIndex = 36;
            this.viewCarGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCarGrid_CellEnter);
            // 
            // NameC
            // 
            this.NameC.HeaderText = "Name";
            this.NameC.Name = "NameC";
            this.NameC.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // CAR_ID
            // 
            this.CAR_ID.HeaderText = "ID";
            this.CAR_ID.Name = "CAR_ID";
            this.CAR_ID.ReadOnly = true;
            this.CAR_ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.viewSoldPanel);
            this.panel1.Controls.Add(this.buyCarPanel);
            this.panel1.Controls.Add(this.viewAvailPanel);
            this.panel1.Controls.Add(this.sellCarPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 525);
            this.panel1.TabIndex = 37;
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
            this.backBtn.Size = new System.Drawing.Size(198, 109);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 83);
            this.panel2.TabIndex = 38;
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
            this.exitBtn.Location = new System.Drawing.Point(766, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(339, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(165, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(288, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Automobile Showroom \r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(209, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 5);
            this.panel3.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(266, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 37);
            this.label4.TabIndex = 39;
            this.label4.Text = "Car Records";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // SMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewCarGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SMMenu";
            this.Text = "Salesman Menu";
            this.buyCarPanel.ResumeLayout(false);
            this.buyCarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sellCarPanel.ResumeLayout(false);
            this.sellCarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.viewAvailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.viewSoldPanel.ResumeLayout(false);
            this.viewSoldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel buyCarPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel sellCarPanel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel viewAvailPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel viewSoldPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView viewCarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}