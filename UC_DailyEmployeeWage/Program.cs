using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage compuation program");
            int present = Attendance();
            int dailyEmployeeWage = 0;
            if (present == 0)
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is Present");
            if (present == 1)
            {
                dailyEmployeeWage = DailyEmployeeWage();
            }
        }

        static int Attendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        static int DailyEmployeeWage()
        {
            int fullDayHour = 8;
            int perHourWage = 20;
            return fullDayHour * perHourWage;
        }
    }
}