using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_milestone
{
     class Program
    {
        
        static void Main(string[] args)
        {
            StudentManagementSystem system = new StudentManagementSystem();

           

        Console.WriteLine("welcome to student registration.");

                //registering new student
                Student student1 = new Student
                {
                    Name = "Relebogile",
                    Surname = "Libitsa",
                    Gender = "female",
                    Email = "577710@belgiumcampus.ac.za",
                    DateOfBirth = new DateTime(2003, 03, 15),
                    PhoneNumber = "0785765631",
                    Qualification = "Diploma"

                };
                system.RegisterStudent(student1);
            }
        

    }
}
