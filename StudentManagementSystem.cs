using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_milestone
{
    //student records and operations


    internal class StudentManagementSystem
    {
        private List<Student> students;
        private Promotion promotion;

        public StudentManagementSystem()
        {
            students = new List<Student>();
            promotion = new Promotion();
        }
        public void RegisterStudents(Student student)
        {
            student.StudentID = GenerateStudentID();
            students.Add(student);
        }

        public int GenerateStudentID()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        void DisplayStudents()
        {
            Console.WriteLine("Registered students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentID}, Name: {student.Name} {student.Surname}, Qualification: {student.Qualification}");
            }
        }
    }
}













