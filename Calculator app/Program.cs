using System.Xml.Serialization;

CalculatorApp();
void CalculatorApp()
{

    // declaring variables

    int FirstNumber = 0;
    int SecondNumber = 0;
    int result = 0;
    int choice = 0;



    // This is where we get user input
    Console.WriteLine("enter your first number then press enter");

    FirstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter your second number");

    SecondNumber = Convert.ToInt32(Console.ReadLine());
    // apart of the user input





    // this is where we will use the loops so the user can pick a maths operation to use

    Console.WriteLine("Choose an option fromthe following list: ");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)

    { 
    result = FirstNumber + SecondNumber;
    Console.WriteLine($"adding {FirstNumber} and {SecondNumber} gives you {result}");
    }

    else if (choice == 2)
    {
        result = FirstNumber - SecondNumber;
        Console.WriteLine($"Subtracting {FirstNumber} and {SecondNumber} gives you {result}");
    }

    else if (choice == 3)
    {
        result = FirstNumber / SecondNumber;
        Console.WriteLine($"Dividing {FirstNumber} and {SecondNumber} gives you {result}");
    }

    else if (choice == 4)
    {
        result = FirstNumber * SecondNumber;
        Console.WriteLine($"Multiplying {FirstNumber} and {SecondNumber} gives you {result}");
    }

    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }



}


