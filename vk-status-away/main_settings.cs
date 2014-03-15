using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk_status_away
{
    public partial class main_settings : Form
    {
        public main_settings()
        {
            InitializeComponent();
        }

        private void get_new_paramentrs_Click(object sender, EventArgs e)
        {
            get_paramentrs get_paramentrs = new get_paramentrs();
            get_paramentrs.ShowDialog();
        }

        private void save_settings_Click(object sender, EventArgs e)
        {
            //string status_out = "Нет на месте. " + text_box_status_out.Text;
            //string status_back = "Я на месте. " + text_box_status_back.Text;
            //Properties.Settings.Default.status_out = status_out;
            //Properties.Settings.Default.status_back = status_back;
            //Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
