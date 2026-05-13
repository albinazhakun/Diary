using Diary.EntityClass;
using Diary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Diary.UI
{
    public partial class PostponeEventForm : Form
    {
        public DateOnly NewDate { get; private set; }
        public TimeOnly NewTime { get; private set; }
        private readonly Event even;

        public PostponeEventForm(Event ev)
        {
            InitializeComponent();
            even = ev;
        }
        private void RescheduleEventForm_Load(object sender, EventArgs e)
        {
            labelEventName.Text = $"Перенесення: «{even.Title}»";
            dateTimePickerNewDate.MinDate = DateTime.Today;
            dateTimePickerNewDate.Value = DateTime.Today;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DateOnly newDate = DateOnly.FromDateTime(dateTimePickerNewDate.Value);
            if (newDate < DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Нова дата не може бути у минулому.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NewDate = newDate;
            NewTime = TimeOnly.FromDateTime(dateTimePickerNewTime.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
