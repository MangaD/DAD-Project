using System;
using System.Text.RegularExpressions;

namespace API
{
    public struct Slot
    {
        public string location;
        public DateTime date;
        public Slot(string _loc, DateTime _date)
        {
            this.location = _loc;
            this.date = _date;
        }
        public static Slot FromString(string slot)
        {
            string r = @"(\w+),(\d{4})-(\d{1,2})-(\d{1,2})";
            MatchCollection mat = Regex.Matches(slot, r);
            if (mat.Count <= 0)
            {
                throw new ArgumentException();
            }
            Match m2 = mat[0];
            string location = m2.Groups[1].Value.ToString();
            int year = Int32.Parse(m2.Groups[2].Value.ToString());
            int mon = Int32.Parse(m2.Groups[3].Value.ToString());
            int day = Int32.Parse(m2.Groups[4].Value.ToString());
            //Utilities.WriteDebug($"Loc: {location}, Year: {year}, Month: {mon}, Day: {day}");
            return new Slot(location, new DateTime(year, mon, day));
        }
        public override string ToString()
        {
            return location + "," + date.ToString("yyyy-MM-dd");
        }
    }
}
