using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             void exec()
            {
                //Get input letters for comparison
                Console.WriteLine("Enter letters");
                string input = Console.ReadLine();


                //use the streamreader to read from the file-import System.IO
                StreamReader file = new StreamReader(@"C:\\Users\Tay-yib Amod\Desktop\words_alpha.txt");
                //set the var line to the file's first line and get the length
                string line = file.ReadLine();

                //input = Console.ReadLine();
                Console.WriteLine("  ");
                Console.WriteLine("The words are: ");

                //Convert output to a char array then sort it
                char[] arr1 = input.ToLower().ToCharArray();
                Array.Sort(arr1);
                string inp = new string(arr1);


                //run loop as long as there are words in the file
                while (line != null)
                {
                    char[] arr2 = line.ToLower().ToCharArray();
                    Array.Sort(arr2);
                    string outp = new string(arr2);

                    //check if the letters of input are in the current line
                    //check if the word is of the same length as the letters
                    if (inp == outp)
                    {
                        //write the word
                        Console.WriteLine(line);
                    }

                    line = file.ReadLine();
                }
                Console.ReadLine();
            }
             exec();
            while (Console.ReadLine() != "0")
            {
                exec();
            }
        }

        
    }
}