using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recuerda.me
{
    public class Latency
    {
        public static List<C.Reminder> reminders;

        public Latency() {
            Directory.CreateDirectory(C.RemindersFolder);
            if (!File.Exists(C.RemindersPath))
                File.Create(C.RemindersPath).Close();

            Timer t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += CheckReminders;

            reminders = new List<C.Reminder>();
            string[] parsedReminders = File.ReadAllLines(C.RemindersPath);
            foreach (var parsedReminder in parsedReminders)
                reminders.Add(C.Reminder.Unparse(parsedReminder));
        }

        void CheckReminders(object sender, EventArgs e) {
            foreach (C.Reminder reminder in reminders)
                reminder.Check();
        }
    }
}
