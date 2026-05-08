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
            SuspendLayout();
            // 
            // listBoxOutdated
            // 
            listBoxOutdated.FormattingEnabled = true;
            listBoxOutdated.Location = new Point(45, 202);
            listBoxOutdated.Name = "listBoxOutdated";
            listBoxOutdated.Size = new Size(721, 144);
            listBoxOutdated.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Застарілі справи";
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Location = new Point(130, 379);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(136, 29);
            buttonDeleteAll.TabIndex = 2;
            buttonDeleteAll.Text = "Видалити всі";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // buttonReschedule
            // 
            buttonReschedule.Location = new Point(341, 379);
            buttonReschedule.Name = "buttonReschedule";
            buttonReschedule.Size = new Size(94, 29);
            buttonReschedule.TabIndex = 3;
            buttonReschedule.Text = "Перенести";
            buttonReschedule.UseVisualStyleBackColor = true;
            buttonReschedule.Click += buttonReschedule_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.Location = new Point(499, 379);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(109, 29);
            buttonSkip.TabIndex = 4;
            buttonSkip.Text = "Пропустити";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // OldEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSkip);
            Controls.Add(buttonReschedule);
            Controls.Add(buttonDeleteAll);
            Controls.Add(label1);
            Controls.Add(listBoxOutdated);
            Name = "OldEventForm";
            Text = "OldEventForm";
            Load += OlddatedEventsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxOutdated;
        private Label label1;
        private Button buttonDeleteAll;
        private Button buttonReschedule;
        private Button buttonSkip;
    }
}