using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _150922_CodeEval_ReadMore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            You are given a text. Write a program which outputs its lines according to the following rules:

If line length is ≤ 55 characters, print it without any changes.
If the line length is > 55 characters, change it as follows:
Trim the line to 40 characters.
If there are spaces ‘ ’ in the resulting string, trim it once again to the last space (the space should be trimmed too).
Add a string ‘... <Read More>’ to the end of the resulting string and print it.
            */

            //string line = "Tom's mouth watered for the apple, but he stuck to his work.";

            StreamReader reader = new StreamReader("..\\..\\SampleInput.txt");
            using (reader)
            {                
                string line = reader.ReadLine();
                while (line != null)
                {
                    
                        if (line.Length <= 55)
                        {
                            Console.WriteLine(line);
                        }
                        else if (line.Length > 55)
                        {
                            line = line.Remove(40);
                            if (line.LastIndexOf(' ') >= 0)
                            {
                            line = line.Remove(line.LastIndexOf(' '));
                            }                            
                            line = line.Trim();                            
                            Console.WriteLine(line + "... <Read More>");
                        }
                        
                        //remove this line for CodeEval
                        line = reader.ReadLine();
                }
                
            }
                            
        }
    }
}
