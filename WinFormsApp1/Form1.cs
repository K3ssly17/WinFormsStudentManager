using System;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private StudentRepository repo = new StudentRepository();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        LoadStudents();

        }

        private void LoadStudents()
        {
            var students = repo.GetAll();
            dgvStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtAge.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            MessageBox.Show("Please fill all fields.");
            return;
        }

        if (!int.TryParse(txtAge.Text, out int age))
        {
            MessageBox.Show("Age must be a number.");
            return;
        }

        
        Student s = new Student
        {
            FullName = txtName.Text,
            Age = age,
            Email = txtEmail.Text
        };

        
        repo.Add(s);
        MessageBox.Show("Student added successfully!");

        
        txtName.Clear();
        txtAge.Clear();
        txtEmail.Clear();

        
        LoadStudents();
    }
}
}

        
    

