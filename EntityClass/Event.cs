using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.EntityClass
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int Duration { get; set; }
        public string? Location { get; set; }
        public Prior Priority { get; set; }
        public Guid? CategoryId { get; set; }
        public bool RemindShow { get; set; } = false;
        public TimeOnly EndTime => Time.AddMinutes(Duration);
        public bool IsPast =>
            Date < DateOnly.FromDateTime(DateTime.Now) ||
            (Date == DateOnly.FromDateTime(DateTime.Now) && EndTime < TimeOnly.FromDateTime(DateTime.Now));

    }
    public enum Prior
    {
        Low,
        Medium,
        High
    }
}
