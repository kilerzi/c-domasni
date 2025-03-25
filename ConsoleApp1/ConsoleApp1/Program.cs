using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    //stavas class student 
    class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
        //opredeluvas sto ti treba za nekoj da bide vo klasata
        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
        //ispecatuva koj student e kade uci i koja grupa e
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Academy: {Academy}, Group: {Group}");
        }
    }
    //tuka ja povikuvame programata
    class Program
    {
        static void Main()
        {
            //array so 5 students
            List<Student> students = new List<Student>
        {
            new Student("mihail", "q academy", "group A"),
            new Student("mihail2", "q academy", "group B"),
            new Student("mihail3", "q academy", "group C"),
            new Student("mihail4", "q academy", "group D"),
            new Student("mihail5", "q academy", "group E")
        };
            //stavas ime proveruva dali go ima
            Console.Write("enter student name: ");
            string inputName = Console.ReadLine();
            //proveruva dali input name dali go ima vo students listata ako go ima se sipecatuva linija 24 do 28 ako go nema vika error
            Student foundStudent = students.Find(student => student.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase));

            if (foundStudent != null)
            {
                foundStudent.DisplayInfo();
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

