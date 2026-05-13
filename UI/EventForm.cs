using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.EntityClass;
using Diary.Logic;
using static System.Net.Mime.MediaTypeNames;

namespace Diary.UI
{
    public partial class EventForm : Form
    {
        public Event? Result { get; private set; }
        private readonly List<Category> categories;
        private readonly Event? editTarget;
        public EventForm(List<Category> categ)
        {
            InitializeComponent();
            categories = categ;
            Text = "Додавання справи";
        }
        public EventForm(List<Category> categ, Event editTarg)
        {
            InitializeComponent();
            categories = categ;
            editTarget = editTarg;
            Text = "Редагування справи";
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Без категорії");
            foreach (Category cat in categories)
                comboBoxCategory.Items.Add(cat);
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.SelectedIndex = 0;
            comboBoxPriority.Items.AddRange(new object[] { "Низький", "Середній", "Високий" });
            comboBoxPriority.SelectedIndex = 1;
            numericUpDownDuration.Minimum = 1;
            numericUpDownDuration.Maximum = 1440;
            if (editTarget is not null)
            {
                textBoxTitle.Text = editTarget.Title;
                dateTimePickerDate.Value = editTarget.Date.ToDateTime(TimeOnly.MinValue);
                dateTimePickerTime.Value = DateTime.Today.Add(editTarget.Time.ToTimeSpan());
                numericUpDownDuration.Value = editTarget.Duration;
                textBoxLocation.Text = editTarget.Location ?? "";
                comboBoxPriority.SelectedIndex = (int)editTarget.Priority;
                if (editTarget.CategoryId.HasValue)
                {
                    Category? cat = categories.FirstOrDefault(c => c.Id == editTarget.CategoryId);
                    if (cat is not null)
                        comboBoxCategory.SelectedItem = cat;
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;
            Event ev = editTarget ?? new Event();
            ev.Title = textBoxTitle.Text.TrimEnd();
            ev.Date = DateOnly.FromDateTime(dateTimePickerDate.Value);
            ev.Time = TimeOnly.FromDateTime(dateTimePickerTime.Value);
            ev.Duration = (int)numericUpDownDuration.Value;
            ev.Location = string.IsNullOrWhiteSpace(textBoxLocation.Text)
                ? null : textBoxLocation.Text.TrimEnd();
            ev.Priority = (Prior)comboBoxPriority.SelectedIndex;
            ev.CategoryId = comboBoxCategory.SelectedItem is Category cat ? cat.Id : null;
            Result = ev;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private bool ValidateFields()
        {
            List<string> errors = new();
            string title = textBoxTitle.Text.Trim();
            if (string.IsNullOrEmpty(title))
                errors.Add("Назва є обов'язковою.");
            else if (title.Length > 200)
                errors.Add("Назва не може перевищувати 200 символів.");
            if (DateOnly.FromDateTime(dateTimePickerDate.Value) < DateOnly.FromDateTime(DateTime.Now))
                errors.Add("Дата не може бути у минулому.");
            if (textBoxLocation.Text.Trim().Length > 200)
                errors.Add("Місце не може перевищувати 200 символів.");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors),
                    "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
