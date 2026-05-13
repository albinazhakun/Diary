using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Diary.EntityClass;
using Diary.Storage;

namespace Diary.Logic
{
    public class CategoryLogic
    {
        private readonly DataStorage memory;
        private List<Category> category;
        public CategoryLogic(DataStorage storag)
        {
            memory = storag;
            category = memory.LoadCategory();
        }
        public void Add(Category catego)
        {
            category.Add(catego);
            memory.SaveCategory(category);
        }
        public void Delete(Guid id)
        {
            category.RemoveAll(c => c.Id == id);
            memory.SaveCategory(category);
        }
        public void Update(Category upd)
        {
            int i = category.FindIndex(c => c.Id == upd.Id);
            if (i >= 0)
                category[i] = upd;
            memory.SaveCategory(category);
        }
        public bool NameOnly(string name, Guid? exep = null) =>
            !category.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.Id != exep);
        public List<Category> GetAll() => category.ToList();
        public Category? GetId(Guid id) =>
            category.FirstOrDefault(c => c.Id == id);
    }
}
