using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//remove chars from first string which are present in second string
namespace Assignments2
{
    public class RemoveChar
    {
        public void removeChars()
        {
        
            Console.WriteLine("Enter First String :");
            string string1=Console.ReadLine();

            Console.WriteLine("Enter Second String :");
            string string2=Console.ReadLine();
      
            for (int index = 0; index < string2.Length; index++)
            {
            var i = string2[index];
            while (string1.Contains(i.ToString() + ""))
            {
                string1 = string1.Replace((i.ToString() + ""),"");
            }
            }
            Console.WriteLine("String after removing Duplicate char:  "+string1);
        }
    }
}