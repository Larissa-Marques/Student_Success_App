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
        public Advisor_Form()
        {
            InitializeComponent();
        }

        private void GPA_Form_Load(object sender, EventArgs e)
        {

        }

        public void update_gpa(double gpa) { 
            textBox_overall_gpa.Text = gpa.ToString();
        }
    }
}
