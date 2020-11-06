namespace Lab7_Pitsyk_IPZ
{
    partial class frmLab7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.діїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBox_goods = new System.Windows.Forms.GroupBox();
            this.gBox_info = new System.Windows.Forms.GroupBox();
            this.gBox_bought = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbox_goods = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_automodel = new System.Windows.Forms.ComboBox();
            this.cbox_partname = new System.Windows.Forms.ComboBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_hint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_onStorage = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_using = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gBox_goods.SuspendLayout();
            this.gBox_info.SuspendLayout();
            this.gBox_bought.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.діїToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(602, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // діїToolStripMenuItem
            // 
            this.діїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_buy,
            this.toolStripMenuItem2,
            this.btn_clear});
            this.діїToolStripMenuItem.Name = "діїToolStripMenuItem";
            this.діїToolStripMenuItem.Size = new System.Drawing.Size(35, 21);
            this.діїToolStripMenuItem.Text = "&Дії";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_using,
            this.проПрограмуToolStripMenuItem,
            this.btn_about});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.довідкаToolStripMenuItem.Text = "Дов&ідка";
            // 
            // gBox_goods
            // 
            this.gBox_goods.Controls.Add(this.cbox_partname);
            this.gBox_goods.Controls.Add(this.cbox_automodel);
            this.gBox_goods.Controls.Add(this.label2);
            this.gBox_goods.Controls.Add(this.label1);
            this.gBox_goods.Location = new System.Drawing.Point(12, 30);
            this.gBox_goods.Name = "gBox_goods";
            this.gBox_goods.Size = new System.Drawing.Size(579, 75);
            this.gBox_goods.TabIndex = 1;
            this.gBox_goods.TabStop = false;
            this.gBox_goods.Text = "Вибір товару";
            // 
            // gBox_info
            // 
            this.gBox_info.Controls.Add(this.txt_onStorage);
            this.gBox_info.Controls.Add(this.label7);
            this.gBox_info.Controls.Add(this.txt_hint);
            this.gBox_info.Controls.Add(this.txt_price);
            this.gBox_info.Controls.Add(this.txt_fullname);
            this.gBox_info.Controls.Add(this.label5);
            this.gBox_info.Controls.Add(this.label4);
            this.gBox_info.Controls.Add(this.label3);
            this.gBox_info.Location = new System.Drawing.Point(12, 125);
            this.gBox_info.Name = "gBox_info";
            this.gBox_info.Size = new System.Drawing.Size(579, 148);
            this.gBox_info.TabIndex = 2;
            this.gBox_info.TabStop = false;
            this.gBox_info.Text = "Інформація";
            // 
            // gBox_bought
            // 
            this.gBox_bought.Controls.Add(this.lbox_goods);
            this.gBox_bought.Location = new System.Drawing.Point(12, 279);
            this.gBox_bought.Name = "gBox_bought";
            this.gBox_bought.Size = new System.Drawing.Size(579, 153);
            this.gBox_bought.TabIndex = 2;
            this.gBox_bought.TabStop = false;
            this.gBox_bought.Text = "Куплено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка Авто:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назва автозапчастини:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повна назва:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ціна за одиницю:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Примітка:";
            // 
            // lbox_goods
            // 
            this.lbox_goods.FormattingEnabled = true;
            this.lbox_goods.ItemHeight = 17;
            this.lbox_goods.Location = new System.Drawing.Point(6, 22);
            this.lbox_goods.Name = "lbox_goods";
            this.lbox_goods.Size = new System.Drawing.Size(567, 123);
            this.lbox_goods.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Загальна сума:";
            // 
            // cbox_automodel
            // 
            this.cbox_automodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_automodel.FormattingEnabled = true;
            this.cbox_automodel.Location = new System.Drawing.Point(111, 32);
            this.cbox_automodel.Name = "cbox_automodel";
            this.cbox_automodel.Size = new System.Drawing.Size(134, 25);
            this.cbox_automodel.Sorted = true;
            this.cbox_automodel.TabIndex = 0;
            // 
            // cbox_partname
            // 
            this.cbox_partname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_partname.FormattingEnabled = true;
            this.cbox_partname.Location = new System.Drawing.Point(422, 32);
            this.cbox_partname.Name = "cbox_partname";
            this.cbox_partname.Size = new System.Drawing.Size(151, 25);
            this.cbox_partname.Sorted = true;
            this.cbox_partname.TabIndex = 1;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(142, 30);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.ReadOnly = true;
            this.txt_fullname.Size = new System.Drawing.Size(431, 23);
            this.txt_fullname.TabIndex = 10;
            this.txt_fullname.TabStop = false;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(142, 63);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(116, 23);
            this.txt_price.TabIndex = 11;
            this.txt_price.TabStop = false;
            // 
            // txt_hint
            // 
            this.txt_hint.Location = new System.Drawing.Point(142, 96);
            this.txt_hint.Multiline = true;
            this.txt_hint.Name = "txt_hint";
            this.txt_hint.ReadOnly = true;
            this.txt_hint.Size = new System.Drawing.Size(431, 34);
            this.txt_hint.TabIndex = 12;
            this.txt_hint.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Залишок на складі, шт:";
            // 
            // txt_onStorage
            // 
            this.txt_onStorage.Location = new System.Drawing.Point(452, 63);
            this.txt_onStorage.Name = "txt_onStorage";
            this.txt_onStorage.ReadOnly = true;
            this.txt_onStorage.Size = new System.Drawing.Size(121, 23);
            this.txt_onStorage.TabIndex = 14;
            this.txt_onStorage.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(467, 440);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(118, 23);
            this.txt_total.TabIndex = 15;
            this.txt_total.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(180, 22);
            this.btn_Exit.Text = "&Вихід";
            // 
            // btn_buy
            // 
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(181, 22);
            this.btn_buy.Text = "&Купити";
            // 
            // btn_using
            // 
            this.btn_using.Name = "btn_using";
            this.btn_using.Size = new System.Drawing.Size(186, 22);
            this.btn_using.Text = "&Як користуватись";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Enabled = false;
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.проПрограмуToolStripMenuItem.Text = "----------------------";
            // 
            // btn_about
            // 
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(186, 22);
            this.btn_about.Text = "&Про програму";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "---------------------";
            // 
            // btn_clear
            // 
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(181, 22);
            this.btn_clear.Text = "&Очистити форму";
            // 
            // frmLab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(602, 469);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gBox_bought);
            this.Controls.Add(this.gBox_info);
            this.Controls.Add(this.gBox_goods);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLab7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автозапчастини \"Фенікс\"";
            this.Load += new System.EventHandler(this.frmLab7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBox_goods.ResumeLayout(false);
            this.gBox_goods.PerformLayout();
            this.gBox_info.ResumeLayout(false);
            this.gBox_info.PerformLayout();
            this.gBox_bought.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem діїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBox_goods;
        private System.Windows.Forms.ComboBox cbox_partname;
        private System.Windows.Forms.ComboBox cbox_automodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox_info;
        private System.Windows.Forms.TextBox txt_onStorage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hint;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBox_bought;
        private System.Windows.Forms.ListBox lbox_goods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem btn_buy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btn_clear;
        private System.Windows.Forms.ToolStripMenuItem btn_using;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_about;
    }
}

