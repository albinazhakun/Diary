namespace Diary.UI
{
    partial class CategoryListForm
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
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            listBoxCategories = new ListBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top;
            buttonAdd.Location = new Point(115, 16);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(133, 56);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top;
            buttonEdit.Location = new Point(282, 16);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(133, 56);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top;
            buttonDelete.Location = new Point(448, 16);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(133, 56);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(87, 77, 87);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 389);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 90);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(262, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 42);
            label1.TabIndex = 6;
            label1.Text = "Категорії";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(697, 92);
            panel3.TabIndex = 7;
            // 
            // listBoxCategories
            // 
            listBoxCategories.BackColor = Color.White;
            listBoxCategories.Dock = DockStyle.Fill;
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.Location = new Point(0, 92);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(697, 297);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            ClientSize = new Size(697, 479);
            Controls.Add(listBoxCategories);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CategoryListForm";
            Text = "Категорії";
            Load += CategoryListForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private ListBox listBoxCategories;
    }
}