namespace ExpertSystemShell
{
    partial class ReasoningForm
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
            this.scReason = new System.Windows.Forms.SplitContainer();
            this.gbRule = new System.Windows.Forms.GroupBox();
            this.tvRule = new System.Windows.Forms.TreeView();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.lvAnswer = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chValue = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.scReason)).BeginInit();
            this.scReason.Panel1.SuspendLayout();
            this.scReason.Panel2.SuspendLayout();
            this.scReason.SuspendLayout();
            this.gbRule.SuspendLayout();
            this.gbAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // scReason
            // 
            this.scReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scReason.Location = new System.Drawing.Point(0, 0);
            this.scReason.Name = "scReason";
            // 
            // scReason.Panel1
            // 
            this.scReason.Panel1.Controls.Add(this.gbRule);
            this.scReason.Panel1MinSize = 200;
            // 
            // scReason.Panel2
            // 
            this.scReason.Panel2.Controls.Add(this.gbAnswer);
            this.scReason.Panel2MinSize = 150;
            this.scReason.Size = new System.Drawing.Size(982, 553);
            this.scReason.SplitterDistance = 550;
            this.scReason.TabIndex = 0;
            // 
            // gbRule
            // 
            this.gbRule.Controls.Add(this.tvRule);
            this.gbRule.Controls.Add(this.lblLink);
            this.gbRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRule.Location = new System.Drawing.Point(0, 0);
            this.gbRule.Name = "gbRule";
            this.gbRule.Size = new System.Drawing.Size(550, 553);
            this.gbRule.TabIndex = 0;
            this.gbRule.TabStop = false;
            this.gbRule.Text = "Правила";
            // 
            // tvRule
            // 
            this.tvRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRule.FullRowSelect = true;
            this.tvRule.Location = new System.Drawing.Point(3, 23);
            this.tvRule.Name = "tvRule";
            this.tvRule.Size = new System.Drawing.Size(544, 527);
            this.tvRule.TabIndex = 1;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(75, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(111, 20);
            this.lblLink.TabIndex = 0;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "(раскрыть все)";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.lvAnswer);
            this.gbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnswer.Location = new System.Drawing.Point(0, 0);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(428, 553);
            this.gbAnswer.TabIndex = 0;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Переменные";
            // 
            // lvAnswer
            // 
            this.lvAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chValue});
            this.lvAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAnswer.FullRowSelect = true;
            this.lvAnswer.Location = new System.Drawing.Point(3, 23);
            this.lvAnswer.MultiSelect = false;
            this.lvAnswer.Name = "lvAnswer";
            this.lvAnswer.Size = new System.Drawing.Size(422, 527);
            this.lvAnswer.TabIndex = 0;
            this.lvAnswer.UseCompatibleStateImageBehavior = false;
            this.lvAnswer.View = System.Windows.Forms.View.Details;
            this.lvAnswer.SelectedIndexChanged += new System.EventHandler(this.lvAnswer_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Имя";
            // 
            // chValue
            // 
            this.chValue.Text = "Значение";
            // 
            // ReasoningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.scReason);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ReasoningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Объяснение";
            this.Resize += new System.EventHandler(this.ReasoningForm_Resize);
            this.scReason.Panel1.ResumeLayout(false);
            this.scReason.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scReason)).EndInit();
            this.scReason.ResumeLayout(false);
            this.gbRule.ResumeLayout(false);
            this.gbRule.PerformLayout();
            this.gbAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer scReason;
        private GroupBox gbRule;
        private TreeView tvRule;
        private LinkLabel lblLink;
        private GroupBox gbAnswer;
        private ListView lvAnswer;
        private ColumnHeader chName;
        private ColumnHeader chValue;
    }
}