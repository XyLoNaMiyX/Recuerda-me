namespace Recuerda.me
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reminderTitleTB = new System.Windows.Forms.TextBox();
            this.reminderContentTB = new System.Windows.Forms.TextBox();
            this.reminderL = new System.Windows.Forms.Label();
            this.remindB = new System.Windows.Forms.Button();
            this.menuMS = new System.Windows.Forms.MenuStrip();
            this.remindMeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.myRemindersTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithWinTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.remindMeAtDTP = new System.Windows.Forms.DateTimePicker();
            this.remindMeAtL = new System.Windows.Forms.Label();
            this.reminderContentL = new System.Windows.Forms.Label();
            this.trayNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openRemindMeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyRemindersTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusSS = new System.Windows.Forms.StatusStrip();
            this.infoTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMS.SuspendLayout();
            this.trayCMS.SuspendLayout();
            this.statusSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminderTitleTB
            // 
            this.reminderTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderTitleTB.Location = new System.Drawing.Point(89, 34);
            this.reminderTitleTB.Name = "reminderTitleTB";
            this.reminderTitleTB.Size = new System.Drawing.Size(295, 20);
            this.reminderTitleTB.TabIndex = 3;
            this.reminderTitleTB.TextChanged += new System.EventHandler(this.ResetInfo);
            this.reminderTitleTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reminderTitleTB_KeyDown);
            // 
            // reminderContentTB
            // 
            this.reminderContentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderContentTB.Location = new System.Drawing.Point(89, 60);
            this.reminderContentTB.Multiline = true;
            this.reminderContentTB.Name = "reminderContentTB";
            this.reminderContentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reminderContentTB.Size = new System.Drawing.Size(483, 35);
            this.reminderContentTB.TabIndex = 4;
            this.reminderContentTB.TextChanged += new System.EventHandler(this.ResetInfo);
            // 
            // reminderL
            // 
            this.reminderL.AutoSize = true;
            this.reminderL.Location = new System.Drawing.Point(12, 37);
            this.reminderL.Name = "reminderL";
            this.reminderL.Size = new System.Drawing.Size(71, 13);
            this.reminderL.TabIndex = 5;
            this.reminderL.Text = "Recordatorio:";
            // 
            // remindB
            // 
            this.remindB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remindB.Location = new System.Drawing.Point(12, 101);
            this.remindB.Name = "remindB";
            this.remindB.Size = new System.Drawing.Size(560, 35);
            this.remindB.TabIndex = 9;
            this.remindB.Text = "¡Recuérdamelo!";
            this.remindB.UseVisualStyleBackColor = true;
            this.remindB.Click += new System.EventHandler(this.remindB_Click);
            // 
            // menuMS
            // 
            this.menuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remindMeTSMI,
            this.settingsTSMI,
            this.helpTSMI});
            this.menuMS.Location = new System.Drawing.Point(0, 0);
            this.menuMS.Name = "menuMS";
            this.menuMS.Size = new System.Drawing.Size(584, 24);
            this.menuMS.TabIndex = 12;
            // 
            // remindMeTSMI
            // 
            this.remindMeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myRemindersTSMI});
            this.remindMeTSMI.Name = "remindMeTSMI";
            this.remindMeTSMI.Size = new System.Drawing.Size(88, 20);
            this.remindMeTSMI.Text = "Recuerda.me";
            this.remindMeTSMI.DropDownOpening += new System.EventHandler(this.remindMeTSMI_DropDownOpening);
            // 
            // myRemindersTSMI
            // 
            this.myRemindersTSMI.Name = "myRemindersTSMI";
            this.myRemindersTSMI.Size = new System.Drawing.Size(166, 22);
            this.myRemindersTSMI.Text = "Mis recordatorios";
            this.myRemindersTSMI.Click += new System.EventHandler(this.myRemindersTSMI_Click);
            // 
            // settingsTSMI
            // 
            this.settingsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWithWinTSMI,
            this.minimizeToTrayTSMI});
            this.settingsTSMI.Name = "settingsTSMI";
            this.settingsTSMI.Size = new System.Drawing.Size(57, 20);
            this.settingsTSMI.Text = "Ajustes";
            // 
            // startWithWinTSMI
            // 
            this.startWithWinTSMI.Checked = true;
            this.startWithWinTSMI.CheckOnClick = true;
            this.startWithWinTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startWithWinTSMI.Name = "startWithWinTSMI";
            this.startWithWinTSMI.Size = new System.Drawing.Size(252, 22);
            this.startWithWinTSMI.Text = "Iniciar con Windows";
            this.startWithWinTSMI.CheckedChanged += new System.EventHandler(this.startWithWinTSMI_CheckedChanged);
            this.startWithWinTSMI.Click += new System.EventHandler(this.startWithWinTSMI_Click);
            // 
            // minimizeToTrayTSMI
            // 
            this.minimizeToTrayTSMI.Checked = global::Recuerda.me.Properties.Settings.Default.minimizeToTray;
            this.minimizeToTrayTSMI.CheckOnClick = true;
            this.minimizeToTrayTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeToTrayTSMI.Name = "minimizeToTrayTSMI";
            this.minimizeToTrayTSMI.Size = new System.Drawing.Size(252, 22);
            this.minimizeToTrayTSMI.Text = "Minimizar a la bandeja de entrada";
            this.minimizeToTrayTSMI.Click += new System.EventHandler(this.minimizeToTrayTSMI_Click);
            // 
            // helpTSMI
            // 
            this.helpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpdatesTSMI,
            this.supportTSMI});
            this.helpTSMI.Name = "helpTSMI";
            this.helpTSMI.Size = new System.Drawing.Size(53, 20);
            this.helpTSMI.Text = "Ayuda";
            // 
            // checkUpdatesTSMI
            // 
            this.checkUpdatesTSMI.Name = "checkUpdatesTSMI";
            this.checkUpdatesTSMI.Size = new System.Drawing.Size(218, 22);
            this.checkUpdatesTSMI.Text = "Comprobar actualizaciones";
            this.checkUpdatesTSMI.Click += new System.EventHandler(this.checkUpdatesTSMI_Click);
            // 
            // supportTSMI
            // 
            this.supportTSMI.Name = "supportTSMI";
            this.supportTSMI.Size = new System.Drawing.Size(218, 22);
            this.supportTSMI.Text = "Soporte";
            this.supportTSMI.Click += new System.EventHandler(this.supportTSMI_Click);
            // 
            // remindMeAtDTP
            // 
            this.remindMeAtDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remindMeAtDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.remindMeAtDTP.Location = new System.Drawing.Point(489, 34);
            this.remindMeAtDTP.Name = "remindMeAtDTP";
            this.remindMeAtDTP.Size = new System.Drawing.Size(83, 20);
            this.remindMeAtDTP.TabIndex = 13;
            this.remindMeAtDTP.ValueChanged += new System.EventHandler(this.ResetInfo);
            // 
            // remindMeAtL
            // 
            this.remindMeAtL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remindMeAtL.AutoSize = true;
            this.remindMeAtL.Location = new System.Drawing.Point(390, 37);
            this.remindMeAtL.Name = "remindMeAtL";
            this.remindMeAtL.Size = new System.Drawing.Size(93, 13);
            this.remindMeAtL.TabIndex = 14;
            this.remindMeAtL.Text = "Recuérdame a las";
            // 
            // reminderContentL
            // 
            this.reminderContentL.AutoSize = true;
            this.reminderContentL.Location = new System.Drawing.Point(12, 63);
            this.reminderContentL.Name = "reminderContentL";
            this.reminderContentL.Size = new System.Drawing.Size(72, 26);
            this.reminderContentL.TabIndex = 15;
            this.reminderContentL.Text = "Contenido del\r\nrecordatorio:";
            // 
            // trayNI
            // 
            this.trayNI.BalloonTipText = "¡Recuerda.me te notificará en el momento!\r\nNo tienes que preocuparte más por reco" +
    "rdar algo.\r\n\r\n¡No cierres Recuerda.me o no serás notificado!";
            this.trayNI.BalloonTipTitle = "Recuerda.me está funcionando";
            this.trayNI.ContextMenuStrip = this.trayCMS;
            this.trayNI.Text = "Recuerda.me";
            this.trayNI.BalloonTipClicked += new System.EventHandler(this.trayNI_BalloonTipClicked);
            this.trayNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayNI_MouseClick);
            // 
            // trayCMS
            // 
            this.trayCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRemindMeTSMI,
            this.viewMyRemindersTSMI,
            this.tss1,
            this.exitTSMI});
            this.trayCMS.Name = "trayCMS";
            this.trayCMS.Size = new System.Drawing.Size(187, 76);
            this.trayCMS.Opening += new System.ComponentModel.CancelEventHandler(this.trayCMS_Opening);
            // 
            // openRemindMeTSMI
            // 
            this.openRemindMeTSMI.Name = "openRemindMeTSMI";
            this.openRemindMeTSMI.Size = new System.Drawing.Size(186, 22);
            this.openRemindMeTSMI.Text = "Abrir Recuerda.me";
            this.openRemindMeTSMI.Click += new System.EventHandler(this.openRemindMeTSMI_Click);
            // 
            // viewMyRemindersTSMI
            // 
            this.viewMyRemindersTSMI.Name = "viewMyRemindersTSMI";
            this.viewMyRemindersTSMI.Size = new System.Drawing.Size(186, 22);
            this.viewMyRemindersTSMI.Text = "Ver mis recordatorios";
            this.viewMyRemindersTSMI.Click += new System.EventHandler(this.myRemindersTSMI_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(186, 22);
            this.exitTSMI.Text = "Salir";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // statusSS
            // 
            this.statusSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTSSL});
            this.statusSS.Location = new System.Drawing.Point(0, 139);
            this.statusSS.Name = "statusSS";
            this.statusSS.Size = new System.Drawing.Size(584, 22);
            this.statusSS.TabIndex = 17;
            // 
            // infoTSSL
            // 
            this.infoTSSL.ForeColor = System.Drawing.Color.Purple;
            this.infoTSSL.Name = "infoTSSL";
            this.infoTSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.statusSS);
            this.Controls.Add(this.reminderContentL);
            this.Controls.Add(this.remindMeAtL);
            this.Controls.Add(this.remindMeAtDTP);
            this.Controls.Add(this.remindB);
            this.Controls.Add(this.reminderL);
            this.Controls.Add(this.reminderContentTB);
            this.Controls.Add(this.reminderTitleTB);
            this.Controls.Add(this.menuMS);
            this.MainMenuStrip = this.menuMS;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainF";
            this.Text = "Recuerda.me 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
            this.Load += new System.EventHandler(this.MainF_Load);
            this.Resize += new System.EventHandler(this.MainF_Resize);
            this.menuMS.ResumeLayout(false);
            this.menuMS.PerformLayout();
            this.trayCMS.ResumeLayout(false);
            this.statusSS.ResumeLayout(false);
            this.statusSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reminderTitleTB;
        private System.Windows.Forms.TextBox reminderContentTB;
        private System.Windows.Forms.Label reminderL;
        private System.Windows.Forms.Button remindB;
        private System.Windows.Forms.MenuStrip menuMS;
        private System.Windows.Forms.ToolStripMenuItem remindMeTSMI;
        private System.Windows.Forms.ToolStripMenuItem myRemindersTSMI;
        private System.Windows.Forms.ToolStripMenuItem settingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem startWithWinTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpTSMI;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem supportTSMI;
        private System.Windows.Forms.DateTimePicker remindMeAtDTP;
        private System.Windows.Forms.Label remindMeAtL;
        private System.Windows.Forms.Label reminderContentL;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayTSMI;
        private System.Windows.Forms.NotifyIcon trayNI;
        private System.Windows.Forms.ContextMenuStrip trayCMS;
        private System.Windows.Forms.ToolStripMenuItem openRemindMeTSMI;
        private System.Windows.Forms.ToolStripMenuItem viewMyRemindersTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.StatusStrip statusSS;
        private System.Windows.Forms.ToolStripStatusLabel infoTSSL;
    }
}

