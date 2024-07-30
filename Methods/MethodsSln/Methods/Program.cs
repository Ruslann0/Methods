namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        int sumAdd = Add(5, 6);
        Console.WriteLine("Add: " + sumAdd);

        int sumSubstraction = Subtraction(7 , 4);
        Console.WriteLine("Subtraction: " + sumSubstraction);

        int sumMultiplication = Multiplication(4 , 5);
        Console.WriteLine("Multiplication: " + sumMultiplication);

        int sumDivision = Division(9, 3);
        Console.WriteLine("Division: " + sumDivision);

        DateTime dateTime = DateTime.Now;
        DateTime newDateTimeValue = dateTime.AddDays(3);
        Console.WriteLine(newDateTimeValue);


    }
    static int Add(int number1, int number2)
    {
       int result = number1 + number2 ;
        return result;
    }
    static int Subtraction(int number1, int number2)
    {
        int result = number1 - number2;
        return result;
    }
    static int Multiplication(int number1, int number2)
    {
        int result = number1 * number2;
        return result;
    }
    static int Division(int number1, int number2)
    {
        int result = number1 / number2;
        return result;
    }
}

