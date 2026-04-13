using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serrano_StudentGradeAnalyzer
{
    public partial class Form1 : Form
    {
        public struct Student
        {
            public string StudentNumber;
            public string StudentName;
            public double Prelim;
            public double Midterm;
            public double Final;
            public double Average;
            public string Remarks;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private double ComputeAverage(double prelim, double midterm, double final)
        {
            return (prelim + midterm + final) / 3.0;
        }
        public static string GetRemarks(double average)
        {
            return average >= 75 ? "Passed" : "Failed";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentNumber", "Student Number");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("Prelim", "Prelim Grade");
            dataGridView1.Columns.Add("Midterm", "Midterm Grade");
            dataGridView1.Columns.Add("Final", "Final Grade");
            dataGridView1.Columns.Add("Average", "Average");
            dataGridView1.Columns.Add("Remarks", "Remarks");
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();

                
                s.StudentNumber = textBox1.Text;  
                s.StudentName = textBox2.Text;   
                s.Prelim = double.Parse(textBox3.Text);
                s.Midterm = double.Parse(textBox4.Text); 
                s.Final = double.Parse(textBox5.Text); 

                
                s.Average = ComputeAverage(s.Prelim, s.Midterm, s.Final);
                s.Remarks = GetRemarks(s.Average);

               
                dataGridView1.Rows.Add(
                    s.StudentNumber,
                    s.StudentName,
                    s.Prelim,
                    s.Midterm,
                    s.Final,
                    s.Average.ToString("F2"),
                    s.Remarks
                );
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric grades!", "Input Error");
            }
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dataGridView1.Rows.Clear();

            textBox1.Focus();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
