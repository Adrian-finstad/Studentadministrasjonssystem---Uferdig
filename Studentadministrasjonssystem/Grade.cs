using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Studentadministrasjonssystem
{
    internal class Grade
    {
        public int ListedStudent { get; set; }
        public int ListedSubject;
        public int Value;

        public Grade(int student, int subject, int value)
        {
            ListedStudent = student;
            ListedSubject = subject;
            Value = value;
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Student ID: {ListedStudent}");
            Console.WriteLine($"Study Program: {ListedSubject}");
            Console.WriteLine($"Grade: {Value}");
            Console.WriteLine();
        }
    }
}
