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
            listBoxCategories = new ListBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listBoxCategories
            // 
            listBoxCategories.BackColor = Color.White;
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.Location = new Point(12, 12);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(776, 344);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(175, 370);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(133, 56);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(342, 370);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(133, 56);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(508, 370);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(133, 56);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 64, 72);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxCategories);
            Name = "CategoryListForm";
            Text = "CategoryListForm";
            Load += CategoryListForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCategories;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}