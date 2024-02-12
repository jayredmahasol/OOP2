namespace CustomerDataEntry
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            chkReading = new CheckBox();
            chkPainting = new CheckBox();
            groupBox2 = new GroupBox();
            rdbUnmarried = new RadioButton();
            rdbMarried = new RadioButton();
            btnPreview = new Button();
            txtCustomerName = new TextBox();
            cmbCountry = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(157, 55);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(157, 86);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(157, 177);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 6;
            label7.Text = "Hobbies";
            label7.Click += label7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFemale);
            groupBox1.Controls.Add(rdbMale);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(181, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 53);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(248, 22);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(78, 25);
            rdbFemale.TabIndex = 1;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(99, 22);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(62, 25);
            rdbMale.TabIndex = 0;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Font = new Font("Segoe UI", 12F);
            chkReading.Location = new Point(280, 177);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(86, 25);
            chkReading.TabIndex = 10;
            chkReading.Text = "Reading";
            chkReading.UseVisualStyleBackColor = true;
            chkReading.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkPainting
            // 
            chkPainting.AutoSize = true;
            chkPainting.Font = new Font("Segoe UI", 12F);
            chkPainting.Location = new Point(429, 177);
            chkPainting.Name = "chkPainting";
            chkPainting.Size = new Size(85, 25);
            chkPainting.TabIndex = 11;
            chkPainting.Text = "Painting";
            chkPainting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbUnmarried);
            groupBox2.Controls.Add(rdbMarried);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(181, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 53);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status";
            // 
            // rdbUnmarried
            // 
            rdbUnmarried.AutoSize = true;
            rdbUnmarried.Location = new Point(248, 22);
            rdbUnmarried.Name = "rdbUnmarried";
            rdbUnmarried.Size = new Size(103, 25);
            rdbUnmarried.TabIndex = 1;
            rdbUnmarried.TabStop = true;
            rdbUnmarried.Text = "Unmarried";
            rdbUnmarried.UseVisualStyleBackColor = true;
            rdbUnmarried.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdbMarried
            // 
            rdbMarried.AutoSize = true;
            rdbMarried.Location = new Point(99, 22);
            rdbMarried.Name = "rdbMarried";
            rdbMarried.Size = new Size(83, 25);
            rdbMarried.TabIndex = 0;
            rdbMarried.TabStop = true;
            rdbMarried.Text = "Married";
            rdbMarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.Font = new Font("Segoe UI", 12F);
            btnPreview.Location = new Point(324, 282);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(111, 43);
            btnPreview.TabIndex = 12;
            btnPreview.Text = "PREVIEW";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.Location = new Point(307, 55);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(287, 27);
            txtCustomerName.TabIndex = 13;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Bangladesh", "Philippines", "Canada", "Japan", "China" });
            cmbCountry.Location = new Point(307, 88);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(287, 23);
            cmbCountry.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCountry);
            Controls.Add(txtCustomerName);
            Controls.Add(btnPreview);
            Controls.Add(groupBox2);
            Controls.Add(chkPainting);
            Controls.Add(chkReading);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Data Entry Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private CheckBox chkReading;
        private CheckBox chkPainting;
        private GroupBox groupBox2;
        private RadioButton rdbUnmarried;
        private RadioButton rdbMarried;
        private Button btnPreview;
        private TextBox txtCustomerName;
        private ComboBox cmbCountry;
    }
}
