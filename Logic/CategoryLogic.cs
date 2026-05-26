using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Diary.EntityClass;
using Diary.Storage;

namespace Diary.Logic
{
    //Бізнес-логіка для керування категоріями справ у щоденнику
    public class CategoryLogic
    {
        private readonly DataStorage memory;
        private List<Category> category;
        //Ініціалізує логіку категорій та завантажує збережені дані зі сховища
        public CategoryLogic(DataStorage storag)
        {
            memory = storag;
            category = memory.LoadCategory();
        }
        //Додає нову категорію та зберігає зміни
        public void Add(Category catego)
        {
            category.Add(catego);
            memory.SaveCategory(category);
        }
        //Видаляє категорію за її унікальним ідентифікатором та зберігає зміни
        public void Delete(Guid id)
        {
            category.RemoveAll(c => c.Id == id);
            memory.SaveCategory(category);
        }
        //Оновлює існуючу категорію новими даними та зберігає зміни
        public void Update(Category upd)
        {
            int i = category.FindIndex(c => c.Id == upd.Id);
            if (i >= 0)
                category[i] = upd;
            memory.SaveCategory(category);
        }
        //перевіряє унфкальність назви категорії серед уже збережених
        public bool NameOnly(string name, Guid? exep = null) =>
            !category.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.Id != exep);
        //повертає список усіх збережених категорій
        public List<Category> GetAll() => category.ToList();
        //повертає категорію за її унікальним ідентифікатором
        public Category? GetId(Guid id) =>
            category.FirstOrDefault(c => c.Id == id);
    }
}
