
using System.Dynamic;
using System.Data;
using System.Security.AccessControl;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bench_Assignments
{
    public class SmallestSum
    {
        int sum,Smallest=int.MaxValue;
        int[] arr=new int[50];       
        public void ConsecutiveSum()
        {
            Console.WriteLine("Enter the No of elements in Array:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in Array:");
            for(int i=0;i<n;i++)
            {
            arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i + 1 < n; i++) 
            {
                // adding the alternate numbers
               // int temp=sum;
               
                sum = arr[i] + arr[i + 1];
                Console.WriteLine(sum);
                if(sum<Smallest)
                {
                    Smallest=sum;
                }
                
            }
            Console.WriteLine("smallest sum is: "+Smallest);
        }
    }
        
}