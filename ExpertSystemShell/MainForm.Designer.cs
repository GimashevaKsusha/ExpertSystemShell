namespace ExpertSystemShell
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiФайл = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiНовый = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiОткрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiСохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiСохранитьКак = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiВыход = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiКонсультация = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiНачатьКонсультацию = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiПоказатьОбъяснение = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpRule = new System.Windows.Forms.TabPage();
            this.lvRule = new System.Windows.Forms.ListView();
            this.chRuleName = new System.Windows.Forms.ColumnHeader();
            this.chRuleScript = new System.Windows.Forms.ColumnHeader();
            this.panelRule = new System.Windows.Forms.Panel();
            this.gbReason = new System.Windows.Forms.GroupBox();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.lvConclusion = new System.Windows.Forms.ListView();
            this.chConcl = new System.Windows.Forms.ColumnHeader();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.lvCondition = new System.Windows.Forms.ListView();
            this.chFact = new System.Windows.Forms.ColumnHeader();
            this.gbUpdRule = new System.Windows.Forms.GroupBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tpVar = new System.Windows.Forms.TabPage();
            this.lvVar = new System.Windows.Forms.ListView();
            this.chVarName = new System.Windows.Forms.ColumnHeader();
            this.chVarType = new System.Windows.Forms.ColumnHeader();
            this.chVarDom = new System.Windows.Forms.ColumnHeader();
            this.panelVar = new System.Windows.Forms.Panel();
            this.gbVarValue = new System.Windows.Forms.GroupBox();
            this.lvVarValue = new System.Windows.Forms.ListView();
            this.chDom = new System.Windows.Forms.ColumnHeader();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.gbUpdVar = new System.Windows.Forms.GroupBox();
            this.btnDeleteVar = new System.Windows.Forms.Button();
            this.btnEditVar = new System.Windows.Forms.Button();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.tpDom = new System.Windows.Forms.TabPage();
            this.lvDom = new System.Windows.Forms.ListView();
            this.chDomName = new System.Windows.Forms.ColumnHeader();
            this.panelDom = new System.Windows.Forms.Panel();
            this.gbDomValue = new System.Windows.Forms.GroupBox();
            this.lvDomValue = new System.Windows.Forms.ListView();
            this.chVal = new System.Windows.Forms.ColumnHeader();
            this.gbUpdDom = new System.Windows.Forms.GroupBox();
            this.btnDeleteDom = new System.Windows.Forms.Button();
            this.btnEditDom = new System.Windows.Forms.Button();
            this.btnAddDom = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpRule.SuspendLayout();
            this.panelRule.SuspendLayout();
            this.gbReason.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.gbCondition.SuspendLayout();
            this.gbUpdRule.SuspendLayout();
            this.tpVar.SuspendLayout();
            this.panelVar.SuspendLayout();
            this.gbVarValue.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.gbUpdVar.SuspendLayout();
            this.tpDom.SuspendLayout();
            this.panelDom.SuspendLayout();
            this.gbDomValue.SuspendLayout();
            this.gbUpdDom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiФайл,
            this.tsmiКонсультация});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // tsmiФайл
            // 
            this.tsmiФайл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiНовый,
            this.tsmiОткрыть,
            this.tsmiСохранить,
            this.tsmiСохранитьКак,
            this.toolStripSeparator,
            this.tsmiВыход});
            this.tsmiФайл.Name = "tsmiФайл";
            this.tsmiФайл.Size = new System.Drawing.Size(59, 24);
            this.tsmiФайл.Text = "Файл";
            // 
            // tsmiНовый
            // 
            this.tsmiНовый.Name = "tsmiНовый";
            this.tsmiНовый.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiНовый.Size = new System.Drawing.Size(342, 26);
            this.tsmiНовый.Text = "Новый...                                   ";
            this.tsmiНовый.Click += new System.EventHandler(this.tsmiНовый_Click);
            // 
            // tsmiОткрыть
            // 
            this.tsmiОткрыть.Name = "tsmiОткрыть";
            this.tsmiОткрыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiОткрыть.Size = new System.Drawing.Size(342, 26);
            this.tsmiОткрыть.Text = "Открыть...";
            this.tsmiОткрыть.Click += new System.EventHandler(this.tsmiОткрыть_Click);
            // 
            // tsmiСохранить
            // 
            this.tsmiСохранить.Name = "tsmiСохранить";
            this.tsmiСохранить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiСохранить.Size = new System.Drawing.Size(342, 26);
            this.tsmiСохранить.Text = "Сохранить";
            this.tsmiСохранить.Click += new System.EventHandler(this.tsmiСохранить_Click);
            // 
            // tsmiСохранитьКак
            // 
            this.tsmiСохранитьКак.Name = "tsmiСохранитьКак";
            this.tsmiСохранитьКак.Size = new System.Drawing.Size(342, 26);
            this.tsmiСохранитьКак.Text = "Сохранить как...";
            this.tsmiСохранитьКак.Click += new System.EventHandler(this.tsmiСохранитьКак_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(339, 6);
            // 
            // tsmiВыход
            // 
            this.tsmiВыход.Name = "tsmiВыход";
            this.tsmiВыход.ShortcutKeyDisplayString = "";
            this.tsmiВыход.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiВыход.Size = new System.Drawing.Size(342, 26);
            this.tsmiВыход.Text = "Выход";
            this.tsmiВыход.Click += new System.EventHandler(this.tsmiВыход_Click);
            // 
            // tsmiКонсультация
            // 
            this.tsmiКонсультация.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiНачатьКонсультацию,
            this.tsmiПоказатьОбъяснение});
            this.tsmiКонсультация.Name = "tsmiКонсультация";
            this.tsmiКонсультация.Size = new System.Drawing.Size(120, 24);
            this.tsmiКонсультация.Text = "Консультация";
            // 
            // tsmiНачатьКонсультацию
            // 
            this.tsmiНачатьКонсультацию.Name = "tsmiНачатьКонсультацию";
            this.tsmiНачатьКонсультацию.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiНачатьКонсультацию.Size = new System.Drawing.Size(352, 26);
            this.tsmiНачатьКонсультацию.Text = "Начать консультацию                     ";
            this.tsmiНачатьКонсультацию.Click += new System.EventHandler(this.tsmiНачатьКонсультацию_Click);
            // 
            // tsmiПоказатьОбъяснение
            // 
            this.tsmiПоказатьОбъяснение.Name = "tsmiПоказатьОбъяснение";
            this.tsmiПоказатьОбъяснение.Size = new System.Drawing.Size(352, 26);
            this.tsmiПоказатьОбъяснение.Text = "Показать объяснение";
            this.tsmiПоказатьОбъяснение.Click += new System.EventHandler(this.tsmiПоказатьОбъяснение_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpRule);
            this.tabControl.Controls.Add(this.tpVar);
            this.tabControl.Controls.Add(this.tpDom);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1282, 655);
            this.tabControl.TabIndex = 1;
            // 
            // tpRule
            // 
            this.tpRule.Controls.Add(this.lvRule);
            this.tpRule.Controls.Add(this.panelRule);
            this.tpRule.Location = new System.Drawing.Point(4, 29);
            this.tpRule.Name = "tpRule";
            this.tpRule.Padding = new System.Windows.Forms.Padding(3);
            this.tpRule.Size = new System.Drawing.Size(1274, 622);
            this.tpRule.TabIndex = 0;
            this.tpRule.Text = "Правила";
            this.tpRule.UseVisualStyleBackColor = true;
            // 
            // lvRule
            // 
            this.lvRule.AllowDrop = true;
            this.lvRule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRuleName,
            this.chRuleScript});
            this.lvRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRule.FullRowSelect = true;
            this.lvRule.Location = new System.Drawing.Point(3, 3);
            this.lvRule.MultiSelect = false;
            this.lvRule.Name = "lvRule";
            this.lvRule.Size = new System.Drawing.Size(768, 616);
            this.lvRule.TabIndex = 1;
            this.lvRule.UseCompatibleStateImageBehavior = false;
            this.lvRule.View = System.Windows.Forms.View.Details;
            this.lvRule.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvRule_ItemDrag);
            this.lvRule.SelectedIndexChanged += new System.EventHandler(this.lvRule_SelectedIndexChanged);
            this.lvRule.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvRule_DragDrop);
            this.lvRule.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvRule_DragEnter);
            this.lvRule.DragOver += new System.Windows.Forms.DragEventHandler(this.lvRule_DragOver);
            this.lvRule.DragLeave += new System.EventHandler(this.lvRule_DragLeave);
            // 
            // chRuleName
            // 
            this.chRuleName.Text = "Имя";
            // 
            // chRuleScript
            // 
            this.chRuleScript.Text = "Описание";
            // 
            // panelRule
            // 
            this.panelRule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRule.Controls.Add(this.gbReason);
            this.panelRule.Controls.Add(this.gbConclusion);
            this.panelRule.Controls.Add(this.gbCondition);
            this.panelRule.Controls.Add(this.gbUpdRule);
            this.panelRule.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRule.Location = new System.Drawing.Point(771, 3);
            this.panelRule.Name = "panelRule";
            this.panelRule.Size = new System.Drawing.Size(500, 616);
            this.panelRule.TabIndex = 0;
            // 
            // gbReason
            // 
            this.gbReason.Controls.Add(this.rtbReason);
            this.gbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReason.Location = new System.Drawing.Point(0, 456);
            this.gbReason.Name = "gbReason";
            this.gbReason.Size = new System.Drawing.Size(500, 160);
            this.gbReason.TabIndex = 3;
            this.gbReason.TabStop = false;
            this.gbReason.Text = "Пояснение";
            // 
            // rtbReason
            // 
            this.rtbReason.BackColor = System.Drawing.SystemColors.Window;
            this.rtbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReason.Location = new System.Drawing.Point(3, 23);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.ReadOnly = true;
            this.rtbReason.Size = new System.Drawing.Size(494, 134);
            this.rtbReason.TabIndex = 0;
            this.rtbReason.Text = "";
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.lvConclusion);
            this.gbConclusion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConclusion.Location = new System.Drawing.Point(0, 268);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Size = new System.Drawing.Size(500, 188);
            this.gbConclusion.TabIndex = 2;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Заключение";
            // 
            // lvConclusion
            // 
            this.lvConclusion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chConcl});
            this.lvConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConclusion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvConclusion.Location = new System.Drawing.Point(3, 23);
            this.lvConclusion.MultiSelect = false;
            this.lvConclusion.Name = "lvConclusion";
            this.lvConclusion.Size = new System.Drawing.Size(494, 162);
            this.lvConclusion.TabIndex = 0;
            this.lvConclusion.UseCompatibleStateImageBehavior = false;
            this.lvConclusion.View = System.Windows.Forms.View.Details;
            // 
            // chConcl
            // 
            this.chConcl.Text = "Значение";
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.lvCondition);
            this.gbCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCondition.Location = new System.Drawing.Point(0, 148);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(500, 120);
            this.gbCondition.TabIndex = 1;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Посылка";
            // 
            // lvCondition
            // 
            this.lvCondition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFact});
            this.lvCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCondition.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCondition.Location = new System.Drawing.Point(3, 23);
            this.lvCondition.MultiSelect = false;
            this.lvCondition.Name = "lvCondition";
            this.lvCondition.Size = new System.Drawing.Size(494, 94);
            this.lvCondition.TabIndex = 0;
            this.lvCondition.UseCompatibleStateImageBehavior = false;
            this.lvCondition.View = System.Windows.Forms.View.Details;
            // 
            // chFact
            // 
            this.chFact.Text = "Значение";
            // 
            // gbUpdRule
            // 
            this.gbUpdRule.Controls.Add(this.btnDeleteRule);
            this.gbUpdRule.Controls.Add(this.btnEditRule);
            this.gbUpdRule.Controls.Add(this.btnAddRule);
            this.gbUpdRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpdRule.Location = new System.Drawing.Point(0, 0);
            this.gbUpdRule.Name = "gbUpdRule";
            this.gbUpdRule.Size = new System.Drawing.Size(500, 148);
            this.gbUpdRule.TabIndex = 0;
            this.gbUpdRule.TabStop = false;
            this.gbUpdRule.Text = "Редактирование";
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteRule.Enabled = false;
            this.btnDeleteRule.Location = new System.Drawing.Point(3, 103);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(494, 40);
            this.btnDeleteRule.TabIndex = 2;
            this.btnDeleteRule.Text = "Удалить";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditRule.Enabled = false;
            this.btnEditRule.Location = new System.Drawing.Point(3, 63);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(494, 40);
            this.btnEditRule.TabIndex = 1;
            this.btnEditRule.Text = "Изменить";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRule.Location = new System.Drawing.Point(3, 23);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(494, 40);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "Добавить";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // tpVar
            // 
            this.tpVar.Controls.Add(this.lvVar);
            this.tpVar.Controls.Add(this.panelVar);
            this.tpVar.Location = new System.Drawing.Point(4, 29);
            this.tpVar.Name = "tpVar";
            this.tpVar.Padding = new System.Windows.Forms.Padding(3);
            this.tpVar.Size = new System.Drawing.Size(1274, 622);
            this.tpVar.TabIndex = 1;
            this.tpVar.Text = "Переменные";
            this.tpVar.UseVisualStyleBackColor = true;
            // 
            // lvVar
            // 
            this.lvVar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVarName,
            this.chVarType,
            this.chVarDom});
            this.lvVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVar.FullRowSelect = true;
            this.lvVar.Location = new System.Drawing.Point(3, 3);
            this.lvVar.MultiSelect = false;
            this.lvVar.Name = "lvVar";
            this.lvVar.Size = new System.Drawing.Size(768, 616);
            this.lvVar.TabIndex = 1;
            this.lvVar.UseCompatibleStateImageBehavior = false;
            this.lvVar.View = System.Windows.Forms.View.Details;
            this.lvVar.SelectedIndexChanged += new System.EventHandler(this.lvVar_SelectedIndexChanged);
            // 
            // chVarName
            // 
            this.chVarName.Text = "Имя";
            // 
            // chVarType
            // 
            this.chVarType.Text = "Тип";
            // 
            // chVarDom
            // 
            this.chVarDom.Text = "Домен";
            // 
            // panelVar
            // 
            this.panelVar.Controls.Add(this.gbVarValue);
            this.panelVar.Controls.Add(this.gbQuestion);
            this.panelVar.Controls.Add(this.gbUpdVar);
            this.panelVar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVar.Location = new System.Drawing.Point(771, 3);
            this.panelVar.Name = "panelVar";
            this.panelVar.Size = new System.Drawing.Size(500, 616);
            this.panelVar.TabIndex = 0;
            // 
            // gbVarValue
            // 
            this.gbVarValue.Controls.Add(this.lvVarValue);
            this.gbVarValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVarValue.Location = new System.Drawing.Point(0, 428);
            this.gbVarValue.Name = "gbVarValue";
            this.gbVarValue.Size = new System.Drawing.Size(500, 188);
            this.gbVarValue.TabIndex = 2;
            this.gbVarValue.TabStop = false;
            this.gbVarValue.Text = "Значения домена";
            // 
            // lvVarValue
            // 
            this.lvVarValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDom});
            this.lvVarValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVarValue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvVarValue.Location = new System.Drawing.Point(3, 23);
            this.lvVarValue.MultiSelect = false;
            this.lvVarValue.Name = "lvVarValue";
            this.lvVarValue.Size = new System.Drawing.Size(494, 162);
            this.lvVarValue.TabIndex = 0;
            this.lvVarValue.UseCompatibleStateImageBehavior = false;
            this.lvVarValue.View = System.Windows.Forms.View.Details;
            // 
            // chDom
            // 
            this.chDom.Text = "Значение";
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.rtbQuestion);
            this.gbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuestion.Location = new System.Drawing.Point(0, 148);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(500, 280);
            this.gbQuestion.TabIndex = 1;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Текст вопроса";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.rtbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQuestion.Location = new System.Drawing.Point(3, 23);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.ReadOnly = true;
            this.rtbQuestion.Size = new System.Drawing.Size(494, 254);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            // 
            // gbUpdVar
            // 
            this.gbUpdVar.Controls.Add(this.btnDeleteVar);
            this.gbUpdVar.Controls.Add(this.btnEditVar);
            this.gbUpdVar.Controls.Add(this.btnAddVar);
            this.gbUpdVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpdVar.Location = new System.Drawing.Point(0, 0);
            this.gbUpdVar.Name = "gbUpdVar";
            this.gbUpdVar.Size = new System.Drawing.Size(500, 148);
            this.gbUpdVar.TabIndex = 0;
            this.gbUpdVar.TabStop = false;
            this.gbUpdVar.Text = "Редактирование";
            // 
            // btnDeleteVar
            // 
            this.btnDeleteVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteVar.Enabled = false;
            this.btnDeleteVar.Location = new System.Drawing.Point(3, 103);
            this.btnDeleteVar.Name = "btnDeleteVar";
            this.btnDeleteVar.Size = new System.Drawing.Size(494, 40);
            this.btnDeleteVar.TabIndex = 2;
            this.btnDeleteVar.Text = "Удалить";
            this.btnDeleteVar.UseVisualStyleBackColor = true;
            this.btnDeleteVar.Click += new System.EventHandler(this.btnDeleteVar_Click);
            // 
            // btnEditVar
            // 
            this.btnEditVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditVar.Enabled = false;
            this.btnEditVar.Location = new System.Drawing.Point(3, 63);
            this.btnEditVar.Name = "btnEditVar";
            this.btnEditVar.Size = new System.Drawing.Size(494, 40);
            this.btnEditVar.TabIndex = 1;
            this.btnEditVar.Text = "Изменить";
            this.btnEditVar.UseVisualStyleBackColor = true;
            this.btnEditVar.Click += new System.EventHandler(this.btnEditVar_Click);
            // 
            // btnAddVar
            // 
            this.btnAddVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVar.Location = new System.Drawing.Point(3, 23);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(494, 40);
            this.btnAddVar.TabIndex = 0;
            this.btnAddVar.Text = "Добавить";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // tpDom
            // 
            this.tpDom.Controls.Add(this.lvDom);
            this.tpDom.Controls.Add(this.panelDom);
            this.tpDom.Location = new System.Drawing.Point(4, 29);
            this.tpDom.Name = "tpDom";
            this.tpDom.Padding = new System.Windows.Forms.Padding(3);
            this.tpDom.Size = new System.Drawing.Size(1274, 622);
            this.tpDom.TabIndex = 2;
            this.tpDom.Text = "Домены";
            this.tpDom.UseVisualStyleBackColor = true;
            // 
            // lvDom
            // 
            this.lvDom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDomName});
            this.lvDom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDom.FullRowSelect = true;
            this.lvDom.Location = new System.Drawing.Point(3, 3);
            this.lvDom.MultiSelect = false;
            this.lvDom.Name = "lvDom";
            this.lvDom.Size = new System.Drawing.Size(768, 616);
            this.lvDom.TabIndex = 1;
            this.lvDom.UseCompatibleStateImageBehavior = false;
            this.lvDom.View = System.Windows.Forms.View.Details;
            this.lvDom.SelectedIndexChanged += new System.EventHandler(this.lvDom_SelectedIndexChanged);
            // 
            // chDomName
            // 
            this.chDomName.Text = "Имя";
            // 
            // panelDom
            // 
            this.panelDom.Controls.Add(this.gbDomValue);
            this.panelDom.Controls.Add(this.gbUpdDom);
            this.panelDom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDom.Location = new System.Drawing.Point(771, 3);
            this.panelDom.Name = "panelDom";
            this.panelDom.Size = new System.Drawing.Size(500, 616);
            this.panelDom.TabIndex = 0;
            // 
            // gbDomValue
            // 
            this.gbDomValue.Controls.Add(this.lvDomValue);
            this.gbDomValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDomValue.Location = new System.Drawing.Point(0, 148);
            this.gbDomValue.Name = "gbDomValue";
            this.gbDomValue.Size = new System.Drawing.Size(500, 468);
            this.gbDomValue.TabIndex = 2;
            this.gbDomValue.TabStop = false;
            this.gbDomValue.Text = "Значения домена";
            // 
            // lvDomValue
            // 
            this.lvDomValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVal});
            this.lvDomValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDomValue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDomValue.Location = new System.Drawing.Point(3, 23);
            this.lvDomValue.MultiSelect = false;
            this.lvDomValue.Name = "lvDomValue";
            this.lvDomValue.Size = new System.Drawing.Size(494, 442);
            this.lvDomValue.TabIndex = 0;
            this.lvDomValue.UseCompatibleStateImageBehavior = false;
            this.lvDomValue.View = System.Windows.Forms.View.Details;
            // 
            // chVal
            // 
            this.chVal.Text = "Значение";
            // 
            // gbUpdDom
            // 
            this.gbUpdDom.Controls.Add(this.btnDeleteDom);
            this.gbUpdDom.Controls.Add(this.btnEditDom);
            this.gbUpdDom.Controls.Add(this.btnAddDom);
            this.gbUpdDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpdDom.Location = new System.Drawing.Point(0, 0);
            this.gbUpdDom.Name = "gbUpdDom";
            this.gbUpdDom.Size = new System.Drawing.Size(500, 148);
            this.gbUpdDom.TabIndex = 0;
            this.gbUpdDom.TabStop = false;
            this.gbUpdDom.Text = "Редактирование";
            // 
            // btnDeleteDom
            // 
            this.btnDeleteDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteDom.Enabled = false;
            this.btnDeleteDom.Location = new System.Drawing.Point(3, 103);
            this.btnDeleteDom.Name = "btnDeleteDom";
            this.btnDeleteDom.Size = new System.Drawing.Size(494, 40);
            this.btnDeleteDom.TabIndex = 2;
            this.btnDeleteDom.Text = "Удалить";
            this.btnDeleteDom.UseVisualStyleBackColor = true;
            this.btnDeleteDom.Click += new System.EventHandler(this.btnDeleteDom_Click);
            // 
            // btnEditDom
            // 
            this.btnEditDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditDom.Enabled = false;
            this.btnEditDom.Location = new System.Drawing.Point(3, 63);
            this.btnEditDom.Name = "btnEditDom";
            this.btnEditDom.Size = new System.Drawing.Size(494, 40);
            this.btnEditDom.TabIndex = 1;
            this.btnEditDom.Text = "Изменить";
            this.btnEditDom.UseVisualStyleBackColor = true;
            this.btnEditDom.Click += new System.EventHandler(this.btnEditDom_Click);
            // 
            // btnAddDom
            // 
            this.btnAddDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDom.Location = new System.Drawing.Point(3, 23);
            this.btnAddDom.Name = "btnAddDom";
            this.btnAddDom.Size = new System.Drawing.Size(494, 40);
            this.btnAddDom.TabIndex = 0;
            this.btnAddDom.Text = "Добавить";
            this.btnAddDom.UseVisualStyleBackColor = true;
            this.btnAddDom.Click += new System.EventHandler(this.btnAddDom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 683);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(1300, 730);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Новая экспертная система";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpRule.ResumeLayout(false);
            this.panelRule.ResumeLayout(false);
            this.gbReason.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.gbUpdRule.ResumeLayout(false);
            this.tpVar.ResumeLayout(false);
            this.panelVar.ResumeLayout(false);
            this.gbVarValue.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.gbUpdVar.ResumeLayout(false);
            this.tpDom.ResumeLayout(false);
            this.panelDom.ResumeLayout(false);
            this.gbDomValue.ResumeLayout(false);
            this.gbUpdDom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private TabControl tabControl;
        private TabPage tpRule;
        private Panel panelRule;
        private TabPage tpVar;
        private TabPage tpDom;
        private GroupBox gbConclusion;
        private GroupBox gbCondition;
        private GroupBox gbUpdRule;
        private Button btnDeleteRule;
        private Button btnEditRule;
        private Button btnAddRule;
        private Panel panelVar;
        private GroupBox gbQuestion;
        private GroupBox gbUpdVar;
        private Button btnDeleteVar;
        private Button btnEditVar;
        private Button btnAddVar;
        private GroupBox gbVarValue;
        private Panel panelDom;
        private GroupBox gbDomValue;
        private GroupBox gbUpdDom;
        private Button btnDeleteDom;
        private Button btnEditDom;
        private Button btnAddDom;
        private ToolStripMenuItem tsmiФайл;
        private ToolStripMenuItem tsmiОткрыть;
        private ToolStripMenuItem tsmiСохранить;
        private ToolStripMenuItem tsmiСохранитьКак;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem tsmiВыход;
        private ToolStripMenuItem tsmiКонсультация;
        private ToolStripMenuItem tsmiНачатьКонсультацию;
        private ToolStripMenuItem tsmiПоказатьОбъяснение;
        private ListView lvConclusion;
        private ListView lvCondition;
        private ListView lvVarValue;
        private ListView lvDomValue;
        private ToolStripMenuItem tsmiНовый;
        private ListView lvRule;
        private ColumnHeader chRuleName;
        private ColumnHeader chRuleScript;
        private ListView lvVar;
        private ListView lvDom;
        private ColumnHeader chVarName;
        private ColumnHeader chVarType;
        private ColumnHeader chVarDom;
        private ColumnHeader chDomName;
        private ColumnHeader chConcl;
        private ColumnHeader chFact;
        private ColumnHeader chDom;
        private ColumnHeader chVal;
        private RichTextBox rtbQuestion;
        private GroupBox gbReason;
        private RichTextBox rtbReason;
    }
}