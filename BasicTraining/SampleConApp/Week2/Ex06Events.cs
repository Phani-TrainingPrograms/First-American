using System;
using System.Threading;

namespace SampleConApp.Week2
{
    delegate void Trigger(string message);

    class AlarmClock
    {
        private DateTime alarmTime;

        public event Trigger RaiseAlarm = null;
        public AlarmClock(DateTime timeOfAlarm)
        {
            alarmTime = timeOfAlarm;
        }
        public void DisplayTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            if(alarmTime.Minute == DateTime.Now.Minute)
            {
                if(RaiseAlarm != null)
                RaiseAlarm("Wake up, Dont sleep when the class is going on!!!!");
            }
        }
    }
    class Ex06Events
    {
        static void Main(string[] args)
        {
            AlarmClock bedClock = new AlarmClock(DateTime.Now.AddMinutes(1));
            bedClock.RaiseAlarm += BedClock_RaiseAlarm;
            do
            {
                bedClock.DisplayTime();
                Thread.Sleep(1000);
                Console.Clear();
            } while (true);
        }

        private static void BedClock_RaiseAlarm(string message)
        {
            UIConsole.PrintMessage(message.ToUpper());
        }
    }
}
