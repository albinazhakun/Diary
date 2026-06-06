using System;
using System.Collections.Generic;
using System.Text;
using Diary.EntityClass;

namespace Diary.Logic
{
    //клас для зберігання результатів пошуку накладок між справами
    public class OverlaysResult
    {
        //перший захід
        public Event EventA { get; }
        //другий захід
        public Event EventB { get; }
        //тривалість перетину у хвилинах
        public int OverlaysMinut { get; }
        //ініціалізує результат накладки з двома заходами та тривалістю перетину
        public OverlaysResult(Event a,Event b, int minut)
        {
            EventA = a;
            EventB = b;
            OverlaysMinut = minut;
        }
    }
    //логіка для пошуку накладок між справами
    public class OverlaysLogic
    {
        //знаходить всі пари справ, які перетинаються за часом
        //для кожної пари обчислює тривалість перетину у хвилинах 
        public List<OverlaysResult> FindOverlays(List<Event> eve)
        {
            List<OverlaysResult> result = new();
            for (int i = 0; i < eve.Count; i++)
            {
                for (int j = i + 1; j <eve.Count; j++)
                {
                    Event a = eve[i];
                    Event b = eve[j];
                    TimeOnly start = a.Time > b.Time ? a.Time : b.Time;
                    TimeOnly end = a.EndTime < b.EndTime ? a.EndTime : b.EndTime;
                    if (end> start && a.Date == b.Date)
                    {
                        int minut = (int)(end.ToTimeSpan() - start.ToTimeSpan()).TotalMinutes;
                        result.Add(new OverlaysResult(a, b, minut));
                    }
                }
            }
            return result;
        }
    }
}
