namespace vk_status_away
{
    partial class get_paramentrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(get_paramentrs));
            this.get_from_url_paramentrs = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // get_from_url_paramentrs
            // 
            this.get_from_url_paramentrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.get_from_url_paramentrs.Location = new System.Drawing.Point(0, 0);
            this.get_from_url_paramentrs.MinimumSize = new System.Drawing.Size(20, 20);
            this.get_from_url_paramentrs.Name = "get_from_url_paramentrs";
            this.get_from_url_paramentrs.Size = new System.Drawing.Size(284, 261);
            this.get_from_url_paramentrs.TabIndex = 0;
            this.get_from_url_paramentrs.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=4241641&scope=friends,status,wall,messag" +
        "es,offline&redirect_uri=http://vkontakte.ru/api/login_success.html&display=popup" +
        "&response_type=token", System.UriKind.Absolute);
            this.get_from_url_paramentrs.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // get_paramentrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.get_from_url_paramentrs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "get_paramentrs";
            this.ShowIcon = false;
            this.Text = "Получение необходимых параметров";
            this.Load += new System.EventHandler(this.get_paramentrs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser get_from_url_paramentrs;
    }
}