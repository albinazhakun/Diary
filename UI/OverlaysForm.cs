using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diary.Logic;

namespace Diary.UI
{
    public partial class OverlaysForm : Form
    {
        private readonly List<OverlaysResult> overlap;
        public OverlaysForm(List<OverlaysResult> over)
        {
            InitializeComponent();
            overlap = over;
        }
        private void OverlapForm_Load(object sender, EventArgs e)
        {
            if (overlap.Count == 0)
            {
                labelResult.Text = "Накладок не виявлено.";
                return;
            }
            labelResult.Text = $"Виявлено накладок: {overlap.Count}";
            foreach (OverlaysResult o in overlap)
                listBoxOverlaps.Items.Add(
                    $"«{o.EventA.Title}» ({o.EventA.Time:HH:mm}) та " +
                    $"«{o.EventB.Title}» ({o.EventB.Time:HH:mm}) — {o.OverlaysMinut} хв.");
        }
        private void buttonClose_Click(object sender, EventArgs e) => Close();
    
    }
}
