namespace Текстовый_редактор_ПР4
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
            this.RTBMain = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.назадToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиИЗаменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветПанелейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBol = new System.Windows.Forms.ToolStripButton();
            this.toolStripReverce = new System.Windows.Forms.ToolStripButton();
            this.toolStripLiner = new System.Windows.Forms.ToolStripButton();
            this.toolStripLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRigthAligment = new System.Windows.Forms.ToolStripButton();
            this.toolStripCenterAligment = new System.Windows.Forms.ToolStripButton();
            this.toolStripLeftAligment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRegUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripRegDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripZoomUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFonts = new System.Windows.Forms.ToolStripComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTBMain
            // 
            this.RTBMain.ContextMenuStrip = this.contextMenuStrip1;
            this.RTBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTBMain.Location = new System.Drawing.Point(0, 63);
            this.RTBMain.Name = "RTBMain";
            this.RTBMain.Size = new System.Drawing.Size(953, 332);
            this.RTBMain.TabIndex = 0;
            this.RTBMain.Text = "";
            this.RTBMain.TextChanged += new System.EventHandler(this.RTBMain_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem1,
            this.впередToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.выделитьВсеToolStripMenuItem1,
            this.найтиToolStripMenuItem,
            this.найтиИЗаменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 192);
            // 
            // назадToolStripMenuItem1
            // 
            this.назадToolStripMenuItem1.Name = "назадToolStripMenuItem1";
            this.назадToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.назадToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.назадToolStripMenuItem1.Text = "Назад";
            // 
            // впередToolStripMenuItem1
            // 
            this.впередToolStripMenuItem1.Name = "впередToolStripMenuItem1";
            this.впередToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.впередToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.впередToolStripMenuItem1.Text = "Вперед";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(212, 6);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(212, 6);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            this.выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            this.выделитьВсеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.выделитьВсеToolStripMenuItem1.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.TextFind);
            // 
            // найтиИЗаменитьToolStripMenuItem
            // 
            this.найтиИЗаменитьToolStripMenuItem.Name = "найтиИЗаменитьToolStripMenuItem";
            this.найтиИЗаменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.найтиИЗаменитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.найтиИЗаменитьToolStripMenuItem.Text = "Найти и заменить";
            this.найтиИЗаменитьToolStripMenuItem.Click += new System.EventHandler(this.TextFind);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменениеToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьНовыйToolStripMenuItem
            // 
            this.создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            this.создатьНовыйToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.создатьНовыйToolStripMenuItem.Text = "Создать новый...";
            this.создатьНовыйToolStripMenuItem.Click += new System.EventHandler(this.NewFile);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // изменениеToolStripMenuItem
            // 
            this.изменениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.впередToolStripMenuItem,
            this.toolStripMenuItem3,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.toolStripMenuItem4,
            this.выделитьВсеToolStripMenuItem});
            this.изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            this.изменениеToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.изменениеToolStripMenuItem.Text = "Изменения";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.впередToolStripMenuItem.Text = "Вперед";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.textCopy);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.TextPaste);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.TextCut);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьЦветПанелейToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // изменитьЦветПанелейToolStripMenuItem
            // 
            this.изменитьЦветПанелейToolStripMenuItem.Name = "изменитьЦветПанелейToolStripMenuItem";
            this.изменитьЦветПанелейToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.изменитьЦветПанелейToolStripMenuItem.Text = "Изменить цвет панелей";
            this.изменитьЦветПанелейToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветПанелейToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripCut,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripFind,
            this.toolStripReplace,
            this.toolStripSeparator2,
            this.toolStripBol,
            this.toolStripReverce,
            this.toolStripLiner,
            this.toolStripLine,
            this.toolStripSeparator3,
            this.toolStripRigthAligment,
            this.toolStripCenterAligment,
            this.toolStripLeftAligment,
            this.toolStripSeparator4,
            this.toolStripRegUp,
            this.toolStripRegDown,
            this.toolStripSeparator5,
            this.toolStripZoomUp,
            this.toolStripZoomDown,
            this.toolStripComboBoxFonts});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 39);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(36, 36);
            this.toolStripNew.Text = "Создать новый файл";
            this.toolStripNew.Click += new System.EventHandler(this.NewFile);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(36, 36);
            this.toolStripOpen.Text = "Открыть файл";
            this.toolStripOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(36, 36);
            this.toolStripSave.Text = "Сохранить файл";
            this.toolStripSave.Click += new System.EventHandler(this.SaveFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCut.Image")));
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(36, 36);
            this.toolStripCut.Text = "Вырезать текст";
            this.toolStripCut.Click += new System.EventHandler(this.TextCut);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopy.Image")));
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(36, 36);
            this.toolStripCopy.Text = "Копировать текст";
            this.toolStripCopy.Click += new System.EventHandler(this.textCopy);
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaste.Image")));
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(36, 36);
            this.toolStripPaste.Text = "Вставить текст";
            this.toolStripPaste.Click += new System.EventHandler(this.TextPaste);
            // 
            // toolStripFind
            // 
            this.toolStripFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFind.Image")));
            this.toolStripFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFind.Name = "toolStripFind";
            this.toolStripFind.Size = new System.Drawing.Size(36, 36);
            this.toolStripFind.Text = "Найти";
            this.toolStripFind.Click += new System.EventHandler(this.TextFind);
            // 
            // toolStripReplace
            // 
            this.toolStripReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReplace.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReplace.Image")));
            this.toolStripReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReplace.Name = "toolStripReplace";
            this.toolStripReplace.Size = new System.Drawing.Size(36, 36);
            this.toolStripReplace.Text = "Найти и заменить";
            this.toolStripReplace.Click += new System.EventHandler(this.TextFind);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBol
            // 
            this.toolStripBol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBol.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBol.Image")));
            this.toolStripBol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBol.Name = "toolStripBol";
            this.toolStripBol.Size = new System.Drawing.Size(36, 36);
            this.toolStripBol.Text = "Жирный шрифт";
            this.toolStripBol.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripReverce
            // 
            this.toolStripReverce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReverce.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReverce.Image")));
            this.toolStripReverce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReverce.Name = "toolStripReverce";
            this.toolStripReverce.Size = new System.Drawing.Size(36, 36);
            this.toolStripReverce.Text = "Курсивный шрифт";
            this.toolStripReverce.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripLiner
            // 
            this.toolStripLiner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLiner.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLiner.Image")));
            this.toolStripLiner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLiner.Name = "toolStripLiner";
            this.toolStripLiner.Size = new System.Drawing.Size(36, 36);
            this.toolStripLiner.Text = "Подчеркнутый шрифт";
            this.toolStripLiner.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripLine
            // 
            this.toolStripLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLine.Image")));
            this.toolStripLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLine.Name = "toolStripLine";
            this.toolStripLine.Size = new System.Drawing.Size(36, 36);
            this.toolStripLine.Text = "Зачеркнутый шрифт";
            this.toolStripLine.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripRigthAligment
            // 
            this.toolStripRigthAligment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRigthAligment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRigthAligment.Image")));
            this.toolStripRigthAligment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRigthAligment.Name = "toolStripRigthAligment";
            this.toolStripRigthAligment.Size = new System.Drawing.Size(36, 36);
            this.toolStripRigthAligment.Text = "Выравнивание текста слева";
            this.toolStripRigthAligment.Click += new System.EventHandler(this.toolStripRigthAligment_Click);
            // 
            // toolStripCenterAligment
            // 
            this.toolStripCenterAligment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCenterAligment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCenterAligment.Image")));
            this.toolStripCenterAligment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCenterAligment.Name = "toolStripCenterAligment";
            this.toolStripCenterAligment.Size = new System.Drawing.Size(36, 36);
            this.toolStripCenterAligment.Text = "Выравнивание текста по центру";
            this.toolStripCenterAligment.Click += new System.EventHandler(this.toolStripRigthAligment_Click);
            // 
            // toolStripLeftAligment
            // 
            this.toolStripLeftAligment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLeftAligment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLeftAligment.Image")));
            this.toolStripLeftAligment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLeftAligment.Name = "toolStripLeftAligment";
            this.toolStripLeftAligment.Size = new System.Drawing.Size(36, 36);
            this.toolStripLeftAligment.Text = "Выравнивание текста справа";
            this.toolStripLeftAligment.Click += new System.EventHandler(this.toolStripRigthAligment_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripRegUp
            // 
            this.toolStripRegUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRegUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegUp.Image")));
            this.toolStripRegUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegUp.Name = "toolStripRegUp";
            this.toolStripRegUp.Size = new System.Drawing.Size(36, 36);
            this.toolStripRegUp.Text = "Верхний регистр";
            this.toolStripRegUp.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripRegDown
            // 
            this.toolStripRegDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRegDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegDown.Image")));
            this.toolStripRegDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegDown.Name = "toolStripRegDown";
            this.toolStripRegDown.Size = new System.Drawing.Size(36, 36);
            this.toolStripRegDown.Text = "Нижний регистр";
            this.toolStripRegDown.Click += new System.EventHandler(this.toolStripBol_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripZoomUp
            // 
            this.toolStripZoomUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZoomUp.Image")));
            this.toolStripZoomUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomUp.Name = "toolStripZoomUp";
            this.toolStripZoomUp.Size = new System.Drawing.Size(36, 36);
            this.toolStripZoomUp.Text = "Увеличить";
            this.toolStripZoomUp.Click += new System.EventHandler(this.toolStripZoom_Click);
            // 
            // toolStripZoomDown
            // 
            this.toolStripZoomDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZoomDown.Image")));
            this.toolStripZoomDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomDown.Name = "toolStripZoomDown";
            this.toolStripZoomDown.Size = new System.Drawing.Size(36, 36);
            this.toolStripZoomDown.Text = "Уменьшить";
            this.toolStripZoomDown.Click += new System.EventHandler(this.toolStripZoom_Click);
            // 
            // toolStripComboBoxFonts
            // 
            this.toolStripComboBoxFonts.Name = "toolStripComboBoxFonts";
            this.toolStripComboBoxFonts.Size = new System.Drawing.Size(121, 39);
            this.toolStripComboBoxFonts.Sorted = true;
            this.toolStripComboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(849, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 32);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText,
            this.StatusZoom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(953, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(149, 17);
            this.StatusText.Text = "Колличество символов: 0";
            // 
            // StatusZoom
            // 
            this.StatusZoom.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.StatusZoom.Name = "StatusZoom";
            this.StatusZoom.Size = new System.Drawing.Size(93, 17);
            this.StatusZoom.Text = "Размерность:  1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 417);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.RTBMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор V2.0";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветПанелейToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBol;
        private System.Windows.Forms.ToolStripButton toolStripReverce;
        private System.Windows.Forms.ToolStripButton toolStripLiner;
        private System.Windows.Forms.ToolStripButton toolStripLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripRigthAligment;
        private System.Windows.Forms.ToolStripButton toolStripCenterAligment;
        private System.Windows.Forms.ToolStripButton toolStripLeftAligment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripRegUp;
        private System.Windows.Forms.ToolStripButton toolStripRegDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripZoomUp;
        private System.Windows.Forms.ToolStripButton toolStripZoomDown;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFonts;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripButton toolStripFind;
        private System.Windows.Forms.ToolStripButton toolStripReplace;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripStatusLabel StatusZoom;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиИЗаменитьToolStripMenuItem;
        public System.Windows.Forms.RichTextBox RTBMain;
    }
}

