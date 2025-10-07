// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter your first number then press enter");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

int result = FirstNumber + SecondNumber;
Console.WriteLine("Your total is {0}", result);
