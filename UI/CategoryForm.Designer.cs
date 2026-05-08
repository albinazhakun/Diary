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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label1.Location = new Point(118, 93);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(197, 80);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(504, 48);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(197, 152);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(504, 112);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(129, 194);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 3;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label3.Location = new Point(124, 314);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 4;
            label3.Text = "Колір";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(197, 315);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(177, 27);
            textBoxColor.TabIndex = 5;
            // 
            // panelColorPreview
            // 
            panelColorPreview.Location = new Point(412, 314);
            panelColorPreview.Name = "panelColorPreview";
            panelColorPreview.Size = new Size(30, 30);
            panelColorPreview.TabIndex = 6;
            // 
            // buttonPickColor
            // 
            buttonPickColor.Location = new Point(225, 365);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(177, 29);
            buttonPickColor.TabIndex = 7;
            buttonPickColor.Text = "Обрати колір";
            buttonPickColor.UseVisualStyleBackColor = true;
            buttonPickColor.Click += buttonPickColor_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(694, 409);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(594, 409);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(buttonPickColor);
            Controls.Add(panelColorPreview);
            Controls.Add(textBoxColor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}