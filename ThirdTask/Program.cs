using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Time
    {
        private int Hour { get; set; }
        private int Minutes { get; set; }

        public Time(int hour, int minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes;
        }

        public override string ToString()
        {
            DateTime temp = new DateTime(2007, 11, 1, Hour, Minutes, 0);
            return temp.ToString("HH:mm");
        }
    }
    
    class Program
    {
        static List<Time> GenerateClock()
        {
            List<Time> clock = new List<Time>();

            for (int hour = 0; hour < 24; hour++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    clock.Add(new Time(hour, minute));
                }
            }

            return clock;
        }

        static bool IsPalindrom(string time)
        {
            if(time == Reverse(time))
            { 
                return true;
            }

            return false;
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            List<Time> clock = GenerateClock();
            List<Time> palindromClock = new List<Time>();

            foreach (Time time in clock)
            {
                if (IsPalindrom(time.ToString()))
                {
                    palindromClock.Add(time);
                }
            }

            foreach (Time time in palindromClock)
            {
                Console.WriteLine(time.ToString());
            }

            Console.ReadKey();
        }
    }
}
