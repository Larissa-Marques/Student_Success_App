using System.Windows.Forms;

namespace Student_Success_App
{
    partial class Form1
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_major = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_major = new System.Windows.Forms.ComboBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.lbl_GPA = new System.Windows.Forms.Label();
            this.textBox_GPA = new System.Windows.Forms.TextBox();
            this.lbl_appt_date = new System.Windows.Forms.Label();
            this.dateTimePicker_appt = new System.Windows.Forms.DateTimePicker();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_high_GPA = new System.Windows.Forms.Button();
            this.btn_low_GPA = new System.Windows.Forms.Button();
            this.btn_remove_record = new System.Windows.Forms.Button();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_risk = new System.Windows.Forms.Button();
            this.checkBox_advisor = new System.Windows.Forms.CheckBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dataView_students = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_students)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(34, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(104, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Student Name";
            // 
            // lbl_major
            // 
            this.lbl_major.AutoSize = true;
            this.lbl_major.Location = new System.Drawing.Point(34, 68);
            this.lbl_major.Name = "lbl_major";
            this.lbl_major.Size = new System.Drawing.Size(48, 20);
            this.lbl_major.TabIndex = 1;
            this.lbl_major.Text = "Major";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(159, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_name.TabIndex = 2;
            // 
            // comboBox_major
            // 
            this.comboBox_major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_major.FormattingEnabled = true;
            this.comboBox_major.Items.AddRange(new object[] {
            "",
            "Business",
            "Engineering",
            "Nursing",
            "Communication",
            "Education"});
            this.comboBox_major.Location = new System.Drawing.Point(133, 65);
            this.comboBox_major.Name = "comboBox_major";
            this.comboBox_major.Size = new System.Drawing.Size(151, 28);
            this.comboBox_major.TabIndex = 3;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(37, 123);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(37, 20);
            this.lbl_year.TabIndex = 4;
            this.lbl_year.Text = "Year";
            // 
            // comboBox_year
            // 
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "",
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior",
            "Graduate"});
            this.comboBox_year.Location = new System.Drawing.Point(133, 115);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(151, 28);
            this.comboBox_year.TabIndex = 5;
            // 
            // lbl_GPA
            // 
            this.lbl_GPA.AutoSize = true;
            this.lbl_GPA.Location = new System.Drawing.Point(40, 165);
            this.lbl_GPA.Name = "lbl_GPA";
            this.lbl_GPA.Size = new System.Drawing.Size(36, 20);
            this.lbl_GPA.TabIndex = 6;
            this.lbl_GPA.Text = "GPA";
            // 
            // textBox_GPA
            // 
            this.textBox_GPA.Location = new System.Drawing.Point(133, 163);
            this.textBox_GPA.Name = "textBox_GPA";
            this.textBox_GPA.Size = new System.Drawing.Size(125, 27);
            this.textBox_GPA.TabIndex = 7;
            // 
            // lbl_appt_date
            // 
            this.lbl_appt_date.AutoSize = true;
            this.lbl_appt_date.Location = new System.Drawing.Point(34, 244);
            this.lbl_appt_date.Name = "lbl_appt_date";
            this.lbl_appt_date.Size = new System.Drawing.Size(163, 20);
            this.lbl_appt_date.TabIndex = 9;
            this.lbl_appt_date.Text = "Last Appointment Date";
            // 
            // dateTimePicker_appt
            // 
            this.dateTimePicker_appt.Location = new System.Drawing.Point(203, 239);
            this.dateTimePicker_appt.Name = "dateTimePicker_appt";
            this.dateTimePicker_appt.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_appt.TabIndex = 10;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(37, 281);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(117, 29);
            this.btn_add_student.TabIndex = 11;
            this.btn_add_student.Text = "Add Student";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(190, 281);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(37, 469);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(133, 27);
            this.textBox_search.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(320, 467);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(133, 29);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_high_GPA
            // 
            this.btn_high_GPA.Location = new System.Drawing.Point(320, 519);
            this.btn_high_GPA.Name = "btn_high_GPA";
            this.btn_high_GPA.Size = new System.Drawing.Size(133, 29);
            this.btn_high_GPA.TabIndex = 18;
            this.btn_high_GPA.Text = "Highest GPA";
            this.btn_high_GPA.UseVisualStyleBackColor = true;
            this.btn_high_GPA.Click += new System.EventHandler(this.btn_high_GPA_Click);
            // 
            // btn_low_GPA
            // 
            this.btn_low_GPA.Location = new System.Drawing.Point(37, 519);
            this.btn_low_GPA.Name = "btn_low_GPA";
            this.btn_low_GPA.Size = new System.Drawing.Size(133, 29);
            this.btn_low_GPA.TabIndex = 19;
            this.btn_low_GPA.Text = "Lowest GPA";
            this.btn_low_GPA.UseVisualStyleBackColor = true;
            this.btn_low_GPA.Click += new System.EventHandler(this.btn_low_GPA_Click);
            // 
            // btn_remove_record
            // 
            this.btn_remove_record.Location = new System.Drawing.Point(37, 565);
            this.btn_remove_record.Name = "btn_remove_record";
            this.btn_remove_record.Size = new System.Drawing.Size(133, 29);
            this.btn_remove_record.TabIndex = 20;
            this.btn_remove_record.Text = "Remove Record";
            this.btn_remove_record.UseVisualStyleBackColor = true;
            this.btn_remove_record.Click += new System.EventHandler(this.btn_remove_record_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Location = new System.Drawing.Point(320, 565);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(133, 29);
            this.btn_remove_all.TabIndex = 21;
            this.btn_remove_all.Text = "Remove All";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(616, 565);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 29);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_risk
            // 
            this.btn_risk.Location = new System.Drawing.Point(615, 519);
            this.btn_risk.Name = "btn_risk";
            this.btn_risk.Size = new System.Drawing.Size(133, 29);
            this.btn_risk.TabIndex = 23;
            this.btn_risk.Text = "Calculate Risk";
            this.btn_risk.UseVisualStyleBackColor = true;
            // 
            // checkBox_advisor
            // 
            this.checkBox_advisor.AutoSize = true;
            this.checkBox_advisor.Location = new System.Drawing.Point(40, 205);
            this.checkBox_advisor.Name = "checkBox_advisor";
            this.checkBox_advisor.Size = new System.Drawing.Size(152, 24);
            this.checkBox_advisor.TabIndex = 24;
            this.checkBox_advisor.Text = "Assigned Advisor?";
            this.checkBox_advisor.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(616, 467);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 29);
            this.btn_edit.TabIndex = 25;
            this.btn_edit.Text = "Edit Record";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dataView_students
            // 
            this.dataView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_students.Location = new System.Drawing.Point(42, 329);
            this.dataView_students.Name = "dataView_students";
            this.dataView_students.RowHeadersWidth = 51;
            this.dataView_students.RowTemplate.Height = 29;
            this.dataView_students.Size = new System.Drawing.Size(300, 188);
            this.dataView_students.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.dataView_students);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.checkBox_advisor);
            this.Controls.Add(this.btn_risk);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_remove_record);
            this.Controls.Add(this.btn_low_GPA);
            this.Controls.Add(this.btn_high_GPA);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.dateTimePicker_appt);
            this.Controls.Add(this.lbl_appt_date);
            this.Controls.Add(this.textBox_GPA);
            this.Controls.Add(this.lbl_GPA);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.comboBox_major);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.lbl_major);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_major;
        private TextBox textBox_name;
        private ComboBox comboBox_major;
        private Label lbl_year;
        private ComboBox comboBox_year;
        private Label lbl_GPA;
        private TextBox textBox_GPA;
        private Label lbl_appt_date;
        private DateTimePicker dateTimePicker_appt;
        private Button btn_add_student;
        private Button btn_clear;
        private TextBox textBox_search;
        private Button btn_search;
        private Button btn_high_GPA;
        private Button btn_low_GPA;
        private Button btn_remove_record;
        private Button btn_remove_all;
        private Button btn_close;
        private Button btn_risk;
        private CheckBox checkBox_advisor;
        private Button btn_edit;
        private DataGridView dataView_students;
    }
}

