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
            this.label1 = new System.Windows.Forms.Label();
            this.viewAvailBtn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.viewSoldBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.viewCarGrid = new System.Windows.Forms.DataGridView();
            this.Car_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carSellBtn = new System.Windows.Forms.Button();
            this.buyCarBtn = new System.Windows.Forms.Button();
            this.outLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Menu";
            // 
            // viewAvailBtn
            // 
            this.viewAvailBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAvailBtn.Location = new System.Drawing.Point(21, 111);
            this.viewAvailBtn.Name = "viewAvailBtn";
            this.viewAvailBtn.Size = new System.Drawing.Size(85, 45);
            this.viewAvailBtn.TabIndex = 2;
            this.viewAvailBtn.Text = "Availabe Cars";
            this.viewAvailBtn.UseVisualStyleBackColor = true;
            this.viewAvailBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAvailBtn_MouseClick);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.Location = new System.Drawing.Point(21, 238);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(85, 45);
            this.viewAllBtn.TabIndex = 3;
            this.viewAllBtn.Text = "All Cars";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            this.viewAllBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAllBtn_MouseClick);
            // 
            // viewSoldBtn
            // 
            this.viewSoldBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSoldBtn.Location = new System.Drawing.Point(21, 176);
            this.viewSoldBtn.Name = "viewSoldBtn";
            this.viewSoldBtn.Size = new System.Drawing.Size(85, 45);
            this.viewSoldBtn.TabIndex = 4;
            this.viewSoldBtn.Text = "Sold Cars";
            this.viewSoldBtn.UseVisualStyleBackColor = true;
            this.viewSoldBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewSoldBtn_MouseClick);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(21, 35);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 30);
            this.backBtn.TabIndex = 5;
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
            this.exitBtn.Location = new System.Drawing.Point(698, 35);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 40);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // viewCarGrid
            // 
            this.viewCarGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Car_Name,
            this.Car_Model,
            this.Car_Comp,
            this.Car_Price,
            this.Car_Status,
            this.ID,
            this.Column1});
            this.viewCarGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCarGrid.Location = new System.Drawing.Point(234, 111);
            this.viewCarGrid.Name = "viewCarGrid";
            this.viewCarGrid.Size = new System.Drawing.Size(543, 300);
            this.viewCarGrid.TabIndex = 8;
            this.viewCarGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCarGrid_CellEnter);
            // 
            // Car_Name
            // 
            this.Car_Name.HeaderText = "Name";
            this.Car_Name.Name = "Car_Name";
            // 
            // Car_Model
            // 
            this.Car_Model.HeaderText = "Model";
            this.Car_Model.Name = "Car_Model";
            // 
            // Car_Comp
            // 
            this.Car_Comp.HeaderText = "Company";
            this.Car_Comp.Name = "Car_Comp";
            // 
            // Car_Price
            // 
            this.Car_Price.HeaderText = "Price";
            this.Car_Price.Name = "Car_Price";
            // 
            // Car_Status
            // 
            this.Car_Status.HeaderText = "Status";
            this.Car_Status.Name = "Car_Status";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // carSellBtn
            // 
            this.carSellBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carSellBtn.Location = new System.Drawing.Point(21, 301);
            this.carSellBtn.Name = "carSellBtn";
            this.carSellBtn.Size = new System.Drawing.Size(85, 45);
            this.carSellBtn.TabIndex = 9;
            this.carSellBtn.Text = "Sell Car";
            this.carSellBtn.UseVisualStyleBackColor = true;
            this.carSellBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.carSellBtn_MouseClick);
            // 
            // buyCarBtn
            // 
            this.buyCarBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyCarBtn.Location = new System.Drawing.Point(21, 366);
            this.buyCarBtn.Name = "buyCarBtn";
            this.buyCarBtn.Size = new System.Drawing.Size(85, 45);
            this.buyCarBtn.TabIndex = 13;
            this.buyCarBtn.Text = "Buy Car";
            this.buyCarBtn.UseVisualStyleBackColor = true;
            this.buyCarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buyCarBtn_MouseClick);
            // 
            // outLbl
            // 
            this.outLbl.AutoSize = true;
            this.outLbl.BackColor = System.Drawing.Color.Red;
            this.outLbl.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outLbl.Location = new System.Drawing.Point(41, 414);
            this.outLbl.Name = "outLbl";
            this.outLbl.Size = new System.Drawing.Size(0, 14);
            this.outLbl.TabIndex = 14;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.BackColor = System.Drawing.Color.Red;
            this.outputLbl.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLbl.Location = new System.Drawing.Point(31, 349);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 14);
            this.outputLbl.TabIndex = 12;
            // 
            // SMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outLbl);
            this.Controls.Add(this.buyCarBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.carSellBtn);
            this.Controls.Add(this.viewCarGrid);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewSoldBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.viewAvailBtn);
            this.Controls.Add(this.label1);
            this.Name = "SMMenu";
            this.Text = "Salesman Menu";
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAvailBtn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button viewSoldBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView viewCarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Status;
        private System.Windows.Forms.Button carSellBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buyCarBtn;
        private System.Windows.Forms.Label outLbl;
        private System.Windows.Forms.Label outputLbl;
    }
}