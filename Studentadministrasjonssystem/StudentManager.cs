using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    class StudentManager
    {
        public List<Student> _students = new List<Student>();
        public StudentManager()
        {
            InitStudents();
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void PrintAllStudentsInfo()
        {
            foreach (var student in _students) 
            {
                student.PrintStudentInfo();
            }
        }
        public void InitStudents()
        {
            _students = new List<Student>() 
            { new Student("Jonas", 21, 420, 483392),
            new Student("Gunnar", 32, 123, 100376),
            new Student("Kølla", 54, 666, 348725),
            new Student("Johnny", 22, 234, 619403),
            new Student("Lisa", 12, 937, 874502),
            new Student("Silje", 26, 448, 135987),
            new Student("Gudrun", 42, 612, 562041),
            new Student("Gjørdiss", 82, 341, 790634),
            new Student("Joseph Fritzl", 71, 259, 246819),
            };

            

        }
    }
}
