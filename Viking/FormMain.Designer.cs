namespace Viking
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelAddClient = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPatronomyc = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelAboniment = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.monthCalendarBirthday2 = new System.Windows.Forms.MonthCalendar();
            this.labelTest = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.pictureBoxIcon);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1184, 107);
            this.panelMain.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(113, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(273, 82);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Viking";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(104, 94);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelAddClient
            // 
            this.labelAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddClient.AutoSize = true;
            this.labelAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddClient.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAddClient.Location = new System.Drawing.Point(450, 113);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(309, 31);
            this.labelAddClient.TabIndex = 1;
            this.labelAddClient.Text = "ДОБАВИТЬ КЛИЕНТА";
            this.labelAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddClient.Click += new System.EventHandler(this.labelAddClient_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(-10, 147);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.Size = new System.Drawing.Size(1194, 457);
            this.dataGridViewClients.TabIndex = 5;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(110, 113);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(334, 31);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(126, 621);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 31);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(127, 662);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(219, 31);
            this.textBoxSurname.TabIndex = 8;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(127, 708);
            this.textBoxPatronymic.Multiline = true;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(219, 31);
            this.textBoxPatronymic.TabIndex = 9;
            this.textBoxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(554, 621);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(219, 31);
            this.textBoxPhoneNumber.TabIndex = 10;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(64, 621);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 25);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSurname.Location = new System.Drawing.Point(10, 662);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(111, 25);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPatronomyc
            // 
            this.labelPatronomyc.AutoSize = true;
            this.labelPatronomyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronomyc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPatronomyc.Location = new System.Drawing.Point(8, 708);
            this.labelPatronomyc.Name = "labelPatronomyc";
            this.labelPatronomyc.Size = new System.Drawing.Size(113, 25);
            this.labelPatronomyc.TabIndex = 13;
            this.labelPatronomyc.Text = "Отчество";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPhoneNumber.Location = new System.Drawing.Point(351, 621);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(197, 25);
            this.labelPhoneNumber.TabIndex = 14;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelStatus.Location = new System.Drawing.Point(462, 668);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(87, 25);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Клиент",
            "Бизнес-клиент",
            "Вип-клиент"});
            this.comboBoxStatus.Location = new System.Drawing.Point(555, 668);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(220, 32);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // labelEdit
            // 
            this.labelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEdit.AutoSize = true;
            this.labelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEdit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelEdit.Location = new System.Drawing.Point(43, 778);
            this.labelEdit.MinimumSize = new System.Drawing.Size(272, 24);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(272, 24);
            this.labelEdit.TabIndex = 19;
            this.labelEdit.Text = "РЕДАКТИРОВАТЬ";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEdit.Click += new System.EventHandler(this.labelEdit_Click);
            // 
            // labelAboniment
            // 
            this.labelAboniment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboniment.AutoSize = true;
            this.labelAboniment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAboniment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAboniment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboniment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAboniment.Location = new System.Drawing.Point(662, 778);
            this.labelAboniment.Name = "labelAboniment";
            this.labelAboniment.Size = new System.Drawing.Size(272, 24);
            this.labelAboniment.TabIndex = 20;
            this.labelAboniment.Text = "ПРОДЛИТЬ АБОНИМЕНТ";
            this.labelAboniment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAboniment.Click += new System.EventHandler(this.labelAboniment_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSearch.Location = new System.Drawing.Point(12, 116);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(92, 25);
            this.labelSearch.TabIndex = 21;
            this.labelSearch.Text = "ПОИСК";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.White;
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.Image")));
            this.pictureBoxRefresh.Location = new System.Drawing.Point(414, 116);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(30, 25);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefresh.TabIndex = 22;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDelete.Location = new System.Drawing.Point(352, 778);
            this.labelDelete.MinimumSize = new System.Drawing.Size(272, 24);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(272, 24);
            this.labelDelete.TabIndex = 23;
            this.labelDelete.Text = "УДАЛИТЬ КЛИЕНТА";
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(554, 714);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(220, 32);
            this.comboBoxGender.TabIndex = 25;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGender.Location = new System.Drawing.Point(494, 714);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(54, 25);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "Пол";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAge.Location = new System.Drawing.Point(780, 621);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(179, 25);
            this.labelAge.TabIndex = 27;
            this.labelAge.Text = "Дата рождения";
            // 
            // monthCalendarBirthday2
            // 
            this.monthCalendarBirthday2.Location = new System.Drawing.Point(971, 621);
            this.monthCalendarBirthday2.Name = "monthCalendarBirthday2";
            this.monthCalendarBirthday2.TabIndex = 28;
            // 
            // labelTest
            // 
            this.labelTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTest.AutoSize = true;
            this.labelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTest.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTest.Location = new System.Drawing.Point(1084, 111);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(88, 31);
            this.labelTest.TabIndex = 29;
            this.labelTest.Text = "ТЕСТ";
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTest.Click += new System.EventHandler(this.labelTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.monthCalendarBirthday2);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelAboniment);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelPatronomyc);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.labelAddClient);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 850);
            this.MinimumSize = new System.Drawing.Size(1200, 850);
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viking";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelAddClient;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPatronomyc;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelAboniment;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.MonthCalendar monthCalendarBirthday2;
        private System.Windows.Forms.Label labelTest;
    }
}

