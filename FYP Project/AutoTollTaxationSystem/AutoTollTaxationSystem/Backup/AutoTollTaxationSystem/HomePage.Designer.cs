namespace AutoTollTaxationSystem
{
    partial class HomePage
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
            this.btn_BalDeduction = new System.Windows.Forms.Button();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BalDeduction
            // 
            this.btn_BalDeduction.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btn_BalDeduction.Location = new System.Drawing.Point(37, 100);
            this.btn_BalDeduction.Name = "btn_BalDeduction";
            this.btn_BalDeduction.Size = new System.Drawing.Size(349, 51);
            this.btn_BalDeduction.TabIndex = 0;
            this.btn_BalDeduction.Text = "Balance Deduction";
            this.btn_BalDeduction.UseVisualStyleBackColor = true;
            this.btn_BalDeduction.Click += new System.EventHandler(this.btn_BalDeduction_Click);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.Location = new System.Drawing.Point(37, 173);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(349, 51);
            this.btn_AdminLogin.TabIndex = 1;
            this.btn_AdminLogin.Text = "Admin Login";
            this.btn_AdminLogin.UseVisualStyleBackColor = true;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto Toll Taxation System";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.btn_BalDeduction);
            this.Name = "HomePage";
            this.Text = "Auto Tool Taxation System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BalDeduction;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.Label label1;
    }
}

