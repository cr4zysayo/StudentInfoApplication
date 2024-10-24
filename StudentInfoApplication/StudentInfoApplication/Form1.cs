using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class StudentInfo
        {
            private string studentID;
            private string lastName;
            private string firstName;

            public StudentInfo() { }

            public StudentInfo(string id, string lastName, string firstName)
            {
                this.studentID = id;
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public StudentInfo(string id, string lastName)
            {
                this.studentID = id;
                this.lastName = lastName;
                this.firstName = firstName;
            }

            
        }
    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(
                Student_id.Text,
                Lname.Text,
                Fname.Text
            );

            StudentList.Items.Add(student.StudentID);
            Lnamelist.Items.Add(student.LastName);
            Fnamelist.Items.Add(student.FirstName);

            Student_id.Clear();
            Lname.Clear();
            Fname.Clear();
        }
    }
    }

//James Vladimir Z. Gacis