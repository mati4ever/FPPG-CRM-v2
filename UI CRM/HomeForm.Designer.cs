namespace UI_CRM
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.todaysTask_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeTask_listbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.missedTask_listbox = new System.Windows.Forms.ListBox();
            this.todayTaskDelay_button = new System.Windows.Forms.Button();
            this.removeTask_button = new System.Windows.Forms.Button();
            this.todayTaskDone_button = new System.Windows.Forms.Button();
            this.closeTaskDone_button = new System.Windows.Forms.Button();
            this.closeTaskDelay_button = new System.Windows.Forms.Button();
            this.missedTaskDone_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadania na dziś:";
            // 
            // todaysTask_listbox
            // 
            this.todaysTask_listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.todaysTask_listbox.FormattingEnabled = true;
            this.todaysTask_listbox.ItemHeight = 23;
            this.todaysTask_listbox.Location = new System.Drawing.Point(39, 55);
            this.todaysTask_listbox.Name = "todaysTask_listbox";
            this.todaysTask_listbox.Size = new System.Drawing.Size(724, 96);
            this.todaysTask_listbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Najbliższe 7 dni:";
            // 
            // closeTask_listbox
            // 
            this.closeTask_listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeTask_listbox.FormattingEnabled = true;
            this.closeTask_listbox.ItemHeight = 23;
            this.closeTask_listbox.Location = new System.Drawing.Point(39, 182);
            this.closeTask_listbox.Name = "closeTask_listbox";
            this.closeTask_listbox.Size = new System.Drawing.Size(724, 142);
            this.closeTask_listbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pominięte zadania:";
            // 
            // missedTask_listbox
            // 
            this.missedTask_listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.missedTask_listbox.FormattingEnabled = true;
            this.missedTask_listbox.ItemHeight = 23;
            this.missedTask_listbox.Location = new System.Drawing.Point(39, 375);
            this.missedTask_listbox.Name = "missedTask_listbox";
            this.missedTask_listbox.Size = new System.Drawing.Size(724, 142);
            this.missedTask_listbox.TabIndex = 1;
            // 
            // todayTaskDelay_button
            // 
            this.todayTaskDelay_button.FlatAppearance.BorderSize = 0;
            this.todayTaskDelay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayTaskDelay_button.Image = ((System.Drawing.Image)(resources.GetObject("todayTaskDelay_button.Image")));
            this.todayTaskDelay_button.Location = new System.Drawing.Point(864, 75);
            this.todayTaskDelay_button.Name = "todayTaskDelay_button";
            this.todayTaskDelay_button.Size = new System.Drawing.Size(74, 48);
            this.todayTaskDelay_button.TabIndex = 6;
            this.todayTaskDelay_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.todayTaskDelay_button.UseVisualStyleBackColor = true;
            this.todayTaskDelay_button.Click += new System.EventHandler(this.todayTaskDelay_button_Click);
            // 
            // removeTask_button
            // 
            this.removeTask_button.FlatAppearance.BorderSize = 0;
            this.removeTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTask_button.Image = ((System.Drawing.Image)(resources.GetObject("removeTask_button.Image")));
            this.removeTask_button.Location = new System.Drawing.Point(864, 426);
            this.removeTask_button.Name = "removeTask_button";
            this.removeTask_button.Size = new System.Drawing.Size(74, 48);
            this.removeTask_button.TabIndex = 7;
            this.removeTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.removeTask_button.UseVisualStyleBackColor = true;
            this.removeTask_button.Click += new System.EventHandler(this.removeTask_button_Click);
            // 
            // todayTaskDone_button
            // 
            this.todayTaskDone_button.FlatAppearance.BorderSize = 0;
            this.todayTaskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayTaskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("todayTaskDone_button.Image")));
            this.todayTaskDone_button.Location = new System.Drawing.Point(784, 75);
            this.todayTaskDone_button.Name = "todayTaskDone_button";
            this.todayTaskDone_button.Size = new System.Drawing.Size(74, 48);
            this.todayTaskDone_button.TabIndex = 8;
            this.todayTaskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.todayTaskDone_button.UseVisualStyleBackColor = true;
            this.todayTaskDone_button.Click += new System.EventHandler(this.todayTaskDone_button_Click);
            // 
            // closeTaskDone_button
            // 
            this.closeTaskDone_button.FlatAppearance.BorderSize = 0;
            this.closeTaskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTaskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("closeTaskDone_button.Image")));
            this.closeTaskDone_button.Location = new System.Drawing.Point(784, 233);
            this.closeTaskDone_button.Name = "closeTaskDone_button";
            this.closeTaskDone_button.Size = new System.Drawing.Size(74, 48);
            this.closeTaskDone_button.TabIndex = 8;
            this.closeTaskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeTaskDone_button.UseVisualStyleBackColor = true;
            this.closeTaskDone_button.Click += new System.EventHandler(this.closeTaskDone_button_Click);
            // 
            // closeTaskDelay_button
            // 
            this.closeTaskDelay_button.FlatAppearance.BorderSize = 0;
            this.closeTaskDelay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTaskDelay_button.Image = ((System.Drawing.Image)(resources.GetObject("closeTaskDelay_button.Image")));
            this.closeTaskDelay_button.Location = new System.Drawing.Point(864, 233);
            this.closeTaskDelay_button.Name = "closeTaskDelay_button";
            this.closeTaskDelay_button.Size = new System.Drawing.Size(74, 48);
            this.closeTaskDelay_button.TabIndex = 6;
            this.closeTaskDelay_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeTaskDelay_button.UseVisualStyleBackColor = true;
            this.closeTaskDelay_button.Click += new System.EventHandler(this.closeTaskDelay_button_Click);
            // 
            // missedTaskDone_button
            // 
            this.missedTaskDone_button.FlatAppearance.BorderSize = 0;
            this.missedTaskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missedTaskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("missedTaskDone_button.Image")));
            this.missedTaskDone_button.Location = new System.Drawing.Point(784, 426);
            this.missedTaskDone_button.Name = "missedTaskDone_button";
            this.missedTaskDone_button.Size = new System.Drawing.Size(74, 48);
            this.missedTaskDone_button.TabIndex = 8;
            this.missedTaskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.missedTaskDone_button.UseVisualStyleBackColor = true;
            this.missedTaskDone_button.Click += new System.EventHandler(this.missedTaskDone_button_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.closeTaskDelay_button);
            this.Controls.Add(this.todayTaskDelay_button);
            this.Controls.Add(this.missedTaskDone_button);
            this.Controls.Add(this.closeTaskDone_button);
            this.Controls.Add(this.removeTask_button);
            this.Controls.Add(this.todayTaskDone_button);
            this.Controls.Add(this.missedTask_listbox);
            this.Controls.Add(this.closeTask_listbox);
            this.Controls.Add(this.todaysTask_listbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox todaysTask_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox closeTask_listbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox missedTask_listbox;
        private System.Windows.Forms.Button todayTaskDelay_button;
        private System.Windows.Forms.Button removeTask_button;
        private System.Windows.Forms.Button todayTaskDone_button;
        private System.Windows.Forms.Button closeTaskDone_button;
        private System.Windows.Forms.Button closeTaskDelay_button;
        private System.Windows.Forms.Button missedTaskDone_button;
    }
}