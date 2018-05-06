using System;
namespace assignment1Q3 {

{
    class Program
    {

        static void Main(string[] args)

        {

            Console.WriteLine("Please type in your first name");

            var fn = Console.ReadLine();

            Console.WriteLine();



            Console.WriteLine("Please type in your last name");

            var ln = Console.ReadLine();

            Console.WriteLine();



            Console.WriteLine("What is your date of birth? (format: dd/mm/yyyy");

            var dob = Console.ReadLine();

            var date = DateTime.Parse(dob);

            Console.WriteLine();

            

            var p3 = new Student(fn, ln, date);

            p3.EnrollStudent();

            Console.WriteLine();

            Console.WriteLine(p3.PersonInfo());

            Console.ReadKey();

        }

    }

}