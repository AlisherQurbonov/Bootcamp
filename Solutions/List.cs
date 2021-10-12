using System;
using System.Collections.Generic;

namespace Bootcamp.Solutions
{
    public class List
    {
       public void Problem1()
       {
           List<int> list = new List<int>();

             int n, sum = 0;


             while (int.TryParse(Console.ReadLine(), out n))
                {
                   
                    sum += n;
                           
                    list.Add(n);
                }

                
                Console.WriteLine("Average: " + (list.Count > 0? sum / list.Count : 0));
        }

        public void Problem2()
        {
            var text = Console.ReadLine().Substring(0, 5);
            var textArray = text.ToCharArray();

            for(int qator = 0; qator < text.Length; qator++)
            {  
            
                int start = qator;
                
                for(int ustun =0; ustun < text.Length; ustun++)
                {
                    System.Console.Write(text[start++ % text.Length ]);
                    
                    
                }
                System.Console.WriteLine(" ");
            }
        }
    } 
 }
