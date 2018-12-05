namespace UI_CRM
{
    partial class PdfReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusMissed_radiobutton = new System.Windows.Forms.RadioButton();
            this.statusActive_radiobutton = new System.Windows.Forms.RadioButton();
            this.statusAll_radiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryMail_radiobutton = new System.Windows.Forms.RadioButton();
            this.categoryCall_radiobutton = new System.Windows.Forms.RadioButton();
            this.categoryMeating_radiobutton = new System.Windows.Forms.RadioButton();
            this.categoryAll_radiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.repetitionAnnually_radiobutton = new System.Windows.Forms.RadioButton();
            this.repetitionQuarterly_radiobutton = new System.Windows.Forms.RadioButton();
            this.repetitionMonthly_radiobutton = new System.Windows.Forms.RadioButton();
            this.repetitionAll_radiobutton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foundElements_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.date1_datePicekr = new System.Windows.Forms.DateTimePicker();
            this.date2_datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generuj raport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Od:";
            this.label2.TextChanged += new System.EventHandler(this.D);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do:";
            this.label3.TextChanged += new System.EventHandler(this.D);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusMissed_radiobutton);
            this.groupBox1.Controls.Add(this.statusActive_radiobutton);
            this.groupBox1.Controls.Add(this.statusAll_radiobutton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // statusMissed_radiobutton
            // 
            this.statusMissed_radiobutton.AutoSize = true;
            this.statusMissed_radiobutton.Location = new System.Drawing.Point(210, 24);
            this.statusMissed_radiobutton.Name = "statusMissed_radiobutton";
            this.statusMissed_radiobutton.Size = new System.Drawing.Size(102, 24);
            this.statusMissed_radiobutton.TabIndex = 5;
            this.statusMissed_radiobutton.TabStop = true;
            this.statusMissed_radiobutton.Text = "Pominięte";
            this.statusMissed_radiobutton.UseVisualStyleBackColor = true;
            this.statusMissed_radiobutton.CheckedChanged += new System.EventHandler(this.statusMissed_radiobutton_CheckedChanged);
            // 
            // statusActive_radiobutton
            // 
            this.statusActive_radiobutton.AutoSize = true;
            this.statusActive_radiobutton.Location = new System.Drawing.Point(109, 25);
            this.statusActive_radiobutton.Name = "statusActive_radiobutton";
            this.statusActive_radiobutton.Size = new System.Drawing.Size(95, 24);
            this.statusActive_radiobutton.TabIndex = 5;
            this.statusActive_radiobutton.TabStop = true;
            this.statusActive_radiobutton.Text = "Aktywne";
            this.statusActive_radiobutton.UseVisualStyleBackColor = true;
            this.statusActive_radiobutton.CheckedChanged += new System.EventHandler(this.statusActive_radiobutton_CheckedChanged);
            // 
            // statusAll_radiobutton
            // 
            this.statusAll_radiobutton.AutoSize = true;
            this.statusAll_radiobutton.Location = new System.Drawing.Point(12, 25);
            this.statusAll_radiobutton.Name = "statusAll_radiobutton";
            this.statusAll_radiobutton.Size = new System.Drawing.Size(91, 24);
            this.statusAll_radiobutton.TabIndex = 5;
            this.statusAll_radiobutton.TabStop = true;
            this.statusAll_radiobutton.Text = "Wszytkie";
            this.statusAll_radiobutton.UseVisualStyleBackColor = true;
            this.statusAll_radiobutton.CheckedChanged += new System.EventHandler(this.statusAll_radiobutton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryMail_radiobutton);
            this.groupBox2.Controls.Add(this.categoryCall_radiobutton);
            this.groupBox2.Controls.Add(this.categoryMeating_radiobutton);
            this.groupBox2.Controls.Add(this.categoryAll_radiobutton);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategoria";
            // 
            // categoryMail_radiobutton
            // 
            this.categoryMail_radiobutton.AutoSize = true;
            this.categoryMail_radiobutton.Location = new System.Drawing.Point(305, 25);
            this.categoryMail_radiobutton.Name = "categoryMail_radiobutton";
            this.categoryMail_radiobutton.Size = new System.Drawing.Size(67, 24);
            this.categoryMail_radiobutton.TabIndex = 5;
            this.categoryMail_radiobutton.TabStop = true;
            this.categoryMail_radiobutton.Text = "Email";
            this.categoryMail_radiobutton.UseVisualStyleBackColor = true;
            this.categoryMail_radiobutton.CheckedChanged += new System.EventHandler(this.categoryMail_radiobutton_CheckedChanged);
            // 
            // categoryCall_radiobutton
            // 
            this.categoryCall_radiobutton.AutoSize = true;
            this.categoryCall_radiobutton.Location = new System.Drawing.Point(217, 25);
            this.categoryCall_radiobutton.Name = "categoryCall_radiobutton";
            this.categoryCall_radiobutton.Size = new System.Drawing.Size(82, 24);
            this.categoryCall_radiobutton.TabIndex = 5;
            this.categoryCall_radiobutton.TabStop = true;
            this.categoryCall_radiobutton.Text = "Telefon";
            this.categoryCall_radiobutton.UseVisualStyleBackColor = true;
            this.categoryCall_radiobutton.CheckedChanged += new System.EventHandler(this.categoryCall_radiobutton_CheckedChanged);
            // 
            // categoryMeating_radiobutton
            // 
            this.categoryMeating_radiobutton.AutoSize = true;
            this.categoryMeating_radiobutton.Location = new System.Drawing.Point(109, 25);
            this.categoryMeating_radiobutton.Name = "categoryMeating_radiobutton";
            this.categoryMeating_radiobutton.Size = new System.Drawing.Size(102, 24);
            this.categoryMeating_radiobutton.TabIndex = 5;
            this.categoryMeating_radiobutton.TabStop = true;
            this.categoryMeating_radiobutton.Text = "Spotkanie";
            this.categoryMeating_radiobutton.UseVisualStyleBackColor = true;
            this.categoryMeating_radiobutton.CheckedChanged += new System.EventHandler(this.categoryMeating_radiobutton_CheckedChanged);
            // 
            // categoryAll_radiobutton
            // 
            this.categoryAll_radiobutton.AutoSize = true;
            this.categoryAll_radiobutton.Location = new System.Drawing.Point(12, 25);
            this.categoryAll_radiobutton.Name = "categoryAll_radiobutton";
            this.categoryAll_radiobutton.Size = new System.Drawing.Size(91, 24);
            this.categoryAll_radiobutton.TabIndex = 5;
            this.categoryAll_radiobutton.TabStop = true;
            this.categoryAll_radiobutton.Text = "Wszytkie";
            this.categoryAll_radiobutton.UseVisualStyleBackColor = true;
            this.categoryAll_radiobutton.CheckedChanged += new System.EventHandler(this.categoryAll_radiobutton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.repetitionAnnually_radiobutton);
            this.groupBox3.Controls.Add(this.repetitionQuarterly_radiobutton);
            this.groupBox3.Controls.Add(this.repetitionMonthly_radiobutton);
            this.groupBox3.Controls.Add(this.repetitionAll_radiobutton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 62);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Powtarzalność";
            // 
            // repetitionAnnually_radiobutton
            // 
            this.repetitionAnnually_radiobutton.AutoSize = true;
            this.repetitionAnnually_radiobutton.Location = new System.Drawing.Point(338, 25);
            this.repetitionAnnually_radiobutton.Name = "repetitionAnnually_radiobutton";
            this.repetitionAnnually_radiobutton.Size = new System.Drawing.Size(84, 24);
            this.repetitionAnnually_radiobutton.TabIndex = 5;
            this.repetitionAnnually_radiobutton.TabStop = true;
            this.repetitionAnnually_radiobutton.Text = "Roczne";
            this.repetitionAnnually_radiobutton.UseVisualStyleBackColor = true;
            this.repetitionAnnually_radiobutton.CheckedChanged += new System.EventHandler(this.repetitionAnnually_radiobutton_CheckedChanged);
            // 
            // repetitionQuarterly_radiobutton
            // 
            this.repetitionQuarterly_radiobutton.AutoSize = true;
            this.repetitionQuarterly_radiobutton.Location = new System.Drawing.Point(227, 25);
            this.repetitionQuarterly_radiobutton.Name = "repetitionQuarterly_radiobutton";
            this.repetitionQuarterly_radiobutton.Size = new System.Drawing.Size(105, 24);
            this.repetitionQuarterly_radiobutton.TabIndex = 5;
            this.repetitionQuarterly_radiobutton.TabStop = true;
            this.repetitionQuarterly_radiobutton.Text = "Kwartalne";
            this.repetitionQuarterly_radiobutton.UseVisualStyleBackColor = true;
            this.repetitionQuarterly_radiobutton.CheckedChanged += new System.EventHandler(this.repetitionQuarterly_radiobutton_CheckedChanged);
            // 
            // repetitionMonthly_radiobutton
            // 
            this.repetitionMonthly_radiobutton.AutoSize = true;
            this.repetitionMonthly_radiobutton.Location = new System.Drawing.Point(109, 25);
            this.repetitionMonthly_radiobutton.Name = "repetitionMonthly_radiobutton";
            this.repetitionMonthly_radiobutton.Size = new System.Drawing.Size(112, 24);
            this.repetitionMonthly_radiobutton.TabIndex = 5;
            this.repetitionMonthly_radiobutton.TabStop = true;
            this.repetitionMonthly_radiobutton.Text = "Miesięczne";
            this.repetitionMonthly_radiobutton.UseVisualStyleBackColor = true;
            this.repetitionMonthly_radiobutton.CheckedChanged += new System.EventHandler(this.repetitionMonthly_radiobutton_CheckedChanged);
            // 
            // repetitionAll_radiobutton
            // 
            this.repetitionAll_radiobutton.AutoSize = true;
            this.repetitionAll_radiobutton.Location = new System.Drawing.Point(12, 25);
            this.repetitionAll_radiobutton.Name = "repetitionAll_radiobutton";
            this.repetitionAll_radiobutton.Size = new System.Drawing.Size(91, 24);
            this.repetitionAll_radiobutton.TabIndex = 5;
            this.repetitionAll_radiobutton.TabStop = true;
            this.repetitionAll_radiobutton.Text = "Wszytkie";
            this.repetitionAll_radiobutton.UseVisualStyleBackColor = true;
            this.repetitionAll_radiobutton.CheckedChanged += new System.EventHandler(this.repetitionAll_radiobutton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(504, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 366);
            this.panel1.TabIndex = 7;
            // 
            // foundElements_textbox
            // 
            this.foundElements_textbox.Enabled = false;
            this.foundElements_textbox.Location = new System.Drawing.Point(266, 372);
            this.foundElements_textbox.Name = "foundElements_textbox";
            this.foundElements_textbox.Size = new System.Drawing.Size(100, 26);
            this.foundElements_textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Liczba znalezionych elementów:";
            this.label4.TextChanged += new System.EventHandler(this.D);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(185, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(185, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generuj PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date1_datePicekr
            // 
            this.date1_datePicekr.CustomFormat = "dd-MM-yyyy";
            this.date1_datePicekr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1_datePicekr.Location = new System.Drawing.Point(78, 268);
            this.date1_datePicekr.Name = "date1_datePicekr";
            this.date1_datePicekr.Size = new System.Drawing.Size(130, 26);
            this.date1_datePicekr.TabIndex = 10;
            // 
            // date2_datePicker
            // 
            this.date2_datePicker.CustomFormat = "dd-MM-yyyy";
            this.date2_datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2_datePicker.Location = new System.Drawing.Point(308, 268);
            this.date2_datePicker.Name = "date2_datePicker";
            this.date2_datePicker.Size = new System.Drawing.Size(130, 26);
            this.date2_datePicker.TabIndex = 10;
            // 
            // PdfReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.date2_datePicker);
            this.Controls.Add(this.date1_datePicekr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foundElements_textbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PdfReportForm";
            this.Text = "PdfReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox foundElements_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton statusAll_radiobutton;
        private System.Windows.Forms.RadioButton statusActive_radiobutton;
        private System.Windows.Forms.RadioButton statusMissed_radiobutton;
        private System.Windows.Forms.RadioButton categoryMail_radiobutton;
        private System.Windows.Forms.RadioButton categoryCall_radiobutton;
        private System.Windows.Forms.RadioButton categoryMeating_radiobutton;
        private System.Windows.Forms.RadioButton categoryAll_radiobutton;
        private System.Windows.Forms.RadioButton repetitionAnnually_radiobutton;
        private System.Windows.Forms.RadioButton repetitionQuarterly_radiobutton;
        private System.Windows.Forms.RadioButton repetitionMonthly_radiobutton;
        private System.Windows.Forms.RadioButton repetitionAll_radiobutton;
        private System.Windows.Forms.DateTimePicker date1_datePicekr;
        private System.Windows.Forms.DateTimePicker date2_datePicker;
    }
}