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
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(267, 130);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 0;
            // 
            // listBoxOverlaps
            // 
            listBoxOverlaps.FormattingEnabled = true;
            listBoxOverlaps.Location = new Point(99, 208);
            listBoxOverlaps.Name = "listBoxOverlaps";
            listBoxOverlaps.Size = new Size(613, 184);
            listBoxOverlaps.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(694, 409);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // OverlaysForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(listBoxOverlaps);
            Controls.Add(labelResult);
            Name = "OverlaysForm";
            Text = "OverlaysForm";
            Load += OverlapForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private ListBox listBoxOverlaps;
        private Button buttonClose;
    }
}