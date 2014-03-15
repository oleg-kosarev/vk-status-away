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
//Подключаем файлы для работы с XML
using System.Xml;
using System.Xml.Linq;


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
            //Начало определяем переменные с информацией в конфиге
            string Settings_access_token = Properties.Settings.Default.access_token; //Получаем из настроек access_token
            string Settings_first_name = Properties.Settings.Default.first_name; //Получаем из настроек first_name
            string Settings_last_name = Properties.Settings.Default.last_name; //Получаем из настроек last_name
            string Settings_url_avator = Properties.Settings.Default.url_avatar; //Получаем из настроек url_avatar
            string Setting_uids = Properties.Settings.Default.user_id;
            string Settings_cerrent_status = Properties.Settings.Default.current_status; //Получаем из настроек url_avatar
            string Settings_status_back = Properties.Settings.Default.status_back;
            string Settings_status_out = Properties.Settings.Default.status_out;
            //Конец определяем переменные с информацией в конфиге

            if (Settings_access_token == "no_access_token")
            {
                get_paramentrs get_paramentrs = new get_paramentrs(); //Инзцилизируем get_paramentrs
                get_paramentrs.ShowDialog(); //Показываем get_paramentrs

            }

            //начинаем доставать урл аватора
            XDocument xmlDocument = XDocument.Load("https://api.vkontakte.ru/method/getProfiles.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids + "&fields=uid, first_name, last_name, nickname, screen_name, sex, bdate (birthdate), city, country, timezone, photo, photo_medium, photo_big, has_mobile, rate, contacts, education, online, counters");
            var people = from user in xmlDocument.Descendants("user")
                         select new
                         {
                             FirstName = user.Element("first_name").Value,
                             LastName = user.Element("last_name").Value,
                             photo_big = user.Element("photo_big").Value
                             //get_lastname = response.Element("last_name")
                         };
            foreach (var user in people)
            {
                Properties.Settings.Default.first_name = user.FirstName;
                Properties.Settings.Default.last_name = user.LastName;
                Properties.Settings.Default.url_avatar = user.photo_big;
                Properties.Settings.Default.Save();
                this.Refresh();
            }

            if (Settings_first_name == "no_first_name" && Settings_last_name == "no_last_name")
            {
                view_first_name.Hide();
                view_last_name.Hide();
            }
            else
            {
                guest.Hide();
                view_first_name.Show();
                view_last_name.Show();
            }

            if (Settings_cerrent_status == "no_get_status")
            {
                status_download.Hide();
                //начинаем доставать status
                XDocument status_get = XDocument.Load("https://api.vkontakte.ru/method/status.get.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids);
                var status = from response in status_get.Descendants("response")
                             select new
                             {
                                 status_text = response.Element("text").Value,
                                 //LastName = user.Element("last_name").Value,
                                 //photo_big = user.Element("photo_big").Value
                                 //get_lastname = response.Element("last_name")
                             };
                foreach (var response_text in status)
                {
                    Properties.Settings.Default.current_status = response_text.status_text;
                    //Properties.Settings.Default.last_name = user.LastName;
                    //Properties.Settings.Default.url_avatar = user.photo_big;
                    Properties.Settings.Default.Save();
                    this.Refresh();
                }
            }
            else
            {
                no_status.Hide();
            }
        }
        //Начинаем описывать меню
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

        private void обратнаяСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback();
            feedback.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void вернутсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //начинаем отпровлять status
            string Settings_access_token = Properties.Settings.Default.access_token; //Получаем из настроек access_token
            string Setting_uids = Properties.Settings.Default.user_id;
            string Settings_status_back = Properties.Settings.Default.status_back;
            XDocument status_get = XDocument.Load("https://api.vkontakte.ru/method/status.set.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids + "&text=" + Settings_status_back);

            //начинаем доставать status
            XDocument status_refres = XDocument.Load("https://api.vkontakte.ru/method/status.get.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids);
            var status = from response in status_refres.Descendants("response")
                         select new
                         {
                             status_text = response.Element("text").Value,
                             //LastName = user.Element("last_name").Value,
                             //photo_big = user.Element("photo_big").Value
                             //get_lastname = response.Element("last_name")
                         };
            foreach (var response_text in status)
            {
                Properties.Settings.Default.current_status = response_text.status_text;
                //Properties.Settings.Default.last_name = user.LastName;
                //Properties.Settings.Default.url_avatar = user.photo_big;
                Properties.Settings.Default.Save();
                this.Refresh();
            }
            status_download.Refresh();
        }

        private void отойтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //начинаем отпровлять status
            string Settings_access_token = Properties.Settings.Default.access_token; //Получаем из настроек access_token
            string Setting_uids = Properties.Settings.Default.user_id;
            string Settings_status_out = Properties.Settings.Default.status_out;
            XDocument status_get = XDocument.Load("https://api.vkontakte.ru/method/status.set.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids + "&text=" + Settings_status_out);

            //начинаем доставать status
            XDocument status_refres = XDocument.Load("https://api.vkontakte.ru/method/status.get.xml?access_token=" + Settings_access_token + "&uids=" + Setting_uids);
            var status = from response in status_refres.Descendants("response")
                        select new
                         {
                             status_text = response.Element("text").Value,
                             //LastName = user.Element("last_name").Value,
                             //photo_big = user.Element("photo_big").Value
                             //get_lastname = response.Element("last_name")
                         };
            foreach (var response_text in status)
            {
                Properties.Settings.Default.current_status = response_text.status_text;
                //Properties.Settings.Default.last_name = user.LastName;
                //Properties.Settings.Default.url_avatar = user.photo_big;
                Properties.Settings.Default.Save();
                this.Refresh();
            }
            status_download.Refresh();
            
            status_download.Refresh();
        }
        //Заканчиваем описывать меню
    }
}
