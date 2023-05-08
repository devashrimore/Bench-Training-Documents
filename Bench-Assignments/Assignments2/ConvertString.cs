using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//convert string into integer
namespace Assignments2
{
    public class ConvertString
    {
        string numstring;
        
        public void getConvert()
        {
            Console.WriteLine("Enter the String :");
            numstring=Console.ReadLine();

            int num=Convert.ToInt32(numstring);
            Console.WriteLine("The Converted Int is : "+numstring);
        } 
    }
}