using System;

enum MonthName
{
    January, February, March, April, May, June, July, August, September, October, November, December
}

class WhatDay
{
    public static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    public static System.Collections.ICollection DaysInLeapMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter a year");
            string line = Console.ReadLine();
            int yearNum = int.Parse(line);
            int monthNum = 0;
            bool isLeapYaer = !Convert.ToBoolean(yearNum % 4);
            int maxDayNum = isLeapYaer ? 366 : 365;

            Console.WriteLine("Please enter a day number between 1 and {0}:", maxDayNum);
            line = Console.ReadLine();
            int dayNum = int.Parse(line);

            if (dayNum < 1 || dayNum > maxDayNum)
            {
                throw new IndexOutOfRangeException("Day out of range");
            }

            foreach (int daysInMonth in (isLeapYaer ? DaysInLeapMonths : DaysInMonths))
            {
                if (dayNum <= daysInMonth) { break; }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }

            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();


            /*
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 28) { goto End; } else { dayNum -= 28; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 30) { goto End; } else { dayNum -= 30; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 30) { goto End; } else { dayNum -= 30; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 30) { goto End; } else { dayNum -= 30; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 30; monthNum++; }
            if (dayNum <= 31) { goto End; } else { dayNum -= 31; monthNum++; }
        End:

            string monthName;
            switch (monthNum)
            {
                case 0: monthName = "January"; break;
                case 1: monthName = "February"; break;
                case 2: monthName = "March"; break;
                case 3: monthName = "April"; break;
                case 4: monthName = "May"; break;
                case 5: monthName = "June"; break;
                case 6: monthName = "July"; break;
                case 7: monthName = "August"; break;
                case 8: monthName = "September"; break;
                case 9: monthName = "October"; break;
                case 10: monthName = "November"; break;
                case 11: monthName = "December"; break;
                default: monthName = "not done yet"; break;
            }
            */
            
            Console.WriteLine("{0},{1}", dayNum, monthName);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        Console.ReadKey();
    }
}

