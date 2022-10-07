using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Success_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int techId = 15273244;
        static int generateId()
        {
            return techId++;
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the student name, major, school year, GPA, advisor
            // assignment information, appointment date will be displayed on the datagridview.
            string assgined_ad = "No";
            if (checkBox_advisor.Checked) assgined_ad = "Yes";

            object[] row = {
                techId++,
                textBox_name.Text,
                comboBox_major.Text,
                comboBox_year.Text,
                textBox_GPA.Text,
                assgined_ad,
                dateTimePicker_appt.Value.ToShortDateString()
            };

            dataView_students.Rows.Add(row);
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

        private void search_data(String search_term)
        {
            foreach (DataGridViewRow row in dataView_students.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(search_term))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //When this button is clicked, it will find on the datagridview the data entered by the user.
            string search_term = textBox_search.Text;
            search_data(search_term);
            /*            ListViewItem matched_item = dataView_students.FindItemWithText(search_term);

                        if (matched_item != null && search_term != "")
                            MessageBox.Show("Student ID: " + matched_item.SubItems[0].Text + "\nName: " +
                                matched_item.SubItems[1].Text + "\nMajor: " +
                                matched_item.SubItems[2].Text + "\nYear: " + matched_item.SubItems[3].Text
                                + "\nGPA: " + matched_item.SubItems[4].Text + "\nAdvisor? " +
                                matched_item.SubItems[5].Text + "\nAppointment: " + matched_item.SubItems[6].Text);
                        else
                            MessageBox.Show("Search not found!");*/
        }

        private void btn_high_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the highest GPA.
            if (dataView_students.Rows.Count != 0)
            {
                decimal highest_GPA = 0;
                ListViewItem highest_GPA_item = new ListViewItem();
                foreach (ListViewItem item in dataView_students.Rows)
                {
                    decimal GPA = Convert.ToDecimal(item.SubItems[4].Text);
                    if (GPA > highest_GPA)
                    {
                        highest_GPA = GPA;
                        highest_GPA_item = item;
                    }
                }

                MessageBox.Show("Student ID " + highest_GPA_item.SubItems[0].Text + "\nName: " +
                        highest_GPA_item.SubItems[1].Text + "\nMajor: " +
                        highest_GPA_item.SubItems[2].Text + "\nYear: " +
                        highest_GPA_item.SubItems[3].Text + "\nGPA: " +
                        highest_GPA_item.SubItems[4].Text + "\nAdvisor: " +
                        highest_GPA_item.SubItems[5].Text + "\nAppointment: " +
                        highest_GPA_item.SubItems[6].Text);
            }
        }

        private void btn_low_GPA_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the lowest GPA.
            if (dataView_students.Rows.Count != 0)
            {
                decimal lowest_GPA = 4;
                ListViewItem lowest_GPA_item = new ListViewItem();
                foreach (ListViewItem item in dataView_students.Rows)
                {
                    decimal GPA = Convert.ToDecimal(item.SubItems[4].Text);
                    if (GPA < lowest_GPA)
                    {
                        lowest_GPA = GPA;
                        lowest_GPA_item = item;
                    }
                }

                MessageBox.Show("Student ID " + lowest_GPA_item.SubItems[0].Text + "\nName: " +
                        lowest_GPA_item.SubItems[1].Text + "\nMajor: " +
                        lowest_GPA_item.SubItems[2].Text + "\nYear: " +
                        lowest_GPA_item.SubItems[3].Text + "\nGPA: " +
                        lowest_GPA_item.SubItems[4].Text + "\nAdvisor: " +
                        lowest_GPA_item.SubItems[5].Text + "\nAppointment: " +
                        lowest_GPA_item.SubItems[6].Text); ;
            }
        }

        private void btn_remove_record_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the selected information.
            if (dataView_students.SelectedRows.Count > 0)
            {
                dataView_students.Rows.Remove(dataView_students.SelectedRows[0]);
            }
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the information without any selection.
            dataView_students.Rows.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will edit the selected information.
            if (dataView_students.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_item = dataView_students.SelectedRows[0];
                textBox_name.Text = selected_item.Cells[1].ToString();
                comboBox_major.Text = selected_item.Cells[2].ToString();
                comboBox_year.Text = selected_item.Cells[3].ToString();
                textBox_GPA.Text = selected_item.Cells[4].ToString();
                dataView_students.Rows.Remove(selected_item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_dbDataSet.StudentSuccessList' table. You can move, or remove it, as needed.
            this.studentSuccessListTableAdapter.Fill(this.student_dbDataSet.StudentSuccessList);

        }
    }
}
