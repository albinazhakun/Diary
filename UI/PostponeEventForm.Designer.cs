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
            SuspendLayout();
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Location = new Point(351, 51);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(0, 20);
            labelEventName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Нова дата";
            // 
            // dateTimePickerNewDate
            // 
            dateTimePickerNewDate.Format = DateTimePickerFormat.Short;
            dateTimePickerNewDate.Location = new Point(266, 157);
            dateTimePickerNewDate.Name = "dateTimePickerNewDate";
            dateTimePickerNewDate.Size = new Size(250, 27);
            dateTimePickerNewDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 271);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Новий час";
            // 
            // dateTimePickerNewTime
            // 
            dateTimePickerNewTime.Format = DateTimePickerFormat.Time;
            dateTimePickerNewTime.Location = new Point(266, 271);
            dateTimePickerNewTime.Name = "dateTimePickerNewTime";
            dateTimePickerNewTime.Size = new Size(250, 27);
            dateTimePickerNewTime.TabIndex = 4;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(694, 409);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(594, 409);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PostponeEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(dateTimePickerNewTime);
            Controls.Add(label3);
            Controls.Add(dateTimePickerNewDate);
            Controls.Add(label2);
            Controls.Add(labelEventName);
            Name = "PostponeEventForm";
            Text = "PostponeEventForm";
            Load += RescheduleEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEventName;
        private Label label2;
        private DateTimePicker dateTimePickerNewDate;
        private Label label3;
        private DateTimePicker dateTimePickerNewTime;
        private Button buttonOk;
        private Button buttonCancel;
    }
}