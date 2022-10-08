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
            this.components = new System.ComponentModel.Container();
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
            this.btn_close = new System.Windows.Forms.Button();
            this.checkBox_advisor = new System.Windows.Forms.CheckBox();
            this.dataView_students = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSuccessListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_dbDataSet = new Student_Success_App.student_dbDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentSuccessListTableAdapter = new Student_Success_App.student_dbDataSetTableAdapters.StudentSuccessListTableAdapter();
            this.risk_filters_lbl = new System.Windows.Forms.Label();
            this.low_risk_rbn = new System.Windows.Forms.RadioButton();
            this.mid_risk_rbn = new System.Windows.Forms.RadioButton();
            this.high_risk_rbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSuccessListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(34, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(92, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Student Name";
            // 
            // lbl_major
            // 
            this.lbl_major.AutoSize = true;
            this.lbl_major.Location = new System.Drawing.Point(34, 54);
            this.lbl_major.Name = "lbl_major";
            this.lbl_major.Size = new System.Drawing.Size(41, 16);
            this.lbl_major.TabIndex = 1;
            this.lbl_major.Text = "Major";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(133, 20);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 22);
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
            this.comboBox_major.Location = new System.Drawing.Point(133, 52);
            this.comboBox_major.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_major.Name = "comboBox_major";
            this.comboBox_major.Size = new System.Drawing.Size(151, 24);
            this.comboBox_major.TabIndex = 3;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(34, 95);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(36, 16);
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
            this.comboBox_year.Location = new System.Drawing.Point(133, 92);
            this.comboBox_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(151, 24);
            this.comboBox_year.TabIndex = 5;
            // 
            // lbl_GPA
            // 
            this.lbl_GPA.AutoSize = true;
            this.lbl_GPA.Location = new System.Drawing.Point(34, 132);
            this.lbl_GPA.Name = "lbl_GPA";
            this.lbl_GPA.Size = new System.Drawing.Size(35, 16);
            this.lbl_GPA.TabIndex = 6;
            this.lbl_GPA.Text = "GPA";
            // 
            // textBox_GPA
            // 
            this.textBox_GPA.Location = new System.Drawing.Point(133, 129);
            this.textBox_GPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GPA.Name = "textBox_GPA";
            this.textBox_GPA.Size = new System.Drawing.Size(125, 22);
            this.textBox_GPA.TabIndex = 7;
            // 
            // lbl_appt_date
            // 
            this.lbl_appt_date.AutoSize = true;
            this.lbl_appt_date.Location = new System.Drawing.Point(34, 195);
            this.lbl_appt_date.Name = "lbl_appt_date";
            this.lbl_appt_date.Size = new System.Drawing.Size(142, 16);
            this.lbl_appt_date.TabIndex = 9;
            this.lbl_appt_date.Text = "Last Appointment Date";
            // 
            // dateTimePicker_appt
            // 
            this.dateTimePicker_appt.Location = new System.Drawing.Point(203, 191);
            this.dateTimePicker_appt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_appt.Name = "dateTimePicker_appt";
            this.dateTimePicker_appt.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_appt.TabIndex = 10;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(37, 225);
            this.btn_add_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(117, 23);
            this.btn_add_student.TabIndex = 11;
            this.btn_add_student.Text = "Add Student";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(190, 225);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(342, 23);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(133, 22);
            this.textBox_search.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(493, 11);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(133, 48);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search (Name)";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_high_GPA
            // 
            this.btn_high_GPA.Location = new System.Drawing.Point(493, 65);
            this.btn_high_GPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_high_GPA.Name = "btn_high_GPA";
            this.btn_high_GPA.Size = new System.Drawing.Size(133, 48);
            this.btn_high_GPA.TabIndex = 18;
            this.btn_high_GPA.Text = "Highest GPA";
            this.btn_high_GPA.UseVisualStyleBackColor = true;
            this.btn_high_GPA.Click += new System.EventHandler(this.btn_high_GPA_Click);
            // 
            // btn_low_GPA
            // 
            this.btn_low_GPA.Location = new System.Drawing.Point(342, 65);
            this.btn_low_GPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_low_GPA.Name = "btn_low_GPA";
            this.btn_low_GPA.Size = new System.Drawing.Size(133, 48);
            this.btn_low_GPA.TabIndex = 19;
            this.btn_low_GPA.Text = "Lowest GPA";
            this.btn_low_GPA.UseVisualStyleBackColor = true;
            this.btn_low_GPA.Click += new System.EventHandler(this.btn_low_GPA_Click);
            // 
            // btn_remove_record
            // 
            this.btn_remove_record.Location = new System.Drawing.Point(342, 117);
            this.btn_remove_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove_record.Name = "btn_remove_record";
            this.btn_remove_record.Size = new System.Drawing.Size(133, 48);
            this.btn_remove_record.TabIndex = 20;
            this.btn_remove_record.Text = "Remove Record";
            this.btn_remove_record.UseVisualStyleBackColor = true;
            this.btn_remove_record.Click += new System.EventHandler(this.btn_remove_record_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(493, 117);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 48);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // checkBox_advisor
            // 
            this.checkBox_advisor.AutoSize = true;
            this.checkBox_advisor.Location = new System.Drawing.Point(37, 164);
            this.checkBox_advisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_advisor.Name = "checkBox_advisor";
            this.checkBox_advisor.Size = new System.Drawing.Size(142, 20);
            this.checkBox_advisor.TabIndex = 24;
            this.checkBox_advisor.Text = "Assigned Advisor?";
            this.checkBox_advisor.UseVisualStyleBackColor = true;
            // 
            // dataView_students
            // 
            this.dataView_students.AutoGenerateColumns = false;
            this.dataView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn,
            this.advisorDataGridViewTextBoxColumn,
            this.lastAppointmentDataGridViewTextBoxColumn});
            this.dataView_students.DataSource = this.studentSuccessListBindingSource;
            this.dataView_students.Location = new System.Drawing.Point(37, 296);
            this.dataView_students.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataView_students.Name = "dataView_students";
            this.dataView_students.RowHeadersWidth = 51;
            this.dataView_students.RowTemplate.Height = 29;
            this.dataView_students.Size = new System.Drawing.Size(1067, 264);
            this.dataView_students.TabIndex = 26;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.Width = 125;
            // 
            // advisorDataGridViewTextBoxColumn
            // 
            this.advisorDataGridViewTextBoxColumn.DataPropertyName = "Advisor";
            this.advisorDataGridViewTextBoxColumn.HeaderText = "Advisor";
            this.advisorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.advisorDataGridViewTextBoxColumn.Name = "advisorDataGridViewTextBoxColumn";
            this.advisorDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastAppointmentDataGridViewTextBoxColumn
            // 
            this.lastAppointmentDataGridViewTextBoxColumn.DataPropertyName = "Last Appointment";
            this.lastAppointmentDataGridViewTextBoxColumn.HeaderText = "Last Appointment";
            this.lastAppointmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastAppointmentDataGridViewTextBoxColumn.Name = "lastAppointmentDataGridViewTextBoxColumn";
            this.lastAppointmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentSuccessListBindingSource
            // 
            this.studentSuccessListBindingSource.DataMember = "StudentSuccessList";
            this.studentSuccessListBindingSource.DataSource = this.student_dbDataSet;
            // 
            // student_dbDataSet
            // 
            this.student_dbDataSet.DataSetName = "student_dbDataSet";
            this.student_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            // 
            // studentSuccessListTableAdapter
            // 
            this.studentSuccessListTableAdapter.ClearBeforeFill = true;
            // 
            // risk_filters_lbl
            // 
            this.risk_filters_lbl.AutoSize = true;
            this.risk_filters_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risk_filters_lbl.Location = new System.Drawing.Point(658, 13);
            this.risk_filters_lbl.Name = "risk_filters_lbl";
            this.risk_filters_lbl.Size = new System.Drawing.Size(85, 16);
            this.risk_filters_lbl.TabIndex = 27;
            this.risk_filters_lbl.Text = "Risk Filters";
            // 
            // low_risk_rbn
            // 
            this.low_risk_rbn.AutoSize = true;
            this.low_risk_rbn.Location = new System.Drawing.Point(661, 49);
            this.low_risk_rbn.Name = "low_risk_rbn";
            this.low_risk_rbn.Size = new System.Drawing.Size(82, 20);
            this.low_risk_rbn.TabIndex = 28;
            this.low_risk_rbn.TabStop = true;
            this.low_risk_rbn.Text = "Low Risk";
            this.low_risk_rbn.UseVisualStyleBackColor = true;
            this.low_risk_rbn.CheckedChanged += new System.EventHandler(this.low_risk_rbn_CheckedChanged);
            // 
            // mid_risk_rbn
            // 
            this.mid_risk_rbn.AutoSize = true;
            this.mid_risk_rbn.Location = new System.Drawing.Point(661, 76);
            this.mid_risk_rbn.Name = "mid_risk_rbn";
            this.mid_risk_rbn.Size = new System.Drawing.Size(116, 20);
            this.mid_risk_rbn.TabIndex = 29;
            this.mid_risk_rbn.TabStop = true;
            this.mid_risk_rbn.Text = "Moderate Risk";
            this.mid_risk_rbn.UseVisualStyleBackColor = true;
            // 
            // high_risk_rbn
            // 
            this.high_risk_rbn.AutoSize = true;
            this.high_risk_rbn.Location = new System.Drawing.Point(661, 103);
            this.high_risk_rbn.Name = "high_risk_rbn";
            this.high_risk_rbn.Size = new System.Drawing.Size(86, 20);
            this.high_risk_rbn.TabIndex = 30;
            this.high_risk_rbn.TabStop = true;
            this.high_risk_rbn.Text = "High Risk";
            this.high_risk_rbn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 620);
            this.Controls.Add(this.high_risk_rbn);
            this.Controls.Add(this.mid_risk_rbn);
            this.Controls.Add(this.low_risk_rbn);
            this.Controls.Add(this.risk_filters_lbl);
            this.Controls.Add(this.dataView_students);
            this.Controls.Add(this.checkBox_advisor);
            this.Controls.Add(this.btn_close);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSuccessListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
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
        private Button btn_close;
        private CheckBox checkBox_advisor;
        private DataGridView dataView_students;
        private student_dbDataSet student_dbDataSet;
        private BindingSource studentSuccessListBindingSource;
        private student_dbDataSetTableAdapters.StudentSuccessListTableAdapter studentSuccessListTableAdapter;
        private BindingSource table1BindingSource;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn advisorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastAppointmentDataGridViewTextBoxColumn;
        private Label risk_filters_lbl;
        private RadioButton low_risk_rbn;
        private RadioButton mid_risk_rbn;
        private RadioButton high_risk_rbn;
    }
}

