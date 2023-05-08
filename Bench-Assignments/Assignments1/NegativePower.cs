using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bench_Assignments
{
    public class NegativePower
    {
        int baseno=0,expo=0;
        double result=1.0;
        
        public void GetNegativePower()
        {
        
        Console.WriteLine("Enter a Base Number:");
        baseno=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an exponent :");
        expo=Convert.ToInt32(Console.ReadLine());

            while (expo < 0)
            {
            result /= baseno;
            ++expo;
            }

        Console.WriteLine(result);
       }
        
    }   
}





