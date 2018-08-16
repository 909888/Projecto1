using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hourlyRatep1
            //int hoursWorkedp1
            //int hourlyRatep2
            //int hoursWorkedp2


            //Console.WriteLine("Anonymous Income Comparison Program");
            //Console.ReadLine();


            //Console.WriteLine("Person 1, ");
            //Console.ReadLine();

            //Console.WriteLine("What is your hourly rate? ");
            //string hourlyRatep1 = Console.ReadLine();
            //Console.ReadLine();

            //Console.WriteLine("How many hours do you work a week? ");
            //string hoursWorkedp1 = Console.ReadLine();
            //Console.ReadLine();


            //Console.WriteLine("Person 2, ");
            //Console.ReadLine();

            //Console.WriteLine("What is your hourly rate? ");
            //string hourlyRatep2 = Console.ReadLine();
            //Console.ReadLine();

            //Console.WriteLine("How many hours do you work a week? ");
            //string hoursWorkedp2 = Console.ReadLine();
            //Console.ReadLine();

            //Console.Write("Annual Salary of Person 1: ");

            int hourlyRatep1;
            int hoursWorkedp1;
            int hourlyRatep2;
            int hoursWorkedp2;

            int rateTimesworked1;
            int rateTimesworked2;

            int annualSalary1;
            int annualSalary2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();


            Console.WriteLine("Person 1, ");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate? ");
            hourlyRatep1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("How many hours do you work a week? ");
            hoursWorkedp1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Person 2, ");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate? ");
            hourlyRatep2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many hours do you work a week? ");
            hoursWorkedp2 = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Annual Salary of Person 1: ");
            //rateTimesworked1 = hourlyRatep1 * hoursWorkedp1;
            //Console.Write("Annual Salary of Person 1: {0} ", rateTimesworked1);
            //Console.ReadLine();

            rateTimesworked1 = hourlyRatep1 * hoursWorkedp1;
            annualSalary1 = rateTimesworked1 * 56;
            Console.WriteLine("Annual Salary of Person 1: {0} ", annualSalary1);
            Console.ReadLine();

            rateTimesworked2 = hourlyRatep2 * hoursWorkedp2;
            annualSalary2 = rateTimesworked2 * 56;
            Console.WriteLine("Annual Salary of Person 2: {0} ", annualSalary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");

            if (annualSalary1 > annualSalary2)
                {
                Console.WriteLine("True");
            } 
            else if (annualSalary1 <= annualSalary2)
                    {
                Console.WriteLine("False");
            
            }
            Console.ReadLine();


            Console.WriteLine("Goodbye");
            Console.ReadLine();










        }
    }
}
