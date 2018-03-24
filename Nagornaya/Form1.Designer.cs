namespace Nagornaya
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.dgvMoney = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пресетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripComboBox();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.шавухаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пиццаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пельмешкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роллыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.салатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оливьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крабовый6чToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закускиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.огурцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помидорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лимоны6чToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нагетсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuy
            // 
            this.dgvBuy.AllowUserToResizeRows = false;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column12,
            this.Column11,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgvBuy.Location = new System.Drawing.Point(12, 27);
            this.dgvBuy.MultiSelect = false;
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.RowHeadersVisible = false;
            this.dgvBuy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuy.Size = new System.Drawing.Size(443, 356);
            this.dgvBuy.TabIndex = 0;
            this.dgvBuy.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBuy_RowsAdded);
            this.dgvBuy.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBuy_RowsRemoved);
            this.dgvBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBuy_MouseClick);
            // 
            // dgvMoney
            // 
            this.dgvMoney.AllowUserToResizeColumns = false;
            this.dgvMoney.AllowUserToResizeRows = false;
            this.dgvMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvMoney.Location = new System.Drawing.Point(510, 27);
            this.dgvMoney.MultiSelect = false;
            this.dgvMoney.Name = "dgvMoney";
            this.dgvMoney.RowHeadersVisible = false;
            this.dgvMoney.Size = new System.Drawing.Size(248, 221);
            this.dgvMoney.TabIndex = 1;
            this.dgvMoney.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMoney_RowsAdded);
            this.dgvMoney.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMoney_MouseClick);
            // 
            // Column10
            // 
            this.Column10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column10.HeaderText = "Кто";
            this.Column10.Items.AddRange(new object[] {
            "Боря",
            "Ктап",
            "Миша",
            "Мойша",
            "Наташка",
            "Свуча",
            "Снегирь",
            "Толян"});
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Потратил";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Долг";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Кинул";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column9.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column9.HeaderText = "Итог";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сумма по людям";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сумма общая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество человек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "На каждого";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Рассчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Если долг указан с минусом - я должен";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "с плюсом - мне должны";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пресетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // пресетыToolStripMenuItem
            // 
            this.пресетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ыToolStripMenuItem,
            this.шавухаToolStripMenuItem,
            this.пиццаToolStripMenuItem,
            this.пельмешкиToolStripMenuItem,
            this.роллыToolStripMenuItem,
            this.салатыToolStripMenuItem,
            this.закускиToolStripMenuItem});
            this.пресетыToolStripMenuItem.Name = "пресетыToolStripMenuItem";
            this.пресетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.пресетыToolStripMenuItem.Text = "Пресеты";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(75, 23);
            this.toolStripMenuItem2.Text = "1";
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            this.ыToolStripMenuItem.Size = new System.Drawing.Size(138, 6);
            // 
            // шавухаToolStripMenuItem
            // 
            this.шавухаToolStripMenuItem.Name = "шавухаToolStripMenuItem";
            this.шавухаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.шавухаToolStripMenuItem.Text = "Шавуха";
            this.шавухаToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // пиццаToolStripMenuItem
            // 
            this.пиццаToolStripMenuItem.Name = "пиццаToolStripMenuItem";
            this.пиццаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.пиццаToolStripMenuItem.Text = "Пицца";
            this.пиццаToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // пельмешкиToolStripMenuItem
            // 
            this.пельмешкиToolStripMenuItem.Name = "пельмешкиToolStripMenuItem";
            this.пельмешкиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.пельмешкиToolStripMenuItem.Text = "Пельмешки";
            this.пельмешкиToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // роллыToolStripMenuItem
            // 
            this.роллыToolStripMenuItem.Name = "роллыToolStripMenuItem";
            this.роллыToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.роллыToolStripMenuItem.Text = "Роллы";
            this.роллыToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // салатыToolStripMenuItem
            // 
            this.салатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оливьеToolStripMenuItem,
            this.крабовый6чToolStripMenuItem});
            this.салатыToolStripMenuItem.Name = "салатыToolStripMenuItem";
            this.салатыToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.салатыToolStripMenuItem.Text = "Салаты";
            // 
            // оливьеToolStripMenuItem
            // 
            this.оливьеToolStripMenuItem.Name = "оливьеToolStripMenuItem";
            this.оливьеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оливьеToolStripMenuItem.Text = "Оливье 6ч.";
            this.оливьеToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // крабовый6чToolStripMenuItem
            // 
            this.крабовый6чToolStripMenuItem.Name = "крабовый6чToolStripMenuItem";
            this.крабовый6чToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.крабовый6чToolStripMenuItem.Text = "Крабовый 6ч.";
            this.крабовый6чToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // закускиToolStripMenuItem
            // 
            this.закускиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.огурцыToolStripMenuItem,
            this.помидорыToolStripMenuItem,
            this.лимоны6чToolStripMenuItem,
            this.нагетсыToolStripMenuItem});
            this.закускиToolStripMenuItem.Name = "закускиToolStripMenuItem";
            this.закускиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.закускиToolStripMenuItem.Text = "Закуски";
            // 
            // огурцыToolStripMenuItem
            // 
            this.огурцыToolStripMenuItem.Name = "огурцыToolStripMenuItem";
            this.огурцыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.огурцыToolStripMenuItem.Text = "Огурцы 6ч.";
            this.огурцыToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // помидорыToolStripMenuItem
            // 
            this.помидорыToolStripMenuItem.Name = "помидорыToolStripMenuItem";
            this.помидорыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.помидорыToolStripMenuItem.Text = "Помидоры 6ч.";
            this.помидорыToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // лимоны6чToolStripMenuItem
            // 
            this.лимоны6чToolStripMenuItem.Name = "лимоны6чToolStripMenuItem";
            this.лимоны6чToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.лимоны6чToolStripMenuItem.Text = "Лимоны 6ч.";
            this.лимоны6чToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // нагетсыToolStripMenuItem
            // 
            this.нагетсыToolStripMenuItem.Name = "нагетсыToolStripMenuItem";
            this.нагетсыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.нагетсыToolStripMenuItem.Text = "Наггетсы 6ч.";
            this.нагетсыToolStripMenuItem.Click += new System.EventHandler(this.пресетыToolStripMenuItem_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "#";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукт";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Сколько";
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 60;
            // 
            // Column11
            // 
            this.Column11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column11.HeaderText = "Тара";
            this.Column11.Items.AddRange(new object[] {
            "Гр",
            "Кг",
            "Шт",
            "Уп",
            "Л",
            " "});
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column5
            // 
            this.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column5.HeaderText = "Кто";
            this.Column5.Items.AddRange(new object[] {
            "Ктап",
            "Свуча",
            "Боря",
            "Миша",
            "Толян",
            "Снегирь",
            "Наташка",
            "Мойша",
            " "});
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Куплено";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 408);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMoney);
            this.Controls.Add(this.dgvBuy);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Тынц-тынц. Нагорная. Жрём@Хилимся";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.DataGridView dgvMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пресетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шавухаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пиццаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пельмешкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem салатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оливьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роллыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крабовый6чToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закускиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem огурцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помидорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нагетсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лимоны6чToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}

