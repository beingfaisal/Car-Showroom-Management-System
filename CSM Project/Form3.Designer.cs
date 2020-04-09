namespace CSM_Project
{
    partial class Manager_Menu
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SmmBtn = new System.Windows.Forms.Button();
            this.carCtrlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to The Manager\'s Menu";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(23, 26);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 35);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(70, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 35);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select to Manage";
            // 
            // SmmBtn
            // 
            this.SmmBtn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmmBtn.Location = new System.Drawing.Point(154, 202);
            this.SmmBtn.Name = "SmmBtn";
            this.SmmBtn.Size = new System.Drawing.Size(102, 45);
            this.SmmBtn.TabIndex = 10;
            this.SmmBtn.Text = "Salesman";
            this.SmmBtn.UseVisualStyleBackColor = true;
            this.SmmBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SmmBtn_MouseClick);
            // 
            // carCtrlBtn
            // 
            this.carCtrlBtn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCtrlBtn.Location = new System.Drawing.Point(464, 202);
            this.carCtrlBtn.Name = "carCtrlBtn";
            this.carCtrlBtn.Size = new System.Drawing.Size(99, 45);
            this.carCtrlBtn.TabIndex = 11;
            this.carCtrlBtn.Text = "Cars";
            this.carCtrlBtn.UseVisualStyleBackColor = true;
            this.carCtrlBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.carCtrlBtn_MouseClick);
            // 
            // Manager_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carCtrlBtn);
            this.Controls.Add(this.SmmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Name = "Manager_Menu";
            this.Text = "Manager Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SmmBtn;
        private System.Windows.Forms.Button carCtrlBtn;
    }
}