using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Utils
{
    public static class HourRetriever
    {
        public static DateTime RetrieveHourFromString(string text) {
            bool withSeconds = text.Length > 5;
            string pattern = withSeconds ? "([01]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]" : "([01]?[0-9]|2[0-3]):[0-5][0-9]";
            Regex regexp = new Regex(pattern);
            Match match = regexp.Match(text);

            string time = text.Substring(match.Index, match.Length);

            string[] atim = time.Split('\'', ':', '.');

            int secs = 0, mins = 0, hour = 0;
            if (withSeconds)
                Int32.TryParse(atim[2], out secs);
            Int32.TryParse(atim[1], out mins);
            Int32.TryParse(atim[0], out hour);

            DateTime n = DateTime.Now;
            DateTime t = new DateTime(n.Year, n.Month, n.Day, hour, mins, secs);

            return t;
        }

        public static bool ContainsHourAndSeconds(string text)
        {
            string pattern = "([01]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]";
            Regex regexp = new Regex(pattern);
            Match match = regexp.Match(text);
            return match.Success;
        }

        public static bool ContainsHourNoSeconds(string text)
        {
            string pattern = "([01]?[0-9]|2[0-3]):[0-5][0-9]";
            Regex regexp = new Regex(pattern);
            Match match = regexp.Match(text);
            return match.Success;
        }
    }
}
