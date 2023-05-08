using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//count no of vowels and constants in string
namespace Assignments2
{
    public class CountVowels
    {
    string input;
    int i, len, vowels, consonants;
     
            public void GetCount()
            {
            Console.WriteLine("Enter the String:");
            input = Console.ReadLine();       
            vowels = 0;
            consonants = 0;
            len = input.Length;
        
            
            for(i = 0; i < len; i++)
            {   
                if (input[i] == 'a' || input[i] == 'e' ||
                    input[i] == 'i' || input[i] == 'o' ||
                    input[i] == 'u' || input[i] == 'A' ||
                    input[i] == 'E' || input[i] == 'I' ||
                    input[i] == 'O' || input[i] == 'U')
                {
                    vowels++;
                }
                else if ((input[i] >= 'a' && input[i] <= 'z') ||
                        (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    consonants++;
                }
            }
            Console.WriteLine("count of vowel     : " + vowels);
            Console.WriteLine("count of consonant : " + consonants);
            }
    }
    
}