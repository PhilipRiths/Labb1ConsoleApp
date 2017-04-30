﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Labb1ConsoleApp.Helpers;

namespace Labb1ConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var program = new Program();
            program.Menu();
            Console.ReadKey();
        }

        public void Menu()
        {
            HelperClass helperclass = new HelperClass();
            Console.WriteLine("Enter names seperated by comma (e.g Maria, Peter, Lisa): ");
            var userResponse = helperclass.GetInputFromUser();
            var checkUserInputNotEmpty = helperclass.CheckUserInputNotEmpty(userResponse);
            var userNames = helperclass.CreateArrayOfPeople(checkUserInputNotEmpty);
            helperclass.RespondToUser(userNames);
        }

    }
}
