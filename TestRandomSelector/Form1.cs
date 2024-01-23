using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;

namespace TestRandomSelector
{
    public partial class Form1 : Form
    {
        string path = ConfigurationManager.AppSettings["file"];
        List<Student> students = new List<Student>();
        string file = @"c:\tempstest\TestStudent.txt";
        
            
        public Form1()
        {
            InitializeComponent();           
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ShowList()
        { 
            lstAllStudents.Items.Clear();
            List<Student> list;
            try 
            {
                list = Actions.ReadFromFile(path);
                foreach (Student student in list)
                {
                    lstAllStudents.Items.Add(student);
                }
            }
            catch (Exception ex) 
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
            
        }

        public void DisplayStudents(List<Student> students)
        {
            // Clear the ListBox to avoid duplicate entries.
            lstAllStudents.Items.Clear();

            foreach (var student in students)
            {
                lstAllStudents.Items.Add($"{student.Id} -  level: {student.Level} - {student.FirstName} {student.LastName}");
            }
        }

        private void lstAllStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            DisplayStudents(students);
        }

        private void btnGenerateGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
