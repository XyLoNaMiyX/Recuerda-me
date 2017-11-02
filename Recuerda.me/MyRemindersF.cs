using System;
using System.IO;
using System.Windows.Forms;

namespace Recuerda.me
{
    public partial class MyRemindersF : Form
    {
        public MyRemindersF() {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        void MyRemindersF_Load(object sender, EventArgs e) {
            RefreshReminders();
        }

        #region Refresh

        public void RefreshReminders()
        {
            C.SaveRemindersFile();

            Latency.reminders.Clear();
            remindersLV.Items.Clear();

            string[] parsedReminders = File.ReadAllLines(C.RemindersPath);
            foreach (var parsedReminder in parsedReminders)
                if (!String.IsNullOrEmpty(parsedReminder))
                    Latency.reminders.Add(C.Reminder.Unparse(parsedReminder));

            foreach (var reminder in Latency.reminders)
                remindersLV.Items.Add(new ListViewItem(new string[] { reminder.Title, reminder.Content,
                    reminder.TriggerTime.ToString(), reminder.IsChecking ? "Sí" : "No"}));
        }

        void remindersLV_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshInfo();
        }

        void RefreshInfo() {
            int c = remindersLV.SelectedIndices.Count;
            removeTSMI.Enabled = c > 0;
            reminderInfoGB.Enabled = c == 1;

            if (reminderInfoGB.Enabled) {
                rlvindex = remindersLV.SelectedIndices[0];
                titleTB.Text = Latency.reminders[rlvindex].Title;
                contentTB.Text = Latency.reminders[rlvindex].Content;
                enabledCB.Checked = Latency.reminders[rlvindex].IsChecking;
                triggerTimeDTP.Value = Latency.reminders[rlvindex].TriggerTime;
            }
        }

        #endregion

        #region Remove

        void clearTSMI_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esto eliminará todos los recordatorios. ¿Estás seguro?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            for (int i = 0; i < Latency.reminders.Count; i++)
                Latency.reminders[i].Notified = true;

            RefreshReminders();
            RefreshInfo();
        }

        int rlvindex;
        void removeTSMI_Click(object sender, EventArgs e) {
            foreach (int i in remindersLV.SelectedIndices)
                Latency.reminders[i].Notified = true;

            RefreshReminders();
            RefreshInfo();
        }

        #endregion

        private void titleTB_TextChanged(object sender, EventArgs e) {
            Latency.reminders[rlvindex].Title = titleTB.Text;
            RefreshReminders();
        }

        private void contentTB_TextChanged(object sender, EventArgs e) {
            Latency.reminders[rlvindex].Content = contentTB.Text;
            RefreshReminders();
        }

        private void hourTB_TextChanged(object sender, EventArgs e) {
            RefreshReminders();
        }

        private void enabledCB_CheckedChanged(object sender, EventArgs e) {
            Latency.reminders[rlvindex].IsChecking = enabledCB.Checked;
            RefreshReminders();
        }

        private void triggerTimeDTP_ValueChanged(object sender, EventArgs e) {
            Latency.reminders[rlvindex].TriggerTime = triggerTimeDTP.Value;
            RefreshReminders();
        }

        private void acceptB_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
