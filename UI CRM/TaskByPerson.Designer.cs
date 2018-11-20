namespace UI_CRM
{
    partial class TaskByPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskByPerson));
            this.customer_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskList_listbox = new System.Windows.Forms.ListBox();
            this.taskDone_button = new System.Windows.Forms.Button();
            this.addTask_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.taskDetails_button = new System.Windows.Forms.Button();
            this.active_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_combobox
            // 
            this.customer_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customer_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_combobox.FormattingEnabled = true;
            this.customer_combobox.Location = new System.Drawing.Point(41, 85);
            this.customer_combobox.Name = "customer_combobox";
            this.customer_combobox.Size = new System.Drawing.Size(364, 28);
            this.customer_combobox.TabIndex = 9;
            this.customer_combobox.SelectedIndexChanged += new System.EventHandler(this.customer_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Klient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zadania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista zadań";
            // 
            // taskList_listbox
            // 
            this.taskList_listbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskList_listbox.FormattingEnabled = true;
            this.taskList_listbox.ItemHeight = 21;
            this.taskList_listbox.Location = new System.Drawing.Point(41, 161);
            this.taskList_listbox.Name = "taskList_listbox";
            this.taskList_listbox.Size = new System.Drawing.Size(697, 382);
            this.taskList_listbox.TabIndex = 10;
            // 
            // taskDone_button
            // 
            this.taskDone_button.FlatAppearance.BorderSize = 0;
            this.taskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDone_button.Image")));
            this.taskDone_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskDone_button.Location = new System.Drawing.Point(773, 231);
            this.taskDone_button.Name = "taskDone_button";
            this.taskDone_button.Size = new System.Drawing.Size(182, 64);
            this.taskDone_button.TabIndex = 34;
            this.taskDone_button.Text = "Wykonane";
            this.taskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDone_button.UseVisualStyleBackColor = true;
            this.taskDone_button.Click += new System.EventHandler(this.taskDone_button_Click);
            // 
            // addTask_button
            // 
            this.addTask_button.FlatAppearance.BorderSize = 0;
            this.addTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask_button.Image = ((System.Drawing.Image)(resources.GetObject("addTask_button.Image")));
            this.addTask_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTask_button.Location = new System.Drawing.Point(773, 161);
            this.addTask_button.Name = "addTask_button";
            this.addTask_button.Size = new System.Drawing.Size(182, 64);
            this.addTask_button.TabIndex = 33;
            this.addTask_button.Text = "Dodaj nowe";
            this.addTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTask_button.UseVisualStyleBackColor = true;
            this.addTask_button.Click += new System.EventHandler(this.addTask_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remove_button.Location = new System.Drawing.Point(773, 371);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(182, 64);
            this.remove_button.TabIndex = 32;
            this.remove_button.Text = "Usuń";
            this.remove_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // taskDetails_button
            // 
            this.taskDetails_button.FlatAppearance.BorderSize = 0;
            this.taskDetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDetails_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDetails_button.Image")));
            this.taskDetails_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskDetails_button.Location = new System.Drawing.Point(773, 301);
            this.taskDetails_button.Name = "taskDetails_button";
            this.taskDetails_button.Size = new System.Drawing.Size(182, 64);
            this.taskDetails_button.TabIndex = 35;
            this.taskDetails_button.Text = "Pokaż";
            this.taskDetails_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDetails_button.UseVisualStyleBackColor = true;
            this.taskDetails_button.Click += new System.EventHandler(this.taskDetails_button_Click);
            // 
            // active_button
            // 
            this.active_button.FlatAppearance.BorderSize = 0;
            this.active_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.active_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.active_button.Location = new System.Drawing.Point(556, 112);
            this.active_button.Name = "active_button";
            this.active_button.Size = new System.Drawing.Size(182, 43);
            this.active_button.TabIndex = 36;
            this.active_button.Text = "Tylko aktywne";
            this.active_button.UseVisualStyleBackColor = true;
            this.active_button.Click += new System.EventHandler(this.active_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.Location = new System.Drawing.Point(773, 481);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(182, 62);
            this.cancel_button.TabIndex = 37;
            this.cancel_button.Text = "Wyjdź";
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // TaskByPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.active_button);
            this.Controls.Add(this.taskDetails_button);
            this.Controls.Add(this.taskDone_button);
            this.Controls.Add(this.addTask_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.taskList_listbox);
            this.Controls.Add(this.customer_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskByPerson";
            this.Text = "TaskByPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customer_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox taskList_listbox;
        private System.Windows.Forms.Button taskDone_button;
        private System.Windows.Forms.Button addTask_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button taskDetails_button;
        private System.Windows.Forms.Button active_button;
        private System.Windows.Forms.Button cancel_button;
    }
}