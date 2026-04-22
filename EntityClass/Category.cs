using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.EntityClass
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Color { get; set; } = "#FFFFFF";
    }
}
