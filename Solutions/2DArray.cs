using System;

namespace Bootcamp.Solutions
{
    public class DArray
    {
        public void Problem1()
        {
            int i,j;
            int[,] arr1 = new int[3,3];
  
             for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                  Console.Write("[{0},{1}] ",i,j);
                arr1[i,j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }  
 
            for(i=0;i<3;i++)
            {
                Console.Write("\n");
                for(j=0;j<3;j++)
                Console.Write("{0}\t",arr1[i,j]);
            }
        }
        public void Problem2()
        {
            float[,] puntuations = new float[10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the puntuation {0} group {1}: ", j + 1, i + 1);
                    puntuations[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }
               public void Problem3()  
        {  
            int n = Convert.ToInt32(Console.ReadLine());  
   
            int m = Convert.ToInt32(Console.ReadLine());   
  
            int[,] arr1 = new int[n, m];  
  
            string arr2 = Convert.ToString(Console.ReadLine());  
  
            string[] temp = arr2.Split(' ');  
  
            int k = 0;  
            for (int i = 0; i < n; i++)  
            {  
                for (int j = 0; j < m; j++)  
                {  
                    int a = Convert.ToInt32(temp[k]);  
                    arr1[i, j] = a;  
                    k++;  
                }  
            }    
            for (int i = 0; i < n; i++)  
            {  
  
                for (int j = 0; j < m; j++)  
                {  
                    if (j == 0)  
                    {  
                        Console.Write(arr1[i, j]);  
                    }  
                    else  
                    {  
                        Console.Write(" " + arr1[i, j]);  
                    }  
  
                }  
                Console.WriteLine();  
            }  
        }  
        public void Problem4()
        {
            int[,] a = new int[3, 5];

            int i = 0;

            for (i=0; i < 3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(a[i, j]);

                Console.WriteLine();
            }
        }
        public void Problem5()
        {
            int[,] arr1 = new int[3,3];
  
             for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                arr1[i,j] = int.Parse(Console.ReadLine()); 
                }
            }  
                int a = arr1.GetLength(0);
                int b = arr1.GetLength(1);
                int sum=0;
                for(int row=0; row<a; row++)
                {
                    for(int i=0; i<b; i++)
                    {
                        if(row==i)
                        {
                            sum += arr1[row,i];
                        }
                    }
                }
                Console.WriteLine(sum);
        } 
    }
}