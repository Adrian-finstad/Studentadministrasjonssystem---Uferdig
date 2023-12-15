using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    class GradeManager
    {
        private List<Grade> _grades = new List<Grade>();



        public GradeManager(List<Student> Students)
        {
            _grades = new List<Grade>();
            var r = new Random();

            for (int i = 0; i < Students.Count; i++)
                 _grades.Add(new Grade(Students[i]._StudentId, Students[i].StudyProgram, r.Next(1,6)));
               
            
        
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void PrintAllGrades()
        {
            foreach (var grade in _grades)
            {
                grade.PrintGrades();
            }
        }

    }
}

