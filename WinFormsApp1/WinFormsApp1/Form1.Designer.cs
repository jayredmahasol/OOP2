namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chbReading = new System.Windows.Forms.CheckBox();
            this.chbPainting = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbUnmarried = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Bangladesh",
            "Philippines",
            "Canada",
            "United States of America"});
            this.cmbCountry.Location = new System.Drawing.Point(342, 106);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(128, 23);
            this.cmbCountry.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Location = new System.Drawing.Point(200, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(17, 22);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 19);
            this.rdbMale.TabIndex = 2;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(142, 22);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(63, 19);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // chbReading
            // 
            this.chbReading.AutoSize = true;
            this.chbReading.Location = new System.Drawing.Point(295, 222);
            this.chbReading.Name = "chbReading";
            this.chbReading.Size = new System.Drawing.Size(69, 19);
            this.chbReading.TabIndex = 8;
            this.chbReading.Text = "Reading";
            this.chbReading.UseVisualStyleBackColor = true;
            // 
            // chbPainting
            // 
            this.chbPainting.AutoSize = true;
            this.chbPainting.Location = new System.Drawing.Point(387, 222);
            this.chbPainting.Name = "chbPainting";
            this.chbPainting.Size = new System.Drawing.Size(70, 19);
            this.chbPainting.TabIndex = 9;
            this.chbPainting.Text = "Painting";
            this.chbPainting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbUnmarried);
            this.groupBox2.Controls.Add(this.rdbMarried);
            this.groupBox2.Location = new System.Drawing.Point(200, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rdbUnmarried
            // 
            this.rdbUnmarried.AutoSize = true;
            this.rdbUnmarried.Location = new System.Drawing.Point(142, 22);
            this.rdbUnmarried.Name = "rdbUnmarried";
            this.rdbUnmarried.Size = new System.Drawing.Size(81, 19);
            this.rdbUnmarried.TabIndex = 1;
            this.rdbUnmarried.TabStop = true;
            this.rdbUnmarried.Text = "Unmarried";
            this.rdbUnmarried.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(17, 22);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(62, 19);
            this.rdbMarried.TabIndex = 0;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Maried";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(232, 347);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(197, 31);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chbPainting);
            this.Controls.Add(this.chbReading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private ComboBox cmbCountry;
        private GroupBox groupBox1;
        private RadioButton rdbFemale;
        private Label label3;
        private CheckBox chbReading;
        private CheckBox chbPainting;
        private GroupBox groupBox2;
        private RadioButton rdbUnmarried;
        private RadioButton rdbMarried;
        private Button btnPreview;
        private RadioButton rdbMale;
    }
}