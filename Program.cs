using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MLearnSharp
{
    class Program
    {   
        
        static string DecToBool(int number)
        {
            int maxPow = 0;
            while(number > Math.Pow(2, maxPow))
            {
                maxPow++;
            }

            Console.WriteLine(maxPow);

            string result = "";

            for(int i = maxPow; i >= 0; i--)
            {
                bool isBitSet = (number & (1 << i)) != 0;
                if (isBitSet){
                    result += '1';
                }
                else {
                    result += '0';
                }
            }

            return result;
        }


        
        
        



        static void Main()
           {

            


           }
    }
}
