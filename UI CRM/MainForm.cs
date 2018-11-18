using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CRM
{
    public partial class MainForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();
            LoadHomePanel();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            LoadHomePanel();

        }

        private void LoadHomePanel()
        {
            moving_panel.Location = new Point(244, 130);

            changing_panel.Controls.Clear();
            HomeForm home = new HomeForm();
            home.TopLevel = false;
            changing_panel.Controls.Add(home);
            home.Show();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            moving_panel.Location = new Point(244, 201);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moving_panel.Location = new Point(244, 272);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
