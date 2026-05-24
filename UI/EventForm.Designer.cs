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
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(71, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            label1.Click += label1_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top;
            textBoxTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxTitle.Location = new Point(135, 26);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(577, 41);
            textBoxTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(99, 25);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(319, 26);
            label3.Name = "label3";
            label3.Size = new Size(39, 23);
            label3.TabIndex = 3;
            label3.Text = "Час";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.OldLace;
            label4.Location = new Point(513, 25);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 4;
            label4.Text = "Тривалість(хв)";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.OldLace;
            label5.Location = new Point(55, 38);
            label5.Name = "label5";
            label5.Size = new Size(159, 23);
            label5.TabIndex = 5;
            label5.Text = "Місце проведення";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.OldLace;
            label6.Location = new Point(129, 24);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 6;
            label6.Text = "Категорія";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.OldLace;
            label7.Location = new Point(465, 24);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 7;
            label7.Text = "Пріоритет";
            label7.Click += label7_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Location = new Point(641, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCansel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Right;
            buttonOk.Location = new Point(741, 9);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Anchor = AnchorStyles.Top;
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(152, 23);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(118, 27);
            dateTimePickerDate.TabIndex = 10;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Anchor = AnchorStyles.Top;
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(364, 23);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(118, 27);
            dateTimePickerTime.TabIndex = 11;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Anchor = AnchorStyles.Top;
            numericUpDownDuration.Location = new Point(643, 23);
            numericUpDownDuration.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericUpDownDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(118, 27);
            numericUpDownDuration.TabIndex = 12;
            numericUpDownDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxLocation
            // 
            textBoxLocation.Anchor = AnchorStyles.Top;
            textBoxLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLocation.Location = new Point(220, 19);
            textBoxLocation.Multiline = true;
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(492, 61);
            textBoxLocation.TabIndex = 13;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(220, 22);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 14;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Anchor = AnchorStyles.Top;
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(561, 22);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(151, 28);
            comboBoxPriority.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.OldLace;
            label8.Location = new Point(309, 15);
            label8.Name = "label8";
            label8.Size = new Size(228, 42);
            label8.TabIndex = 16;
            label8.Text = "Нова справа";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 73);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonOk);
            panel3.Controls.Add(buttonCancel);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 47);
            panel3.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(87, 77, 87);
            panel1.Controls.Add(textBoxTitle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 123);
            panel1.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(87, 77, 87);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dateTimePickerDate);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dateTimePickerTime);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(numericUpDownDuration);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 85);
            panel4.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(87, 77, 87);
            panel5.Controls.Add(textBoxLocation);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 281);
            panel5.Name = "panel5";
            panel5.Size = new Size(846, 113);
            panel5.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(87, 77, 87);
            panel6.Controls.Add(comboBoxPriority);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(comboBoxCategory);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 394);
            panel6.Name = "panel6";
            panel6.Size = new Size(846, 99);
            panel6.TabIndex = 23;
            // 
            // EventForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            CancelButton = buttonCancel;
            ClientSize = new Size(846, 539);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "EventForm";
            Text = "Нова справа";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}