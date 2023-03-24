namespace ExpertSystemShell
{
    partial class DomainForm
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
            this.flpChange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.flpVal = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbVal = new System.Windows.Forms.RichTextBox();
            this.btnAddVal = new System.Windows.Forms.Button();
            this.btnEditVal = new System.Windows.Forms.Button();
            this.btnDeleteVal = new System.Windows.Forms.Button();
            this.gbVal = new System.Windows.Forms.GroupBox();
            this.lvVal = new System.Windows.Forms.ListView();
            this.chVal = new System.Windows.Forms.ColumnHeader();
            this.flpChange.SuspendLayout();
            this.gbName.SuspendLayout();
            this.flpVal.SuspendLayout();
            this.gbVal.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpChange
            // 
            this.flpChange.Controls.Add(this.btnExit);
            this.flpChange.Controls.Add(this.btnSave);
            this.flpChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpChange.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpChange.Location = new System.Drawing.Point(0, 363);
            this.flpChange.Name = "flpChange";
            this.flpChange.Size = new System.Drawing.Size(782, 40);
            this.flpChange.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(629, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.rtbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbName.Location = new System.Drawing.Point(0, 0);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(782, 70);
            this.gbName.TabIndex = 1;
            this.gbName.TabStop = false;
            this.gbName.Text = "Имя";
            // 
            // rtbName
            // 
            this.rtbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbName.Location = new System.Drawing.Point(3, 23);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(776, 30);
            this.rtbName.TabIndex = 0;
            this.rtbName.Text = "";
            this.rtbName.Click += new System.EventHandler(this.rtbName_Click);
            // 
            // flpVal
            // 
            this.flpVal.Controls.Add(this.rtbVal);
            this.flpVal.Controls.Add(this.btnAddVal);
            this.flpVal.Controls.Add(this.btnEditVal);
            this.flpVal.Controls.Add(this.btnDeleteVal);
            this.flpVal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpVal.Location = new System.Drawing.Point(0, 293);
            this.flpVal.Name = "flpVal";
            this.flpVal.Size = new System.Drawing.Size(782, 70);
            this.flpVal.TabIndex = 3;
            // 
            // rtbVal
            // 
            this.rtbVal.Location = new System.Drawing.Point(3, 3);
            this.rtbVal.Name = "rtbVal";
            this.rtbVal.Size = new System.Drawing.Size(300, 30);
            this.rtbVal.TabIndex = 0;
            this.rtbVal.Text = "";
            this.rtbVal.TextChanged += new System.EventHandler(this.rtbVal_TextChanged);
            // 
            // btnAddVal
            // 
            this.btnAddVal.Enabled = false;
            this.btnAddVal.Location = new System.Drawing.Point(309, 3);
            this.btnAddVal.Name = "btnAddVal";
            this.btnAddVal.Size = new System.Drawing.Size(150, 30);
            this.btnAddVal.TabIndex = 1;
            this.btnAddVal.Text = "Добавить";
            this.btnAddVal.UseVisualStyleBackColor = true;
            this.btnAddVal.Click += new System.EventHandler(this.btnAddVal_Click);
            // 
            // btnEditVal
            // 
            this.btnEditVal.Enabled = false;
            this.btnEditVal.Location = new System.Drawing.Point(465, 3);
            this.btnEditVal.Name = "btnEditVal";
            this.btnEditVal.Size = new System.Drawing.Size(150, 30);
            this.btnEditVal.TabIndex = 2;
            this.btnEditVal.Text = "Изменить";
            this.btnEditVal.UseVisualStyleBackColor = true;
            this.btnEditVal.Click += new System.EventHandler(this.btnEditVal_Click);
            // 
            // btnDeleteVal
            // 
            this.btnDeleteVal.Enabled = false;
            this.btnDeleteVal.Location = new System.Drawing.Point(621, 3);
            this.btnDeleteVal.Name = "btnDeleteVal";
            this.btnDeleteVal.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteVal.TabIndex = 3;
            this.btnDeleteVal.Text = "Удалить";
            this.btnDeleteVal.UseVisualStyleBackColor = true;
            this.btnDeleteVal.Click += new System.EventHandler(this.btnDeleteVal_Click);
            // 
            // gbVal
            // 
            this.gbVal.Controls.Add(this.lvVal);
            this.gbVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVal.Location = new System.Drawing.Point(0, 70);
            this.gbVal.Name = "gbVal";
            this.gbVal.Size = new System.Drawing.Size(782, 223);
            this.gbVal.TabIndex = 4;
            this.gbVal.TabStop = false;
            this.gbVal.Text = "Допустимые значения";
            // 
            // lvVal
            // 
            this.lvVal.AllowDrop = true;
            this.lvVal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVal});
            this.lvVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVal.FullRowSelect = true;
            this.lvVal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvVal.Location = new System.Drawing.Point(3, 23);
            this.lvVal.MultiSelect = false;
            this.lvVal.Name = "lvVal";
            this.lvVal.Size = new System.Drawing.Size(776, 197);
            this.lvVal.TabIndex = 0;
            this.lvVal.UseCompatibleStateImageBehavior = false;
            this.lvVal.View = System.Windows.Forms.View.Details;
            this.lvVal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvVal_ItemDrag);
            this.lvVal.SelectedIndexChanged += new System.EventHandler(this.lvVal_SelectedIndexChanged);
            this.lvVal.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvVal_DragDrop);
            this.lvVal.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvVal_DragEnter);
            this.lvVal.DragOver += new System.Windows.Forms.DragEventHandler(this.lvVal_DragOver);
            this.lvVal.DragLeave += new System.EventHandler(this.lvVal_DragLeave);
            // 
            // chVal
            // 
            this.chVal.Text = "Значение";
            // 
            // DomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.gbVal);
            this.Controls.Add(this.flpVal);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.flpChange);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "DomainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DomainForm";
            this.Resize += new System.EventHandler(this.DomainForm_Resize);
            this.flpChange.ResumeLayout(false);
            this.gbName.ResumeLayout(false);
            this.flpVal.ResumeLayout(false);
            this.gbVal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpChange;
        private Button btnExit;
        private Button btnSave;
        private GroupBox gbName;
        private RichTextBox rtbName;
        private FlowLayoutPanel flpVal;
        private RichTextBox rtbVal;
        private Button btnAddVal;
        private Button btnEditVal;
        private Button btnDeleteVal;
        private GroupBox gbVal;
        private ListView lvVal;
        private ColumnHeader chVal;
    }
}