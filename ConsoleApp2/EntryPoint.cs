using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            /*
            string[] stringArray = { "This", "C#", "is", "course", "a", "I love playing with the console" };
            string string1 = stringArray[0] +" "+ stringArray[2] + " " + stringArray[4] + " " + stringArray[1] + " " + stringArray[3];
            string string2 = stringArray[5];
            Console.WriteLine(@"""{0}"",""{1}""", string1, string2);
            Console.WriteLine(@"C:\Program Files\""Microsoft Programs""\'VisualStudio'");
            Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\\'VisualStudio\'");
            Console.WriteLine("---------------------------------");
            string stringPath = ":\\Program Files\\\"Microsoft Programs\"\\";
            Console.WriteLine("Input an application: ");
            string app = Console.ReadLine();
            Console.WriteLine("Input local device letter: ");
            char drive = (char)Console.Read();
            Console.WriteLine(drive + stringPath + "\'" + app + "\'");
            */

            //4-------------------------
            string[] proteinIntakeWeek = { "Protein intake week: 1", "80.88557", "94.56465", "76.777", "80.14582" };
            Console.Write('|' + proteinIntakeWeek[0] + '|');

            printALine(proteinIntakeWeek[0]);

            MiddleLine(proteinIntakeWeek, proteinIntakeWeek[0]);

            printALine(proteinIntakeWeek[0]);

            Console.WriteLine();

        }
        private static void printALine(string text)
        {
            Console.Write("\n" + '|');
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("=");
            }
            Console.Write('|');
        }
        private static void MiddleLine(string[] array, string text)
        {
            //int space = text.Length - 4;
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write("\n" + '|');
                //String.Format("{0:0.00}",Sale);
                Console.Write("{0, 22}", array[i]);
                Console.Write('|');

            }

        }

    }
}
