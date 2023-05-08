
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bench_Assignments
{
    public class Reverse
    {
        public void SimpleReverse()
        {
            Console.WriteLine("----Reverse Without Recursion----");
            Console.WriteLine("Enter String");
            string Input1=Console.ReadLine();
           
      
            char[] charArray = Input1.ToCharArray(); 
            
            string reversedString = String.Empty; 

            int length, index; 
            length = charArray.Length - 1;
            index = length;
            
            
            while (index > -1) 
            {     
                reversedString = reversedString + charArray[index]; 
                index--; 
            }
            Console.WriteLine("The Reversed String : "+reversedString);
        }

        public void ReverseRecursion()
        {
            Console.WriteLine("\n\n----Reverse With Recursion----");
            Console.WriteLine("Enter String");
            string Input1=Console.ReadLine();


            string str = StringReverse(Input1);
            Console.Write("The reversed string  : "+str);
        }

        public static string StringReverse(string str)
            {
                if (str.Length > 0)
                    return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
                else
                    return str;
            }
    }
}