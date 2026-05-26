using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Diary.EntityClass;

namespace Diary.Storage
{
    /// <summary>
    /// клас для зберігання та завантаження даних у форматі JSON
    /// при ініціалізації створює папку Diary в директорії AppData
    /// та визначає шляхи до файлів events.json і categories.json
    /// серіалізація виконується з відступами для зручності читання файлів,
    /// а перелічувальні типи зберігаються як рядки завдяки JsonStringEnumConverter
    /// </summary>
    public class DataStorage
    {
        //шлях до файлу для зберігання справ
        public readonly string eventsPath;
        //шлях до файлу для зберігання категорій
        private readonly string categoryPath;
        private readonly JsonSerializerOptions optn = new()
        {
            WriteIndented = true,
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };
        //створює папку %AppData%\Diary якщо не існує
        //та визначає шляхи до файлів
        public DataStorage()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Diary");
            Directory.CreateDirectory(folder);
            eventsPath = Path.Combine(folder, "events.json");
            categoryPath = Path.Combine(folder, "categories.json");
        }
        //завантажує список справ з файлу
        //якщо файл не існує, повертає порожній список
        public List<Event> LoadEvents()
        {
            if (!File.Exists(eventsPath))
                return new List<Event>();
            string json = File.ReadAllText(eventsPath);
            return JsonSerializer.Deserialize<List<Event>>(json, optn)
                ?? new List<Event>();
        }
        //серіалізує переданий список заходів у JSON та записує його до файлу events
        //перезаписує файл повністю при кожному виклику
        public void SaveEvents(List<Event> events)
        {
            File.WriteAllText(eventsPath, JsonSerializer.Serialize(events, optn));
        }
        //завантажує список категорій з файлу
        //якщо файл не існує, повертає порожній список
        public List<Category> LoadCategory()
        {
            if (!File.Exists(categoryPath))
                return new List<Category>();
            string json = File.ReadAllText(categoryPath);
            return JsonSerializer.Deserialize<List<Category>>(json, optn)
                ?? new List<Category>();
        }
        //серіалізує переданий список категорій у JSON та записує його до файлу categories
        //перезаписує файл повністю при кожному виклику
        public void SaveCategory(List<Category> categories)
        {
            File.WriteAllText(categoryPath, JsonSerializer.Serialize(categories, optn));
        }
    }
}
