// See https://aka.ms/new-console-template for more information


using Studentadministrasjonssystem;

void Main()
{
    var manager = new ManagementSystem();
    Console.WriteLine("Welcome to your own personal student administration system.");
    Console.WriteLine("Do you wish to see information about:");
    Console.WriteLine("(1.) Students");
    Console.WriteLine("(2.) Do you wish to see details regarding a students grades?");
    var userInput = Console.ReadLine();
    if (userInput == "1")
    {
        manager.SManager.PrintAllStudentsInfo();
    }
    else if (userInput == "2")
    {
        manager.GManager.PrintAllGrades();
    }
    else 
    { Console.WriteLine("Invalid response, please try again. ");
        Main();

    }




}

//void SubjectsView()
//{
//    SubjectManager subjectManager = new SubjectManager();

//    var subject1 = new Subject(420, "Name", 90);
//    var subject2 = new Subject(123, "Name", 120);
//    var subject3 = new Subject(666, "Name", 69);
//    var subject4 = new Subject(234, "Name", 180);
//    var subject5 = new Subject(937, "Name", 180);
//    var subject6 = new Subject(448, "Name", 90);
//    var subject7 = new Subject(612, "Name", 120);
//    var subject8 = new Subject(341, "Name", 80);
//    var subject9 = new Subject(259, "Name", 120);

//    SubjectManager.AddSubject(subject1);
//    studentManager.AddStudent(student2);
//    studentManager.AddStudent(student3);
//    studentManager.AddStudent(student4);
//    studentManager.AddStudent(student5);
//    studentManager.AddStudent(student6);
//    studentManager.AddStudent(student7);
//    studentManager.AddStudent(student8);
//    studentManager.AddStudent(student9);
//}
Main();
