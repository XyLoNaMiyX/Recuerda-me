using System;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Recuerda.me
{
    public static class C {
        public static string RemindersFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\LonamiWebs\\Remind.me";
        public static string RemindersPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\LonamiWebs\\Remind.me\\reminders.me";

        public static string LckFile = Path.GetTempPath() + "\\remind.me.lck";

        public static void SaveRemindersFile() {
            StringBuilder sb = new StringBuilder();
            foreach (var reminder in Latency.reminders) {
                if (!reminder.Notified)
                    sb.AppendLine(reminder.Parse());
            }
            File.WriteAllText(C.RemindersPath, sb.ToString(), Encoding.UTF8);
        }

        public class Reminder
        {
            public string Title;
            public string Content;
            public DateTime TriggerTime;
            public bool Notified = false;
            public bool IsChecking;

            public void Check() {
                var n = DateTime.Now;
                if (n.Date == TriggerTime.Date)
                    if (n.Hour == TriggerTime.Hour)
                        if (n.Minute == TriggerTime.Minute)
                            if (n.Second == TriggerTime.Second)
                                Notify();
            }

            void Notify() {
                new SoundPlayer(Properties.Resources.notification).Play();
                new NotifyF(Title, Content).Show();
                Notified = true;
                C.SaveRemindersFile();
            }

            public Reminder() { }
            public Reminder(string title, string content, DateTime triggerTime) {
                Title = String.IsNullOrWhiteSpace(title) ? "<Sin título>" : title;
                Content = String.IsNullOrWhiteSpace(title) ? "<Sin contenido>" : content; ;
                TriggerTime = triggerTime;
                IsChecking = true;
            }

            public string Parse()
            {
                string title = Title.Replace(";", "&sc;");
                string content = Content.Replace(";", "&sc;").Replace("\r\n", "&lb;");
                string isChecking = IsChecking.ToString();
                string triggerTime = TriggerTime.ToString();

                return String.Join(";", title, content, isChecking, triggerTime);
            }

            public static Reminder Unparse(string parsedReminder)
            {
                string[] con = parsedReminder.Replace("&lb;", "\r\n").Replace("&sc;", ";").Split(';');
                string title = con[0];
                string content = con[1];
                return new Reminder
                {
                    Title = title,
                    Content = content,
                    IsChecking = Boolean.Parse(con[2]),
                    TriggerTime = DateTime.Parse(con[3])
                };
            }
        }
    }
}