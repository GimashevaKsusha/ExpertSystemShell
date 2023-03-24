namespace ExpertSystemShell
{
    partial class FactForm
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
            this.gbVar = new System.Windows.Forms.GroupBox();
            this.cbVar = new System.Windows.Forms.ComboBox();
            this.gbAddVar = new System.Windows.Forms.GroupBox();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.flpChange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbVal = new System.Windows.Forms.GroupBox();
            this.cbVal = new System.Windows.Forms.ComboBox();
            this.lvlSign = new System.Windows.Forms.Label();
            this.gbVar.SuspendLayout();
            this.gbAddVar.SuspendLayout();
            this.flpChange.SuspendLayout();
            this.gbVal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVar
            // 
            this.gbVar.Controls.Add(this.cbVar);
            this.gbVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVar.Location = new System.Drawing.Point(0, 0);
            this.gbVar.Name = "gbVar";
            this.gbVar.Size = new System.Drawing.Size(682, 70);
            this.gbVar.TabIndex = 0;
            this.gbVar.TabStop = false;
            this.gbVar.Text = "Выбрать переменную";
            // 
            // cbVar
            // 
            this.cbVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVar.FormattingEnabled = true;
            this.cbVar.Location = new System.Drawing.Point(3, 23);
            this.cbVar.Name = "cbVar";
            this.cbVar.Size = new System.Drawing.Size(676, 28);
            this.cbVar.TabIndex = 0;
            this.cbVar.SelectedIndexChanged += new System.EventHandler(this.cbVar_SelectedIndexChanged);
            // 
            // gbAddVar
            // 
            this.gbAddVar.Controls.Add(this.btnAddVar);
            this.gbAddVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAddVar.Location = new System.Drawing.Point(0, 70);
            this.gbAddVar.Name = "gbAddVar";
            this.gbAddVar.Size = new System.Drawing.Size(682, 70);
            this.gbAddVar.TabIndex = 4;
            this.gbAddVar.TabStop = false;
            this.gbAddVar.Text = "Создать новую переменную";
            // 
            // btnAddVar
            // 
            this.btnAddVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVar.Location = new System.Drawing.Point(3, 23);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(676, 28);
            this.btnAddVar.TabIndex = 0;
            this.btnAddVar.Text = "Добавить";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // flpChange
            // 
            this.flpChange.Controls.Add(this.btnExit);
            this.flpChange.Controls.Add(this.btnSave);
            this.flpChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpChange.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpChange.Location = new System.Drawing.Point(0, 273);
            this.flpChange.Name = "flpChange";
            this.flpChange.Size = new System.Drawing.Size(682, 40);
            this.flpChange.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbVal
            // 
            this.gbVal.Controls.Add(this.cbVal);
            this.gbVal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbVal.Location = new System.Drawing.Point(0, 203);
            this.gbVal.Name = "gbVal";
            this.gbVal.Size = new System.Drawing.Size(682, 70);
            this.gbVal.TabIndex = 7;
            this.gbVal.TabStop = false;
            this.gbVal.Text = "Значение";
            // 
            // cbVal
            // 
            this.cbVal.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVal.FormattingEnabled = true;
            this.cbVal.Location = new System.Drawing.Point(3, 23);
            this.cbVal.Name = "cbVal";
            this.cbVal.Size = new System.Drawing.Size(676, 28);
            this.cbVal.TabIndex = 0;
            // 
            // lvlSign
            // 
            this.lvlSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlSign.Location = new System.Drawing.Point(0, 140);
            this.lvlSign.Name = "lvlSign";
            this.lvlSign.Size = new System.Drawing.Size(682, 63);
            this.lvlSign.TabIndex = 8;
            this.lvlSign.Text = "=";
            this.lvlSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 313);
            this.Controls.Add(this.lvlSign);
            this.Controls.Add(this.gbVal);
            this.Controls.Add(this.flpChange);
            this.Controls.Add(this.gbAddVar);
            this.Controls.Add(this.gbVar);
            this.MinimumSize = new System.Drawing.Size(700, 360);
            this.Name = "FactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Посылка";
            this.gbVar.ResumeLayout(false);
            this.gbAddVar.ResumeLayout(false);
            this.flpChange.ResumeLayout(false);
            this.gbVal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbVar;
        private ComboBox cbVar;
        private GroupBox gbAddVar;
        private Button btnAddVar;
        private FlowLayoutPanel flpChange;
        private Button btnExit;
        private Button btnSave;
        private GroupBox gbVal;
        private ComboBox cbVal;
        private Label lvlSign;
    }
}