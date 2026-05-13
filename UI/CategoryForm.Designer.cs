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
            panel2 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label1.Location = new Point(75, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            label1.Click += label1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(148, 19);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(504, 48);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(148, 110);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(504, 112);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(86, 148);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 3;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label3.Location = new Point(148, 260);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 4;
            label3.Text = "Колір";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(279, 262);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(177, 27);
            textBoxColor.TabIndex = 5;
            // 
            // panelColorPreview
            // 
            panelColorPreview.Location = new Point(229, 260);
            panelColorPreview.Name = "panelColorPreview";
            panelColorPreview.Size = new Size(30, 30);
            panelColorPreview.TabIndex = 6;
            // 
            // buttonPickColor
            // 
            buttonPickColor.Location = new Point(475, 261);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(177, 29);
            buttonPickColor.TabIndex = 7;
            buttonPickColor.Text = "Обрати колір";
            buttonPickColor.UseVisualStyleBackColor = true;
            buttonPickColor.Click += buttonPickColor_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top;
            buttonOk.Location = new Point(678, 13);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top;
            buttonCancel.Location = new Point(578, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 74);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonOk);
            panel2.Controls.Add(buttonCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 54);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(87, 77, 87);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panelColorPreview);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxName);
            panel3.Controls.Add(textBoxDescription);
            panel3.Controls.Add(buttonPickColor);
            panel3.Controls.Add(textBoxColor);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 395);
            panel3.TabIndex = 12;
            // 
            // CategoryForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            CancelButton = buttonCancel;
            ClientSize = new Size(769, 523);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}