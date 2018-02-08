using System;
using System.Collections.Generic;

namespace Teht1_L9
{
    class MiniAsio
    {
        private List<Student> Students;

        public MiniAsio()
        {
            Students = new List<Student>();
        }

        /// <summary>
        /// Adds student
        /// </summary>
        /// <param name="student">Student to add</param>
        /// <returns>true on success, false on failure</returns>
        public bool AddStudent(Student student)
        {
            foreach (Student oldStudent in Students)
            {
                if (student.AsioID == oldStudent.AsioID) return false;
            }
            
            Students.Add(student);
            return true;

        }

        /// <summary>
        /// Adds student
        /// </summary>
        /// <param name="firstName">student first name</param>
        /// <param name="lastName">student last name</param>
        /// <param name="asioID">student asio id</param>
        /// <param name="group">student group</param>
        /// <returns>true on success, false on failure</returns>
        public bool AddStudent(string firstName, string lastName, string asioID, string group)
        {
            return AddStudent(new Student(firstName, lastName, asioID, group));
        }

        public void PrintStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public List<Student> GetStudents()
        {
            return new List<Student>(Students);
        }

        public List<Student> GetStudents(SortedBy sort)
        {
            List<Student> ret = new List<Student>(Students);
            switch (sort)
            {
                case SortedBy.FirstName:
                    ret.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                    break;
                case SortedBy.LastName:
                    ret.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                    break;
                case SortedBy.AsioID:
                    ret.Sort((x, y) => x.AsioID.CompareTo(y.AsioID));
                    break;
                case SortedBy.Group:
                    ret.Sort((x, y) => x.Group.CompareTo(y.Group));
                    break;
            }
            return ret;
        }

    }
    enum SortedBy
    {
        FirstName, LastName, AsioID, Group
    }
}
