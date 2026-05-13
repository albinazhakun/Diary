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
    public partial class OldEventForm : Form
    {
        private readonly List<Event> olddated;
        private readonly EventLogic eventLogic;
        public OldEventForm(List<Event> oldd, EventLogic eve)
        {
            InitializeComponent();
            olddated = oldd;
            eventLogic = eve;
        }
        private void OlddatedEventsForm_Load(object sender, EventArgs e)
        {
            static string Short(string s) => s.Length > 30 ? s[..30] + "…" : s;
            foreach (Event ev in olddated)
                listBoxOutdated.Items.Add($"{Short(ev.Title)} — {ev.Date:dd.MM.yyyy} {ev.Time:HH:mm}");
        }
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            eventLogic.DeleteOldDate();
            Close();
        }
        private void buttonReschedule_Click(object sender, EventArgs e)
        {
            foreach (Event ev in olddated)
            {
                using PostponeEventForm form = new(ev);
                if (form.ShowDialog() == DialogResult.OK)
                    eventLogic.Postpone(ev.Id, form.NewDate, form.NewTime);
            }
            Close();
        }
        private void buttonSkip_Click(object sender, EventArgs e) => Close();
    }
}
