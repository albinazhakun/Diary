using System;
using System.Collections.Generic;
using System.Text;
using Diary.EntityClass;

namespace Diary.Logic
{
    /// <summary>
    /// реалізує автоматичне нагадування про заплановані заходи
    /// використовує таймер Windows Forms з інтервалом 60 секунд, який щохвилини
    /// перевіряє наявність заходу, що починається протягом наступних 5 хвилин
    /// при виявленні такого заходу генерує подію RemindTrig для відображення
    /// нагадування в інтерфейсі користувача
    /// реалізує IDisposable для коректногозвільнення ресурсів таймера після завершення роботи
    /// </summary>
    public class RemindLogic : IDisposable
    {
        private readonly EventLogic eventLogic;
        private readonly System.Windows.Forms.Timer timer;
        //подія що генерується при виявленні заходу для нагадування
        public event Action<Event>? RemindTrig;
        //ініціалізує логіку нагадувань та налаштовує таймер
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
        //запускає таймер для початку перевірки нагадувань
        public void Start() => timer.Start();
        //зупиняє таймер для припинення перевірки нагадувань
        public void Stop() => timer.Stop();
        //звільняє ресурси таймера при завершенні роботи
        public void Dispose() => timer.Dispose();
    }   
}
