using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public class StudentRepository
    {
        
        private readonly string cs =
            "Server=DESKTOP-7RRRC97;Database=WindowsFormsDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<Student> GetAll()
        {
            List<Student> list = new();

            using SqlConnection con = new(cs);
            using SqlCommand cmd = new("SELECT Id, FullName, Age, Email FROM Students", con);

            con.Open();
            using SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Student
                {
                    Id = r.GetInt32(0),
                    FullName = r.GetString(1),
                    Age = r.GetInt32(2),
                    Email = r.GetString(3)
                });
            }

            return list;
        }

        public void Add(Student s)
        {
            using SqlConnection con = new(cs);
            using SqlCommand cmd = new(
                "INSERT INTO Students (FullName, Age, Email) VALUES (@n, @a, @e)", con);

            cmd.Parameters.Add("@n", SqlDbType.NVarChar).Value = s.FullName;
            cmd.Parameters.Add("@a", SqlDbType.Int).Value = s.Age;
            cmd.Parameters.Add("@e", SqlDbType.NVarChar).Value = s.Email;

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
