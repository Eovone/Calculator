using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // A list to save the calculations
        List<string> calculationHistoryList = new List<string>() { };
        
        // Welcome message for user
        WelcomeMessage();

        // Loop that keeps running and allowing calculations as long as user doesn't choose to exit from StartView.
        while (true)
        {
            try
            {
                StartView:
                // Show StartView where you can see CalcHistory, Exit program or continue.
                StartView();
                var keyPressed = Console.ReadKey();
                // Exits program with Esc
                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    return;
                }

                // Print out the list of calculationhistory, will be empty at start, with H
                else if (keyPressed.Key == ConsoleKey.H)
                {
                    CalcHistoryCall();
                    goto StartView;
                }                    
                                
                // Show CalcView where you see instructions for the calculator
                CalcView();
                string userInput = Console.ReadLine();
                
                if (userInput.Contains("+"))
                {
                    // The + method
                    PlusMethod(userInput);
                }
                
                else if (userInput.Contains("-"))
                {
                    // The - method
                    MinusMethod(userInput);
                }
                
                else if (userInput.Contains("*"))
                {
                    // The * method
                    MultiMethod(userInput);
                }
                
                else if (userInput.Contains("/"))
                {
                    // The / method
                    DivMethod(userInput);
                }

                // Errormessage if userInput does not cointain + - * /.
                else
                {
                    ErrorMessage();                    
                }                

            }

            catch
            {
                ErrorMessage();                
            }

        }

        // Method for calculating and identifying 2 numbers with +
        string PlusMethod(string userInput)
        {
            // PLUS Seperate the userInput into two variables
            int operatorIndex = userInput.IndexOf("+");
            string numberOneTxt = userInput[..operatorIndex];
            string numberTwoTxt = userInput[(operatorIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneInt = int.Parse(numberOneTxt);
            int numberTwoInt = int.Parse(numberTwoTxt);

            // Calculation
            int calculationInt = numberOneInt + numberTwoInt;

            // Converting the result to a string and adding it to the list
            string calcTxt = Convert.ToString(calculationInt);
            string calcHistoryItem = $"{numberOneTxt}+{numberTwoTxt} = {calcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneInt}+{numberTwoInt} = {calculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

        // Method for calculating and identifying 2 numbers with -
        string MinusMethod(string userInput)
        {
            // MINUS Seperate the userInput into two variables and identify which operator is used
            int operatorIndex = userInput.IndexOf("-");
            string numberOneTxt = userInput[..operatorIndex];
            string numberTwoTxt = userInput[(operatorIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneInt = int.Parse(numberOneTxt);
            int numberTwoInt = int.Parse(numberTwoTxt);

            // Calculation
            int calculationInt = numberOneInt - numberTwoInt;

            // Converting the result to a string and adding it to the list
            string calcTxt = Convert.ToString(calculationInt);
            string calcHistoryItem = $"{numberOneTxt}-{numberTwoTxt} = {calcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneInt}-{numberTwoInt} = {calculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

        // Method for calculating and identifying 2 numbers with *
        string MultiMethod(string userInput)
        {
            // MULTIPLICATION Seperate the userInput into two variables and identify which operator is used
            int operatorIndex = userInput.IndexOf("*");
            string numberOneTxt = userInput[..operatorIndex];
            string numberTwoTxt = userInput[(operatorIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneInt = int.Parse(numberOneTxt);
            int numberTwoInt = int.Parse(numberTwoTxt);

            // Calculation
            int calculationInt = numberOneInt * numberTwoInt;

            // Converting the result to a string and adding it to the list
            string calcTxt = Convert.ToString(calculationInt);
            string calcHistoryItem = $"{numberOneTxt}*{numberTwoTxt} = {calcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneInt}*{numberTwoInt} = {calculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

        // Method for calculating and identifying 2 numbers with /
        string DivMethod(string userInput)
        {
            // DIVISION Seperate the userInput into two variables and identify which operator is used
            int operatorIndex = userInput.IndexOf("/");
            string numberOneTxt = userInput[..operatorIndex];
            string numberTwoTxt = userInput[(operatorIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneInt = int.Parse(numberOneTxt);
            int numberTwoInt = int.Parse(numberTwoTxt);

            // Errormessage when user tries to divide with 0.
            if (numberTwoInt == 0)
            {
                Console.WriteLine("\nYou can't divide with 0.");
                ErrorMessage();
                return userInput;
            }

            // Calculation
            double calculationDoub = (double)numberOneInt / numberTwoInt;

            // Converting the result to a string and adding it to the list
            string calcTxt = Convert.ToString(calculationDoub);
            string calcHistoryItem = $"{numberOneTxt}/{numberTwoTxt} = {calcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneInt}/{numberTwoInt} = {calculationDoub}");
            Console.ReadKey();

            return calcHistoryItem;
        }

        // Method for showing calcHistoryList
        void CalcHistoryCall()
        {
            Console.Clear();
            Console.WriteLine("*Calculation History*");
            Console.WriteLine("\nEnter - To continue.");
            Console.WriteLine("---------------------");

            foreach (string s in calculationHistoryList)
            {
                Thread.Sleep(500);
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

        // Method for showing StartView
        void StartView()
        {
            // Welcoming message and option to view calculation history(H), exit program(Esc) or continue. 
            Console.Clear();
            Console.WriteLine("*Start View*\n");
            Console.WriteLine("ESC - To Exit program.\nH - To view Calculation History.\nAny other key - To continue.");
        }

        // Method for showing StartView
        void CalcView()
        {
            // User inputs numbers and operator, only possible with 2 numbers and 1 operator.
            Console.Clear();
            Console.WriteLine("*Calculator*\n");
            Console.WriteLine("Write TWO numbers and the operator you want to calculate.\nExample: 341+85\t\t" + "Available operators: + - * /" + "\n\nEnter - to Calculate and Continue.\n");
        }

        // Method for showing ErrorMessage
        void ErrorMessage()
        {
            Console.WriteLine("\n*ERROR 404*\nSomething went wrong\nYou will be sent to *Start View*\n\nPress any button to continue.");
            Console.ReadKey();
        }

        // Method that is a welcomemessage for the user
        void WelcomeMessage()
        {
            string welcomeMessage = "Welcome to the Calculator!";

            for (int i = 0; i < welcomeMessage.Length; i++)
			    {
                    Thread.Sleep(75);
                    Console.Write(welcomeMessage[i]);
			    }

            Console.WriteLine("\n");

            string pressContinue = "Press Enter to continue.";

            for (int i = 0; i < pressContinue.Length; i++)
			    {
                    Thread.Sleep(75);
                    Console.Write(pressContinue[i]);
			    }

            Console.ReadLine();
        }
    }

}