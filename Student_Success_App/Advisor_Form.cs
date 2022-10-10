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
    public partial class Advisor_Form : Form
    {
        private decimal avg_gpa;
        private decimal percent_with_advisors;
        public Advisor_Form(decimal avg_gpa, decimal percent_with_advisors)
        {
            InitializeComponent();
            this.avg_gpa = avg_gpa;
            this.percent_with_advisors = percent_with_advisors;
        }

        private void GPA_Form_Load(object sender, EventArgs e)
        {
            textBox_avg_gpa.Text = avg_gpa.ToString();
            textBox_without_advisor_percent.Text = percent_with_advisors.ToString();

        }
    }
}
