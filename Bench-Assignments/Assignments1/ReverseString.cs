using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bench_Assignments
{
    public class ReverseString
    {
        
        //reverse string
        public string Reverse() 
        { 
            Console.WriteLine("Enter First String");
            string Input1=Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string Input2=Console.ReadLine();
      
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
            //return reversedString;

            if(reversedString.Length!=Input2.Length)
            {
                return "String Are not Equal";
            }
            else
            {
                for(int i=0;i<reversedString.Length;i++)
                {
                    if(reversedString[i] != Input2[i])
                    {
                        i=reversedString.Length;
                        return "strings are not Equal";
                    }
                }
                return "strings are Equal";
            }
        } 

      
    }
    
}

 