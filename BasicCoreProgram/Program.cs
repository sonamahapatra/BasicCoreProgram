using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Basic Core Program");
            Console.WriteLine("Please Choose One From Below Option: ");
            Console.WriteLine("1.FlipCoin\n 2.LeapYear\n 3.PowerOfTwo \n 4.Harmonic Series \n 5.Factor \n 6.FindQuotientAndRemainder");
       
                
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FlipCoin.Flip();
                    break;
                case 2:
                    LeapYear.TheLeapYear();
                    break;
                    case 3:
                    PowerOfTwo.CalPow();
                    break;
                    case 4:
                    Harmonic.HarmonicSeries();
                    break;
                    case 5:
                        Factor.PrimeFactor();
                    break;
                    case 6:
                    QuotientandRemainder.FindQuotientAndRemainder();
                    break;
                default:
                    Console.WriteLine("Please Choose Program With Given Option");
                    break;
            }


        }
    }
}
