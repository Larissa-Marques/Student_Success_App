// The purpose of this application is to filter if students are high, moderate or low risk depending on 
// different variables such as GPA and meeting with an advisor. 

using System;
using System.Windows.Forms;

namespace Student_Success_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
            none_rbn.Checked = true;

        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When Add button is clicked, the student name, major, school year, GPA, advisor
            // assignment information, appointment date will be added to the db and be
            // displayed on the datagridview.
            Boolean assgined_ad = false;
            if (checkBox_advisor.Checked) assgined_ad = true;

            decimal gpa = 0;
            try
            {
                gpa = Convert.ToDecimal(textBox_GPA.Text);
                if (gpa < 0 || gpa > 4) throw new Exception();
                studentSuccessListTableAdapter.InsertQuery(
                    textBox_name.Text,
                    comboBox_major.Text,
                    comboBox_year.Text,
                    gpa,
                    assgined_ad,
                    dateTimePicker_appt.Value.ToShortDateString()
                );

                this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the inputs will be cleared.
            textBox_name.Text = "";
            comboBox_major.Text = "";
            comboBox_year.Text = "";
            textBox_GPA.Text = "";
            dateTimePicker_appt.Value = DateTime.Today;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find on the datagridview the data entered by the user.
            string search_term = textBox_search.Text;
            Boolean search_found = false;
            dataView_students.ClearSelection();
            foreach (DataGridViewRow row in dataView_students.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Equals(search_term.ToLower()))
                {
                    row.Selected = true;
                    search_found = true;
                }
            }

            if (!search_found) MessageBox.Show("Search not found!");
        }

        private void btn_high_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and highlight the record with the highest GPA.
            dataView_students.ClearSelection();
            if (dataView_students.Rows.Count != 0)
            {
                decimal highest_GPA = 0;
                DataGridViewRow highest_GPA_row = new DataGridViewRow();
                foreach (DataGridViewRow row in dataView_students.Rows)
                {
                    decimal current_gpa = Convert.ToDecimal(row.Cells[4].Value);
                    if (row.Cells[4].Value != null && current_gpa > highest_GPA)
                    {
                        highest_GPA = current_gpa;
                        highest_GPA_row = row;
                    }
                }
                highest_GPA_row.Selected = true;
            }
        }

        private void btn_low_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and highlight the record with the lowest GPA.
            dataView_students.ClearSelection();
            if (dataView_students.Rows.Count != 0)
            {
                decimal lowest_GPA = 4;
                DataGridViewRow lowest_GPA_row = new DataGridViewRow();
                foreach (DataGridViewRow row in dataView_students.Rows)
                {
                    decimal current_gpa = Convert.ToDecimal(row.Cells[4].Value);
                    if (row.Cells[4].Value != null && current_gpa < lowest_GPA)
                    {
                        lowest_GPA = current_gpa;
                        lowest_GPA_row = row;
                    }
                }
                lowest_GPA_row.Selected = true;
            }
        }

        private void btn_remove_record_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove the selected record.

            if (dataView_students.SelectedRows.Count > 0)
            {
                int student_id = (int)dataView_students.SelectedRows[0].Cells[0].Value;
                studentSuccessListTableAdapter.DeleteQuery(student_id);
            }
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void none_rbn_CheckedChanged(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
        }

        private void low_risk_rbn_CheckedChanged(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.LowRisk(this.student_dbDataSet.StudentSuccessList);
        }

        private void mid_risk_rbn_CheckedChanged(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.MidRisk(this.student_dbDataSet.StudentSuccessList);
        }

        private void high_risk_rbn_CheckedChanged(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.HighRisk(this.student_dbDataSet.StudentSuccessList);
        }

        private void btn_advisor_portal_Click(object sender, EventArgs e)
        {
            decimal avg_gpa = 2;
            decimal percent_with_advisors = 6;

            Advisor_Form advisor_form = new Advisor_Form(avg_gpa, percent_with_advisors);
            Login_Form login_form = new Login_Form(advisor_form);
            login_form.Show();
        }
    }
}
