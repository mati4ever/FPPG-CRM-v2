namespace UI_CRM
{
    partial class PersonListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.person_listbox = new System.Windows.Forms.ListBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.customerTask_button = new System.Windows.Forms.Button();
            this.fullProfile_button = new System.Windows.Forms.Button();
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.alfabetic_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista klientów";
            // 
            // person_listbox
            // 
            this.person_listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.person_listbox.FormattingEnabled = true;
            this.person_listbox.ItemHeight = 23;
            this.person_listbox.Location = new System.Drawing.Point(16, 58);
            this.person_listbox.Name = "person_listbox";
            this.person_listbox.Size = new System.Drawing.Size(751, 487);
            this.person_listbox.Sorted = true;
            this.person_listbox.TabIndex = 2;
            // 
            // remove_button
            // 
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remove_button.Location = new System.Drawing.Point(773, 481);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(182, 64);
            this.remove_button.TabIndex = 4;
            this.remove_button.Text = "Usuń";
            this.remove_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // customerTask_button
            // 
            this.customerTask_button.FlatAppearance.BorderSize = 0;
            this.customerTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerTask_button.Image = ((System.Drawing.Image)(resources.GetObject("customerTask_button.Image")));
            this.customerTask_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customerTask_button.Location = new System.Drawing.Point(773, 198);
            this.customerTask_button.Name = "customerTask_button";
            this.customerTask_button.Size = new System.Drawing.Size(182, 64);
            this.customerTask_button.TabIndex = 5;
            this.customerTask_button.Text = "Zadania";
            this.customerTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerTask_button.UseVisualStyleBackColor = true;
            this.customerTask_button.Click += new System.EventHandler(this.customerTask_button_Click);
            // 
            // fullProfile_button
            // 
            this.fullProfile_button.FlatAppearance.BorderSize = 0;
            this.fullProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullProfile_button.Image = ((System.Drawing.Image)(resources.GetObject("fullProfile_button.Image")));
            this.fullProfile_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fullProfile_button.Location = new System.Drawing.Point(773, 128);
            this.fullProfile_button.Name = "fullProfile_button";
            this.fullProfile_button.Size = new System.Drawing.Size(182, 64);
            this.fullProfile_button.TabIndex = 6;
            this.fullProfile_button.Text = "Pełny profil";
            this.fullProfile_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fullProfile_button.UseVisualStyleBackColor = true;
            this.fullProfile_button.Click += new System.EventHandler(this.fullProfile_button_Click);
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.FlatAppearance.BorderSize = 0;
            this.addCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer_button.Image = ((System.Drawing.Image)(resources.GetObject("addCustomer_button.Image")));
            this.addCustomer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCustomer_button.Location = new System.Drawing.Point(773, 58);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(182, 64);
            this.addCustomer_button.TabIndex = 7;
            this.addCustomer_button.Text = "Dodaj nowego";
            this.addCustomer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomer_button.UseVisualStyleBackColor = true;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // alfabetic_button
            // 
            this.alfabetic_button.FlatAppearance.BorderSize = 0;
            this.alfabetic_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alfabetic_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alfabetic_button.Location = new System.Drawing.Point(585, 12);
            this.alfabetic_button.Name = "alfabetic_button";
            this.alfabetic_button.Size = new System.Drawing.Size(182, 43);
            this.alfabetic_button.TabIndex = 4;
            this.alfabetic_button.Text = "Alfabetycznie";
            this.alfabetic_button.UseVisualStyleBackColor = true;
            this.alfabetic_button.Click += new System.EventHandler(this.alfabetic_button_Click);
            // 
            // PersonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.customerTask_button);
            this.Controls.Add(this.fullProfile_button);
            this.Controls.Add(this.addCustomer_button);
            this.Controls.Add(this.alfabetic_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.person_listbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox person_listbox;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button customerTask_button;
        private System.Windows.Forms.Button fullProfile_button;
        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.Button alfabetic_button;
    }
}