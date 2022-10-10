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
            this.textBox_overall_gpa = new System.Windows.Forms.TextBox();
            this.lbl_overall_gpa = new System.Windows.Forms.Label();
            this.lbl_gpa_ave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_overall_gpa
            // 
            this.textBox_overall_gpa.Location = new System.Drawing.Point(395, 228);
            this.textBox_overall_gpa.Name = "textBox_overall_gpa";
            this.textBox_overall_gpa.Size = new System.Drawing.Size(100, 22);
            this.textBox_overall_gpa.TabIndex = 37;
            // 
            // lbl_overall_gpa
            // 
            this.lbl_overall_gpa.AutoSize = true;
            this.lbl_overall_gpa.Location = new System.Drawing.Point(308, 231);
            this.lbl_overall_gpa.Name = "lbl_overall_gpa";
            this.lbl_overall_gpa.Size = new System.Drawing.Size(81, 16);
            this.lbl_overall_gpa.TabIndex = 36;
            this.lbl_overall_gpa.Text = "Overall GPA";
            // 
            // lbl_gpa_ave
            // 
            this.lbl_gpa_ave.AutoSize = true;
            this.lbl_gpa_ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gpa_ave.Location = new System.Drawing.Point(305, 200);
            this.lbl_gpa_ave.Name = "lbl_gpa_ave";
            this.lbl_gpa_ave.Size = new System.Drawing.Size(109, 16);
            this.lbl_gpa_ave.TabIndex = 35;
            this.lbl_gpa_ave.Text = "GPA Averages";
            // 
            // GPA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_overall_gpa);
            this.Controls.Add(this.lbl_overall_gpa);
            this.Controls.Add(this.lbl_gpa_ave);
            this.Name = "GPA_Form";
            this.Text = "GPA_Form";
            this.Load += new System.EventHandler(this.GPA_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_overall_gpa;
        private System.Windows.Forms.Label lbl_overall_gpa;
        private System.Windows.Forms.Label lbl_gpa_ave;
    }
}