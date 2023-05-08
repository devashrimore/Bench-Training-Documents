using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//to find difference between equals and ==
namespace Assignments2
{
    public class DiffEquals
    {
        int x = 2;
        public void Get()
        {
        try
        {
            string str1 = null;
            string str2 = null;
            Console.WriteLine(x == 2.0); 
            Console.WriteLine(x.Equals(2.0)); 
            Console.WriteLine(str1 == str2);  //True
            Console.WriteLine(str1.Equals(str2));  //this will throw an error 
        }
        catch (System.Exception)
        {
            
            throw;
        }
        }
    }
}