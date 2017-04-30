using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labb1ConsoleApp.Helpers
{
    public class HelperClass
    {

        public string GetInputFromUser()
        {
            return Console.ReadLine();
        }

        public string CheckUserInputNotEmpty(string userInput)
        {
            if (userInput != string.Empty)

                return userInput;
            UserInputEmptyMsg();
            return userInput;
        }

        public void UserInputEmptyMsg()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This list don't contain any names");
            Console.ResetColor();
        }
        public string[] CreateArrayOfPeople(string response)
        {
            string[] createArrayOfPeople = response.Split(',').Select(responseValue => responseValue.Trim()).ToArray();
            return createArrayOfPeople;
        }

        public void RespondToUserOutOfRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A person can only have between 2 and 9 letters");
            Console.ResetColor();
        }
        public void RespondToUser(string[] peopleArray)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string people in peopleArray)
            {
                if (people.Length < 2 || people.Length > 9)
                {
                    RespondToUserOutOfRange();
                }
                else
                {
                    Console.WriteLine($"***SUPER-{people.ToUpper()}***");
                }
            }
            Console.ResetColor();
        }
    }
}

