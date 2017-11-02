using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using Utils;

namespace Recuerda.me
{
    public partial class MainF : Form
    {

        #region Setup

        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            remindTimingCB.SelectedIndex = 1;
        }

        private void lonamiwebsLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://lonamiwebs.github.io");
        }

        #endregion

        #region Check Checked

        private void remindTimingRB_CheckedChanged(object sender, EventArgs e)
        {
            CheckChecked();
        }

        void CheckChecked() {
            if (remindTimeRB.Checked) {
                remindTimingTB.Enabled = false;
                remindTimingCB.Enabled = false;
                remindTimeTB.Enabled = true;
            } else {
                remindTimingTB.Enabled = true;
                remindTimingCB.Enabled = true;
                remindTimeTB.Enabled = false;
            }
        }

        #endregion

        #region Check valid

        bool IsPositiveNum(string text)
        {
            if (IsNum(text))
                return Double.Parse(text) > 0;
            return false;
        }

        bool IsNum(string text)
        {
            double num;
            return Double.TryParse(text, out num);
        }

        bool CheckValid()
        {
            if (remindTimingRB.Checked)
                return IsPositiveNum(remindTimingTB.Text);
            else
                return HourRetriever.ContainsHourAndSeconds(remindTimeTB.Text)
                    || HourRetriever.ContainsHourNoSeconds(remindTimeTB.Text);
        }

        private void remindTimingTB_TextChanged(object sender, EventArgs e)
        {
            remindTimingTB.BackColor = Color.White;
        }

        private void remindTimeTB_TextChanged(object sender, EventArgs e)
        {
            remindTimeTB.BackColor = Color.White;
        }

        #endregion

        #region Start Reminder

        private void remindB_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (reminderTitleTB.Text != "")
                    reminderNI.BalloonTipTitle = reminderTitleTB.Text;
                if (reminderTextTB.Text != "")
                    reminderNI.BalloonTipText = reminderTextTB.Text;

                HideForm();
                StartReminder();
            }
            else
            {
                if (remindTimingRB.Checked)
                    remindTimingTB.BackColor = Color.Salmon;
                else
                    remindTimeTB.BackColor = Color.Salmon;
            }
        }

        #endregion

        #region Hide and show form

        void HideForm() {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            remindmeNI.Visible = true;
        }

        void ShowForm() {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            remindmeNI.Visible = false;
        }

        private void remindmeNI_Click(object sender, EventArgs e)
        {
            remindmeNI.ShowBalloonTip(10000);
        }

        private void remindmeNI_BalloonTipClicked(object sender, EventArgs e)
        {
            StopReminder();
            ShowForm();
        }

        #endregion

        #region Reminder

        void StartReminder() {
            if (remindTimingRB.Checked)
            {
                countdown = Double.Parse(remindTimingTB.Text, CultureInfo.InvariantCulture)
                    * Math.Pow(60, remindTimingCB.SelectedIndex);
            }
            else
            {
                dt = HourRetriever.RetrieveHourFromString(remindTimeTB.Text);
                remindmeNI.Text = "Remind.me está esperando hasta las " + dt.ToString("HH:mm:ss");
            }

            reminderT.Enabled = true;
        }

        void StopReminder()
        {
            if (countdown > -1)
            {
                remindTimingTB.Text = countdown.ToString();
                remindTimingCB.SelectedIndex = 0;
            }

            reminderT.Enabled = false;
        }

        DateTime dt = new DateTime(1, 1, 1);
        double seconds = 0;
        double countdown = -1;

        private void reminderT_Tick(object sender, EventArgs e)
        {
            seconds += 0.5;
            CheckReminder();
        }

        void CheckReminder() {
            if (countdown > -1)
            {
                countdown -= 0.5;

                TimeSpan ts = TimeSpan.FromSeconds(countdown);
                if (ts.Hours > 0)
                    remindmeNI.Text = "Remind.me: esperando " + ts.Hours + " hora(s), " +
                        ts.Minutes + " minuto(s) y " + ts.Seconds + " segundo(s)";
                else if (ts.Minutes > 0)
                    remindmeNI.Text = "Remind.me está esperando " + ts.Minutes +
                        " minuto(s) y " + ts.Seconds + " segundo(s)";
                else
                    remindmeNI.Text = "Remind.me está esperando " + ts.Seconds + " segundo(s)";

                if (countdown <= 0)
                    Notify();
            }
            else
            {
                DateTime n = DateTime.Now;
                if (dt.Hour == n.Hour && dt.Minute == n.Minute && dt.Second == n.Second)
                    Notify();
            }
        }

        void Notify() {
            reminderNI.Visible = true;
            remindmeNI.Visible = false;
            reminderT.Enabled = false;
            reminderNI.ShowBalloonTip(10000);

            var player = new SoundPlayer();
            player.Stream = Properties.Resources.notification;
            player.Play();
        }

        private void reminderNI_Click(object sender, EventArgs e)
        {
            reminderNI.Visible = false;
            new NotifyF(reminderNI.BalloonTipText, reminderNI.BalloonTipTitle).Show();
        }

        #endregion

        private void checkUpdatesB_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "rem").Show();
        }
    }
}
