using System;

namespace ExternalSub
{
    public class Time
    {
        Int64 timeMS;

        public Time(Int64 fromMilliSeconds)
        {
            timeMS = fromMilliSeconds;
        }

        public Time(String fromString)
        {
            //00:00:48,601;
            Int32 i1, i2, i3;
            Int16 hour, min, sec, msec;
            
            i1 = fromString.IndexOf(':', 0);
            i2 = fromString.IndexOf(':', i1 + 1);
            i3 = fromString.IndexOf(',', i2 + 1);
            hour = Convert.ToInt16(fromString.Substring(0, i1));
            min = Convert.ToInt16(fromString.Substring(i1 + 1, i2 - i1 - 1));
            sec = Convert.ToInt16(fromString.Substring(i2 + 1, i3 - i2 - 1));
            msec = Convert.ToInt16(fromString.Substring(i3 + 1, fromString.Length - i3 - 1));

            timeMS = msec + sec * 1000 + min * 60000 + hour * 3600000;
        }

        public void Add(Int64 ms)
        {
            timeMS += ms;
        }

        public int Hours { get { return (Int32)(timeMS / 3600000); } }
        public int Minutes { get { return (Int32)((timeMS / 60000) % 60); } }
        public int Seconds { get { return (Int32)((timeMS / 1000) % 60); } }
        public int Milliseconds { get { return (Int32)(timeMS % 1000); } }

        public Int64 asSeconds { get { return timeMS / 1000; } }
        public Int64 asMilliSeconds { get { return timeMS; } }
        public String asTimeString 
        { 
            get 
            {
                String h0 = "", m0 = "", s0 = "", ms0 = "";
                if (Hours < 10)
                    h0 = "0";
                if (Minutes < 10)
                    m0 = "0";
                if (Seconds < 10)
                    s0 = "0";
                if (Milliseconds < 100)
                    ms0 = "0";
                if (Milliseconds < 10)
                    ms0 += "0";

                return h0 + Hours + ":" + m0 + Minutes + ":" + s0 + Seconds + "," + ms0 + Milliseconds;
            }
        }

        override public String ToString()
        {
            String ans = this.asTimeString;
            return ans.Substring(0, ans.Length - 4);
        }

        public Int32 CompareTo(Time B)
        {
            if (this.asMilliSeconds > B.asMilliSeconds)
                return 1;
            if (this.asMilliSeconds < B.asMilliSeconds)
                return -1;
            return 0;
        }

        public static Time operator +(Time c1, Time c2)
        {
            return new Time(c1.asMilliSeconds + c2.asMilliSeconds);
        }
        public static Time operator +(Time c1, Int64 c2)
        {
            return new Time(c1.asMilliSeconds + c2);
        }
        public static Boolean operator >(Time c1, Time c2)
        {
            return c1.CompareTo(c2) > 0;
        }
        public static Boolean operator <(Time c1, Time c2)
        {
            return c1.CompareTo(c2) < 0;
        }
        public static Boolean operator ==(Time c1, Time c2)
        {
            return c1.CompareTo(c2) == 0;
        }
        public static Boolean operator !=(Time c1, Time c2)
        {
            return c1.CompareTo(c2) != 0;
        }
        public static Boolean operator >=(Time c1, Time c2)
        {
            return (c1 > c2) || (c1 == c2);
        }
        public static Boolean operator <=(Time c1, Time c2)
        {
            return (c1 < c2) || (c1 == c2);
        }
        public override int GetHashCode()
        {
            return timeMS.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return (this == (Time)obj);
        }
    }
}
