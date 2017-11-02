namespace Recuerda.me
{
    partial class MyRemindersF
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
            this.reminderInfoGB = new System.Windows.Forms.GroupBox();
            this.remindAtL = new System.Windows.Forms.Label();
            this.triggerTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.enabledCB = new System.Windows.Forms.CheckBox();
            this.contentTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.hourL = new System.Windows.Forms.Label();
            this.contentL = new System.Windows.Forms.Label();
            this.titleL = new System.Windows.Forms.Label();
            this.remindersLV = new System.Windows.Forms.ListView();
            this.titleCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.triggerTimeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enabledCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remindersCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptB = new System.Windows.Forms.Button();
            this.reminderInfoGB.SuspendLayout();
            this.remindersCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminderInfoGB
            // 
            this.reminderInfoGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderInfoGB.Controls.Add(this.remindAtL);
            this.reminderInfoGB.Controls.Add(this.triggerTimeDTP);
            this.reminderInfoGB.Controls.Add(this.enabledCB);
            this.reminderInfoGB.Controls.Add(this.contentTB);
            this.reminderInfoGB.Controls.Add(this.titleTB);
            this.reminderInfoGB.Controls.Add(this.hourL);
            this.reminderInfoGB.Controls.Add(this.contentL);
            this.reminderInfoGB.Controls.Add(this.titleL);
            this.reminderInfoGB.Enabled = false;
            this.reminderInfoGB.Location = new System.Drawing.Point(12, 142);
            this.reminderInfoGB.Name = "reminderInfoGB";
            this.reminderInfoGB.Size = new System.Drawing.Size(510, 164);
            this.reminderInfoGB.TabIndex = 1;
            this.reminderInfoGB.TabStop = false;
            this.reminderInfoGB.Text = "Información del recordatorio";
            // 
            // remindAtL
            // 
            this.remindAtL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remindAtL.AutoSize = true;
            this.remindAtL.Location = new System.Drawing.Point(6, 143);
            this.remindAtL.Name = "remindAtL";
            this.remindAtL.Size = new System.Drawing.Size(76, 13);
            this.remindAtL.TabIndex = 8;
            this.remindAtL.Text = "Recordar a las";
            // 
            // triggerTimeDTP
            // 
            this.triggerTimeDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.triggerTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.triggerTimeDTP.Location = new System.Drawing.Point(88, 138);
            this.triggerTimeDTP.Name = "triggerTimeDTP";
            this.triggerTimeDTP.Size = new System.Drawing.Size(81, 20);
            this.triggerTimeDTP.TabIndex = 7;
            this.triggerTimeDTP.ValueChanged += new System.EventHandler(this.triggerTimeDTP_ValueChanged);
            // 
            // enabledCB
            // 
            this.enabledCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enabledCB.AutoSize = true;
            this.enabledCB.Location = new System.Drawing.Point(436, 139);
            this.enabledCB.Name = "enabledCB";
            this.enabledCB.Size = new System.Drawing.Size(68, 17);
            this.enabledCB.TabIndex = 6;
            this.enabledCB.Text = "Activado";
            this.enabledCB.UseVisualStyleBackColor = true;
            this.enabledCB.CheckedChanged += new System.EventHandler(this.enabledCB_CheckedChanged);
            // 
            // contentTB
            // 
            this.contentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTB.Location = new System.Drawing.Point(9, 58);
            this.contentTB.Multiline = true;
            this.contentTB.Name = "contentTB";
            this.contentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTB.Size = new System.Drawing.Size(495, 73);
            this.contentTB.TabIndex = 4;
            this.contentTB.TextChanged += new System.EventHandler(this.contentTB_TextChanged);
            // 
            // titleTB
            // 
            this.titleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTB.Location = new System.Drawing.Point(47, 19);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(457, 20);
            this.titleTB.TabIndex = 3;
            this.titleTB.TextChanged += new System.EventHandler(this.titleTB_TextChanged);
            // 
            // hourL
            // 
            this.hourL.AutoSize = true;
            this.hourL.Location = new System.Drawing.Point(11, 104);
            this.hourL.Name = "hourL";
            this.hourL.Size = new System.Drawing.Size(33, 13);
            this.hourL.TabIndex = 2;
            this.hourL.Text = "Hora:";
            // 
            // contentL
            // 
            this.contentL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contentL.AutoSize = true;
            this.contentL.Location = new System.Drawing.Point(6, 42);
            this.contentL.Name = "contentL";
            this.contentL.Size = new System.Drawing.Size(58, 13);
            this.contentL.TabIndex = 1;
            this.contentL.Text = "Contenido:";
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.Location = new System.Drawing.Point(6, 22);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(38, 13);
            this.titleL.TabIndex = 0;
            this.titleL.Text = "Título:";
            // 
            // remindersLV
            // 
            this.remindersLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remindersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleCH,
            this.contentCH,
            this.triggerTimeCH,
            this.enabledCH});
            this.remindersLV.ContextMenuStrip = this.remindersCMS;
            this.remindersLV.FullRowSelect = true;
            this.remindersLV.HideSelection = false;
            this.remindersLV.Location = new System.Drawing.Point(12, 12);
            this.remindersLV.Name = "remindersLV";
            this.remindersLV.Size = new System.Drawing.Size(512, 124);
            this.remindersLV.TabIndex = 2;
            this.remindersLV.UseCompatibleStateImageBehavior = false;
            this.remindersLV.View = System.Windows.Forms.View.Details;
            this.remindersLV.SelectedIndexChanged += new System.EventHandler(this.remindersLV_SelectedIndexChanged);
            // 
            // titleCH
            // 
            this.titleCH.Text = "Título";
            this.titleCH.Width = 129;
            // 
            // contentCH
            // 
            this.contentCH.Text = "Contenido";
            this.contentCH.Width = 198;
            // 
            // triggerTimeCH
            // 
            this.triggerTimeCH.Text = "Fecha y hora";
            this.triggerTimeCH.Width = 123;
            // 
            // enabledCH
            // 
            this.enabledCH.Text = "Activado";
            this.enabledCH.Width = 56;
            // 
            // remindersCMS
            // 
            this.remindersCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTSMI,
            this.removeTSMI});
            this.remindersCMS.Name = "remindersCMS";
            this.remindersCMS.Size = new System.Drawing.Size(186, 48);
            // 
            // clearTSMI
            // 
            this.clearTSMI.Name = "clearTSMI";
            this.clearTSMI.Size = new System.Drawing.Size(185, 22);
            this.clearTSMI.Text = "Vaciar lista";
            this.clearTSMI.Click += new System.EventHandler(this.clearTSMI_Click);
            // 
            // removeTSMI
            // 
            this.removeTSMI.Enabled = false;
            this.removeTSMI.Name = "removeTSMI";
            this.removeTSMI.Size = new System.Drawing.Size(185, 22);
            this.removeTSMI.Text = "Eliminar recordatorio";
            this.removeTSMI.Click += new System.EventHandler(this.removeTSMI_Click);
            // 
            // acceptB
            // 
            this.acceptB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptB.Location = new System.Drawing.Point(447, 316);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(75, 23);
            this.acceptB.TabIndex = 3;
            this.acceptB.Text = "Aceptar";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // MyRemindersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 351);
            this.Controls.Add(this.acceptB);
            this.Controls.Add(this.remindersLV);
            this.Controls.Add(this.reminderInfoGB);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "MyRemindersF";
            this.Text = "Mis recordatorios";
            this.Load += new System.EventHandler(this.MyRemindersF_Load);
            this.reminderInfoGB.ResumeLayout(false);
            this.reminderInfoGB.PerformLayout();
            this.remindersCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox reminderInfoGB;
        private System.Windows.Forms.ListView remindersLV;
        private System.Windows.Forms.Label hourL;
        private System.Windows.Forms.Label contentL;
        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.ColumnHeader titleCH;
        private System.Windows.Forms.ColumnHeader contentCH;
        private System.Windows.Forms.ColumnHeader triggerTimeCH;
        private System.Windows.Forms.ColumnHeader enabledCH;
        private System.Windows.Forms.CheckBox enabledCB;
        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.ContextMenuStrip remindersCMS;
        private System.Windows.Forms.ToolStripMenuItem clearTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeTSMI;
        private System.Windows.Forms.DateTimePicker triggerTimeDTP;
        private System.Windows.Forms.Label remindAtL;
        private System.Windows.Forms.Button acceptB;
    }
}