namespace Diary.UI
{
    partial class OldEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxOutdated = new ListBox();
            label1 = new Label();
            buttonDeleteAll = new Button();
            buttonReschedule = new Button();
            buttonSkip = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxOutdated
            // 
            listBoxOutdated.Dock = DockStyle.Fill;
            listBoxOutdated.FormattingEnabled = true;
            listBoxOutdated.Location = new Point(0, 100);
            listBoxOutdated.Name = "listBoxOutdated";
            listBoxOutdated.Size = new Size(742, 256);
            listBoxOutdated.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(221, 29);
            label1.Name = "label1";
            label1.Size = new Size(300, 42);
            label1.TabIndex = 1;
            label1.Text = "Застарілі справи";
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Anchor = AnchorStyles.Top;
            buttonDeleteAll.Location = new Point(301, 17);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(140, 48);
            buttonDeleteAll.TabIndex = 2;
            buttonDeleteAll.Text = "Видалити всі";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // buttonReschedule
            // 
            buttonReschedule.Anchor = AnchorStyles.Top;
            buttonReschedule.Location = new Point(128, 17);
            buttonReschedule.Name = "buttonReschedule";
            buttonReschedule.Size = new Size(140, 48);
            buttonReschedule.TabIndex = 3;
            buttonReschedule.Text = "Перенести";
            buttonReschedule.UseVisualStyleBackColor = true;
            buttonReschedule.Click += buttonReschedule_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.Anchor = AnchorStyles.Top;
            buttonSkip.Location = new Point(473, 17);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(140, 48);
            buttonSkip.TabIndex = 4;
            buttonSkip.Text = "Пропустити";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 100);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(87, 77, 87);
            panel2.Controls.Add(buttonSkip);
            panel2.Controls.Add(buttonDeleteAll);
            panel2.Controls.Add(buttonReschedule);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 83);
            panel2.TabIndex = 6;
            // 
            // OldEventForm
            // 
            AcceptButton = buttonReschedule;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            CancelButton = buttonSkip;
            ClientSize = new Size(742, 439);
            Controls.Add(listBoxOutdated);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OldEventForm";
            Text = "OldEventForm";
            Load += OlddatedEventsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOutdated;
        private Label label1;
        private Button buttonDeleteAll;
        private Button buttonReschedule;
        private Button buttonSkip;
        private Panel panel1;
        private Panel panel2;
    }
}