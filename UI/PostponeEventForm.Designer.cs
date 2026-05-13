namespace Diary.UI
{
    partial class PostponeEventForm
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
            labelEventName = new Label();
            label2 = new Label();
            dateTimePickerNewDate = new DateTimePicker();
            label3 = new Label();
            dateTimePickerNewTime = new DateTimePicker();
            buttonOk = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            labelEventName.ForeColor = Color.OldLace;
            labelEventName.Location = new Point(175, 60);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(0, 31);
            labelEventName.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(96, 42);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Нова дата";
            // 
            // dateTimePickerNewDate
            // 
            dateTimePickerNewDate.Anchor = AnchorStyles.Top;
            dateTimePickerNewDate.Format = DateTimePickerFormat.Short;
            dateTimePickerNewDate.Location = new Point(193, 42);
            dateTimePickerNewDate.Name = "dateTimePickerNewDate";
            dateTimePickerNewDate.Size = new Size(250, 27);
            dateTimePickerNewDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(93, 110);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 3;
            label3.Text = "Новий час";
            // 
            // dateTimePickerNewTime
            // 
            dateTimePickerNewTime.Anchor = AnchorStyles.Top;
            dateTimePickerNewTime.Format = DateTimePickerFormat.Time;
            dateTimePickerNewTime.Location = new Point(193, 110);
            dateTimePickerNewTime.Name = "dateTimePickerNewTime";
            dateTimePickerNewTime.Size = new Size(250, 27);
            dateTimePickerNewTime.TabIndex = 4;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Right;
            buttonOk.Location = new Point(517, 14);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Location = new Point(417, 14);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 64, 72);
            panel1.Controls.Add(labelEventName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 151);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 64, 72);
            panel2.Controls.Add(buttonOk);
            panel2.Controls.Add(buttonCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 55);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(87, 77, 87);
            panel3.Controls.Add(dateTimePickerNewTime);
            panel3.Controls.Add(dateTimePickerNewDate);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 173);
            panel3.TabIndex = 9;
            // 
            // PostponeEventForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(87, 77, 87);
            CancelButton = buttonCancel;
            ClientSize = new Size(636, 379);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PostponeEventForm";
            Text = "PostponeEventForm";
            Load += RescheduleEventForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelEventName;
        private Label label2;
        private DateTimePicker dateTimePickerNewDate;
        private Label label3;
        private DateTimePicker dateTimePickerNewTime;
        private Button buttonOk;
        private Button buttonCancel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}