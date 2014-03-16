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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show_access_token = new System.Windows.Forms.TextBox();
            this.get_new_paramentrs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.save_settings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.text_box_status_back = new System.Windows.Forms.TextBox();
            this.text_box_status_out = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.text_box_status_out);
            this.groupBox2.Controls.Add(this.text_box_status_back);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для статуса";
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
            // timer1
            // 
            this.timer1.Enabled = global::vk_status_away.Properties.Settings.Default.timer_eneble;
            this.timer1.Interval = global::vk_status_away.Properties.Settings.Default.timer_interval;
            // 
            // text_box_status_back
            // 
            this.text_box_status_back.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "status_back", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.text_box_status_back.Location = new System.Drawing.Point(76, 33);
            this.text_box_status_back.Name = "text_box_status_back";
            this.text_box_status_back.Size = new System.Drawing.Size(347, 20);
            this.text_box_status_back.TabIndex = 0;
            this.text_box_status_back.Text = global::vk_status_away.Properties.Settings.Default.status_back;
            // 
            // text_box_status_out
            // 
            this.text_box_status_out.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vk_status_away.Properties.Settings.Default, "status_out", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.text_box_status_out.Location = new System.Drawing.Point(76, 60);
            this.text_box_status_out.Name = "text_box_status_out";
            this.text_box_status_out.Size = new System.Drawing.Size(347, 20);
            this.text_box_status_out.TabIndex = 1;
            this.text_box_status_out.Text = global::vk_status_away.Properties.Settings.Default.status_out;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вернулись";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ушли";
            // 
            // main_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 385);
            this.Controls.Add(this.save_settings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main_settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.main_settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button get_new_paramentrs;
        private System.Windows.Forms.Button save_settings;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox show_access_token;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_box_status_out;
        private System.Windows.Forms.TextBox text_box_status_back;
    }
}