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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.remindTimingTB = new System.Windows.Forms.TextBox();
            this.remindTimingCB = new System.Windows.Forms.ComboBox();
            this.reminderTitleTB = new System.Windows.Forms.TextBox();
            this.reminderTextTB = new System.Windows.Forms.TextBox();
            this.reminderL = new System.Windows.Forms.Label();
            this.remindTimingRB = new System.Windows.Forms.RadioButton();
            this.remindTimeRB = new System.Windows.Forms.RadioButton();
            this.remindTimeTB = new System.Windows.Forms.TextBox();
            this.reminderT = new System.Windows.Forms.Timer(this.components);
            this.remindB = new System.Windows.Forms.Button();
            this.lonamiwebsLL = new System.Windows.Forms.LinkLabel();
            this.tipTT = new System.Windows.Forms.ToolTip(this.components);
            this.reminderNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.remindmeNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkUpdatesB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remindTimingTB
            // 
            this.remindTimingTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTimingTB.Location = new System.Drawing.Point(119, 12);
            this.remindTimingTB.MaxLength = 10;
            this.remindTimingTB.Name = "remindTimingTB";
            this.remindTimingTB.Size = new System.Drawing.Size(53, 20);
            this.remindTimingTB.TabIndex = 0;
            this.tipTT.SetToolTip(this.remindTimingTB, "Introduzca un número que indique el\r\ntiempo en el que desee que se le recuerde.\r\n" +
        "Por ejemplo, 5");
            this.remindTimingTB.TextChanged += new System.EventHandler(this.remindTimingTB_TextChanged);
            // 
            // remindTimingCB
            // 
            this.remindTimingCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTimingCB.AutoCompleteCustomSource.AddRange(new string[] {
            "hora(s)",
            "minuto(s)",
            "segundo(s)"});
            this.remindTimingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remindTimingCB.FormattingEnabled = true;
            this.remindTimingCB.Items.AddRange(new object[] {
            "segundo(s)",
            "minuto(s)",
            "hora(s)"});
            this.remindTimingCB.Location = new System.Drawing.Point(178, 11);
            this.remindTimingCB.Name = "remindTimingCB";
            this.remindTimingCB.Size = new System.Drawing.Size(67, 21);
            this.remindTimingCB.TabIndex = 2;
            this.tipTT.SetToolTip(this.remindTimingCB, "Seleccione en que se va a medir el tiempo\r\nen el que debe esperar para que le rec" +
        "uerde");
            // 
            // reminderTitleTB
            // 
            this.reminderTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderTitleTB.Location = new System.Drawing.Point(12, 92);
            this.reminderTitleTB.Name = "reminderTitleTB";
            this.reminderTitleTB.Size = new System.Drawing.Size(233, 20);
            this.reminderTitleTB.TabIndex = 3;
            this.tipTT.SetToolTip(this.reminderTitleTB, "Título del recordatorio. Puede estar vacío.");
            // 
            // reminderTextTB
            // 
            this.reminderTextTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderTextTB.Location = new System.Drawing.Point(12, 118);
            this.reminderTextTB.Multiline = true;
            this.reminderTextTB.Name = "reminderTextTB";
            this.reminderTextTB.Size = new System.Drawing.Size(233, 75);
            this.reminderTextTB.TabIndex = 4;
            this.tipTT.SetToolTip(this.reminderTextTB, "Contenido del recordatorio. Puede estar vacío.");
            // 
            // reminderL
            // 
            this.reminderL.AutoSize = true;
            this.reminderL.Location = new System.Drawing.Point(12, 76);
            this.reminderL.Name = "reminderL";
            this.reminderL.Size = new System.Drawing.Size(71, 13);
            this.reminderL.TabIndex = 5;
            this.reminderL.Text = "Recordatorio:";
            // 
            // remindTimingRB
            // 
            this.remindTimingRB.AutoSize = true;
            this.remindTimingRB.Checked = true;
            this.remindTimingRB.Location = new System.Drawing.Point(12, 12);
            this.remindTimingRB.Name = "remindTimingRB";
            this.remindTimingRB.Size = new System.Drawing.Size(101, 17);
            this.remindTimingRB.TabIndex = 6;
            this.remindTimingRB.TabStop = true;
            this.remindTimingRB.Text = "Recuérdame en";
            this.remindTimingRB.UseVisualStyleBackColor = true;
            this.remindTimingRB.CheckedChanged += new System.EventHandler(this.remindTimingRB_CheckedChanged);
            // 
            // remindTimeRB
            // 
            this.remindTimeRB.AutoSize = true;
            this.remindTimeRB.Location = new System.Drawing.Point(12, 38);
            this.remindTimeRB.Name = "remindTimeRB";
            this.remindTimeRB.Size = new System.Drawing.Size(111, 17);
            this.remindTimeRB.TabIndex = 7;
            this.remindTimeRB.Text = "Recuérdame a las";
            this.remindTimeRB.UseVisualStyleBackColor = true;
            // 
            // remindTimeTB
            // 
            this.remindTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTimeTB.Enabled = false;
            this.remindTimeTB.Location = new System.Drawing.Point(129, 37);
            this.remindTimeTB.MaxLength = 8;
            this.remindTimeTB.Name = "remindTimeTB";
            this.remindTimeTB.Size = new System.Drawing.Size(116, 20);
            this.remindTimeTB.TabIndex = 8;
            this.tipTT.SetToolTip(this.remindTimeTB, "Introduzca un formato de hora válido\r\nen el cual desee que se le recuerde.\r\nUtili" +
        "ze los dos puntos, como ejemplos:\r\n18:02:30\r\n13:05");
            this.remindTimeTB.TextChanged += new System.EventHandler(this.remindTimeTB_TextChanged);
            // 
            // reminderT
            // 
            this.reminderT.Interval = 500;
            this.reminderT.Tick += new System.EventHandler(this.reminderT_Tick);
            // 
            // remindB
            // 
            this.remindB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindB.Location = new System.Drawing.Point(146, 199);
            this.remindB.Name = "remindB";
            this.remindB.Size = new System.Drawing.Size(96, 23);
            this.remindB.TabIndex = 9;
            this.remindB.Text = "¡Recuérdamelo!";
            this.remindB.UseVisualStyleBackColor = true;
            this.remindB.Click += new System.EventHandler(this.remindB_Click);
            // 
            // lonamiwebsLL
            // 
            this.lonamiwebsLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lonamiwebsLL.AutoSize = true;
            this.lonamiwebsLL.Location = new System.Drawing.Point(12, 204);
            this.lonamiwebsLL.Name = "lonamiwebsLL";
            this.lonamiwebsLL.Size = new System.Drawing.Size(86, 13);
            this.lonamiwebsLL.TabIndex = 10;
            this.lonamiwebsLL.TabStop = true;
            this.lonamiwebsLL.Text = "lonamiwebs.github.io";
            this.lonamiwebsLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lonamiwebsLL_LinkClicked);
            // 
            // tipTT
            // 
            this.tipTT.AutomaticDelay = 100;
            this.tipTT.AutoPopDelay = 4000;
            this.tipTT.InitialDelay = 300;
            this.tipTT.ReshowDelay = 20;
            // 
            // reminderNI
            // 
            this.reminderNI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.reminderNI.BalloonTipText = "Si no te acuerdas de lo que deberías recordar,\r\n¡deberías haberlo puesto en el te" +
    "xto del recordatorio!";
            this.reminderNI.BalloonTipTitle = "¡Ahora mismo deberías acordarte de algo!";
            this.reminderNI.Icon = ((System.Drawing.Icon)(resources.GetObject("reminderNI.Icon")));
            this.reminderNI.Text = "Recuerda.me";
            this.reminderNI.Click += new System.EventHandler(this.reminderNI_Click);
            // 
            // remindmeNI
            // 
            this.remindmeNI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.remindmeNI.BalloonTipText = "Haga clic en este globo para volver a Remind.me\r\ny detener el recordatorio actual" +
    ", o modificarlo";
            this.remindmeNI.BalloonTipTitle = "Remind.me está esperando";
            this.remindmeNI.Icon = ((System.Drawing.Icon)(resources.GetObject("remindmeNI.Icon")));
            this.remindmeNI.Text = "Remind.me está esperando ";
            this.remindmeNI.BalloonTipClicked += new System.EventHandler(this.remindmeNI_BalloonTipClicked);
            this.remindmeNI.Click += new System.EventHandler(this.remindmeNI_Click);
            // 
            // checkUpdatesB
            // 
            this.checkUpdatesB.Location = new System.Drawing.Point(102, 63);
            this.checkUpdatesB.Name = "checkUpdatesB";
            this.checkUpdatesB.Size = new System.Drawing.Size(143, 23);
            this.checkUpdatesB.TabIndex = 11;
            this.checkUpdatesB.Text = "Comprobar actualizaciones";
            this.checkUpdatesB.UseVisualStyleBackColor = true;
            this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.checkUpdatesB);
            this.Controls.Add(this.lonamiwebsLL);
            this.Controls.Add(this.remindB);
            this.Controls.Add(this.remindTimeTB);
            this.Controls.Add(this.remindTimeRB);
            this.Controls.Add(this.remindTimingRB);
            this.Controls.Add(this.reminderL);
            this.Controls.Add(this.reminderTextTB);
            this.Controls.Add(this.reminderTitleTB);
            this.Controls.Add(this.remindTimingCB);
            this.Controls.Add(this.remindTimingTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(270, 270);
            this.Name = "MainF";
            this.Text = "Recuerda.me";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remindTimingTB;
        private System.Windows.Forms.ComboBox remindTimingCB;
        private System.Windows.Forms.TextBox reminderTitleTB;
        private System.Windows.Forms.TextBox reminderTextTB;
        private System.Windows.Forms.Label reminderL;
        private System.Windows.Forms.RadioButton remindTimingRB;
        private System.Windows.Forms.RadioButton remindTimeRB;
        private System.Windows.Forms.TextBox remindTimeTB;
        private System.Windows.Forms.Timer reminderT;
        private System.Windows.Forms.Button remindB;
        private System.Windows.Forms.LinkLabel lonamiwebsLL;
        private System.Windows.Forms.ToolTip tipTT;
        private System.Windows.Forms.NotifyIcon reminderNI;
        private System.Windows.Forms.NotifyIcon remindmeNI;
        private System.Windows.Forms.Button checkUpdatesB;
    }
}

