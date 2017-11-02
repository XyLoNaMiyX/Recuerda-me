// It creates many instances... It is so cool tho!

public class Reminder
{
	public string Title;
	public string Content;
	public DateTime TriggerTime;

	public bool Notified = false;
	bool _IsChecking;
	public bool IsChecking
	{
		get
		{
			return _IsChecking;
		}
		set
		{
			_IsChecking = value;
			SetChecking(value);
		}
	}

	Timer Checker;
	void SetChecking(bool checking)
	{
		if (checking) {
			Checker = new Timer() { Interval = 1000, Enabled = true };
			Checker.Tick += CheckReminder;
		} else {
			if (Checker != null) {
				Checker.Enabled = false;
				Checker.Tick -= CheckReminder;
			}
			Checker = null; // can i Checker.Dispose();?
		}
	}

	void CheckReminder(object sender, EventArgs e) {
		var n = DateTime.Now;
		System.Diagnostics.Debug.WriteLine(n.Second);
		if (n.Date == TriggerTime.Date)
			if (n.Hour == TriggerTime.Hour)
				if (n.Minute == TriggerTime.Minute)
					if (n.Second == TriggerTime.Second) {
						Notify();
						IsChecking = false;
					}
	}

	void Notify() {
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
		string[] con = parsedReminder.Split(';');
		string title = con[0].Replace("&sc;", ";");
		string content = con[1].Replace("&sc;", ";").Replace("&lb;", "\r\n");
		return new Reminder
		{
			Title = title,
			Content = content,
			IsChecking = Boolean.Parse(con[2]),
			TriggerTime = DateTime.Parse(con[3])
		};
	}
}