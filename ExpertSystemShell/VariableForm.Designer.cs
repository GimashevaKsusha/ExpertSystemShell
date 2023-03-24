namespace ExpertSystemShell
{
    partial class VariableForm
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
            this.gbDom = new System.Windows.Forms.GroupBox();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.gbAddDom = new System.Windows.Forms.GroupBox();
            this.btnAddDom = new System.Windows.Forms.Button();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbDR = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.flpChange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.gbName.SuspendLayout();
            this.gbDom.SuspendLayout();
            this.gbAddDom.SuspendLayout();
            this.gbType.SuspendLayout();
            this.flpChange.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.rtbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbName.Location = new System.Drawing.Point(0, 0);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(582, 70);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Имя";
            // 
            // rtbName
            // 
            this.rtbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbName.Location = new System.Drawing.Point(3, 23);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(576, 28);
            this.rtbName.TabIndex = 0;
            this.rtbName.Text = "";
            this.rtbName.TextChanged += new System.EventHandler(this.rtbName_TextChanged);
            // 
            // gbDom
            // 
            this.gbDom.Controls.Add(this.cbDomain);
            this.gbDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDom.Location = new System.Drawing.Point(0, 70);
            this.gbDom.Name = "gbDom";
            this.gbDom.Size = new System.Drawing.Size(582, 70);
            this.gbDom.TabIndex = 1;
            this.gbDom.TabStop = false;
            this.gbDom.Text = "Выбрать домен";
            // 
            // cbDomain
            // 
            this.cbDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(3, 23);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(576, 28);
            this.cbDomain.TabIndex = 0;
            // 
            // gbAddDom
            // 
            this.gbAddDom.Controls.Add(this.btnAddDom);
            this.gbAddDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAddDom.Location = new System.Drawing.Point(0, 140);
            this.gbAddDom.Name = "gbAddDom";
            this.gbAddDom.Size = new System.Drawing.Size(582, 70);
            this.gbAddDom.TabIndex = 2;
            this.gbAddDom.TabStop = false;
            this.gbAddDom.Text = "Создать новый домен";
            // 
            // btnAddDom
            // 
            this.btnAddDom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDom.Location = new System.Drawing.Point(3, 23);
            this.btnAddDom.Name = "btnAddDom";
            this.btnAddDom.Size = new System.Drawing.Size(576, 30);
            this.btnAddDom.TabIndex = 0;
            this.btnAddDom.Text = "Добавить";
            this.btnAddDom.UseVisualStyleBackColor = true;
            this.btnAddDom.Click += new System.EventHandler(this.btnAddDom_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbDR);
            this.gbType.Controls.Add(this.rbD);
            this.gbType.Controls.Add(this.rbR);
            this.gbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbType.Location = new System.Drawing.Point(0, 210);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(582, 110);
            this.gbType.TabIndex = 3;
            this.gbType.TabStop = false;
            this.gbType.Text = "Тип переменной";
            // 
            // rbDR
            // 
            this.rbDR.AutoSize = true;
            this.rbDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDR.Location = new System.Drawing.Point(3, 71);
            this.rbDR.Name = "rbDR";
            this.rbDR.Size = new System.Drawing.Size(576, 24);
            this.rbDR.TabIndex = 2;
            this.rbDR.TabStop = true;
            this.rbDR.Text = "Выводимо-запрашиваемая";
            this.rbDR.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbD.Location = new System.Drawing.Point(3, 47);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(576, 24);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "Выводимая";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbR
            // 
            this.rbR.AutoSize = true;
            this.rbR.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbR.Location = new System.Drawing.Point(3, 23);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(576, 24);
            this.rbR.TabIndex = 0;
            this.rbR.TabStop = true;
            this.rbR.Text = "Запрашиваемая";
            this.rbR.UseVisualStyleBackColor = true;
            // 
            // flpChange
            // 
            this.flpChange.Controls.Add(this.btnExit);
            this.flpChange.Controls.Add(this.btnSave);
            this.flpChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpChange.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpChange.Location = new System.Drawing.Point(0, 513);
            this.flpChange.Name = "flpChange";
            this.flpChange.Size = new System.Drawing.Size(582, 40);
            this.flpChange.TabIndex = 5;
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
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.rtbQuestion);
            this.gbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuestion.Location = new System.Drawing.Point(0, 320);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(582, 193);
            this.gbQuestion.TabIndex = 6;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Текст вопроса";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQuestion.Location = new System.Drawing.Point(3, 23);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(576, 167);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            // 
            // VariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.flpChange);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbAddDom);
            this.Controls.Add(this.gbDom);
            this.Controls.Add(this.gbName);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "VariableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переменная";
            this.gbName.ResumeLayout(false);
            this.gbDom.ResumeLayout(false);
            this.gbAddDom.ResumeLayout(false);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.flpChange.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbName;
        private GroupBox gbDom;
        private GroupBox gbAddDom;
        private GroupBox gbType;
        private FlowLayoutPanel flpChange;
        private RichTextBox rtbName;
        private ComboBox cbDomain;
        private Button btnAddDom;
        private RadioButton rbDR;
        private RadioButton rbD;
        private RadioButton rbR;
        private Button btnExit;
        private Button btnSave;
        private GroupBox gbQuestion;
        private RichTextBox rtbQuestion;
    }
}