﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recuerda.me
{
    public partial class NotifyF : Form
    {
        public NotifyF(string title, string text) {
            InitializeComponent();
            this.Text = title;
            notificationL.Text = text;
        }
        private void NotifyF_Load(object sender, EventArgs e) {
            this.Activate();
        }

        private void acceptB_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void copyContentTSMI_Click(object sender, EventArgs e) {
            Clipboard.SetText(notificationL.Text);
        }
    }
}
