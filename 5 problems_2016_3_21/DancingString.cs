using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_problems_2016_3_21
{
    public class DancingString
    {

        public string armsUp = @"
                     *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ";

        public string armsDown = @"
                     *  * 
                   *      * 
                     *  *         
                       *       
                   *  *  * 
                 *    *   *  
               *      *     *  
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ";

        public void JumpingJack()
        {


            for (int i = 1; i < 5; i++)
            {
                if (i % 2==1)Console.WriteLine(armsUp);
                else
                {
                    Console.WriteLine(armsDown);
                }
                Console.WriteLine("Press key to continue...");
                Console.ReadKey();
                Console.Clear();
            }




 

        }

    }
}
