using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_problems_2016_3_21
{
   public class LengthOfChars
    {

        string givenString;
        public void GetLengthofGivenString()
        {
         Console.WriteLine("Please Enter the 'info you want the Length of'\n");
            
            givenString = Console.ReadLine();
            
            Console.WriteLine(givenString.Length);
            Console.WriteLine("\n\rPress the ENTER key to continue...");

        
            Console.ReadLine();

        }
        
    }
}
