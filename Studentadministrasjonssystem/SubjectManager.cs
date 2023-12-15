using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class SubjectManager
    {
        public List<Subject> _subjects = new List<Subject>();

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public void PrintAllSubjectsInfo()
        {
            foreach (var subject in _subjects)
            {
                subject.PrintSubjectInfo();
            }
        }


        public void InitSubjects()
        {
            _subjects = new List<Subject>()
            {
                new Subject(420, "Juss",90),
                new Subject(123, "Tømrerfaget",120),
                new Subject(666, "Biologi", 69),
                new Subject(234, "Elektronikk",180),
                new Subject(937, "Sykepleier",180),
                new Subject(448, "Veterinær",90),
                new Subject(612, "Strikkefaget",120),
                new Subject(341, "Mekanikerfaget",80),
                new Subject(259, "Vakt og sikring",120),
            };
        }

        
    }
}

