namespace Diary
{
    partial class MainForm
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 45, 28);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 668);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Bisque;
            button5.Location = new Point(0, 259);
            button5.Name = "button5";
            button5.Size = new Size(244, 47);
            button5.TabIndex = 11;
            button5.Text = "Застарілі справи";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Bisque;
            button4.Location = new Point(0, 206);
            button4.Name = "button4";
            button4.Size = new Size(244, 47);
            button4.TabIndex = 10;
            button4.Text = "Накладки";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Bisque;
            button3.Location = new Point(0, 153);
            button3.Name = "button3";
            button3.Size = new Size(244, 47);
            button3.TabIndex = 9;
            button3.Text = "Категорії";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 4;
            label1.Text = "МЕНЮ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(132, 89, 43);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(0, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 248);
            panel4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(53, 163);
            button2.Name = "button2";
            button2.Size = new Size(141, 39);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(79, 53, 36);
            panel3.Location = new Point(0, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 10);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(116, 48, 20);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(244, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 72);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Bisque;
            button1.Location = new Point(-3, 100);
            button1.Name = "button1";
            button1.Size = new Size(244, 47);
            button1.TabIndex = 12;
            button1.Text = "Усі справи";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 187, 153);
            ClientSize = new Size(1211, 668);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.LightSalmon;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button buttonAllEvents;
        private Button button1;
    }
}