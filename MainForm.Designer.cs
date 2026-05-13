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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            buttonAllEvents = new Button();
            buttonOutdated = new Button();
            buttonCheckOverlays = new Button();
            buttonCategories = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            buttonSearch = new Button();
            comboBoxCategoryFilter = new ComboBox();
            textBoxSearch = new TextBox();
            panel3 = new Panel();
            panelTop = new Panel();
            buttonPickDate = new Button();
            buttonDayAfterTomorrow = new Button();
            buttonTomorrow = new Button();
            buttonToday = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            labelNoResults = new Label();
            dataGridViewEvents = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panelLeft.SuspendLayout();
            panel4.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            panel1.SuspendLayout();
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
            panelLeft.Paint += panelLeft_Paint;
            // 
            // buttonAllEvents
            // 
            buttonAllEvents.Anchor = AnchorStyles.Left;
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
            buttonOutdated.Anchor = AnchorStyles.Left;
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
            buttonCheckOverlays.Anchor = AnchorStyles.Left;
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
            buttonCategories.Anchor = AnchorStyles.Left;
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
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 176, 176);
            label1.Location = new Point(82, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 4;
            label1.Text = "МЕНЮ";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.FromArgb(136, 120, 120);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(buttonSearch);
            panel4.Controls.Add(comboBoxCategoryFilter);
            panel4.Controls.Add(textBoxSearch);
            panel4.Location = new Point(0, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 245);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(24, 24, 24);
            label2.Location = new Point(78, 19);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 13;
            label2.Text = "ПОШУК";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Left;
            buttonSearch.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.ForeColor = Color.FromArgb(24, 24, 24);
            buttonSearch.Location = new Point(52, 169);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(141, 39);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.Anchor = AnchorStyles.Left;
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Location = new Point(32, 114);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(180, 28);
            comboBoxCategoryFilter.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left;
            textBoxSearch.Location = new Point(32, 66);
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
            panelTop.Controls.Add(buttonPickDate);
            panelTop.Controls.Add(buttonDayAfterTomorrow);
            panelTop.Controls.Add(buttonTomorrow);
            panelTop.Controls.Add(buttonToday);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(244, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(967, 73);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // buttonPickDate
            // 
            buttonPickDate.Anchor = AnchorStyles.Top;
            buttonPickDate.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonPickDate.ForeColor = Color.FromArgb(24, 24, 24);
            buttonPickDate.Location = new Point(659, 14);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(136, 44);
            buttonPickDate.TabIndex = 4;
            buttonPickDate.Text = "Обрати";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // buttonDayAfterTomorrow
            // 
            buttonDayAfterTomorrow.Anchor = AnchorStyles.Top;
            buttonDayAfterTomorrow.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonDayAfterTomorrow.ForeColor = Color.FromArgb(24, 24, 24);
            buttonDayAfterTomorrow.Location = new Point(504, 14);
            buttonDayAfterTomorrow.Name = "buttonDayAfterTomorrow";
            buttonDayAfterTomorrow.Size = new Size(136, 44);
            buttonDayAfterTomorrow.TabIndex = 3;
            buttonDayAfterTomorrow.Text = "Післязавтра";
            buttonDayAfterTomorrow.UseVisualStyleBackColor = true;
            buttonDayAfterTomorrow.Click += buttonDayAfterTomorrow_Click;
            // 
            // buttonTomorrow
            // 
            buttonTomorrow.Anchor = AnchorStyles.Top;
            buttonTomorrow.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonTomorrow.ForeColor = Color.FromArgb(24, 24, 24);
            buttonTomorrow.Location = new Point(338, 14);
            buttonTomorrow.Name = "buttonTomorrow";
            buttonTomorrow.Size = new Size(136, 44);
            buttonTomorrow.TabIndex = 2;
            buttonTomorrow.Text = "Завтра";
            buttonTomorrow.UseVisualStyleBackColor = true;
            buttonTomorrow.Click += buttonTomorrow_Click;
            // 
            // buttonToday
            // 
            buttonToday.Anchor = AnchorStyles.Top;
            buttonToday.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonToday.ForeColor = Color.FromArgb(24, 24, 24);
            buttonToday.Location = new Point(181, 14);
            buttonToday.Name = "buttonToday";
            buttonToday.Size = new Size(136, 44);
            buttonToday.TabIndex = 1;
            buttonToday.Text = "Сьогодні";
            buttonToday.UseVisualStyleBackColor = true;
            buttonToday.Click += buttonToday_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top;
            buttonDelete.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonDelete.ForeColor = Color.FromArgb(24, 24, 24);
            buttonDelete.Location = new Point(593, 14);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(153, 45);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top;
            buttonEdit.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonEdit.ForeColor = Color.FromArgb(24, 24, 24);
            buttonEdit.Location = new Point(421, 14);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(153, 45);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top;
            buttonAdd.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            buttonAdd.ForeColor = Color.FromArgb(24, 24, 24);
            buttonAdd.Location = new Point(248, 14);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(153, 45);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelNoResults
            // 
            labelNoResults.AutoSize = true;
            labelNoResults.BackColor = Color.White;
            labelNoResults.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNoResults.ForeColor = SystemColors.ControlDarkDark;
            labelNoResults.Location = new Point(634, 356);
            labelNoResults.Name = "labelNoResults";
            labelNoResults.Size = new Size(183, 28);
            labelNoResults.TabIndex = 3;
            labelNoResults.Text = "Збігів не знайдено";
            labelNoResults.Visible = false;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.BackgroundColor = Color.White;
            dataGridViewEvents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(184, 176, 176);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 176, 176);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Columns.AddRange(new DataGridViewColumn[] { colTitle, colDate, colTime, colDuration, colLocation, colCategory, colPriority });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightSalmon;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEvents.Dock = DockStyle.Fill;
            dataGridViewEvents.EnableHeadersVisualStyles = false;
            dataGridViewEvents.GridColor = Color.Silver;
            dataGridViewEvents.Location = new Point(244, 73);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.RowTemplate.Height = 35;
            dataGridViewEvents.Size = new Size(967, 595);
            dataGridViewEvents.TabIndex = 2;
            dataGridViewEvents.CellClick += dataGridViewEvents_CellClick;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(184, 176, 176);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(244, 597);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 71);
            panel1.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1211, 668);
            Controls.Add(panel1);
            Controls.Add(labelNoResults);
            Controls.Add(dataGridViewEvents);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            ForeColor = Color.LightSalmon;
            Name = "MainForm";
            Text = "Щоденник";
            FormClosing += MainForm_FormClothing;
            Load += MainForm_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            panel1.ResumeLayout(false);
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
        private Label labelNoResults;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonPickDate;
        private Button buttonDayAfterTomorrow;
        private Button buttonTomorrow;
        private Button buttonToday;
        private DataGridView dataGridViewEvents;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPriority;
        private Label label2;
        private Panel panel1;
    }
}