using System;
using System.Text.RegularExpressions;

namespace API
{
    [Serializable]
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

        public static bool operator ==(Slot lhs, Slot rhs)
        {
            return lhs.location == rhs.location && lhs.date == rhs.date;
        }
        public static bool operator !=(Slot lhs, Slot rhs)
        {
            return lhs.location != rhs.location || lhs.date != rhs.date;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Slot))
            {
                return false;
            }

            Slot ra = (Slot)obj;

            return this.location.Equals(ra.location) && this.date.Equals(ra.date);
        }

        // https://www.loganfranken.com/blog/692/overriding-equals-in-c-part-2/
        public override int GetHashCode()
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, location) ? location.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, date) ? date.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
