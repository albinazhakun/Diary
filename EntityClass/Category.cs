using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.EntityClass
{
    /// <summary>
    /// Категорія справ у щоденнику
    /// Групує заходи за типом та візуально виділяє їх у інтерфейсі
    /// </summary>
    public class Category
    {
        // Унікальний ідентифікатор категорії, генерується автоматично
        public Guid Id { get; set; } = Guid.NewGuid();
        //Унікальна назва категорії, обов'язкова для заповнення
        public string Name { get; set; } = string.Empty;
        // Необов'язковий опис категорії для додаткової інформації
        public string? Description { get; set; }
        // Колір категорії у форматі HEX, за замовчуванням білий
        public string? Color { get; set; } = "#FFFFFF";
    }
}
