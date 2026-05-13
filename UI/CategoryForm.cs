using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.EntityClass;
using Diary.Logic;
//using static System.Net.Mime.MediaTypeNames;

namespace Diary.UI
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryLogic categoryLogic;
        private readonly Category? editTarget;
        public CategoryForm(CategoryLogic categ)
        {
            InitializeComponent();
            categoryLogic = categ;
            Text = "Додавання категорії";
        }
        public CategoryForm(CategoryLogic categ, Category editTarg)
        {
            InitializeComponent();
            categoryLogic = categ;
            editTarget = editTarg;
            Text = "Редагування категорії";
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (editTarget is not null)
            {
                textBoxName.Text = editTarget.Name;
                textBoxDescription.Text = editTarget.Description ?? "";
                textBoxColor.Text = editTarget.Color ?? "#FFFFFF";
                try
                {
                    panelColorPreview.BackColor = ColorTranslator.FromHtml(editTarget.Color ?? "#FFFFFF");
                }
                catch
                {
                    panelColorPreview.BackColor = Color.White;
                }
            }
            else
            {
                textBoxColor.Text = "#FFFFFF";
                panelColorPreview.BackColor = Color.White;
            }
        }
        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new();
            try
            {
                dialog.Color = ColorTranslator.FromHtml(textBoxColor.Text);
            }
            catch
            {
                dialog.Color = Color.White;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxColor.Text = ColorTranslator.ToHtml(dialog.Color);
                panelColorPreview.BackColor = dialog.Color;
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            List<string> errors = new();
            if (string.IsNullOrEmpty(name))
                errors.Add("Назва є обов'язковою.");
            else if (name.Length > 50)
                errors.Add("Назва не може перевищувати 50 символів.");
            else if (!categoryLogic.NameOnly(name, editTarget?.Id))
                errors.Add("Категорія з такою назвою вже існує.");
            if (textBoxDescription.Text.Trim().Length > 200)
                errors.Add("Опис не може перевищувати 200 символів.");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Category cat = editTarget ?? new Category();
            cat.Name = name;
            cat.Description = string.IsNullOrWhiteSpace(textBoxDescription.Text)
                ? null : textBoxDescription.Text.TrimEnd();
            cat.Color = textBoxColor.Text;
            if (editTarget is not null)
                categoryLogic.Update(cat);
            else
                categoryLogic.Add(cat);
            DialogResult = DialogResult.OK;
            Close();

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
