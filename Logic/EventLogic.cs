using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Diary.EntityClass;
using Diary.Storage;

namespace Diary.Logic
{
    public class EventLogic
    {
        private readonly Data memory;
        private List<Event> events;
        public EventLogic(Data storage)
        {
            memory = storage;
            events = memory.LoadEvents();
        }
        public void Add(Event eve)
        {
            events.Add(eve);
            memory.SaveEvents(events);

        }
        public void Delete(Guid id)
        {
            events.RemoveAll(e => e.Id == id);
            memory.SaveEvents(events);
        }
        public void Update(Event updated)
        {
            int i = events.FindIndex(e => e.Id == updated.Id);
            if (i >= 0)
                events[i] = updated;
            memory.SaveEvents(events);
        }
        public void CategoryReset(Guid categoryId)
        {
            foreach (Event eve in events.Where(e => e.CategoryId == categoryId))
                eve.CategoryId = null;
            memory.SaveEvents(events);
        }
        public void Postpone(Guid id, DateOnly newDate, TimeOnly newTime)
        {
            Event? eve = events.FirstOrDefault(e => e.Id == id);
            if(eve!= null)
            {
                eve.Date = newDate;
                eve.Time = newTime;
            }
            memory.SaveEvents(events);

        }
        public void Reminder(Guid id)
        {
            Event? eve = events.FirstOrDefault(e => e.Id == id);
            if (eve != null)
                eve.RemindShow = true;
            memory.SaveEvents(events);
        }
        public List<Event> GetAllEvents() => 
            events.OrderBy(e => e.Date).ThenBy(e => e.Time).ToList();
        public List<Event> GetOldDate() => 
            events.Where(e => e.Date < DateOnly.FromDateTime(DateTime.Now)).ToList();
        public List<Event> GetDate(DateOnly date) => 
            events.Where(e => e.Date == date).OrderBy(e => e.Time).ToList();
        public List<Event> Search(string? title, Guid? categoryId)
        {
            IEnumerable<Event> result = events;
            if (!string.IsNullOrWhiteSpace(title))
                result = result.Where(e => 
                e.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            if (categoryId.HasValue)
                result = result.Where(e => e.CategoryId == categoryId);
            return result.OrderBy(e => e.Date).ThenBy(e => e.Time).ToList();
        }
        public Event? NextReminder()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);
            return events
                .Where(e => e.Date == today && !e.RemindShow && e.Time > now && e.Time <= now.AddMinutes(5))
                .OrderBy(e => e.Time)
                .FirstOrDefault();
        }
        public void DeleteOldDate()
        {
            events.RemoveAll(e => e.Date < DateOnly.FromDateTime(DateTime.Now));
            memory.SaveEvents(events);
        }
    }
}
