namespace ExpertSystemShell
{
    partial class RuleForm
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
            this.gbName = new System.Windows.Forms.GroupBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.flpChange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCond = new System.Windows.Forms.GroupBox();
            this.lvCond = new System.Windows.Forms.ListView();
            this.flpCond = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCond = new System.Windows.Forms.Button();
            this.btnEditCond = new System.Windows.Forms.Button();
            this.btnDeleteCond = new System.Windows.Forms.Button();
            this.gbConcl = new System.Windows.Forms.GroupBox();
            this.lvConcl = new System.Windows.Forms.ListView();
            this.flpConcl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddConcl = new System.Windows.Forms.Button();
            this.btnEditConcl = new System.Windows.Forms.Button();
            this.btnDeleteConcl = new System.Windows.Forms.Button();
            this.gbReason = new System.Windows.Forms.GroupBox();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.gbName.SuspendLayout();
            this.flpChange.SuspendLayout();
            this.gbCond.SuspendLayout();
            this.flpCond.SuspendLayout();
            this.gbConcl.SuspendLayout();
            this.flpConcl.SuspendLayout();
            this.gbReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.rtbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbName.Location = new System.Drawing.Point(0, 0);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(582, 60);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Имя";
            // 
            // rtbName
            // 
            this.rtbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbName.Location = new System.Drawing.Point(3, 23);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(576, 34);
            this.rtbName.TabIndex = 0;
            this.rtbName.Text = "";
            this.rtbName.Click += new System.EventHandler(this.rtbName_Click);
            // 
            // flpChange
            // 
            this.flpChange.Controls.Add(this.btnExit);
            this.flpChange.Controls.Add(this.btnSave);
            this.flpChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpChange.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpChange.Location = new System.Drawing.Point(0, 713);
            this.flpChange.Name = "flpChange";
            this.flpChange.Size = new System.Drawing.Size(582, 40);
            this.flpChange.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCond
            // 
            this.gbCond.Controls.Add(this.lvCond);
            this.gbCond.Controls.Add(this.flpCond);
            this.gbCond.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCond.Location = new System.Drawing.Point(0, 60);
            this.gbCond.Name = "gbCond";
            this.gbCond.Size = new System.Drawing.Size(582, 250);
            this.gbCond.TabIndex = 2;
            this.gbCond.TabStop = false;
            this.gbCond.Text = "Посылка";
            // 
            // lvCond
            // 
            this.lvCond.AllowDrop = true;
            this.lvCond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCond.FullRowSelect = true;
            this.lvCond.Location = new System.Drawing.Point(3, 23);
            this.lvCond.MultiSelect = false;
            this.lvCond.Name = "lvCond";
            this.lvCond.Size = new System.Drawing.Size(576, 184);
            this.lvCond.TabIndex = 1;
            this.lvCond.UseCompatibleStateImageBehavior = false;
            this.lvCond.View = System.Windows.Forms.View.List;
            this.lvCond.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvCond_ItemDrag);
            this.lvCond.SelectedIndexChanged += new System.EventHandler(this.lvCond_SelectedIndexChanged);
            this.lvCond.Click += new System.EventHandler(this.lvCond_Click);
            this.lvCond.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvCond_DragDrop);
            this.lvCond.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvCond_DragEnter);
            this.lvCond.DragOver += new System.Windows.Forms.DragEventHandler(this.lvCond_DragOver);
            this.lvCond.DragLeave += new System.EventHandler(this.lvCond_DragLeave);
            // 
            // flpCond
            // 
            this.flpCond.Controls.Add(this.btnAddCond);
            this.flpCond.Controls.Add(this.btnEditCond);
            this.flpCond.Controls.Add(this.btnDeleteCond);
            this.flpCond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpCond.Location = new System.Drawing.Point(3, 207);
            this.flpCond.Name = "flpCond";
            this.flpCond.Size = new System.Drawing.Size(576, 40);
            this.flpCond.TabIndex = 0;
            // 
            // btnAddCond
            // 
            this.btnAddCond.Location = new System.Drawing.Point(3, 3);
            this.btnAddCond.Name = "btnAddCond";
            this.btnAddCond.Size = new System.Drawing.Size(150, 30);
            this.btnAddCond.TabIndex = 0;
            this.btnAddCond.Text = "Добавить";
            this.btnAddCond.UseVisualStyleBackColor = true;
            this.btnAddCond.Click += new System.EventHandler(this.btnAddCond_Click);
            // 
            // btnEditCond
            // 
            this.btnEditCond.Enabled = false;
            this.btnEditCond.Location = new System.Drawing.Point(159, 3);
            this.btnEditCond.Name = "btnEditCond";
            this.btnEditCond.Size = new System.Drawing.Size(150, 30);
            this.btnEditCond.TabIndex = 1;
            this.btnEditCond.Text = "Изменить";
            this.btnEditCond.UseVisualStyleBackColor = true;
            this.btnEditCond.Click += new System.EventHandler(this.btnEditCond_Click);
            // 
            // btnDeleteCond
            // 
            this.btnDeleteCond.Enabled = false;
            this.btnDeleteCond.Location = new System.Drawing.Point(315, 3);
            this.btnDeleteCond.Name = "btnDeleteCond";
            this.btnDeleteCond.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteCond.TabIndex = 2;
            this.btnDeleteCond.Text = "Удалить";
            this.btnDeleteCond.UseVisualStyleBackColor = true;
            this.btnDeleteCond.Click += new System.EventHandler(this.btnDeleteCond_Click);
            // 
            // gbConcl
            // 
            this.gbConcl.Controls.Add(this.lvConcl);
            this.gbConcl.Controls.Add(this.flpConcl);
            this.gbConcl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConcl.Location = new System.Drawing.Point(0, 310);
            this.gbConcl.Name = "gbConcl";
            this.gbConcl.Size = new System.Drawing.Size(582, 250);
            this.gbConcl.TabIndex = 3;
            this.gbConcl.TabStop = false;
            this.gbConcl.Text = "Заключение";
            // 
            // lvConcl
            // 
            this.lvConcl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConcl.FullRowSelect = true;
            this.lvConcl.Location = new System.Drawing.Point(3, 23);
            this.lvConcl.MultiSelect = false;
            this.lvConcl.Name = "lvConcl";
            this.lvConcl.Size = new System.Drawing.Size(576, 184);
            this.lvConcl.TabIndex = 1;
            this.lvConcl.UseCompatibleStateImageBehavior = false;
            this.lvConcl.View = System.Windows.Forms.View.List;
            this.lvConcl.SelectedIndexChanged += new System.EventHandler(this.lvConcl_SelectedIndexChanged);
            this.lvConcl.Click += new System.EventHandler(this.lvConcl_Click);
            // 
            // flpConcl
            // 
            this.flpConcl.Controls.Add(this.btnAddConcl);
            this.flpConcl.Controls.Add(this.btnEditConcl);
            this.flpConcl.Controls.Add(this.btnDeleteConcl);
            this.flpConcl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpConcl.Location = new System.Drawing.Point(3, 207);
            this.flpConcl.Name = "flpConcl";
            this.flpConcl.Size = new System.Drawing.Size(576, 40);
            this.flpConcl.TabIndex = 0;
            // 
            // btnAddConcl
            // 
            this.btnAddConcl.Location = new System.Drawing.Point(3, 3);
            this.btnAddConcl.Name = "btnAddConcl";
            this.btnAddConcl.Size = new System.Drawing.Size(150, 30);
            this.btnAddConcl.TabIndex = 0;
            this.btnAddConcl.Text = "Добавить";
            this.btnAddConcl.UseVisualStyleBackColor = true;
            this.btnAddConcl.Click += new System.EventHandler(this.btnAddConcl_Click);
            // 
            // btnEditConcl
            // 
            this.btnEditConcl.Enabled = false;
            this.btnEditConcl.Location = new System.Drawing.Point(159, 3);
            this.btnEditConcl.Name = "btnEditConcl";
            this.btnEditConcl.Size = new System.Drawing.Size(150, 30);
            this.btnEditConcl.TabIndex = 1;
            this.btnEditConcl.Text = "Изменить";
            this.btnEditConcl.UseVisualStyleBackColor = true;
            this.btnEditConcl.Click += new System.EventHandler(this.btnEditConcl_Click);
            // 
            // btnDeleteConcl
            // 
            this.btnDeleteConcl.Enabled = false;
            this.btnDeleteConcl.Location = new System.Drawing.Point(315, 3);
            this.btnDeleteConcl.Name = "btnDeleteConcl";
            this.btnDeleteConcl.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteConcl.TabIndex = 2;
            this.btnDeleteConcl.Text = "Удалить";
            this.btnDeleteConcl.UseVisualStyleBackColor = true;
            this.btnDeleteConcl.Click += new System.EventHandler(this.btnDeleteConcl_Click);
            // 
            // gbReason
            // 
            this.gbReason.Controls.Add(this.rtbReason);
            this.gbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReason.Location = new System.Drawing.Point(0, 560);
            this.gbReason.Name = "gbReason";
            this.gbReason.Size = new System.Drawing.Size(582, 153);
            this.gbReason.TabIndex = 4;
            this.gbReason.TabStop = false;
            this.gbReason.Text = "Пояснение";
            // 
            // rtbReason
            // 
            this.rtbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReason.Location = new System.Drawing.Point(3, 23);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(576, 127);
            this.rtbReason.TabIndex = 0;
            this.rtbReason.Text = "";
            this.rtbReason.Click += new System.EventHandler(this.rtbReason_Click);
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.gbReason);
            this.Controls.Add(this.gbConcl);
            this.Controls.Add(this.gbCond);
            this.Controls.Add(this.flpChange);
            this.Controls.Add(this.gbName);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "RuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Правило";
            this.Resize += new System.EventHandler(this.RuleForm_Resize);
            this.gbName.ResumeLayout(false);
            this.flpChange.ResumeLayout(false);
            this.gbCond.ResumeLayout(false);
            this.flpCond.ResumeLayout(false);
            this.gbConcl.ResumeLayout(false);
            this.flpConcl.ResumeLayout(false);
            this.gbReason.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbName;
        private RichTextBox rtbName;
        private FlowLayoutPanel flpChange;
        private GroupBox gbCond;
        private ListView lvCond;
        private FlowLayoutPanel flpCond;
        private Button btnAddCond;
        private Button btnEditCond;
        private Button btnDeleteCond;
        private GroupBox gbConcl;
        private GroupBox gbReason;
        private RichTextBox rtbReason;
        private Button btnExit;
        private Button btnSave;
        private ListView lvConcl;
        private FlowLayoutPanel flpConcl;
        private Button btnAddConcl;
        private Button btnEditConcl;
        private Button btnDeleteConcl;
    }
}