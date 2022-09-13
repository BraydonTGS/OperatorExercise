// Calculator Program //

do
{
    double num1 = 0;
    double num2 = 0;
    double radius = 0;
    double area = 0;
    double answer = 0;

    Console.WriteLine("*******************");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("*******************");
    Console.WriteLine();
    Console.WriteLine("1: Standard Calculator");
    Console.WriteLine("2: Area of a Cirlce");
    string chooseProgram = Console.ReadLine();

    if (chooseProgram == "1")
    {
        Console.Write("Please Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Pick From the Following");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.WriteLine("\t% : Modulus");
        Console.Write("Enter an Operator ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "+":
                answer = num1 + num2;
                break;
            case "-":
                answer = num1 - num2;
                break;
            case "*":
                answer = num1 * num2;
                break;
            case "/":
                answer = Math.Round(num1 / num2, 2);
                break;
            case "%":
                answer = num1 % num2;
                break;
            default:
                Console.WriteLine("Please enter the right operator!!! ");
                break;

        }
        Console.WriteLine($"The result is {answer}");
        Console.Write("Would you like to continue(Y/N)? ");
    }
    else
    {
        Console.Write("Please Enter the Radius of a Circle: ");
        area = Convert.ToDouble(Console.ReadLine());
        area = Math.Round(AreaOfACirlce(area), 2);
        Console.WriteLine($"The Area of the Cirlce is {area}"); 

         static double AreaOfACirlce(double userInput)
        {
            userInput = Math.PI * Math.Pow(userInput, 2); 
            return userInput; 
        }

    }
    Console.Write("Would you like to continue(Y/N)? ");

}       while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Thank You!!!");
        Console.ReadLine();




