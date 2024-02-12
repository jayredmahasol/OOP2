namespace CustomerDataEntry
{
    partial class PreviewCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSex = new Label();
            lblStatus = new Label();
            lblHobbies = new Label();
            lblCountryName = new Label();
            lblCustomerName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(157, 75);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(157, 106);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 1;
            label2.Text = "Country Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(157, 168);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 6;
            label7.Text = "Hobbies";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(157, 198);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 13;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(157, 138);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 14;
            label4.Text = "Sex";
            label4.Click += label4_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 12F);
            lblSex.Location = new Point(340, 138);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(34, 21);
            lblSex.TabIndex = 19;
            lblSex.Text = "Sex";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(340, 198);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 21);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Status";
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Font = new Font("Segoe UI", 12F);
            lblHobbies.Location = new Point(340, 168);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(67, 21);
            lblHobbies.TabIndex = 17;
            lblHobbies.Text = "Hobbies";
            // 
            // lblCountryName
            // 
            lblCountryName.AutoSize = true;
            lblCountryName.Font = new Font("Segoe UI", 12F);
            lblCountryName.Location = new Point(340, 106);
            lblCountryName.Name = "lblCountryName";
            lblCountryName.Size = new Size(112, 21);
            lblCountryName.TabIndex = 16;
            lblCountryName.Text = "Country Name";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(340, 75);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(124, 21);
            lblCustomerName.TabIndex = 15;
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.Click += lblCustomerName_Click;
            // 
            // PreviewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSex);
            Controls.Add(lblStatus);
            Controls.Add(lblHobbies);
            Controls.Add(lblCountryName);
            Controls.Add(lblCustomerName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PreviewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preview Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label lblSex;
        private Label lblStatus;
        private Label lblHobbies;
        private Label lblCountryName;
        private Label lblCustomerName;
    }
}
