namespace AutoTollTaxationSystem
{
    partial class form_BalDeduct
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.tb_RFID = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_PrvsAmount = new System.Windows.Forms.Label();
            this.lbl_CurrAmount = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(58, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(250, 26);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Auto Toll Taxation System";
            // 
            // tb_RFID
            // 
            this.tb_RFID.Location = new System.Drawing.Point(37, 66);
            this.tb_RFID.Name = "tb_RFID";
            this.tb_RFID.Size = new System.Drawing.Size(278, 20);
            this.tb_RFID.TabIndex = 1;
            this.tb_RFID.TextChanged += new System.EventHandler(this.tb_RFID_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Nina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(31, 135);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(107, 18);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Previous Balance";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Nina", 11.25F);
            this.lbl2.Location = new System.Drawing.Point(34, 190);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(102, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Current Balance";
            // 
            // lbl_PrvsAmount
            // 
            this.lbl_PrvsAmount.AutoSize = true;
            this.lbl_PrvsAmount.Location = new System.Drawing.Point(264, 140);
            this.lbl_PrvsAmount.Name = "lbl_PrvsAmount";
            this.lbl_PrvsAmount.Size = new System.Drawing.Size(51, 13);
            this.lbl_PrvsAmount.TabIndex = 4;
            this.lbl_PrvsAmount.Text = "*Amount*";
            // 
            // lbl_CurrAmount
            // 
            this.lbl_CurrAmount.AutoSize = true;
            this.lbl_CurrAmount.Location = new System.Drawing.Point(264, 195);
            this.lbl_CurrAmount.Name = "lbl_CurrAmount";
            this.lbl_CurrAmount.Size = new System.Drawing.Size(51, 13);
            this.lbl_CurrAmount.TabIndex = 5;
            this.lbl_CurrAmount.Text = "*Amount*";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(240, 241);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // form_BalDeduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_CurrAmount);
            this.Controls.Add(this.lbl_PrvsAmount);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tb_RFID);
            this.Controls.Add(this.lbl_header);
            this.Name = "form_BalDeduct";
            this.Text = "Auto Toll Taxation System ";
            this.Load += new System.EventHandler(this.form_BalDeduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox tb_RFID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_PrvsAmount;
        private System.Windows.Forms.Label lbl_CurrAmount;
        private System.Windows.Forms.Button btn_Back;
    }
}