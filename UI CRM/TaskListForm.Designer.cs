namespace UI_CRM
{
    partial class TaskListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListForm));
            this.task_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTask_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.taskDetails_button = new System.Windows.Forms.Button();
            this.taskDone_button = new System.Windows.Forms.Button();
            this.active_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_listbox
            // 
            this.task_listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.task_listbox.FormattingEnabled = true;
            this.task_listbox.ItemHeight = 23;
            this.task_listbox.Location = new System.Drawing.Point(16, 58);
            this.task_listbox.Name = "task_listbox";
            this.task_listbox.Size = new System.Drawing.Size(751, 487);
            this.task_listbox.Sorted = true;
            this.task_listbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista zadań";
            // 
            // addTask_button
            // 
            this.addTask_button.FlatAppearance.BorderSize = 0;
            this.addTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask_button.Image = ((System.Drawing.Image)(resources.GetObject("addTask_button.Image")));
            this.addTask_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTask_button.Location = new System.Drawing.Point(773, 58);
            this.addTask_button.Name = "addTask_button";
            this.addTask_button.Size = new System.Drawing.Size(182, 64);
            this.addTask_button.TabIndex = 9;
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
            this.remove_button.Location = new System.Drawing.Point(773, 479);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(182, 64);
            this.remove_button.TabIndex = 8;
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
            this.taskDetails_button.Location = new System.Drawing.Point(773, 128);
            this.taskDetails_button.Name = "taskDetails_button";
            this.taskDetails_button.Size = new System.Drawing.Size(182, 64);
            this.taskDetails_button.TabIndex = 10;
            this.taskDetails_button.Text = "Pokaż";
            this.taskDetails_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDetails_button.UseVisualStyleBackColor = true;
            this.taskDetails_button.Click += new System.EventHandler(this.taskDetails_button_Click);
            // 
            // taskDone_button
            // 
            this.taskDone_button.FlatAppearance.BorderSize = 0;
            this.taskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDone_button.Image")));
            this.taskDone_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskDone_button.Location = new System.Drawing.Point(773, 198);
            this.taskDone_button.Name = "taskDone_button";
            this.taskDone_button.Size = new System.Drawing.Size(182, 64);
            this.taskDone_button.TabIndex = 11;
            this.taskDone_button.Text = "Wykonane";
            this.taskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDone_button.UseVisualStyleBackColor = true;
            this.taskDone_button.Click += new System.EventHandler(this.taskDone_button_Click);
            // 
            // active_button
            // 
            this.active_button.FlatAppearance.BorderSize = 0;
            this.active_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.active_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.active_button.Location = new System.Drawing.Point(585, 9);
            this.active_button.Name = "active_button";
            this.active_button.Size = new System.Drawing.Size(182, 43);
            this.active_button.TabIndex = 12;
            this.active_button.Text = "Tylko aktywne";
            this.active_button.UseVisualStyleBackColor = true;
            this.active_button.Click += new System.EventHandler(this.active_button_Click);
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.active_button);
            this.Controls.Add(this.taskDetails_button);
            this.Controls.Add(this.taskDone_button);
            this.Controls.Add(this.addTask_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.task_listbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskListForm";
            this.Text = "TaskListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox task_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTask_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button taskDetails_button;
        private System.Windows.Forms.Button taskDone_button;
        private System.Windows.Forms.Button active_button;
    }
}