using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vk_status_away
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Settings_access_token = Properties.Settings.Default.access_token;
            if (Settings_access_token == "no_access_token")
            {
                get_paramentrs get_paramentrs = new get_paramentrs();
                get_paramentrs.ShowDialog();

            }

        }

        private void конфигурацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_settings main_settings = new main_settings();
            main_settings.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();
            AboutBox.ShowDialog();
        }
    }
}
