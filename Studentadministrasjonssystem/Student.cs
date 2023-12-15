using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    class Student
    {
        public string _Name = "";
        public int _Age;
        //public string _StudyProgram = "";
        public int StudyProgram;
        public int _StudentId;

        public Student(string name, int age, int studyProgram, int studentId)
        {
            _Name = name;
            _Age = age;
            StudyProgram = studyProgram;
            _StudentId = studentId;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student ID: {_StudentId}");
            Console.WriteLine($"Name: {_Name}");
            Console.WriteLine($"Age: {_Age}");
            Console.WriteLine($"Study Program: {StudyProgram}");
            Console.WriteLine();
        }
    }
}
