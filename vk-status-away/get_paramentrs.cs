using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace vk_status_away
{
    public partial class get_paramentrs : Form
    {
        public get_paramentrs()
        {
            InitializeComponent();
        }

        private void get_paramentrs_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("access_token") != -1)
            {
                string accessToken = "";
                string userId = "";
                Regex myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match m in myReg.Matches(e.Url.ToString()))
                {
                    if (m.Groups["name"].Value == "access_token")
                    {
                        accessToken = m.Groups["value"].Value;
                    }
                    else if (m.Groups["name"].Value == "user_id")
                    {
                        userId = m.Groups["value"].Value;
                    }
                    // еще можно запомнить срок жизни access_token - expires_in,
                    // если нужно
                }


                //MessageBox.Show(String.Format("Ключ доступа: {0}\nUserID: {1}", accessToken, userId));
                Properties.Settings.Default.access_token = accessToken;
                Properties.Settings.Default.user_id = userId;
                Properties.Settings.Default.Save();

                string Settings_access_token = Properties.Settings.Default.access_token;
                string Settings_user_id = Properties.Settings.Default.user_id;
                if (Settings_access_token != "no_access_token" & Settings_user_id != "no_user_id")
                {
                    MessageBox.Show("Ваши данные успешно получены и занесены в конфиг файл.");
                    //MessageBox.Show(Settings_access_token + "------Settings_access_token");
                    //MessageBox.Show(Settings_user_id + "------Settings_user_id");

                }
                else
                {
                    MessageBox.Show("Ваши данные мы не смогли получить. Попробуйте ещё раз!");
                    get_from_url_paramentrs.Navigate("https://oauth.vk.com/authorize?client_id=4241641&scope=friends,status,wall,messages,offline&redirect_uri=http://vkontakte.ru/api/login_success.html&display=popup&response_type=token");
                    //MessageBox.Show(Settings_access_token + "------Settings_access_token");
                    //MessageBox.Show(Settings_user_id + "------Settings_user_id");
                }

                main_forms main_forms = new main_forms();
                main_forms.Refresh(); 
                this.Close();
               // main_forms main_forms = new main_forms();
                //main_settings.Refresh();

                //main_forms main_form = new main_forms();
                //main_form.Refresh(); 
            }
        }
    }
}
