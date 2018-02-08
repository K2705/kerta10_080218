using System;
using System.IO;

namespace Teht1_L10
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        /// <summary>
        /// luodaan tiedosto
        /// kysytään käyttäjältä nimet
        /// kirjoitetaan nimet tiedostoon
        /// avataan tiedosto lukua varten
        /// näytetään nimet
        /// </summary>
        static void Test()
        {
            try
            {
                string myfile = @"D:\K2705\testi.txt";

                using (StreamWriter writer = new StreamWriter(myfile))
                {
                    string input;
                    do
                    {
                        Console.Write("Write text\n> ");
                        input = Console.ReadLine();
                        if (input.Length > 0)
                        {
                            writer.WriteLine(input);
                        }
                    } while (input.Length > 0);


                    writer.Close(); //Ei tarvita, kiitos using-lohkon
                }

                if (File.Exists(myfile))
                {
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("File {0} contains names\n{1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("File {0} not found", myfile);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
