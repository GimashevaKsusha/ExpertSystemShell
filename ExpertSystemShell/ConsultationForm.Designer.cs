namespace ExpertSystemShell
{
    partial class ConsultationForm
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
            this.flpAnswer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.rtbConsultation = new System.Windows.Forms.RichTextBox();
            this.flpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAnswer
            // 
            this.flpAnswer.Controls.Add(this.btnAnswer);
            this.flpAnswer.Controls.Add(this.cbAnswer);
            this.flpAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAnswer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAnswer.Location = new System.Drawing.Point(0, 533);
            this.flpAnswer.Name = "flpAnswer";
            this.flpAnswer.Size = new System.Drawing.Size(562, 50);
            this.flpAnswer.TabIndex = 0;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(379, 3);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(180, 28);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // cbAnswer
            // 
            this.cbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Location = new System.Drawing.Point(13, 3);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(360, 28);
            this.cbAnswer.TabIndex = 1;
            // 
            // rtbConsultation
            // 
            this.rtbConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsultation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbConsultation.Location = new System.Drawing.Point(0, 0);
            this.rtbConsultation.Name = "rtbConsultation";
            this.rtbConsultation.ReadOnly = true;
            this.rtbConsultation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConsultation.Size = new System.Drawing.Size(562, 533);
            this.rtbConsultation.TabIndex = 1;
            this.rtbConsultation.Text = "";
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 583);
            this.Controls.Add(this.rtbConsultation);
            this.Controls.Add(this.flpAnswer);
            this.MinimumSize = new System.Drawing.Size(580, 630);
            this.Name = "ConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Консультация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultationForm_FormClosed);
            this.flpAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpAnswer;
        private Button btnAnswer;
        private ComboBox cbAnswer;
        private RichTextBox rtbConsultation;
    }
}