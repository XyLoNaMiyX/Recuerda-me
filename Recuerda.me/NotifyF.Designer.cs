namespace Recuerda.me
{
    partial class NotifyF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyF));
            this.acceptB = new System.Windows.Forms.Button();
            this.notificationL = new System.Windows.Forms.Label();
            this.menuCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyContentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptB
            // 
            this.acceptB.Location = new System.Drawing.Point(414, 226);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(58, 23);
            this.acceptB.TabIndex = 0;
            this.acceptB.Text = "Aceptar";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // notificationL
            // 
            this.notificationL.AutoSize = true;
            this.notificationL.ContextMenuStrip = this.menuCMS;
            this.notificationL.Location = new System.Drawing.Point(13, 13);
            this.notificationL.MaximumSize = new System.Drawing.Size(470, 200);
            this.notificationL.Name = "notificationL";
            this.notificationL.Size = new System.Drawing.Size(63, 13);
            this.notificationL.TabIndex = 1;
            this.notificationL.Text = "Notificación";
            // 
            // menuCMS
            // 
            this.menuCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyContentTSMI});
            this.menuCMS.Name = "menuCMS";
            this.menuCMS.Size = new System.Drawing.Size(167, 48);
            // 
            // copyContentTSMI
            // 
            this.copyContentTSMI.Name = "copyContentTSMI";
            this.copyContentTSMI.Size = new System.Drawing.Size(166, 22);
            this.copyContentTSMI.Text = "Copiar contenido";
            this.copyContentTSMI.Click += new System.EventHandler(this.copyContentTSMI_Click);
            // 
            // NotifyF
            // 
            this.AcceptButton = this.acceptB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.ContextMenuStrip = this.menuCMS;
            this.ControlBox = false;
            this.Controls.Add(this.notificationL);
            this.Controls.Add(this.acceptB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotifyF";
            this.Text = "Notificación";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotifyF_Load);
            this.menuCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptB;
        private System.Windows.Forms.Label notificationL;
        private System.Windows.Forms.ContextMenuStrip menuCMS;
        private System.Windows.Forms.ToolStripMenuItem copyContentTSMI;
    }
}