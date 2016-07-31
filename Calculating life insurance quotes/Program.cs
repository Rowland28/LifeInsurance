using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace Calculating_life_insurance_quotes
{
        class Program
    {

        static void Main(string[] args)
        {
            double Total = 0;
            string Gender;

            Console.WriteLine("Please enter your gender: (Male or Female)");
            Gender = Console.ReadLine();
            Gender = Gender.ToLower();

            Console.WriteLine("Gender: " + Gender);
                                       

            //Console.ReadLine();

            int Age;
            Console.WriteLine("Please enter how old you are");

            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("age: " + Age);

            //Console.ReadLine();

            if ((Gender == "male") && Age <= 18) Console.WriteLine(Total = 150);

            else

            if ((Gender == "male") && Age >= 19 && Age <= 24) Console.WriteLine(Total = 180);

            else

            if ((Gender == "male") && Age >= 25 && Age <= 35) Console.WriteLine(Total = 200);

            else

            if ((Gender == "male") && Age >= 35 && Age <= 45) Console.WriteLine(Total = 250);

            else

            if ((Gender == "male") && Age >= 45 && Age <= 59) Console.WriteLine(Total = 320);

            else

            if ((Gender == "male") && Age >= 60) Console.WriteLine(Total = 500);

            else

            if ((Gender == "female") && Age <= 18) Console.WriteLine(Total = 100);

            else

            if ((Gender == "female") && Age >= 19 && Age <= 24) Console.WriteLine(Total = 165);

            else

            if ((Gender == "female") && Age >= 25 && Age <= 34) Console.WriteLine(Total = 180);

            else

            if ((Gender == "female") && Age >= 35 && Age <= 44) Console.WriteLine(Total = 225);

            else

            if ((Gender == "female") && Age >= 45 && Age <= 59) Console.WriteLine(Total = 315);

            else

            if ((Gender == "female") && Age >= 60) Console.WriteLine(Total = 485);

            else
                Console.WriteLine("Error encounted, please restart");

            //Console.ReadLine();

            string Country;

            Console.WriteLine("Please enter your Country:");
            Country = Console.ReadLine();

            Country = Country.ToLower();

            if (Country == "england") Console.WriteLine(Total);

            else

             if (Country == "scotland") Console.WriteLine(Total = Total + 200);

            else

            if (Country == "wales") Console.WriteLine(Total = Total - 100);

            else

            if (Country == "ireland") Console.WriteLine(Total = Total + 50);

            else

            if (Country == "northern ireland") Console.WriteLine(Total = Total + 75);

            else
                Console.WriteLine(Total = Total + 100);

            //Console.ReadLine();

            String Child;

            Console.WriteLine("Do you have children? yes or no");
            Child = Console.ReadLine();

            Child = Child.ToLower();

            if (Child == "yes") Console.WriteLine(Total = Total * 1.5);

            else

             if (Child == "no") Console.WriteLine(Total);

            else
                Console.WriteLine("Please restart application, apologies for any errors");

            //Console.ReadLine();

            String Smoker;

            Console.WriteLine("Are you a smoker? yes or no");
            Smoker = Console.ReadLine();

            Smoker = Smoker.ToLower();

            if (Smoker == "yes") Console.WriteLine(Total = Total * (3));

            else

             if (Smoker == "no") Console.WriteLine("good job");

            else
                Console.WriteLine("Please restart application, apologies for any errors");

            //Console.ReadLine();

            int Exercise;

            Console.WriteLine("How many hours of exercise do you do per week?");
            Exercise = int.Parse(Console.ReadLine());

            if (Exercise == 0) Console.WriteLine(Total = Total * (1.2));

            else

            if (Exercise >= 1 && Exercise <= 2) Console.WriteLine(Total);

            else

            if (Exercise >= 3 && Exercise <= 5) Console.WriteLine(Total = Total * (0.7));

            else

            if (Exercise >= 6 && Exercise <= 8) Console.WriteLine(Total = Total * (0.5));

            else

            if (Exercise >= 9) Console.WriteLine(Total = Total * (1.5));

            else
                Console.WriteLine("Please restart application, apologies for any errors");

            //Console.ReadLine();

            if (Total <= 50) Console.WriteLine(Total = 50);

            else
            Console.WriteLine(Total);
            Console.ReadLine();
        }

    }


    }


