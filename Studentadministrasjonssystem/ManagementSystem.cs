using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
internal class ManagementSystem
{
    public StudentManager SManager { get; set; }
    public SubjectManager SubManager { get; set; }
    public GradeManager GManager { get; set; }
        public ManagementSystem()
        {
            SManager = new StudentManager();
            SubManager = new SubjectManager();
            GManager = new GradeManager(SManager._students);
        }

    }
}
