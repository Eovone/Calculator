// A list to save the calculations
List<string> calculationHistoryList = new List<string>() { };

startOfLoop:
while (true)
{
    try
    {
    // Welcoming message and option to view calculation history(H), exit program(Esc) or continue. 
    Console.Clear();
    Console.WriteLine("Welcome to the Calculator!\n\n");
    Console.WriteLine("If you want to Exit program, press Escape.\nTo view your Calculation History press H.\nTo continue press Enter.");
    var keyPressed = Console.ReadKey();

    // Exits program with Esc
    if (keyPressed.Key == ConsoleKey.Escape)
    {
        return;
    }

    // Print out the list of calculationhistory, will be empty at start, with H
    else if (keyPressed.Key == ConsoleKey.H)
    {
            Console.Clear();
            Console.WriteLine("Calculation History:");
            Console.WriteLine("--------------------");

            foreach (string s in calculationHistoryList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
    }

    // User inputs numbers and operator, only possible with 2 numbers and 1 operator.
    Console.Clear();
    Console.WriteLine("Write TWO numbers and the operator you want to calculate.\nExample: 341+85\t\t" + "Available operators: + - * /" + "\n\nPress Enter to Calculate and Continue.\n");
    string userInput = Console.ReadLine();


    // Identify which operator is used, this one if " + " is used.
    if (userInput.Contains("+"))
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

    }

    // Identify which operator is used, this one if " - " is used.
    else if (userInput.Contains("-"))
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
    }

    // Identify which operator is used, this one if " * " is used.
    else if (userInput.Contains("*"))
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
    }

    // Identify which operator is used, this one if " / " is used.
    else if (userInput.Contains("/"))
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

            // Errormessage when user tries to dived 0 with 0. goto startOfLoop if this happens.
            if (numberOneDivInt == 0 && numberTwoDivInt == 0)
            {
                Console.WriteLine("You can't divide 0 / 0.\nPress any key to continue.");
                Console.ReadKey();
                goto startOfLoop;
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
    }
}
    // Errormessage if the input is not correct
    catch (Exception)
    {
        Console.WriteLine("\n*ERROR 404*\nSomething went horribly wrong, try again!\nPress any button to continue.");
        Console.ReadKey();
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