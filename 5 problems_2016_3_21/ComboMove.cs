using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_problems_2016_3_21
{
   public class ComboMove

    { 
        //The combo move is: Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump.
       public void Combo()
        { 
         string bmo = "Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump";
            bmo = bmo.Replace(", ", "\n");
            Console.WriteLine(bmo);
        }
        

    }
}
