using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _02_AlarmClock
{
    class Clock
    {
        public delegate void ClockHandler();
        public event ClockHandler Tick;
        public event ClockHandler Alarm;

        public String date_time
        {
            get; set;
        }

        protected virtual void OnTick()
        {
            if (Tick != null)
            {
                Tick();
            }
            else
            {
                Console.WriteLine("嘀嗒(Tick)事件没触发");
                Console.ReadKey();
            }
        }

        protected virtual void OnAlarm()
        {
            if (Alarm != null)
            {
                Alarm();
            }
            else
            {
                Console.WriteLine("响铃(Alarm)事件没触发");
                Console.ReadKey();
            }
        }

        public void MyTick()
        {
            while (true)
            {
                //每隔一秒钟触发一次事件
                Thread.Sleep(1000);
                OnTick();
                MyAlarm();
            }
        }

        public void MyAlarm()
        {
            if (date_time == DateTime.Now.ToString())
            {
                OnAlarm();
            }
        }
    }
}
