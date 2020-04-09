namespace CSM_Project
{
    partial class SaleManCtrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.fireBtn = new System.Windows.Forms.Button();
            this.viewHireBtn = new System.Windows.Forms.Button();
            this.viewFireBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Employee Management";
            // 
            // empGrid
            // 
            this.empGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EName,
            this.Pin,
            this.Contact,
            this.Address,
            this.Email,
            this.HireDate,
            this.FireDate,
            this.Status,
            this.Sales});
            this.empGrid.Location = new System.Drawing.Point(495, 120);
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(693, 360);
            this.empGrid.TabIndex = 1;
            this.empGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empGrid_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // EName
            // 
            this.EName.HeaderText = "Name";
            this.EName.Name = "EName";
            this.EName.Width = 60;
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Password";
            this.Pin.Name = "Pin";
            this.Pin.Width = 78;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.Width = 69;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 70;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // HireDate
            // 
            this.HireDate.HeaderText = "Hire Date";
            this.HireDate.Name = "HireDate";
            this.HireDate.Width = 77;
            // 
            // FireDate
            // 
            this.FireDate.HeaderText = "Fire Date";
            this.FireDate.Name = "FireDate";
            this.FireDate.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // Sales
            // 
            this.Sales.HeaderText = "Sales";
            this.Sales.Name = "Sales";
            this.Sales.Width = 58;
            // 
            // hireBtn
            // 
            this.hireBtn.Location = new System.Drawing.Point(26, 437);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(61, 34);
            this.hireBtn.TabIndex = 2;
            this.hireBtn.Text = "Hire";
            this.hireBtn.UseVisualStyleBackColor = true;
            this.hireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hireBtn_MouseClick_1);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(156, 146);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 3;
            // 
            // pinBox
            // 
            this.pinBox.Location = new System.Drawing.Point(156, 197);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(199, 20);
            this.pinBox.TabIndex = 4;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(156, 246);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(199, 20);
            this.contactBox.TabIndex = 5;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(156, 295);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(199, 20);
            this.addressBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(156, 345);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(199, 20);
            this.emailBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(93, 437);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(67, 34);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateBtn_MouseClick);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(234, 437);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(62, 34);
            this.viewBtn.TabIndex = 14;
            this.viewBtn.Text = "View All";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewBtn_MouseClick);
            // 
            // fireBtn
            // 
            this.fireBtn.Location = new System.Drawing.Point(166, 437);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(62, 34);
            this.fireBtn.TabIndex = 15;
            this.fireBtn.Text = "Fire";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fireBtn_MouseClick);
            // 
            // viewHireBtn
            // 
            this.viewHireBtn.Location = new System.Drawing.Point(98, 478);
            this.viewHireBtn.Name = "viewHireBtn";
            this.viewHireBtn.Size = new System.Drawing.Size(62, 34);
            this.viewHireBtn.TabIndex = 16;
            this.viewHireBtn.Text = "View Hired";
            this.viewHireBtn.UseVisualStyleBackColor = true;
            this.viewHireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewHireBtn_MouseClick);
            // 
            // viewFireBtn
            // 
            this.viewFireBtn.Location = new System.Drawing.Point(166, 477);
            this.viewFireBtn.Name = "viewFireBtn";
            this.viewFireBtn.Size = new System.Drawing.Size(62, 34);
            this.viewFireBtn.TabIndex = 17;
            this.viewFireBtn.Text = "View Fired";
            this.viewFireBtn.UseVisualStyleBackColor = true;
            this.viewFireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewFireBtn_MouseClick);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(66, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 35);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(19, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 35);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // SaleManCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 524);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewFireBtn);
            this.Controls.Add(this.viewHireBtn);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.hireBtn);
            this.Controls.Add(this.empGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleManCtrl";
            this.Text = "Employee Managment";
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.Button hireBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.Button viewHireBtn;
        private System.Windows.Forms.Button viewFireBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}