using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        public double GetMaximum(double firstNumber, double secondNumber)
        {
            return Math.Max(firstNumber, secondNumber);
        }

        public void Print()
        {
            PrintPerson("Mr. Harry Potter");
            PrintPerson("Ms. Mary Poppins");
            PrintPerson("Mr. Johnny Black");
        }

        private void PrintPerson(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        public static class StudentStatistics
        {
            public const int StudentCount = 48;
        }

        public class Shotgun1
        {
            public void DisplayStudents()
            {
                Console.WriteLine($"Student Count = {StudentStatistics.StudentCount}");
            }
        }

        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine($"Total Students : {StudentStatistics.StudentCount}");
            }
        }

        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
    }

    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string Format()
        {
            return $"{Day:00}/{Month:00}/{Year:0000}";
        }
    }
}
