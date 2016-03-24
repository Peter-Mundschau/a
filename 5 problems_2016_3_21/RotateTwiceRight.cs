using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_problems_2016_3_21
{
    public class RotateTwiceRight
    {
        

        public static void RotatebyTwo()
        {
            Console.WriteLine("Enter your Numbers Followed by a Coma;  eg;(1, 2, 3, )\n" );
            string userNumber = Console.ReadLine();
            

            List<string> listofNumbers = userNumber.Split(',').ToList<string>();
            int numberListLength = listofNumbers.LongCount;
            int numberListLength = listofNumbers.LongCount();

            listofNumbers.Sort();   

            return ;  
        }

        
        
    

    }
}
