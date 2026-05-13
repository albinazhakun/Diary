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
    public partial class RemindForm : Form
    {
        private readonly Event even;
        private readonly System.Windows.Forms.Timer timer;
        public RemindForm(Event ev)
        {
            InitializeComponent();
            even = ev;
            timer = new System.Windows.Forms.Timer { Interval = 30_000 };
            timer.Tick += (_, _) => Close();
            TopMost = true;
        }
        private void ReminderForm_Load(object sender, EventArgs e)
        {
            labelTitle.Text = $"Нагадування: Скоро розпочнеться «{even.Title}»";
            textBoxName.Text = even.Title;
            textBoxTime.Text = even.Time.ToString("HH:mm");
            textBoxLocation.Text = even.Location ?? "—";
            timer.Start();
        }
        private void buttonOk_Click(object sender, EventArgs e) => Close();
        private void ReminderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }

     
    }
}
