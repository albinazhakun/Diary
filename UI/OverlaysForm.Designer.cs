namespace Diary.UI
{
    partial class OverlaysForm
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
            labelResult = new Label();
            listBoxOverlaps = new ListBox();
            buttonClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top;
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.ForeColor = Color.OldLace;
            labelResult.Location = new Point(186, 70);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 31);
            labelResult.TabIndex = 0;
            // 
            // listBoxOverlaps
            // 
            listBoxOverlaps.Dock = DockStyle.Fill;
            listBoxOverlaps.FormattingEnabled = true;
            listBoxOverlaps.Location = new Point(0, 175);
            listBoxOverlaps.Name = "listBoxOverlaps";
            listBoxOverlaps.Size = new Size(758, 207);
            listBoxOverlaps.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Right;
            buttonClose.Location = new Point(652, 11);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 64, 72);
            panel1.Controls.Add(labelResult);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 175);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(87, 77, 87);
            panel2.Controls.Add(buttonClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 52);
            panel2.TabIndex = 4;
            // 
            // OverlaysForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(758, 434);
            Controls.Add(listBoxOverlaps);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OverlaysForm";
            Text = "Накладки";
            Load += OverlapForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelResult;
        private ListBox listBoxOverlaps;
        private Button buttonClose;
        private Panel panel1;
        private Panel panel2;
    }
}