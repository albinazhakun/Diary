using System;
using System.Collections.Generic;
using System.Text;
using Diary.EntityClass;

namespace Diary.Logic
{
    public class OverlaysResult
    {
        public Event EventA { get; }
        public Event EventB { get; }
        public int OverlaysMinut { get; }
        public OverlaysResult(Event a,Event b, int minut)
        {
            EventA = a;
            EventB = b;
            OverlaysMinut = minut;
        }
    }
    public class OverlaysLogic
    {
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
                    if (end> start)
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
