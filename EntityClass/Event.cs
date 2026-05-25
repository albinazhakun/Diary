using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.EntityClass
{
    /// <summary>
    /// Заспланований захід або справа
    /// Зберігає всю необхідну інформацію
    /// </summary>
    public class Event
    { // Унікальний ідентифікатор заходу, генерується автоматично
        public Guid Id { get; set; } = Guid.NewGuid();
        //Назва, відображається у списку та нагадуваннях
        public string Title { get; set; } = string.Empty;
        //Дата проведення
        public DateOnly Date { get; set; }
        //час почтаку
        public TimeOnly Time { get; set; }
        //тривалість у хвилинах, використовується для обчислення
        //часу закінчення та виявлення накладок
        public int Duration { get; set; }
        //місце проведення, необов'язкове поле для заповнення
        public string? Location { get; set; }
        //Пріоритет заходу, впливає на порядок сортування 
        public Prior Priority { get; set; }
        //Ідентифікатор категорії, до якої належить захід
        public Guid? CategoryId { get; set; }
        //Ознака того, чи було показано нагадування для цього заходу
        public bool RemindShow { get; set; } = false;
        //Обчислюване властивість для визначення часу закінчення заходу
        public TimeOnly EndTime => Time.AddMinutes(Duration);
        //Повертає true, якщо захід вже минув
        public bool IsPast =>
            Date < DateOnly.FromDateTime(DateTime.Now) ||
            (Date == DateOnly.FromDateTime(DateTime.Now) && EndTime < TimeOnly.FromDateTime(DateTime.Now));

    }
    //Визначає рівень пріоритету заходу
    public enum Prior
    {
        Low,
        Medium,
        High
    }
}
