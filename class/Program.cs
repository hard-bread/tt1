using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{

    class Student
    {
        public Guid id;
        public string firstname;
        public string lastname;
        public string middlename;
        public int age;
        public string group;
    }

    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.id = Guid.NewGuid();
            student.firstname = "Иванов";
            student.lastname = "";
            student.middlename = "";
            student.group = "235109";
            student.age = 19;

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastname}");
            Console.WriteLine($"Имя: {student.firstname}");
        }

        static void Main() 
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }

}
