namespace Diary.UI
{
    partial class EventForm
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
            label1 = new Label();
            textBoxTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            numericUpDownDuration = new NumericUpDown();
            textBoxLocation = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxPriority = new ComboBox();
            label8 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(184, 176, 176);
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(177, 31);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(250, 180);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(406, 63);
            textBoxTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(184, 176, 176);
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(27, 165);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(184, 176, 176);
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(242, 165);
            label3.Name = "label3";
            label3.Size = new Size(44, 24);
            label3.TabIndex = 3;
            label3.Text = "Час";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(184, 176, 176);
            label4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(463, 166);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 4;
            label4.Text = "Тривалість(хв)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(184, 176, 176);
            label5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(52, 265);
            label5.Name = "label5";
            label5.Size = new Size(184, 24);
            label5.TabIndex = 5;
            label5.Text = "Місце проведення";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(184, 176, 176);
            label6.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(40, 40, 40);
            label6.Location = new Point(85, 355);
            label6.Name = "label6";
            label6.Size = new Size(99, 24);
            label6.TabIndex = 6;
            label6.Text = "Категорія";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(184, 176, 176);
            label7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(40, 40, 40);
            label7.Location = new Point(401, 355);
            label7.Name = "label7";
            label7.Size = new Size(101, 24);
            label7.TabIndex = 7;
            label7.Text = "Пріоритет";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(565, 429);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCansel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(675, 429);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(85, 164);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(118, 27);
            dateTimePickerDate.TabIndex = 10;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(292, 165);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(118, 27);
            dateTimePickerTime.TabIndex = 11;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(613, 164);
            numericUpDownDuration.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericUpDownDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(118, 27);
            numericUpDownDuration.TabIndex = 12;
            numericUpDownDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(250, 14);
            textBoxLocation.Multiline = true;
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(406, 63);
            textBoxLocation.TabIndex = 13;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(190, 351);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 14;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(508, 351);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(151, 28);
            comboBoxPriority.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.OldLace;
            label8.Location = new Point(272, 9);
            label8.Name = "label8";
            label8.Size = new Size(230, 41);
            label8.TabIndex = 16;
            label8.Text = "Нова справа";
            label8.Click += label8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(184, 176, 176);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxLocation);
            panel1.Controls.Add(textBoxTitle);
            panel1.Location = new Point(-8, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 337);
            panel1.TabIndex = 17;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            ClientSize = new Size(781, 470);
            Controls.Add(label8);
            Controls.Add(comboBoxPriority);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownDuration);
            Controls.Add(dateTimePickerTime);
            Controls.Add(dateTimePickerDate);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonCancel;
        private Button buttonOk;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTime;
        private NumericUpDown numericUpDownDuration;
        private TextBox textBoxLocation;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxPriority;
        private Label label8;
        private Panel panel1;
    }
}