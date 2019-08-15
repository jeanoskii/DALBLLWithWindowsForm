namespace WindowsFormsApplication1
{
    partial class Phones
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtYR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(11, 11);
            this.txtID.MaxLength = 7;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 18);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Phone I.D.";
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(146, 11);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(118, 42);
            this.btnA.TabIndex = 14;
            this.btnA.Text = "Add";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnU.FlatAppearance.BorderSize = 0;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.White;
            this.btnU.Location = new System.Drawing.Point(270, 11);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(118, 42);
            this.btnU.TabIndex = 15;
            this.btnU.Text = "Update";
            this.btnU.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(394, 11);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(118, 42);
            this.btnD.TabIndex = 16;
            this.btnD.Text = "Delete";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(146, 59);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(366, 114);
            this.dgv.TabIndex = 17;
            // 
            // txtPN
            // 
            this.txtPN.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPN.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.ForeColor = System.Drawing.Color.White;
            this.txtPN.Location = new System.Drawing.Point(11, 35);
            this.txtPN.MaxLength = 10;
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(130, 18);
            this.txtPN.TabIndex = 18;
            this.txtPN.Text = "Phone Name";
            this.txtPN.Click += new System.EventHandler(this.txtPN_Click);
            this.txtPN.Leave += new System.EventHandler(this.txtPN_Leave);
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtM.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.Color.White;
            this.txtM.Location = new System.Drawing.Point(11, 59);
            this.txtM.MaxLength = 20;
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(130, 18);
            this.txtM.TabIndex = 19;
            this.txtM.Text = "Manufacturer";
            this.txtM.Click += new System.EventHandler(this.txtM_Click);
            this.txtM.Leave += new System.EventHandler(this.txtM_Leave);
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.ForeColor = System.Drawing.Color.White;
            this.txtP.Location = new System.Drawing.Point(11, 83);
            this.txtP.MaxLength = 20;
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(130, 18);
            this.txtP.TabIndex = 20;
            this.txtP.Text = "Price";
            this.txtP.Click += new System.EventHandler(this.txtP_Click);
            this.txtP.Leave += new System.EventHandler(this.txtP_Leave);
            // 
            // txtSC
            // 
            this.txtSC.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSC.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSC.ForeColor = System.Drawing.Color.White;
            this.txtSC.Location = new System.Drawing.Point(11, 107);
            this.txtSC.MaxLength = 5;
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(130, 18);
            this.txtSC.TabIndex = 21;
            this.txtSC.Text = "Storage Capacity";
            this.txtSC.Click += new System.EventHandler(this.txtSC_Click);
            this.txtSC.Leave += new System.EventHandler(this.txtSC_Leave);
            // 
            // txtOS
            // 
            this.txtOS.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOS.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.ForeColor = System.Drawing.Color.White;
            this.txtOS.Location = new System.Drawing.Point(11, 131);
            this.txtOS.MaxLength = 20;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(130, 18);
            this.txtOS.TabIndex = 22;
            this.txtOS.Text = "Operating System";
            this.txtOS.Click += new System.EventHandler(this.txtOS_Click);
            this.txtOS.Leave += new System.EventHandler(this.txtOS_Leave);
            // 
            // txtYR
            // 
            this.txtYR.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYR.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYR.ForeColor = System.Drawing.Color.White;
            this.txtYR.Location = new System.Drawing.Point(11, 155);
            this.txtYR.MaxLength = 4;
            this.txtYR.Name = "txtYR";
            this.txtYR.Size = new System.Drawing.Size(130, 18);
            this.txtYR.TabIndex = 23;
            this.txtYR.Text = "Year Released";
            this.txtYR.Click += new System.EventHandler(this.txtYR_Click);
            this.txtYR.Leave += new System.EventHandler(this.txtYR_Leave);
            // 
            // Phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 183);
            this.Controls.Add(this.txtYR);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtSC);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtID);
            this.Name = "Phones";
            this.Text = "Mobile Phones";
            this.Load += new System.EventHandler(this.Phones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtYR;
    }
}

