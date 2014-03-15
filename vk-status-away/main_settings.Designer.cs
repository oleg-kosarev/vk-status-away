namespace vk_status_away
{
    partial class main_settings
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.get_new_paramentrs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save_settings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.text_box_status_out = new System.Windows.Forms.TextBox();
            this.text_box_status_back = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show_access_token = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.show_access_token);
            this.groupBox1.Controls.Add(this.get_new_paramentrs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для подключения";
            // 
            // get_new_paramentrs
            // 
            this.get_new_paramentrs.AutoSize = true;
            this.get_new_paramentrs.Location = new System.Drawing.Point(273, 57);
            this.get_new_paramentrs.Name = "get_new_paramentrs";
            this.get_new_paramentrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.get_new_paramentrs.Size = new System.Drawing.Size(151, 23);
            this.get_new_paramentrs.TabIndex = 4;
            this.get_new_paramentrs.Text = "Получить новые данные";
            this.get_new_paramentrs.UseVisualStyleBackColor = false;
            this.get_new_paramentrs.Click += new System.EventHandler(this.get_new_paramentrs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваш ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш токен";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_box_status_out);
            this.groupBox2.Controls.Add(this.text_box_status_back);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для статуса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Статус ухода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Статус возврата";
            // 
            // save_settings
            // 
            this.save_settings.Location = new System.Drawing.Point(291, 356);
            this.save_settings.Name = "save_settings";
            this.save_settings.Size = new System.Drawing.Size(151, 23);
            this.save_settings.TabIndex = 2;
            this.save_settings.Text = "Сохранить настрой";
            this.save_settings.UseVisualStyleBackColor = true;
            this.save_settings.Click += new System.EventHandler(this.save_settings_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "!!!Внимание!!!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки программы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автозагруска при старте ситемы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Менять статуст при старте программы";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::vk_status_away.Properties.Settings.Default, "smena_statusa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Включено",
            "Выключено"});
            this.comboBox2.Location = new System.Drawing.Point(6, 82);
            this.comboBox2.Name = global::vk_status_away.Properties.Settings.Default.smena_statusa;
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // text_box_status_out
            // 
            this.text_box_status_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_box_status_out.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "status_out", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.text_box_status_out.Location = new System.Drawing.Point(104, 44);
            this.text_box_status_out.Name = "text_box_status_out";
            this.text_box_status_out.Size = new System.Drawing.Size(311, 20);
            this.text_box_status_out.TabIndex = 7;
            this.text_box_status_out.Text = global::vk_status_away.Properties.Settings.Default.status_out;
            this.toolTip1.SetToolTip(this.text_box_status_out, "Учитывайте что перед статусом будет добавлено \"На месте нету\"");
            // 
            // text_box_status_back
            // 
            this.text_box_status_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_box_status_back.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "status_back", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.text_box_status_back.Location = new System.Drawing.Point(104, 18);
            this.text_box_status_back.Name = "text_box_status_back";
            this.text_box_status_back.Size = new System.Drawing.Size(311, 20);
            this.text_box_status_back.TabIndex = 6;
            this.text_box_status_back.Text = global::vk_status_away.Properties.Settings.Default.status_back;
            this.toolTip1.SetToolTip(this.text_box_status_back, "Учитывайте что пере вашим статусом будет добавлено \"Я на масте\".");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "user_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(76, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = global::vk_status_away.Properties.Settings.Default.user_id;
            // 
            // show_access_token
            // 
            this.show_access_token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.show_access_token.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "access_token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.show_access_token.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.show_access_token.Location = new System.Drawing.Point(76, 20);
            this.show_access_token.Name = "show_access_token";
            this.show_access_token.ReadOnly = true;
            this.show_access_token.Size = new System.Drawing.Size(347, 13);
            this.show_access_token.TabIndex = 5;
            this.show_access_token.TabStop = false;
            this.show_access_token.Text = global::vk_status_away.Properties.Settings.Default.access_token;
            // 
            // timer1
            // 
            this.timer1.Enabled = global::vk_status_away.Properties.Settings.Default.timer_eneble;
            this.timer1.Interval = global::vk_status_away.Properties.Settings.Default.timer_interval;
            // 
            // main_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.save_settings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main_settings";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button get_new_paramentrs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_settings;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox show_access_token;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox text_box_status_out;
        private System.Windows.Forms.TextBox text_box_status_back;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}