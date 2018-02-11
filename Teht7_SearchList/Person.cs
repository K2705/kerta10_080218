using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7_SearchList
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static string RandomName(Random rng, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] name = new char[length];
            for (int i = 0; i < length; i++)
            {
                name[i] = chars[rng.Next(chars.Length)];
            }
            return new string(name);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
