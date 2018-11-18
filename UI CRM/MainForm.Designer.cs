namespace UI_CRM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logo_panel = new System.Windows.Forms.Panel();
            this.button_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.changing_panel = new System.Windows.Forms.Panel();
            this.moving_panel = new System.Windows.Forms.Panel();
            this.button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.logo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_panel.BackgroundImage")));
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_panel.Location = new System.Drawing.Point(12, 23);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(228, 98);
            this.logo_panel.TabIndex = 0;
            // 
            // button_panel
            // 
            this.button_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button_panel.Controls.Add(this.exit_button);
            this.button_panel.Controls.Add(this.button1);
            this.button_panel.Controls.Add(this.customer_button);
            this.button_panel.Controls.Add(this.home_button);
            this.button_panel.Location = new System.Drawing.Point(12, 127);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(228, 451);
            this.button_panel.TabIndex = 0;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_button.Location = new System.Drawing.Point(0, 383);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(228, 65);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "WYJDŹ";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "ZADANIA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_button
            // 
            this.customer_button.FlatAppearance.BorderSize = 0;
            this.customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customer_button.Image = ((System.Drawing.Image)(resources.GetObject("customer_button.Image")));
            this.customer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer_button.Location = new System.Drawing.Point(0, 74);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(228, 65);
            this.customer_button.TabIndex = 3;
            this.customer_button.Text = "KLIENCI";
            this.customer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customer_button.UseVisualStyleBackColor = true;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_button.Location = new System.Drawing.Point(0, 3);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(228, 65);
            this.home_button.TabIndex = 3;
            this.home_button.Text = "START";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // changing_panel
            // 
            this.changing_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.changing_panel.Location = new System.Drawing.Point(262, 23);
            this.changing_panel.Name = "changing_panel";
            this.changing_panel.Size = new System.Drawing.Size(967, 555);
            this.changing_panel.TabIndex = 0;
            // 
            // moving_panel
            // 
            this.moving_panel.BackColor = System.Drawing.Color.Yellow;
            this.moving_panel.Location = new System.Drawing.Point(244, 130);
            this.moving_panel.Name = "moving_panel";
            this.moving_panel.Size = new System.Drawing.Size(10, 65);
            this.moving_panel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 600);
            this.Controls.Add(this.moving_panel);
            this.Controls.Add(this.changing_panel);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.logo_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.button_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Panel changing_panel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel moving_panel;
    }
}