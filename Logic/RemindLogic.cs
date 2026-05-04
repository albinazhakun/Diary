using System;
using System.Collections.Generic;
using System.Text;
using Diary.EntityClass;

namespace Diary.Logic
{
    public class RemindLogic : IDisposable
    {
        private readonly EventLogic eventLogic;
        private readonly System.Windows.Forms.Timer timer;
        public event Action<Event>? RemindTrig;
        public RemindLogic(EventLogic eve)
        {
            eventLogic = eve;
            timer = new System.Windows.Forms.Timer { Interval = 60000 };
            timer.Tick += (_, _) =>
            {
                Event? ev = eventLogic.NextReminder();
                if (ev == null) 
                    return;
                eventLogic.Reminder(ev.Id);
                RemindTrig?.Invoke(ev);
            };
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Stop();
        public void Dispose() => timer.Dispose();
    }   
}
