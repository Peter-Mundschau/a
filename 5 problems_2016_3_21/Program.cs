using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_problems_2016_3_21
{
    public class Program
    {
        static void Main(string[] args)
        {
            LengthOfChars stringLength = new LengthOfChars();
            stringLength.GetLengthofGivenString();

            ValueOfPi givePi = new ValueOfPi();
            givePi.PiValue();

            ComboMove getCombo = new ComboMove();
            getCombo.Combo();

            DancingString jumpingJack = new DancingString();
            jumpingJack.JumpingJack();

        }
    }
}
