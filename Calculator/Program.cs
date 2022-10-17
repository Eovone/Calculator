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

    // Method for calculating 2 numbers with -
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

    // Method for calculating 2 numbers with *
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

    // Method for calculating 2 numbers with /
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
                Console.WriteLine("You can't divide with 0.\nPress any key to continue.");
                Console.ReadKey();
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