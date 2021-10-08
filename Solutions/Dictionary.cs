using System;
using System.Collections.Generic;

namespace Bootcamp.Solutions
{
    public class Dictionary
    {
        public void Problem1()
    {
    {
        int TotalStudents = 0;
        int TotalGrades = 0;

        Console.WriteLine("Enter the number of students: ");
        TotalStudents = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of exams: ");
        TotalGrades = Convert.ToInt32(Console.ReadLine());

        int[,] scoresArray = new int[TotalStudents, TotalGrades];

        for (int r = 0; r < TotalStudents; r++)
            for (int c = 0; c < TotalGrades; c++)
            {
            Console.Write("Please enter exam score {0} for student {1}: ", c + 1, r + 1);
                scoresArray[r, c] = Convert.ToInt32(Console.ReadLine());
            }
        for (int r = 0; r < scoresArray.GetLength(0); r++)
        {
            int studentSum = 0;
            int testCount = 0;
            for (int c = 0; c < scoresArray.GetLength(1); c++)
            {
                studentSum += scoresArray[r, c];
                testCount++;
            }
            string gradeLetter = "";
            double average = studentSum / testCount;
            Console.WriteLine("\nStudent " + (r + 1).ToString() + " Average Score: " + average.ToString());

            if (average >= 90)
            {
                gradeLetter = "A";
            }
            else if (average >= 80 && average < 90)
            {
                gradeLetter = "B";
            }
            else if (average >= 70 && average < 80)
            {
                gradeLetter = "C";
            }
            else if (average >= 60 && average < 70)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            Console.WriteLine("Student " + (r + 1).ToString() + " will recieve a(n) " + gradeLetter + " in the class.\n");
        }
        Console.Write("\nPress the [ENTER] key to exit.");
        Console.ReadLine();
    }
            }
        }
    }
