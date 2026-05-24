namespace Diary.UI
{
    partial class CategoryForm
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxColor = new TextBox();
            panelColorPreview = new Panel();
            buttonPickColor = new Button();
            buttonOk = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(72, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            label1.Click += label1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.Location = new Point(145, 24);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(504, 58);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top;
            textBoxDescription.Location = new Point(145, 37);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(504, 71);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(83, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 3;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(78, 35);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 4;
            label3.Text = "Колір";
            // 
            // textBoxColor
            // 
            textBoxColor.Anchor = AnchorStyles.Top;
            textBoxColor.Location = new Point(478, 37);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(177, 27);
            textBoxColor.TabIndex = 5;
            // 
            // panelColorPreview
            // 
            panelColorPreview.Anchor = AnchorStyles.Top;
            panelColorPreview.Location = new Point(156, 35);
            panelColorPreview.Name = "panelColorPreview";
            panelColorPreview.Size = new Size(30, 29);
            panelColorPreview.TabIndex = 6;
            // 
            // buttonPickColor
            // 
            buttonPickColor.Anchor = AnchorStyles.Top;
            buttonPickColor.Location = new Point(203, 35);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(177, 29);
            buttonPickColor.TabIndex = 7;
            buttonPickColor.Text = "Обрати колір";
            buttonPickColor.UseVisualStyleBackColor = true;
            buttonPickColor.Click += buttonPickColor_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(620, 13);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(520, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 74);
            panel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.OldLace;
            label8.Location = new Point(246, 16);
            label8.Name = "label8";
            label8.Size = new Size(183, 42);
            label8.TabIndex = 17;
            label8.Text = "Категорія";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonOk);
            panel2.Controls.Add(buttonCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 54);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(87, 77, 87);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 100);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(87, 77, 87);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBoxDescription);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 174);
            panel4.Name = "panel4";
            panel4.Size = new Size(721, 144);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(87, 77, 87);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBoxColor);
            panel5.Controls.Add(buttonPickColor);
            panel5.Controls.Add(panelColorPreview);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 318);
            panel5.Name = "panel5";
            panel5.Size = new Size(721, 98);
            panel5.TabIndex = 14;
            // 
            // CategoryForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            CancelButton = buttonCancel;
            ClientSize = new Size(721, 469);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Text = "Категорія";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label label2;
        private Label label3;
        private TextBox textBoxColor;
        private Panel panelColorPreview;
        private Button buttonPickColor;
        private Button buttonOk;
        private Button buttonCancel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Panel panel4;
        private Panel panel5;
    }
}