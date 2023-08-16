
public class MathManager
{
    public static void Main(string[] args)
    {
        System.Console.Write("JD Calculator says --- ");
        MathManager jdCalculator = new MathManager();
        jdCalculator.AddTwoNumbers();
        jdCalculator.Add10ToNumber(5);
        jdCalculator.Add10ToNumber(15);
        jdCalculator.Add10ToNumber(45);

        jdCalculator.AddTwoDigits(3, 9); //12
        jdCalculator.AddTwoDigits(342, 2534);


        System.Console.Write("RR Calculator says --- ");
        MathManager rrCalculator = new MathManager();
        int returnedSum = rrCalculator.AddTwoDigitsAndReturnTheSum(100,100);
        System.Console.Write(" Returned Sum is :");
        System.Console.WriteLine(returnedSum);
    }

    public void AddTwoNumbers()
    {
        int num01 = 10;
        int num02 = 20;
        AddTwoDigits(num01, num02);
        // int sum = num01 + num02;
        // System.Console.Write("The Sum is ");
        // System.Console.WriteLine(sum);
    }

    public void Add10ToNumber(int num01)
    {
        int num02 = 10;
        int sum = num01 + num02;
        System.Console.Write("The Sum of digits is ");
        System.Console.WriteLine(sum);
    }

    public void AddTwoDigits(int num01, int num02)
    {
        int sum = num01 + num02;
        System.Console.Write("The Sum of digits is ");
        System.Console.WriteLine(sum);
    }
    public int AddTwoDigitsAndReturnTheSum(int num01, int num02)
    {
        int sum = num01 + num02;
        return sum;
    }
}