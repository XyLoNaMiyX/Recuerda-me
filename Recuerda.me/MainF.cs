using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Recuerda.me
{
    public partial class MainF : Form
    {

        #region Setup

        public MainF(bool minimized) {
            InitializeComponent();
            trayNI.Icon = Icon = Properties.Resources.icon;
            if (minimized)
                ChangeDisplay(false);
        }

        void MainF_Load(object sender, EventArgs e) {
            CheckStartWidthWindows();
            remindMeAtDTP.MinDate = DateTime.Now;
            remindMeAtDTP.Value = DateTime.Now.AddMinutes(5);

            int c = Latency.reminders.Count;
            string reminders = c == 1 ? "recordatorio" : "recordatorios";
            infoTSSL.Text = "Recuerda.me ha cargado " + c + " " + reminders + " correctamente.";
        }

        #endregion

        #region Start with Windows

        void CheckStartWidthWindows() {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                (@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (startWithWinTSMI.Checked)
                rk.SetValue("Recuerda.me", Application.ExecutablePath.ToString() + " -m");
            else
                rk.DeleteValue("Recuerda.me", false);
        }

        #endregion

        #region Add Reminder

        void remindB_Click(object sender, EventArgs e) {
            AddReminder();
            reminderTitleTB.Text = reminderContentTB.Text = "";
            infoTSSL.Text = "¡Se ha añadido un nuevo recordatorio correctamente!";
        }

        void AddReminder() {
            Directory.CreateDirectory(C.RemindersFolder);
            if (!File.Exists(C.RemindersPath))
                File.Create(C.RemindersPath);

            C.Reminder r = new C.Reminder(reminderTitleTB.Text, reminderContentTB.Text, remindMeAtDTP.Value);
            Latency.reminders.Add(r);
            C.SaveRemindersFile();


            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "MyRemindersF")
                    ((MyRemindersF)form).RefreshReminders();
            }
        }

        void reminderTitleTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                reminderContentTB.Focus();
            }
        }
        void ResetInfo(object sender, EventArgs e) {
            infoTSSL.Text = "Recuerda.me v2.0 | Creado por Lonami - http://lonamiwebs.github.io";
        }

        #endregion

        #region Tool Strip Menu Items

        void remindMeTSMI_DropDownOpening(object sender, EventArgs e) {
            myRemindersTSMI.Enabled = !IsMyRemindersOpen();
        }

        bool IsMyRemindersOpen() {
            bool found = false;
            foreach (Form form in Application.OpenForms)
                if (!found)
                    found = form.Name == "MyRemindersF";
            return found;
        }

        void myRemindersTSMI_Click(object sender, EventArgs e) {
            new MyRemindersF().Show();
        }

        void startWithWinTSMI_CheckedChanged(object sender, EventArgs e) {
            CheckStartWidthWindows();
        }
        private void startWithWinTSMI_Click(object sender, EventArgs e) {
            if (!startWithWinTSMI.Checked)
                if (MessageBox.Show("¿Está seguro de que quiere deshabilitar el programa al inicio de Windows?\r\n" +
                    "¡Si tiene recordatorios puestos para días posteriores y el programa no está abierto no " + 
                    "se le recordará!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                    startWithWinTSMI.Checked = true;
        }

        private void minimizeToTrayTSMI_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Se recomienda dejar esta opción activada ya que, si se cierra el programa, " +
                "no se le podrá recordar en el momento.\r\n¿Está seguro de desactivarla?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                minimizeToTrayTSMI.Checked = true;
        }

        void supportTSMI_Click(object sender, EventArgs e) {
            Process.Start("http://lonamiwebs.github.io/contacto?t=software&q=rem2");
        }

        #endregion

        void checkUpdatesTSMI_Click(object sender, EventArgs e) {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "rem2").Show();
        }

        #region System Tray

        void MainF_Resize(object sender, EventArgs e)
        {
            if (minimizeToTrayTSMI.Checked)
                if (WindowState == FormWindowState.Minimized)
                    ChangeDisplay(false);
        }

        void ChangeDisplay(bool visible) {
            WindowState = visible ? FormWindowState.Normal : FormWindowState.Minimized;
            ShowInTaskbar = visible;
            trayNI.Visible = !visible;
        }

        void trayNI_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                trayNI.ShowBalloonTip(2000);
        }

        void trayNI_BalloonTipClicked(object sender, EventArgs e) {
            ChangeDisplay(true);
        }

        void openRemindMeTSMI_Click(object sender, EventArgs e) {
            ChangeDisplay(true);
        }

        void trayCMS_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            viewMyRemindersTSMI.Enabled = !IsMyRemindersOpen();
        }

        void exitTSMI_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion

        #region Closing

        private void MainF_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            if (minimizeToTrayTSMI.Checked)
                if (trayNI.Visible)
                    Application.Exit();
                else
                    ChangeDisplay(false);
            else
                Application.Exit();
        }

        #endregion

    }
}