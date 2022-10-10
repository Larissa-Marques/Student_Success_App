namespace Student_Success_App
{
    partial class Advisor_Form
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
            this.textBox_avg_gpa = new System.Windows.Forms.TextBox();
            this.lbl_avg_gpa = new System.Windows.Forms.Label();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.lbl_without_advisor_percentage = new System.Windows.Forms.Label();
            this.textBox_without_advisor_percent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_avg_gpa
            // 
            this.textBox_avg_gpa.Location = new System.Drawing.Point(110, 86);
            this.textBox_avg_gpa.Name = "textBox_avg_gpa";
            this.textBox_avg_gpa.ReadOnly = true;
            this.textBox_avg_gpa.Size = new System.Drawing.Size(100, 22);
            this.textBox_avg_gpa.TabIndex = 37;
            // 
            // lbl_avg_gpa
            // 
            this.lbl_avg_gpa.AutoSize = true;
            this.lbl_avg_gpa.Location = new System.Drawing.Point(85, 67);
            this.lbl_avg_gpa.Name = "lbl_avg_gpa";
            this.lbl_avg_gpa.Size = new System.Drawing.Size(159, 16);
            this.lbl_avg_gpa.TabIndex = 36;
            this.lbl_avg_gpa.Text = "Average GPA of Students";
            // 
            // lbl_summary
            // 
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summary.Location = new System.Drawing.Point(123, 21);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(71, 16);
            this.lbl_summary.TabIndex = 35;
            this.lbl_summary.Text = "Summary";
            // 
            // lbl_without_advisor_percentage
            // 
            this.lbl_without_advisor_percentage.AutoSize = true;
            this.lbl_without_advisor_percentage.Location = new System.Drawing.Point(60, 126);
            this.lbl_without_advisor_percentage.Name = "lbl_without_advisor_percentage";
            this.lbl_without_advisor_percentage.Size = new System.Drawing.Size(224, 16);
            this.lbl_without_advisor_percentage.TabIndex = 38;
            this.lbl_without_advisor_percentage.Text = "Students without Advisor Percentage";
            // 
            // textBox_without_advisor_percent
            // 
            this.textBox_without_advisor_percent.Location = new System.Drawing.Point(110, 145);
            this.textBox_without_advisor_percent.Name = "textBox_without_advisor_percent";
            this.textBox_without_advisor_percent.ReadOnly = true;
            this.textBox_without_advisor_percent.Size = new System.Drawing.Size(100, 22);
            this.textBox_without_advisor_percent.TabIndex = 39;
            // 
            // Advisor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 189);
            this.Controls.Add(this.textBox_without_advisor_percent);
            this.Controls.Add(this.lbl_without_advisor_percentage);
            this.Controls.Add(this.textBox_avg_gpa);
            this.Controls.Add(this.lbl_avg_gpa);
            this.Controls.Add(this.lbl_summary);
            this.Name = "Advisor_Form";
            this.Text = "GPA_Form";
            this.Load += new System.EventHandler(this.GPA_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_avg_gpa;
        private System.Windows.Forms.Label lbl_avg_gpa;
        private System.Windows.Forms.Label lbl_summary;
        private System.Windows.Forms.Label lbl_without_advisor_percentage;
        private System.Windows.Forms.TextBox textBox_without_advisor_percent;
    }
}