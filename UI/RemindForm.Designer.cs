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
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(325, 67);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(0, 20);
            labelTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Назва";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(316, 131);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 211);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 3;
            label3.Text = "Час початку";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(341, 200);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(125, 27);
            textBoxTime.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 291);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 5;
            label4.Text = "Місце проведення";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(322, 280);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.ReadOnly = true;
            textBoxLocation.Size = new Size(125, 27);
            textBoxLocation.TabIndex = 6;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(694, 409);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // RemindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk);
            Controls.Add(textBoxLocation);
            Controls.Add(label4);
            Controls.Add(textBoxTime);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Name = "RemindForm";
            Text = "RemindForm";
            FormClosing += ReminderForm_FormClosing;
            Load += ReminderForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}