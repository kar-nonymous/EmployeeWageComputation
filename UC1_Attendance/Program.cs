﻿using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage compuation program");
            int isPresent = Attendance();
            if (isPresent == 0)
                Console.WriteLine("Employee is Absent!");
            else
                Console.WriteLine("Employee is Present!");
        }

        static int Attendance()
        {
            Random random= new Random();
            return random.Next(0, 2);
        }
    }
}