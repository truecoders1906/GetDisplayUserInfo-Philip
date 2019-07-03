using System;
using System.Collections.Generic;
using System.Text;

namespace Questionaire
{
   public class Program
    {
        public static decimal GetDecimalAnswerFromUser(string question) //this method will be called a bunch below
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            decimal answer = decimal.Parse(response);
            return answer;
        }
        public static void Main(string[] args)
        {
            Questionaire display = new Questionaire(); //constructor

            Console.WriteLine("Check, check...");
            Console.WriteLine("<<Display capabilities = Active>>");

            Console.WriteLine("What is your first name?");
            display.FirstName = Console.ReadLine();
            Console.WriteLine("Your name is " + display.FirstName);

            Console.WriteLine("What is your last name?");
            display.LastName = Console.ReadLine();
            Console.WriteLine("Your last name is " + display.LastName);

            
            display.FavoriteNumber = GetDecimalAnswerFromUser("What is your favorite number?");
            Console.WriteLine("Your favorite number is " + display.FavoriteNumber);

            //Console.WriteLine("How many pets do you own, love, and cherish?"); dont state question here because its stated in above method
            display.NumberOfPets = GetDecimalAnswerFromUser("How many pets do you own, love, and cherish?");
            Console.WriteLine("You own " + display.NumberOfPets + " pets.");

           
                Console.WriteLine("What are the names of your pets?");
                display.NameOfPets = Console.ReadLine();
                Console.WriteLine("Your pet(s): " + display.NameOfPets+ ".");

            //display.NameOfPets.Add (Console.ReadLine()); //this needs to be a list because the number of pets can vary. try foreach petName in NameOfPEts

            //Console.Write("Your pets are" + display.NameOfPets(Console.ReadLine()) + "."); ;
        }       } }