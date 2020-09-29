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
            int partTimeWage = 0;
            switch (present)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present");
                    dailyEmployeeWage = DailyEmployeeWage();
                    int partTime = Attendance();
                    if (partTime == 1)
                        partTimeWage = PartTimeWage();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Daily Employee Wage : {0}", dailyEmployeeWage);
            Console.WriteLine("Part Time Employee Wage : {0}", partTimeWage);
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
        static int PartTimeWage()
        {
            int partTimeHour = 4;
            int perHourWage = 20;
            return partTimeHour * perHourWage;
        }
    }
}