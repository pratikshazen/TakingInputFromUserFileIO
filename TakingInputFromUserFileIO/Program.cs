using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TakingInputFromUserFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string s1 = null;
            Console.WriteLine("Enter your text here: ");
            while (str != "#")
            {
                
                str = Console.ReadLine();

                if (str != "#")
                {
                    s1 = s1 + str;
                }
            }

            using (FileStream fs = new FileStream(@"e:\UserInput.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(s1);
                    writer.WriteLine("The contents of the file in streamwriter: ");
                    writer.WriteLine("welcome ");
                }

            }
            using (FileStream fs1 = new FileStream(@"d:\UserInput.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs1))
                {
                    Console.WriteLine("The contents of file UserInput.txt: " + reader.ReadToEnd());
                }


            }
        }
    }
}