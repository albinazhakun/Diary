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
            panelLeft = new Panel();
            buttonAllEvents = new Button();
            buttonOutdated = new Button();
            buttonCheckOverlays = new Button();
            buttonCategories = new Button();
            label1 = new Label();
            panel4 = new Panel();
            buttonSearch = new Button();
            comboBoxCategoryFilter = new ComboBox();
            textBoxSearch = new TextBox();
            panel3 = new Panel();
            panelTop = new Panel();
            buttonDelete = new Button();
            buttonPickDate = new Button();
            buttonEdit = new Button();
            buttonDayAfterTomorrow = new Button();
            buttonAdd = new Button();
            buttonTomorrow = new Button();
            buttonToday = new Button();
            buttonAllDates = new Button();
            dataGridViewEvents = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            labelNoResults = new Label();
            panelLeft.SuspendLayout();
            panel4.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(24, 24, 24);
            panelLeft.Controls.Add(buttonAllEvents);
            panelLeft.Controls.Add(buttonOutdated);
            panelLeft.Controls.Add(buttonCheckOverlays);
            panelLeft.Controls.Add(buttonCategories);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(panel4);
            panelLeft.Controls.Add(panel3);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(244, 668);
            panelLeft.TabIndex = 0;
            // 
            // buttonAllEvents
            // 
            buttonAllEvents.FlatAppearance.BorderSize = 0;
            buttonAllEvents.FlatStyle = FlatStyle.Flat;
            buttonAllEvents.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAllEvents.ForeColor = Color.FromArgb(184, 176, 160);
            buttonAllEvents.Location = new Point(-3, 100);
            buttonAllEvents.Name = "buttonAllEvents";
            buttonAllEvents.Size = new Size(244, 47);
            buttonAllEvents.TabIndex = 12;
            buttonAllEvents.Text = "Усі справи";
            buttonAllEvents.UseVisualStyleBackColor = true;
            buttonAllEvents.Click += buttonAllEvents_Click;
            // 
            // buttonOutdated
            // 
            buttonOutdated.FlatAppearance.BorderSize = 0;
            buttonOutdated.FlatStyle = FlatStyle.Flat;
            buttonOutdated.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOutdated.ForeColor = Color.FromArgb(184, 176, 160);
            buttonOutdated.Location = new Point(0, 259);
            buttonOutdated.Name = "buttonOutdated";
            buttonOutdated.Size = new Size(244, 47);
            buttonOutdated.TabIndex = 11;
            buttonOutdated.Text = "Застарілі справи";
            buttonOutdated.UseVisualStyleBackColor = true;
            buttonOutdated.Click += buttonOutdated_Click;
            // 
            // buttonCheckOverlays
            // 
            buttonCheckOverlays.FlatAppearance.BorderSize = 0;
            buttonCheckOverlays.FlatStyle = FlatStyle.Flat;
            buttonCheckOverlays.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckOverlays.ForeColor = Color.FromArgb(184, 176, 160);
            buttonCheckOverlays.Location = new Point(0, 206);
            buttonCheckOverlays.Name = "buttonCheckOverlays";
            buttonCheckOverlays.Size = new Size(244, 47);
            buttonCheckOverlays.TabIndex = 10;
            buttonCheckOverlays.Text = "Накладки";
            buttonCheckOverlays.UseVisualStyleBackColor = true;
            buttonCheckOverlays.Click += buttonCheckOverlays_Click;
            // 
            // buttonCategories
            // 
            buttonCategories.FlatAppearance.BorderSize = 0;
            buttonCategories.FlatStyle = FlatStyle.Flat;
            buttonCategories.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCategories.ForeColor = Color.FromArgb(184, 176, 160);
            buttonCategories.Location = new Point(0, 153);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(244, 47);
            buttonCategories.TabIndex = 9;
            buttonCategories.Text = "Категорії";
            buttonCategories.UseVisualStyleBackColor = true;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 176, 176);
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 4;
            label1.Text = "МЕНЮ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(136, 120, 120);
            panel4.Controls.Add(buttonSearch);
            panel4.Controls.Add(comboBoxCategoryFilter);
            panel4.Controls.Add(textBoxSearch);
            panel4.Location = new Point(0, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 248);
            panel4.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.ForeColor = Color.FromArgb(24, 24, 24);
            buttonSearch.Location = new Point(53, 163);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(141, 39);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Location = new Point(35, 108);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(180, 28);
            comboBoxCategoryFilter.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(35, 60);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 10);
            panel3.TabIndex = 2;
            // 
            // panelTop
            // 
            panelTop.AutoScroll = true;
            panelTop.BackColor = Color.FromArgb(80, 72, 72);
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonPickDate);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonDayAfterTomorrow);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(buttonTomorrow);
            panelTop.Controls.Add(buttonToday);
            panelTop.Controls.Add(buttonAllDates);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(244, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(967, 72);
            panelTop.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(827, 18);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(99, 42);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonPickDate
            // 
            buttonPickDate.Location = new Point(401, 44);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(93, 29);
            buttonPickDate.TabIndex = 4;
            buttonPickDate.Text = "Обрати";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(709, 18);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 42);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDayAfterTomorrow
            // 
            buttonDayAfterTomorrow.Location = new Point(300, 44);
            buttonDayAfterTomorrow.Name = "buttonDayAfterTomorrow";
            buttonDayAfterTomorrow.Size = new Size(94, 29);
            buttonDayAfterTomorrow.TabIndex = 3;
            buttonDayAfterTomorrow.Text = "Післязавтра";
            buttonDayAfterTomorrow.UseVisualStyleBackColor = true;
            buttonDayAfterTomorrow.Click += buttonDayAfterTomorrow_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(586, 18);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(99, 42);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonTomorrow
            // 
            buttonTomorrow.Location = new Point(200, 44);
            buttonTomorrow.Name = "buttonTomorrow";
            buttonTomorrow.Size = new Size(94, 29);
            buttonTomorrow.TabIndex = 2;
            buttonTomorrow.Text = "Завтра";
            buttonTomorrow.UseVisualStyleBackColor = true;
            buttonTomorrow.Click += buttonTomorrow_Click;
            // 
            // buttonToday
            // 
            buttonToday.Location = new Point(100, 44);
            buttonToday.Name = "buttonToday";
            buttonToday.Size = new Size(94, 29);
            buttonToday.TabIndex = 1;
            buttonToday.Text = "Сьогодні";
            buttonToday.UseVisualStyleBackColor = true;
            buttonToday.Click += buttonToday_Click;
            // 
            // buttonAllDates
            // 
            buttonAllDates.Location = new Point(0, 44);
            buttonAllDates.Name = "buttonAllDates";
            buttonAllDates.Size = new Size(94, 29);
            buttonAllDates.TabIndex = 0;
            buttonAllDates.Text = "Усі дати";
            buttonAllDates.UseVisualStyleBackColor = true;
            buttonAllDates.Click += buttonAllDates_Click;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.BackgroundColor = Color.FromArgb(184, 176, 176);
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Columns.AddRange(new DataGridViewColumn[] { colTitle, colDate, colTime, colDuration, colLocation, colCategory, colPriority });
            dataGridViewEvents.Location = new Point(272, 112);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(911, 522);
            dataGridViewEvents.TabIndex = 2;
            dataGridViewEvents.Visible = false;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Назва";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.Width = 125;
            // 
            // colDate
            // 
            colDate.HeaderText = "Дата";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.Width = 125;
            // 
            // colTime
            // 
            colTime.HeaderText = "Час";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.Width = 125;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Тривалість(хв)";
            colDuration.MinimumWidth = 6;
            colDuration.Name = "colDuration";
            colDuration.Width = 125;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Місце";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.Width = 125;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Категорія";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.Width = 125;
            // 
            // colPriority
            // 
            colPriority.HeaderText = "Пріорітет";
            colPriority.MinimumWidth = 6;
            colPriority.Name = "colPriority";
            colPriority.Width = 125;
            // 
            // labelNoResults
            // 
            labelNoResults.AutoSize = true;
            labelNoResults.BackColor = Color.FromArgb(184, 176, 176);
            labelNoResults.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNoResults.ForeColor = SystemColors.ControlDarkDark;
            labelNoResults.Location = new Point(634, 356);
            labelNoResults.Name = "labelNoResults";
            labelNoResults.Size = new Size(183, 28);
            labelNoResults.TabIndex = 3;
            labelNoResults.Text = "Збігів не знайдено";
            labelNoResults.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1211, 668);
            Controls.Add(labelNoResults);
            Controls.Add(dataGridViewEvents);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            ForeColor = Color.LightSalmon;
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClothing;
            Load += MainForm_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLeft;
        private Panel panelTop;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button buttonSearch;
        private ComboBox comboBoxCategoryFilter;
        private TextBox textBoxSearch;
        private Button buttonOutdated;
        private Button buttonCheckOverlays;
        private Button buttonCategories;
        private Button buttonAllEvents;
        private DataGridView dataGridViewEvents;
        private Label labelNoResults;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonPickDate;
        private Button buttonDayAfterTomorrow;
        private Button buttonTomorrow;
        private Button buttonToday;
        private Button buttonAllDates;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPriority;
    }
}