using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7_SearchList
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            FillPersonList(personsList, 10000);
            Console.WriteLine();
            TestListSearch(personsList, 1000);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

            Dictionary<string, Person> personsDict = new Dictionary<string, Person>();
            FillPersonDictionary(personsDict, 10000);
            Console.WriteLine();
            TestDictSearch(personsDict, 1000);
        }

        private static void TestDictSearch(Dictionary<string, Person> persons, int count)
        {
            int foundCount = 0;
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < count; i++)
            {
                string name = Person.RandomName(random, 4);
                Person foundPerson;
                if (persons.TryGetValue(name, out foundPerson))
                {
                    foundCount++;
                    Console.WriteLine(foundPerson);
                }
            }

            DateTime endTime = DateTime.Now;

            Console.WriteLine("Persons in list: " + persons.Count);
            Console.WriteLine("Persons searched: " + count);
            Console.WriteLine("Persons found: " + foundCount);
            Console.WriteLine("Time elapsed: " + (endTime - startTime).TotalMilliseconds + "ms");
        }

        private static void TestListSearch(List<Person> persons, int count)
        {
            int foundCount = 0;
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < count; i++)
            {
                string name = Person.RandomName(random, 4);
                Person foundPerson = persons.Find(x => x.FirstName == name);
                if (foundPerson != null)
                {
                    foundCount++;
                    Console.WriteLine(foundPerson);
                }
            }

            DateTime endTime = DateTime.Now;

            Console.WriteLine("Persons in list: " + persons.Count);
            Console.WriteLine("Persons searched: " + count);
            Console.WriteLine("Persons found: " + foundCount);
            Console.WriteLine("Time elapsed: " + (endTime - startTime).TotalMilliseconds + "ms");
        }

        private static void FillPersonList(List<Person> persons, int count)
        {
            Console.WriteLine("Populating person list...");
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < count; i++)
            {
                persons.Add(new Person(Person.RandomName(random, 4), Person.RandomName(random, 8)));
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(count + " Persons generated in " + (endTime - startTime).TotalMilliseconds + "ms");
        }


        private static void FillPersonDictionary(Dictionary<string, Person> persons, int count)
        {
            Console.WriteLine("Populating person list...");
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < count; ) //incremented inside loop
            {
                string firstName = Person.RandomName(random, 4);
                if (!persons.ContainsKey(firstName))
                {
                    string lastName = Person.RandomName(random, 8);
                    persons.Add(firstName, new Person(firstName, lastName));
                    i++;
                }
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(count + " Persons generated in " + (endTime - startTime).TotalMilliseconds + "ms");
        }
    }
}
