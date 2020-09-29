using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emlpoyee wage computation program");
            int dailyWage = 0; 
            int totalPartTimeWage = 0;
            int workingDays = 20;
            int workingHours = 0;
            bool flag = false;
            for (int i = 1; i <= workingDays; i++)
            {
                int present = Attendance();
                int dailyEmployeeWage = 0, partTimeWage = 0;
                switch (present)
                {
                    case 0:
                        break;
                    case 1:
                        workingHours += 8;
                        if (workingHours > 100)
                        {
                            flag = true;
                            break;
                        }
                        dailyEmployeeWage = DailyEmployeeWage();
                        int doPartTime = Attendance();
                        if (doPartTime == 1)
                        {
                            workingHours += 4;
                            if (workingHours > 100)
                            {
                                flag = true;
                                break;
                            }
                            partTimeWage = PartTimeWage();
                        }

                        break;
                    default:
                        break;
                }
                if (flag)
                    break;
                dailyWage += dailyEmployeeWage;
                totalPartTimeWage += partTimeWage;
            }
            Console.WriteLine("Total Daily Employee Wage : {0}", dailyWage);
            Console.WriteLine("Total Part Time Employee Wage : {0}", totalPartTimeWage);
            Console.WriteLine("Total Wage : {0}", dailyWage + totalPartTimeWage);
        }
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
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