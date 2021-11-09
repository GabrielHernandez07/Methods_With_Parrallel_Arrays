using System;
using System.Collections.Generic;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] studentsName = new string[5];
                studentsName[0] = "Jimmy John";
                studentsName[1] = "Kyle Walker";
                studentsName[2] = "Gabriel Jesus";
                studentsName[3] = "Phil Foden";
                studentsName[4] = "Kevin Debruyne";

                int[] studentsID = new int[5];
                studentsID[0] = 12345;
                studentsID[1] = 54321;
                studentsID[2] = 45678;
                studentsID[3] = 56789;
                studentsID[4] = 00001;

                List<List<double>> grades = new List<List<double>>();
                grades.Add(new List<double>());
                grades.Add(new List<double>());
                grades.Add(new List<double>());
                grades.Add(new List<double>());
                grades.Add(new List<double>());

                grades[0].Add(75.5);
                grades[0].Add(70);
                grades[0].Add(72);

                grades[1].Add(80);
                grades[1].Add(83);
                grades[1].Add(86);

                grades[2].Add(90);
                grades[2].Add(95);
                grades[2].Add(99);

                grades[3].Add(60);
                grades[3].Add(66);
                grades[3].Add(70);

                grades[4].Add(90);
                grades[4].Add(80);
                grades[4].Add(60);

            for (int i = 0; i < grades.Count; i++)
            {
                StudentInformation(studentsName[i], studentsID[i], grades[i]);
            }
        }
        static void StudentInformation(string studentsName, int studentsID, List<double> grades)
        {
            double sum = 0;
             foreach (var grade in grades)
            {
                sum += grade;
            }
            double average = sum / grades.Count;
            Console.WriteLine($"{studentsName}, student ID: {studentsID}, has an average of {average.ToString("N2")}.");

        }
    }
}
