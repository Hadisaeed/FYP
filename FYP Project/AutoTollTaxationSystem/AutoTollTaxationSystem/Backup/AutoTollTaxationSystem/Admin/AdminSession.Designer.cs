namespace AutoTollTaxationSystem
{
    partial class form_AdminSession
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_TopUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(7, 14);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(271, 28);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Auto Toll Taxation System";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(47, 98);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(177, 37);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_TopUp
            // 
            this.btn_TopUp.Location = new System.Drawing.Point(47, 175);
            this.btn_TopUp.Name = "btn_TopUp";
            this.btn_TopUp.Size = new System.Drawing.Size(177, 39);
            this.btn_TopUp.TabIndex = 4;
            this.btn_TopUp.Text = "Top Up";
            this.btn_TopUp.UseVisualStyleBackColor = true;
            this.btn_TopUp.Click += new System.EventHandler(this.btn_TopUp_Click);
            // 
            // form_AdminSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_TopUp);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_header);
            this.Name = "form_AdminSession";
            this.Text = "Welcome Admin!";
            this.Load += new System.EventHandler(this.form_AdminSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_TopUp;
    }
}