namespace Teht1_L9
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string AsioID { get; }
        public string Group { get; }

        public Student(string firstName, string lastName, string asioID, string group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AsioID = asioID;
            this.Group = group;
        }

        //public void Print()
        //{
        //    Console.WriteLine(FirstName + " " + LastName);
        //    Console.WriteLine("ID: " + AsioID);
        //    Console.WriteLine("Group: " + Group);
        //}

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + AsioID + " " + Group;
        }
    }
}
