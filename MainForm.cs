using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.EntityClass;
using Diary.Logic;
using Diary.UI;

namespace Diary
{
    public partial class MainForm : Form
    {

        private readonly EventLogic eventLogic;
        private readonly CategoryLogic categoryLogic;
        private readonly RemindLogic remindLogic;
        private readonly OverlaysLogic overlaysLogic;
        private DateOnly? selectedDate = null;
        public MainForm(EventLogic eve, CategoryLogic cat, RemindLogic rem, OverlaysLogic over)
        {
            InitializeComponent();
            eventLogic = eve;
            categoryLogic = cat;
            remindLogic = rem;
            overlaysLogic = over;
            remindLogic.RemindTrig += OnReminderTriggered;
            remindLogic.Start();
            Shown += MainFormShown;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupTable();
            LoadCategoryFilter();
            RefreshTable();
            dataGridViewEvents.ClearSelection();
            KeyPreview = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    MessageBox.Show(
                        "F1 - допомога\n" +
                        "Enter – згода\n" +
                        "Delete – видалити вибрану справу\n" +
                        "Ins – додати нову справу\n" +
                        "Esc – відмова\n" +
                        "Tab / Shift+Tab – перехід між полями",
                        "Допомога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                case Keys.Insert:
                    buttonAdd_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Enter:
                    if (dataGridViewEvents.CurrentRow?.Tag is Event)
                        buttonEdit_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Delete:
                    if (dataGridViewEvents.CurrentRow?.Tag is Event)
                        buttonDelete_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Escape:
                    dataGridViewEvents.ClearSelection();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SetupTable()
        {
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.AllowUserToAddRows = false;
            dataGridViewEvents.AllowUserToDeleteRows = false;
            dataGridViewEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvents.MultiSelect = false;
            dataGridViewEvents.RowHeadersVisible = false;
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.AutoGenerateColumns = false;
            dataGridViewEvents.DefaultCellStyle.ForeColor = Color.Black;

        }
        private void RefreshTable()
        {
            List<Event> events = selectedDate.HasValue
                ? eventLogic.GetDate(selectedDate.Value)
                : eventLogic.GetAllEvents();
            FillTable(events);
        }
        private void FillTable(List<Event> events)
        {
            dataGridViewEvents.Rows.Clear();
            labelNoResults.Visible = false;
            if ((events.Count == 0))
            {
                labelNoResults.Visible = true;
                return;
            }
            foreach (Event ev in events)
            {
                int i = dataGridViewEvents.Rows.Add(
                    ev.Title,
                    ev.Date.ToString("yyyy-MM-dd"),
                    ev.Time.ToString("HH:mm"),
                    ev.Duration,
                    ev.Location ?? "",
                    GetCategoryName(ev.CategoryId),
                    GetPriorityText(ev.Priority));
                dataGridViewEvents.Rows[i].Tag = ev;
                if (ev.IsPast)
                {
                    dataGridViewEvents.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                }
                Category? cat = categoryLogic.GetId(ev.CategoryId ?? Guid.Empty);
                if (cat?.Color != null)
                {
                    try
                    {
                        Color rowColor = ColorTranslator.FromHtml(cat.Color);
                        dataGridViewEvents.Rows[i].DefaultCellStyle.BackColor = rowColor;
                    }
                    catch { }
                }
            }
            dataGridViewEvents.ClearSelection();
        }
        private void LoadCategoryFilter()
        {
            comboBoxCategoryFilter.Items.Clear();
            comboBoxCategoryFilter.Items.Add("Усі категорії");
            foreach (Category cat in categoryLogic.GetAll())
            {
                comboBoxCategoryFilter.Items.Add(cat);
            }
            comboBoxCategoryFilter.SelectedIndex = 0;
            comboBoxCategoryFilter.DisplayMember = "Name";
        }
        private void MainFormShown(object? sender, EventArgs e)
        {
            ChecOutDateEve();
        }
        private void buttonAllEvents_Click(object sender, EventArgs e)
        {
            selectedDate = null;
            RefreshTable();
        }
        private void buttonCategories_Click(object sender, EventArgs e)
        {
            using CategoryListForm form = new(categoryLogic, eventLogic);
            form.ShowDialog();
            LoadCategoryFilter();
            RefreshTable();
        }
        private void buttonCheckOverlays_Click(object sender, EventArgs e)
        {
            List<Event> todayEvents = eventLogic.GetDate(DateOnly.FromDateTime(DateTime.Now));
            List<OverlaysResult> overlays = overlaysLogic.FindOverlays(todayEvents);
            using OverlaysForm form = new(overlays);
            form.ShowDialog();
        }
        private void buttonOutdated_Click(object sender, EventArgs e)
        {
            List<Event> outdated = eventLogic.GetOldDate();
            if (outdated.Count == 0)
            {
                MessageBox.Show("Застарілих справ немає", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using OldEventForm form = new(outdated, eventLogic);
            form.ShowDialog();
            RefreshTable();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = textBoxSearch.Text.Trim();
            if (title.Length > 150)
            {
                MessageBox.Show("Запит не може перевищувати 150 символів", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Guid? categoryId = comboBoxCategoryFilter.SelectedItem is Category cat ? cat.Id : null;
            List<Event> results = eventLogic.Search(string.IsNullOrWhiteSpace(title) ? null : title, categoryId);
            FillTable(results);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            selectedDate = DateOnly.FromDateTime(DateTime.Now);
            RefreshTable();
        }

        private void buttonTomorrow_Click(object sender, EventArgs e)
        {
            selectedDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
            RefreshTable();
        }
        private void buttonDayAfterTomorrow_Click(Object sender, EventArgs e)
        {
            selectedDate = DateOnly.FromDateTime(DateTime.Now.AddDays(2));
            RefreshTable();
        }
        private void buttonPickDate_Click(object sender, EventArgs e)
        {
            using Form pickerForm = new()
            {
                Text = "Оберіть дату",
                Size = new Size(280, 110),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };
            DateTimePicker picker = new()
            {
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Top,
            };
            Button ok = new()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Dock = DockStyle.Bottom,
            };
            pickerForm.Controls.Add(picker);
            pickerForm.Controls.Add(ok);
            pickerForm.AcceptButton = ok;
            if (pickerForm.ShowDialog() == DialogResult.OK)
            {
                selectedDate = DateOnly.FromDateTime(picker.Value);
                RefreshTable();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using EventForm form = new(categoryLogic.GetAll());
            if (form.ShowDialog() == DialogResult.OK)
            {
                eventLogic.Add(form.Result!);
                RefreshTable();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Event? selected = GetSelectedEvent();
            if (selected is null)
                return;
            using EventForm form = new(categoryLogic.GetAll(), selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                eventLogic.Update(form.Result!);
                RefreshTable();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Event? selected = GetSelectedEvent();
            if (selected is null)
                return;
            DialogResult confirm = MessageBox.Show(
                $"Ви впевнені що хочете видалити справу \" {selected.Title}\"? Цю дію неможливо скасувати.",
                "Підтверження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                eventLogic.Delete(selected.Id);
                RefreshTable();
            }
        }
        private void OnReminderTriggered(Event ev)
        {
            if (InvokeRequired)
            {
                Invoke(() => OnReminderTriggered(ev));
                return;
            }
            using RemindForm form = new(ev);
            form.ShowDialog();
        }
        private void ChecOutDateEve()
        {
            List<Event> outdated = eventLogic.GetOldDate();
            if (outdated.Count == 0)
                return;
            using OldEventForm form = new(outdated, eventLogic);
            form.ShowDialog();
            RefreshTable();
        }
        private void MainForm_FormClothing(object sender, FormClosingEventArgs e)
        {
            remindLogic.Stop();
            remindLogic.Dispose();
        }
        private Event? GetSelectedEvent()
        {
            if (dataGridViewEvents.CurrentRow?.Tag is Event ev)
                return ev;
            MessageBox.Show("Оберіть справу зі списку", "Увага",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }
        private string GetCategoryName(Guid? categoryId)
        {
            if (!categoryId.HasValue)
                return "Без категорії";
            return categoryLogic.GetId(categoryId.Value)?.Name ?? "Без категорії";
        }
        private static string GetPriorityText(Prior priority) => priority switch
        {
            Prior.Low => "Низький",
            Prior.Medium => "Середній",
            Prior.High => "Високий",
            _ => "Середній"
        };

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
