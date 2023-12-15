using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    class Subject
    {
        public int Code;
        public string Name = "";
        public int StudyPoints;

        public Subject(int subjectCode, string subjectName, int subjectStudyPoint)
        {
            Code = subjectCode;
            Name = subjectName;
            StudyPoints = subjectStudyPoint;
        }

        public void PrintSubjectInfo()
        {
            Console.WriteLine($"Subject Code: {Code}");
            Console.WriteLine($"Subject Name: {Name}");
            Console.WriteLine($"Subject Study Point: {StudyPoints}");
            Console.WriteLine(); 
        }

        
    }
}
