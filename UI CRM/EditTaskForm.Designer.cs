namespace UI_CRM
{
    partial class EditTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            this.executionDate_textbox = new System.Windows.Forms.TextBox();
            this.note_textbox = new System.Windows.Forms.TextBox();
            this.creationDate_textbox = new System.Windows.Forms.TextBox();
            this.repetition_combobox = new System.Windows.Forms.ComboBox();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.customer_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editCustomer_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.saveCustomer_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // executionDate_textbox
            // 
            this.executionDate_textbox.Enabled = false;
            this.executionDate_textbox.Location = new System.Drawing.Point(241, 174);
            this.executionDate_textbox.Name = "executionDate_textbox";
            this.executionDate_textbox.Size = new System.Drawing.Size(177, 26);
            this.executionDate_textbox.TabIndex = 18;
            this.executionDate_textbox.Tag = "ED";
            // 
            // note_textbox
            // 
            this.note_textbox.Enabled = false;
            this.note_textbox.Location = new System.Drawing.Point(475, 103);
            this.note_textbox.Multiline = true;
            this.note_textbox.Name = "note_textbox";
            this.note_textbox.Size = new System.Drawing.Size(441, 256);
            this.note_textbox.TabIndex = 19;
            this.note_textbox.Tag = "ED";
            // 
            // creationDate_textbox
            // 
            this.creationDate_textbox.Enabled = false;
            this.creationDate_textbox.Location = new System.Drawing.Point(54, 174);
            this.creationDate_textbox.Name = "creationDate_textbox";
            this.creationDate_textbox.Size = new System.Drawing.Size(177, 26);
            this.creationDate_textbox.TabIndex = 20;
            // 
            // repetition_combobox
            // 
            this.repetition_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.repetition_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.repetition_combobox.Enabled = false;
            this.repetition_combobox.FormattingEnabled = true;
            this.repetition_combobox.Location = new System.Drawing.Point(54, 331);
            this.repetition_combobox.Name = "repetition_combobox";
            this.repetition_combobox.Size = new System.Drawing.Size(364, 28);
            this.repetition_combobox.TabIndex = 15;
            this.repetition_combobox.Tag = "ED";
            // 
            // category_combobox
            // 
            this.category_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_combobox.Enabled = false;
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Location = new System.Drawing.Point(54, 251);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(364, 28);
            this.category_combobox.TabIndex = 16;
            this.category_combobox.Tag = "ED";
            // 
            // customer_combobox
            // 
            this.customer_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customer_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_combobox.Enabled = false;
            this.customer_combobox.FormattingEnabled = true;
            this.customer_combobox.Location = new System.Drawing.Point(54, 101);
            this.customer_combobox.Name = "customer_combobox";
            this.customer_combobox.Size = new System.Drawing.Size(364, 28);
            this.customer_combobox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(237, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data wykonania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data zlecenia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(471, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Szczegółowe informacje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Powtarzalność";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kategoria zadania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Klient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zadanie";
            // 
            // editCustomer_button
            // 
            this.editCustomer_button.FlatAppearance.BorderSize = 0;
            this.editCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomer_button.Image = ((System.Drawing.Image)(resources.GetObject("editCustomer_button.Image")));
            this.editCustomer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editCustomer_button.Location = new System.Drawing.Point(200, 479);
            this.editCustomer_button.Name = "editCustomer_button";
            this.editCustomer_button.Size = new System.Drawing.Size(182, 64);
            this.editCustomer_button.TabIndex = 27;
            this.editCustomer_button.Text = "Edytuj";
            this.editCustomer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editCustomer_button.UseVisualStyleBackColor = true;
            this.editCustomer_button.Click += new System.EventHandler(this.editCustomer_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.Location = new System.Drawing.Point(12, 481);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(182, 62);
            this.cancel_button.TabIndex = 26;
            this.cancel_button.Text = "Wyjdź";
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // saveCustomer_button
            // 
            this.saveCustomer_button.Enabled = false;
            this.saveCustomer_button.FlatAppearance.BorderSize = 0;
            this.saveCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCustomer_button.Image = ((System.Drawing.Image)(resources.GetObject("saveCustomer_button.Image")));
            this.saveCustomer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveCustomer_button.Location = new System.Drawing.Point(773, 481);
            this.saveCustomer_button.Name = "saveCustomer_button";
            this.saveCustomer_button.Size = new System.Drawing.Size(182, 62);
            this.saveCustomer_button.TabIndex = 28;
            this.saveCustomer_button.Tag = "ED";
            this.saveCustomer_button.Text = "Zapisz";
            this.saveCustomer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveCustomer_button.UseVisualStyleBackColor = true;
            this.saveCustomer_button.Click += new System.EventHandler(this.saveCustomer_button_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.editCustomer_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.saveCustomer_button);
            this.Controls.Add(this.executionDate_textbox);
            this.Controls.Add(this.note_textbox);
            this.Controls.Add(this.creationDate_textbox);
            this.Controls.Add(this.repetition_combobox);
            this.Controls.Add(this.category_combobox);
            this.Controls.Add(this.customer_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox executionDate_textbox;
        private System.Windows.Forms.TextBox note_textbox;
        private System.Windows.Forms.TextBox creationDate_textbox;
        private System.Windows.Forms.ComboBox repetition_combobox;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.ComboBox customer_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editCustomer_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button saveCustomer_button;
    }
}