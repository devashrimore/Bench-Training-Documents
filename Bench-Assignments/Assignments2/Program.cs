
using System.Security.AccessControl;
using System;

namespace Assignments2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Count of vowels,Consonants in string
            // CountVowels c=new CountVowels();
            // c.GetCount();
            #endregion

             #region Convert string to Int
            // ConvertString c=new ConvertString();
            // c.getConvert();
            #endregion

             #region Count of vowels,Consonants in string
            //  DiffEquals d=new DiffEquals();
            //  d.Get();
            #endregion

            #region Count of vowels,Consonants in string
            // RemoveChar obj=new RemoveChar();
            // obj.removeChars();
            #endregion

            #region Permutations of a string
            Console.WriteLine("Enter String :");
            String str = Console.ReadLine(); 
            int n = str.Length; 
            Permutation p=new Permutation();
            p.permute(str, 0, n-1); 
            #endregion
        }
    }
}
