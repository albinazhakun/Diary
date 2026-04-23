using Diary.EntityClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Diary.Logic
{
    public class Data
    {
        private readonly string eventsPath;
        private readonly string categoryPath;
        private readonly JsonSerializerOptions optn = new()
        {
            WriteIndented = true,
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };
        public Data()
        {
            string fold = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Diary");
            Directory.CreateDirectory(fold);
            eventsPath = Path.Combine(fold, "events.json");
            categoryPath = Path.Combine(fold, "categories.json");
        }

        public List<Event> LoadEvents()
        {
            if (!File.Exists(eventsPath))
                return new List<Event>();
            string json = File.ReadAllText(eventsPath);
            return JsonSerializer.Deserialize<List<Event>>(json, optn)
                ?? new List<Event>();
        }
        public void SaveEvents(List<Event> events)
        {

        }
    }
}
