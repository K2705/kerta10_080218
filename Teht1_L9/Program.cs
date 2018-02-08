using System;
using System.Collections.Generic;

namespace Teht1_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniAsio asio = new MiniAsio();
            TestAddStudents(asio);
            Console.WriteLine();
            TestAddStudentInput(asio);
            Console.WriteLine();
            TestSortStudents(asio);
        }

        private static void TestSortStudents(MiniAsio asio)
        {
            Console.WriteLine("Students in alphabetical order:");
            List<Student> students = asio.GetStudents(SortedBy.LastName);
            foreach (Student s in students) Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("Students by ASIO ID:");
            students = asio.GetStudents(SortedBy.AsioID);
            foreach (Student s in students) Console.WriteLine(s);
        }

        private static void TestAddStudentInput(MiniAsio asio)
        {
            Console.Write("Enter first name\n> ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name\n> ");
            string lastName = Console.ReadLine();
            Console.Write("Enter ASIO ID\n> ");
            string asioID = Console.ReadLine();
            Console.Write("Enter group\n> ");
            string group = Console.ReadLine();
            if (asio.AddStudent(firstName, lastName, asioID, group))
            {
                Console.WriteLine("Student successfully added.");
            }
            else
            {
                Console.WriteLine("Error: Duplicate ASIO ID \"{0}\" exists.", asioID);
            }
        }

        private static void TestAddStudents(MiniAsio asio)
        {
            asio.AddStudent("Masa", "Niemi", "", "");
            asio.AddStudent("Allan", "Aalto", "A1111", "");
            asio.AddStudent("Hanna", "Husso", "B2222", "");
            asio.AddStudent("Teppo", "Testaaja", "C3333", "TTV17S1");
            Console.WriteLine("Students in MiniASIO:");
            asio.PrintStudents();
        }
    }
}
