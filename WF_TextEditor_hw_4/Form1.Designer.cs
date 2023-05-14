
namespace WF_TextEditor_hw_4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.именитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save_as = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_del = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_select_all = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_font = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_bColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1097, 518);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.именитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // именитьToolStripMenuItem
            // 
            this.именитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.delToolStripMenuItem1,
            this.selectAllToolStripMenuItem});
            this.именитьToolStripMenuItem.Name = "именитьToolStripMenuItem";
            this.именитьToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.именитьToolStripMenuItem.Text = "Правка";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem1
            // 
            this.delToolStripMenuItem1.Name = "delToolStripMenuItem1";
            this.delToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.delToolStripMenuItem1.Text = "Удалить";
            this.delToolStripMenuItem1.Click += new System.EventHandler(this.delToolStripMenuItem1_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.selectAllToolStripMenuItem.Text = "Выделить все";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fColorToolStripMenuItem,
            this.bColorToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.изменитьToolStripMenuItem.Text = "Вид";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontToolStripMenuItem.Text = "Шрифт";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fColorToolStripMenuItem
            // 
            this.fColorToolStripMenuItem.Name = "fColorToolStripMenuItem";
            this.fColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fColorToolStripMenuItem.Text = "Цвет текста";
            this.fColorToolStripMenuItem.Click += new System.EventHandler(this.fColorToolStripMenuItem_Click);
            // 
            // bColorToolStripMenuItem
            // 
            this.bColorToolStripMenuItem.Name = "bColorToolStripMenuItem";
            this.bColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bColorToolStripMenuItem.Text = "Цвет фона";
            this.bColorToolStripMenuItem.Click += new System.EventHandler(this.bColorToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_open,
            this.toolStripButton_save,
            this.toolStripButton_save_as,
            this.toolStripSeparator1,
            this.toolStripButton_cut,
            this.toolStripButton_copy,
            this.toolStripButton_paste,
            this.toolStripButton_del,
            this.toolStripButton_select_all,
            this.toolStripSeparator2,
            this.toolStripButton_font,
            this.toolStripButton_bColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1097, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.UseWaitCursor = true;
            // 
            // toolStripButton_open
            // 
            this.toolStripButton_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_open.Image")));
            this.toolStripButton_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_open.Name = "toolStripButton_open";
            this.toolStripButton_open.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_open.Text = "Открыть";
            this.toolStripButton_open.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_save.Text = "Сохранить";
            this.toolStripButton_save.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripButton_save_as
            // 
            this.toolStripButton_save_as.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save_as.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save_as.Image")));
            this.toolStripButton_save_as.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save_as.Name = "toolStripButton_save_as";
            this.toolStripButton_save_as.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_save_as.Text = "Сохранить как";
            this.toolStripButton_save_as.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 124);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem1_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton_cut
            // 
            this.toolStripButton_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_cut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_cut.Image")));
            this.toolStripButton_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_cut.Name = "toolStripButton_cut";
            this.toolStripButton_cut.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_cut.Text = "Вырезать";
            this.toolStripButton_cut.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_copy.Image")));
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_copy.Text = "Копировать";
            this.toolStripButton_copy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripButton_paste
            // 
            this.toolStripButton_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_paste.Image")));
            this.toolStripButton_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_paste.Name = "toolStripButton_paste";
            this.toolStripButton_paste.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_paste.Text = "Вставить";
            this.toolStripButton_paste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripButton_del
            // 
            this.toolStripButton_del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_del.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_del.Image")));
            this.toolStripButton_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_del.Name = "toolStripButton_del";
            this.toolStripButton_del.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_del.Text = "Удалить";
            this.toolStripButton_del.Click += new System.EventHandler(this.delToolStripMenuItem1_Click);
            // 
            // toolStripButton_select_all
            // 
            this.toolStripButton_select_all.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_select_all.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_select_all.Image")));
            this.toolStripButton_select_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_select_all.Name = "toolStripButton_select_all";
            this.toolStripButton_select_all.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_select_all.Text = "Выделить все";
            this.toolStripButton_select_all.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripButton_font
            // 
            this.toolStripButton_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_font.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_font.Image")));
            this.toolStripButton_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_font.Name = "toolStripButton_font";
            this.toolStripButton_font.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_font.Text = "Шрифт";
            this.toolStripButton_font.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripButton_bColor
            // 
            this.toolStripButton_bColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_bColor.Image")));
            this.toolStripButton_bColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bColor.Name = "toolStripButton_bColor";
            this.toolStripButton_bColor.Size = new System.Drawing.Size(29, 35);
            this.toolStripButton_bColor.Text = "Цвет фона";
            this.toolStripButton_bColor.Click += new System.EventHandler(this.bColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 546);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem именитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_open;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripButton toolStripButton_save_as;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_cut;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_paste;
        private System.Windows.Forms.ToolStripButton toolStripButton_del;
        private System.Windows.Forms.ToolStripButton toolStripButton_select_all;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_font;
        private System.Windows.Forms.ToolStripButton toolStripButton_bColor;
    }
}

