internal class Program
{
    private static void Main(string[] args)
    {
        // A list to save the calculations
        List<string> calculationHistoryList = new List<string>() { };

        while (true)
        {
            try
            {
                // Welcoming message and option to view calculation history(H), exit program(Esc) or continue. 
                Console.Clear();
                Console.WriteLine("Welcome to the Calculator!\n\n*Start View*\n\n");
                Console.WriteLine("ESC - To Exit program.\nH - To view Calculation History.\nEnter - To continue.");
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
                }

                // User inputs numbers and operator, only possible with 2 numbers and 1 operator.
                Console.Clear();
                Console.WriteLine("*Calculator*\n");
                Console.WriteLine("Write TWO numbers and the operator you want to calculate.\nExample: 341+85\t\t" + "Available operators: + - * /" + "\n\nEnter - to Calculate and Continue.\n");
                string userInput = Console.ReadLine();


                // Identify which operator is used, this one if " + " is used.
                if (userInput.Contains("+"))
                {
                    PlusMethod(userInput);
                }

                // Identify which operator is used, this one if " - " is used.
                else if (userInput.Contains("-"))
                {
                    MinusMethod(userInput);
                }

                // Identify which operator is used, this one if " * " is used.
                else if (userInput.Contains("*"))
                {
                    MultiMethod(userInput);
                }

                // Identify which operator is used, this one if " / " is used.
                else if (userInput.Contains("/"))
                {
                    DivMethod(userInput);
                }

                // Errormessage if userInput does not cointain + - * /.
                else
                {
                    Console.WriteLine("\n*ERROR 404*\nSomething went horribly wrong, try again!\nPress any button to continue.");
                    Console.ReadKey();
                }                

            }

            catch
            {
                Console.WriteLine("\n*ERROR 404*\nSomething went horribly wrong, try again!\nPress any button to continue.");
                Console.ReadKey();
            }

        }

    // Method for calculating 2 numbers with +
    string PlusMethod(string userInput)
        {
            // PLUS Seperate the userInput into two variables
            int operatorPlusIndex = userInput.IndexOf("+");

            // numberOneTxt is the number before the operator
            string numberOnePlusTxt = userInput[..operatorPlusIndex];
            // numberTwoTxt is the number after the operator
            string numberTwoPlusTxt = userInput[(operatorPlusIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOnePlusInt = int.Parse(numberOnePlusTxt);
            int numberTwoPlusInt = int.Parse(numberTwoPlusTxt);

            // Calculation
            int plusCalculationInt = numberOnePlusInt + numberTwoPlusInt;

            // Converting the result to a string and adding it to the list
            string plusCalcTxt = Convert.ToString(plusCalculationInt);
            string calcHistoryItem = $"{numberOnePlusTxt}+{numberTwoPlusTxt} = {plusCalcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOnePlusInt}+{numberTwoPlusInt} = {plusCalculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

    // Method for calculating 2 numbers with -
    string MinusMethod(string userInput)
        {
            // MINUS Seperate the userInput into two variables and identify which operator is used
            int operatorMinusIndex = userInput.IndexOf("-");

            // numberOneTxt is the number before the operator
            string numberOneMinusTxt = userInput[..operatorMinusIndex];
            // numberTwoTxt is the number after the operator
            string numberTwoMinusTxt = userInput[(operatorMinusIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneMinusInt = int.Parse(numberOneMinusTxt);
            int numberTwoMinusInt = int.Parse(numberTwoMinusTxt);

            // Calculation
            int minusCalculationInt = numberOneMinusInt - numberTwoMinusInt;

            // Converting the result to a string and adding it to the list
            string minusCalcTxt = Convert.ToString(minusCalculationInt);
            string calcHistoryItem = $"{numberOneMinusTxt}-{numberTwoMinusTxt} = {minusCalcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneMinusInt}-{numberTwoMinusInt} = {minusCalculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

    // Method for calculating 2 numbers with *
    string MultiMethod(string userInput)
        {
            // MULTIPLICATION Seperate the userInput into two variables and identify which operator is used
            int operatorMultiIndex = userInput.IndexOf("*");

            // numberOneTxt is the number before the operator
            string numberOneMultiTxt = userInput[..operatorMultiIndex];
            // numberTwoTxt is the number after the operator
            string numberTwoMultiTxt = userInput[(operatorMultiIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneMultiInt = int.Parse(numberOneMultiTxt);
            int numberTwoMultiInt = int.Parse(numberTwoMultiTxt);

            // Calculation
            int multiCalculationInt = numberOneMultiInt * numberTwoMultiInt;

            // Converting the result to a string and adding it to the list
            string multiCalcTxt = Convert.ToString(multiCalculationInt);
            string calcHistoryItem = $"{numberOneMultiTxt}*{numberTwoMultiTxt} = {multiCalcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneMultiInt}*{numberTwoMultiInt} = {multiCalculationInt}");
            Console.ReadKey();

            return calcHistoryItem;
        }

    // Method for calculating 2 numbers with /
    string DivMethod(string userInput)
        {
            // DIVISION Seperate the userInput into two variables and identify which operator is used
            int operatorDivIndex = userInput.IndexOf("/");

            // numberOneTxt is the number before the operator
            string numberOneDivTxt = userInput[..operatorDivIndex];
            // numberTwoTxt is the number after the operator
            string numberTwoDivTxt = userInput[(operatorDivIndex + 1)..];

            // Converting strings of numbers into int so it can be calculated with
            int numberOneDivInt = int.Parse(numberOneDivTxt);
            int numberTwoDivInt = int.Parse(numberTwoDivTxt);

            // Errormessage when user tries to divide with 0.
            if (numberTwoDivInt == 0)
            {
                Console.WriteLine("You can't divide with 0.\nPress any key to continue.");
                Console.ReadKey();
                return userInput;
            }

            // Calculation
            double divCalculationDoub = (double)numberOneDivInt / numberTwoDivInt;

            // Converting the result to a string and adding it to the list
            string divCalcTxt = Convert.ToString(divCalculationDoub);
            string calcHistoryItem = $"{numberOneDivTxt}/{numberTwoDivTxt} = {divCalcTxt}";
            calculationHistoryList.Add(new string(calcHistoryItem));

            // Printing out the calculation and result
            Console.WriteLine($"{numberOneDivInt}/{numberTwoDivInt} = {divCalculationDoub}");
            Console.ReadKey();

            return calcHistoryItem;
        }

    // Method for showing calcHistoryList
    void CalcHistoryCall()
        {
            Console.Clear();
            Console.WriteLine("*Calculation History*");
            Console.WriteLine("Enter - To continue.");
            Console.WriteLine("---------------------");

            foreach (string s in calculationHistoryList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
    
}



// Pseudokod för uppgiften

// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
//OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
//Visa resultat
//Fråga användaren om den vill visa tidigare resultat.
//Visa tidigare resultat
//Fråga användaren om den vill avsluta eller fortsätta.