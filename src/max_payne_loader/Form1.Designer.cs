namespace max_payne_loader
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.chbx_asdeveloper = new System.Windows.Forms.CheckBox();
            this.btn_loader = new System.Windows.Forms.Button();
            this.btn_nfo = new System.Windows.Forms.Button();
            this.btn_howtouse = new System.Windows.Forms.Button();
            this.chbx_nodlg = new System.Windows.Forms.CheckBox();
            this.chbx_skipstrtup = new System.Windows.Forms.CheckBox();
            this.chbx_screenshot = new System.Windows.Forms.CheckBox();
            this.chbx_no3d = new System.Windows.Forms.CheckBox();
            this.chbx_runinwindow = new System.Windows.Forms.CheckBox();
            this.ofdpain = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_logo
            // 
            this.pct_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(12, 12);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(174, 298);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pct_logo.TabIndex = 0;
            this.pct_logo.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_logo, "Перейти на офф. сайт игры.");
            this.pct_logo.Click += new System.EventHandler(this.pct_logo_Click);
            this.pct_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct_logo_MouseDown);
            // 
            // chbx_asdeveloper
            // 
            this.chbx_asdeveloper.AutoSize = true;
            this.chbx_asdeveloper.Checked = true;
            this.chbx_asdeveloper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_asdeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_asdeveloper.ForeColor = System.Drawing.Color.DarkRed;
            this.chbx_asdeveloper.Location = new System.Drawing.Point(12, 341);
            this.chbx_asdeveloper.Name = "chbx_asdeveloper";
            this.chbx_asdeveloper.Size = new System.Drawing.Size(73, 17);
            this.chbx_asdeveloper.TabIndex = 1;
            this.chbx_asdeveloper.Text = "-developer";
            this.toolTip1.SetToolTip(this.chbx_asdeveloper, "Включение режима разработчика. Также \r\nпозволяет получить доступ к игровой консол" +
        "и.");
            this.chbx_asdeveloper.UseVisualStyleBackColor = true;
            // 
            // btn_loader
            // 
            this.btn_loader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loader.Location = new System.Drawing.Point(12, 312);
            this.btn_loader.Name = "btn_loader";
            this.btn_loader.Size = new System.Drawing.Size(70, 23);
            this.btn_loader.TabIndex = 2;
            this.btn_loader.Text = "Run Game";
            this.toolTip1.SetToolTip(this.btn_loader, "Запуск игры с выбранными параметрами. \r\n\r\nПо умолчанию игра запустится автоматиче" +
        "ски,\r\nно при возникновении трудностей, программа попросит\r\nуказать файл запуска " +
        "игры.");
            this.btn_loader.UseVisualStyleBackColor = true;
            this.btn_loader.Click += new System.EventHandler(this.btn_loader_Click);
            // 
            // btn_nfo
            // 
            this.btn_nfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nfo.Location = new System.Drawing.Point(138, 312);
            this.btn_nfo.Name = "btn_nfo";
            this.btn_nfo.Size = new System.Drawing.Size(48, 23);
            this.btn_nfo.TabIndex = 3;
            this.btn_nfo.Text = "iNFO";
            this.toolTip1.SetToolTip(this.btn_nfo, "О программе..");
            this.btn_nfo.UseVisualStyleBackColor = true;
            this.btn_nfo.Click += new System.EventHandler(this.btn_nfo_Click);
            // 
            // btn_howtouse
            // 
            this.btn_howtouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_howtouse.Location = new System.Drawing.Point(88, 312);
            this.btn_howtouse.Name = "btn_howtouse";
            this.btn_howtouse.Size = new System.Drawing.Size(44, 23);
            this.btn_howtouse.TabIndex = 4;
            this.btn_howtouse.Text = "Help!";
            this.toolTip1.SetToolTip(this.btn_howtouse, "Полное описание команд, читов и пасхальных яиц на англ. и русском языке.");
            this.btn_howtouse.UseVisualStyleBackColor = true;
            this.btn_howtouse.Click += new System.EventHandler(this.btn_howtouse_Click);
            // 
            // chbx_nodlg
            // 
            this.chbx_nodlg.AutoSize = true;
            this.chbx_nodlg.BackColor = System.Drawing.Color.Transparent;
            this.chbx_nodlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_nodlg.Location = new System.Drawing.Point(120, 387);
            this.chbx_nodlg.Name = "chbx_nodlg";
            this.chbx_nodlg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbx_nodlg.Size = new System.Drawing.Size(66, 17);
            this.chbx_nodlg.TabIndex = 5;
            this.chbx_nodlg.Text = "nodialog-";
            this.toolTip1.SetToolTip(this.chbx_nodlg, " Пропускает стартовый диалог  Max Payne при загрузке игры.");
            this.chbx_nodlg.UseVisualStyleBackColor = false;
            // 
            // chbx_skipstrtup
            // 
            this.chbx_skipstrtup.AutoSize = true;
            this.chbx_skipstrtup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_skipstrtup.Location = new System.Drawing.Point(12, 364);
            this.chbx_skipstrtup.Name = "chbx_skipstrtup";
            this.chbx_skipstrtup.Size = new System.Drawing.Size(77, 17);
            this.chbx_skipstrtup.TabIndex = 6;
            this.chbx_skipstrtup.Text = "-skipstartup";
            this.toolTip1.SetToolTip(this.chbx_skipstrtup, "Пропускает стартовую анимацию.");
            this.chbx_skipstrtup.UseVisualStyleBackColor = true;
            // 
            // chbx_screenshot
            // 
            this.chbx_screenshot.AutoSize = true;
            this.chbx_screenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_screenshot.Location = new System.Drawing.Point(108, 341);
            this.chbx_screenshot.Name = "chbx_screenshot";
            this.chbx_screenshot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbx_screenshot.Size = new System.Drawing.Size(78, 17);
            this.chbx_screenshot.TabIndex = 7;
            this.chbx_screenshot.Text = "screenshot-";
            this.toolTip1.SetToolTip(this.chbx_screenshot, "Позволяет при нажатии на клавишу F10 делать скриншоты.\r\nСнимки сохраняются в \"scr" +
        "eenshots\" папку, которая лежит в каталоге с  игрой.\r\n\r\n");
            this.chbx_screenshot.UseVisualStyleBackColor = true;
            // 
            // chbx_no3d
            // 
            this.chbx_no3d.AutoSize = true;
            this.chbx_no3d.BackColor = System.Drawing.Color.Transparent;
            this.chbx_no3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_no3d.Location = new System.Drawing.Point(12, 387);
            this.chbx_no3d.Name = "chbx_no3d";
            this.chbx_no3d.Size = new System.Drawing.Size(111, 17);
            this.chbx_no3d.TabIndex = 8;
            this.chbx_no3d.Text = "-disable3dpreloads";
            this.toolTip1.SetToolTip(this.chbx_no3d, "Если система работает и текстурная память кончается \r\nпри загрузке уровня, эта оп" +
        "ция может избежать\r\nзакрытия игры из-за  ошибки драйверов.\r\n");
            this.chbx_no3d.UseVisualStyleBackColor = false;
            // 
            // chbx_runinwindow
            // 
            this.chbx_runinwindow.AutoSize = true;
            this.chbx_runinwindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_runinwindow.Location = new System.Drawing.Point(124, 364);
            this.chbx_runinwindow.Name = "chbx_runinwindow";
            this.chbx_runinwindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbx_runinwindow.Size = new System.Drawing.Size(62, 17);
            this.chbx_runinwindow.TabIndex = 9;
            this.chbx_runinwindow.Text = "window-";
            this.toolTip1.SetToolTip(this.chbx_runinwindow, "Запуск игры в оконном режиме, с выбранным \r\nразрешением из диалогового окна запус" +
        "ка Max Payne.\r\n\r\n Все 3D-ускорители не поддерживают работу в  оконном режиме.");
            this.chbx_runinwindow.UseVisualStyleBackColor = true;
            // 
            // ofdpain
            // 
            this.ofdpain.FileName = "MaxPayne.exe";
            this.ofdpain.Filter = "Max Payne Game File(MaxPayne.exe)|MaxPayne.exe";
            this.ofdpain.ShowReadOnly = true;
            this.ofdpain.SupportMultiDottedExtensions = true;
            this.ofdpain.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdpain_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 407);
            this.Controls.Add(this.chbx_runinwindow);
            this.Controls.Add(this.chbx_no3d);
            this.Controls.Add(this.chbx_screenshot);
            this.Controls.Add(this.chbx_skipstrtup);
            this.Controls.Add(this.chbx_nodlg);
            this.Controls.Add(this.btn_howtouse);
            this.Controls.Add(this.btn_nfo);
            this.Controls.Add(this.btn_loader);
            this.Controls.Add(this.chbx_asdeveloper);
            this.Controls.Add(this.pct_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Payne™ Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.CheckBox chbx_asdeveloper;
        private System.Windows.Forms.Button btn_loader;
        private System.Windows.Forms.Button btn_nfo;
        private System.Windows.Forms.Button btn_howtouse;
        private System.Windows.Forms.CheckBox chbx_nodlg;
        private System.Windows.Forms.CheckBox chbx_skipstrtup;
        private System.Windows.Forms.CheckBox chbx_screenshot;
        private System.Windows.Forms.CheckBox chbx_no3d;
        private System.Windows.Forms.CheckBox chbx_runinwindow;
		private System.Windows.Forms.OpenFileDialog ofdpain;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}

