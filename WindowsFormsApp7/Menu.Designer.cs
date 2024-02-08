namespace WindowsFormsApp7
{
    partial class Menu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеОрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оказаниеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингСотрудниковЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиЭивотномуЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещаемостьВетклиникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингУслугЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.оказаниеУслугиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугиToolStripMenuItem,
            this.данныеОрганизацииToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // данныеОрганизацииToolStripMenuItem
            // 
            this.данныеОрганизацииToolStripMenuItem.Name = "данныеОрганизацииToolStripMenuItem";
            this.данныеОрганизацииToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.данныеОрганизацииToolStripMenuItem.Text = "Данные организации";
            this.данныеОрганизацииToolStripMenuItem.Click += new System.EventHandler(this.данныеОрганизацииToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // оказаниеУслугиToolStripMenuItem
            // 
            this.оказаниеУслугиToolStripMenuItem.Name = "оказаниеУслугиToolStripMenuItem";
            this.оказаниеУслугиToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.оказаниеУслугиToolStripMenuItem.Text = "Оказание услуги";
            this.оказаниеУслугиToolStripMenuItem.Click += new System.EventHandler(this.оказаниеУслугиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рейтингСотрудниковЗаПериодToolStripMenuItem,
            this.услугиЭивотномуЗаПериодToolStripMenuItem,
            this.посещаемостьВетклиникиToolStripMenuItem,
            this.рейтингУслугЗаПериодToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // рейтингСотрудниковЗаПериодToolStripMenuItem
            // 
            this.рейтингСотрудниковЗаПериодToolStripMenuItem.Name = "рейтингСотрудниковЗаПериодToolStripMenuItem";
            this.рейтингСотрудниковЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.рейтингСотрудниковЗаПериодToolStripMenuItem.Text = "Рейтинг сотрудников за период";
            // 
            // услугиЭивотномуЗаПериодToolStripMenuItem
            // 
            this.услугиЭивотномуЗаПериодToolStripMenuItem.Name = "услугиЭивотномуЗаПериодToolStripMenuItem";
            this.услугиЭивотномуЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.услугиЭивотномуЗаПериодToolStripMenuItem.Text = "Услуги эивотному за период";
            // 
            // посещаемостьВетклиникиToolStripMenuItem
            // 
            this.посещаемостьВетклиникиToolStripMenuItem.Name = "посещаемостьВетклиникиToolStripMenuItem";
            this.посещаемостьВетклиникиToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.посещаемостьВетклиникиToolStripMenuItem.Text = "Посещаемость ветклиники";
            // 
            // рейтингУслугЗаПериодToolStripMenuItem
            // 
            this.рейтингУслугЗаПериодToolStripMenuItem.Name = "рейтингУслугЗаПериодToolStripMenuItem";
            this.рейтингУслугЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.рейтингУслугЗаПериодToolStripMenuItem.Text = "Рейтинг услуг за период ";
            this.рейтингУслугЗаПериодToolStripMenuItem.Click += new System.EventHandler(this.рейтингУслугЗаПериодToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Главное меню";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеОрганизацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оказаниеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингСотрудниковЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиЭивотномуЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещаемостьВетклиникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингУслугЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

