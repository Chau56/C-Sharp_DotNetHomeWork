using System;

namespace _02_AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            
            c.Tick += new Clock.ClockHandler(DisplayTick);
            c.Alarm += new Clock.ClockHandler(DisplayAlarm);

            c.date_time = DateTime.Now.AddSeconds(5).ToString();
            c.MyTick();
        }

        public static void DisplayTick()
        {
            Console.WriteLine("Tick!");
        }

        public static void DisplayAlarm()
        {
            Console.WriteLine("Alarm!");
        }
    }
}
