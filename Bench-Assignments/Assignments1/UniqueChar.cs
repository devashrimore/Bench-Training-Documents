using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bench_Assignments
{
    public class UniqueChar
    {
        public void CheckUnique()
        {
            int count;  
            Console.WriteLine("Enter the String:");
            string str=Console.ReadLine();
            
            
            char[] string1 = str.ToCharArray();  
            
            Console.WriteLine("Unique characters in a given string: ");  
             
            for(int i = 0; i <string1.Length; i++) 
            {  
                count = 1;  
                for(int j = i+1; j <string1.Length; j++) 
                {  
                    if(string1[i] == string1[j] && string1[i] != ' ') {  
                        count++;  
                        //Set string1[j] to 0 to avoid printing visited character  
                        string1[j] = '0';  
                    }  
                }  
                //A character is considered as duplicate if count is greater than 1  
                if(count > 1 && string1[i] != '0')
                 {}
                else if(string1[i] != '0')
                Console.WriteLine(string1[i]); 
            }
        }
    }
}