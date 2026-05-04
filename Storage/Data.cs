using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Diary.EntityClass;

namespace Diary.Storage
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
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Diary");
            Directory.CreateDirectory(folder);
            eventsPath = Path.Combine(folder, "events.json");
            categoryPath = Path.Combine(folder, "categories.json");
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
            File.WriteAllText(eventsPath, JsonSerializer.Serialize(events, optn));
        }
        public List<Category> LoadCategory()
        {
            if (!File.Exists(categoryPath))
                return new List<Category>();
            string json = File.ReadAllText(categoryPath);
            return JsonSerializer.Deserialize<List<Category>>(json, optn)
                ?? new List<Category>();
        }
        public void SaveCategory(List<Category> categories)
        {
            File.WriteAllText(categoryPath, JsonSerializer.Serialize(categories, optn));
        }
    }
}
