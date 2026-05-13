using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.EntityClass;
using Diary.Logic;

namespace Diary.UI
{
    public partial class CategoryListForm : Form
    {
        private readonly CategoryLogic categoryLogic;
        private readonly EventLogic eventLogic;
        public CategoryListForm(CategoryLogic categ, EventLogic even)
        {
            InitializeComponent();
            categoryLogic = categ;
            eventLogic = even;
        }
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            listBoxCategories.Items.Clear();
            foreach (Category cat in categoryLogic.GetAll())
                listBoxCategories.Items.Add(cat);
            listBoxCategories.DisplayMember = "Name";
            UpdateButtons();
        }
        private void UpdateButtons()
        {
            bool selected = listBoxCategories.SelectedItem is not null;
            buttonEdit.Enabled = selected;
            buttonDelete.Enabled = selected;
        }
        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using CategoryForm form = new(categoryLogic);
            if (form.ShowDialog() == DialogResult.OK)
                RefreshList();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is not Category selected)
                return;
            using CategoryForm form = new(categoryLogic, selected);
            if (form.ShowDialog() == DialogResult.OK)
                RefreshList();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is not Category selected)
                return;
            int count = eventLogic.GetAllEvents().Count(ev => ev.CategoryId == selected.Id);
            string msg = count > 0
                ? $"До категорії \"{selected.Name}\" прив'язано {count} справ. Вони отримають статус «Без категорії». Продовжити?"
                : $"Видалити категорію \"{selected.Name}\"?";
            if (MessageBox.Show(msg, "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                eventLogic.CategoryReset(selected.Id);
                categoryLogic.Delete(selected.Id);
                RefreshList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
