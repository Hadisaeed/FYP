namespace AutoTollTaxationSystem
{
    partial class form_TopUp
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
            this.label11 = new System.Windows.Forms.Label();
            this.txt_RFID = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_TopUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_header2 = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CurrentAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_CarNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "RFID No:";
            // 
            // txt_RFID
            // 
            this.txt_RFID.Location = new System.Drawing.Point(302, 94);
            this.txt_RFID.Name = "txt_RFID";
            this.txt_RFID.Size = new System.Drawing.Size(115, 20);
            this.txt_RFID.TabIndex = 52;
            this.txt_RFID.TextChanged += new System.EventHandler(this.txt_RFID_TextChanged);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(327, 266);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 37);
            this.btn_Back.TabIndex = 50;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_TopUp
            // 
            this.btn_TopUp.Location = new System.Drawing.Point(231, 266);
            this.btn_TopUp.Name = "btn_TopUp";
            this.btn_TopUp.Size = new System.Drawing.Size(90, 37);
            this.btn_TopUp.TabIndex = 49;
            this.btn_TopUp.Text = "Top Up";
            this.btn_TopUp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Car No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // lbl_header2
            // 
            this.lbl_header2.AutoSize = true;
            this.lbl_header2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header2.Location = new System.Drawing.Point(29, 47);
            this.lbl_header2.Name = "lbl_header2";
            this.lbl_header2.Size = new System.Drawing.Size(51, 18);
            this.lbl_header2.TabIndex = 29;
            this.lbl_header2.Text = "TopUp";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(27, 19);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(271, 28);
            this.lbl_header.TabIndex = 28;
            this.lbl_header.Text = "Auto Toll Taxation System";
            this.lbl_header.Click += new System.EventHandler(this.lbl_header_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Current Balance:";
            // 
            // lbl_CurrentAmount
            // 
            this.lbl_CurrentAmount.AutoSize = true;
            this.lbl_CurrentAmount.Location = new System.Drawing.Point(366, 193);
            this.lbl_CurrentAmount.Name = "lbl_CurrentAmount";
            this.lbl_CurrentAmount.Size = new System.Drawing.Size(51, 13);
            this.lbl_CurrentAmount.TabIndex = 55;
            this.lbl_CurrentAmount.Text = "*Amount*";
            this.lbl_CurrentAmount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Top Up Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 57;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(371, 132);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 13);
            this.lbl_Name.TabIndex = 58;
            this.lbl_Name.Text = "*NAME*";
            this.lbl_Name.Visible = false;
            // 
            // lbl_CarNo
            // 
            this.lbl_CarNo.AutoSize = true;
            this.lbl_CarNo.Location = new System.Drawing.Point(366, 164);
            this.lbl_CarNo.Name = "lbl_CarNo";
            this.lbl_CarNo.Size = new System.Drawing.Size(51, 13);
            this.lbl_CarNo.TabIndex = 59;
            this.lbl_CarNo.Text = "* Car No*";
            this.lbl_CarNo.Visible = false;
            // 
            // form_TopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.lbl_CarNo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_CurrentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_RFID);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_TopUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_header2);
            this.Controls.Add(this.lbl_header);
            this.Name = "form_TopUp";
            this.Text = "Top Up";
            this.Load += new System.EventHandler(this.form_TopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_RFID;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_TopUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_header2;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_CurrentAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_CarNo;

    }
}