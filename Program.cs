using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        { 
        
            int n=19;
            Console.WriteLine(Parser.HumanTimeFormat.NSquaresFor(n));

        }


    }


    public class Parser
    {
        public class HumanTimeFormat
        {
            public static int NSquaresFor(int n)
            {
                int counter = 0;
                double number = (double)n;
                while (n > 0)
                {
                    
                    if ((Math.Sqrt(number)) % 1 == 0)
                    {
                        counter++;
                        n -= (int)number;
                        number = n;
                    }
                    else
                    {
                        number--;
                    }
                }
                
                   
               
                    
                
                return counter;
            }

          
        }
    }


}


