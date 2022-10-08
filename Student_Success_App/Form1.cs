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
            // TODO: This line of code loads data into the 'student_dbDataSet.StudentSuccessList' table. You can move, or remove it, as needed.
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);

        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the student name, major, school year, GPA, advisor
            // assignment information, appointment date will be displayed on the datagridview.
            string assgined_ad = "No";
            if (checkBox_advisor.Checked) assgined_ad = "Yes";

            studentSuccessListTableAdapter.InsertQuery(
                textBox_name.Text,
                comboBox_major.Text,
                comboBox_year.Text,
                textBox_GPA.Text,
                assgined_ad,
                dateTimePicker_appt.Value.ToShortDateString()
            );

            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the information will be erased.
            textBox_name.Text = "";
            comboBox_major.Text = "";
            comboBox_year.Text = "";
            textBox_GPA.Text = "";
            dateTimePicker_appt.Value = DateTime.Today;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //When this button is clicked, it will find on the datagridview the data entered by the user.
            string search_term = textBox_search.Text;
            Boolean search_found = false;
            dataView_students.ClearSelection();
            foreach (DataGridViewRow row in dataView_students.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(search_term))
                {
                    row.Selected = true;
                    search_found = true;
                }
            }

            if (!search_found) MessageBox.Show("Search not found!");
        }

        private void btn_high_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the highest GPA.
            if (dataView_students.Rows.Count != 0)
            {
                decimal highest_GPA = 0;
                DataGridViewRow highest_GPA_row = new DataGridViewRow();
                foreach (DataGridViewRow row in dataView_students.Rows)
                {
                    if (row.Cells[4].Value != "" && Convert.ToDecimal(row.Cells[4].Value) > highest_GPA)
                    {
                        highest_GPA_row = row;
                    }
                }
                highest_GPA_row.Selected = true;
            }
        }

        private void btn_low_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the lowest GPA.
           /* if (dataView_students.Rows.Count != 0)
            {
                decimal lowest_GPA = 4;
                DataGridViewRow lowest_GPA_item = new DataGridViewRow();
                foreach (DataGridViewRow item in dataView_students.Rows)
                {
                    decimal GPA = Convert.ToDecimal(item.Cells[4].Value);
                    if (GPA < lowest_GPA)
                    {
                        lowest_GPA = GPA;
                        lowest_GPA_item = item;
                    }
                }

                MessageBox.Show("Student ID " + lowest_GPA_item.Cells[0].Value + "\nName: " +
                        lowest_GPA_item.Cells[1].Value + "\nMajor: " +
                        lowest_GPA_item.Cells[2].Value + "\nYear: " +
                        lowest_GPA_item.Cells[3].Value + "\nGPA: " +
                        lowest_GPA_item.Cells[4].Value + "\nAdvisor: " +
                        lowest_GPA_item.Cells[5].Value + "\nAppointment: " +
                        lowest_GPA_item.Cells[6].Value); ;
            }*/
        }

        private void btn_remove_record_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the selected information.

            if (dataView_students.SelectedRows.Count > 0)
            {
                //dataView_students.Rows.Remove(dataView_students.SelectedRows[0]);
                int student_id = (int)dataView_students.SelectedRows[0].Cells[0].Value;
                studentSuccessListTableAdapter.DeleteQuery(student_id);
            }
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void low_risk_rbn_CheckedChanged(object sender, EventArgs e)
        {
            this.studentSuccessListTableAdapter.LowRisk(this.student_dbDataSet.StudentSuccessList);
        }
    }
}
