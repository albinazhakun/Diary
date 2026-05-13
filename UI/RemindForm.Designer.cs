namespace Diary.UI
{
    partial class RemindForm
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
            labelTitle = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxTime = new TextBox();
            label4 = new Label();
            textBoxLocation = new TextBox();
            buttonOk = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            labelTitle.ForeColor = Color.OldLace;
            labelTitle.Location = new Point(88, 61);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(0, 31);
            labelTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(140, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Назва";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.Location = new Point(204, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(297, 27);
            textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(90, 110);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 3;
            label3.Text = "Час початку";
            // 
            // textBoxTime
            // 
            textBoxTime.Anchor = AnchorStyles.Top;
            textBoxTime.Location = new Point(204, 109);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(297, 27);
            textBoxTime.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.OldLace;
            label4.Location = new Point(39, 180);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 5;
            label4.Text = "Місце проведення";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Anchor = AnchorStyles.Top;
            textBoxLocation.Location = new Point(204, 176);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.ReadOnly = true;
            textBoxLocation.Size = new Size(297, 27);
            textBoxLocation.TabIndex = 6;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Right;
            buttonOk.Location = new Point(599, 14);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 64, 72);
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 151);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 64, 72);
            panel2.Controls.Add(buttonOk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 55);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(87, 77, 87);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxLocation);
            panel3.Controls.Add(textBoxName);
            panel3.Controls.Add(textBoxTime);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 275);
            panel3.TabIndex = 10;
            // 
            // RemindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(87, 77, 87);
            CancelButton = buttonOk;
            ClientSize = new Size(705, 481);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RemindForm";
            Text = "RemindForm";
            FormClosing += ReminderForm_FormClosing;
            Load += ReminderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxTime;
        private Label label4;
        private TextBox textBoxLocation;
        private Button buttonOk;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}