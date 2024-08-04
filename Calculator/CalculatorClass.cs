public class CalculatorClass
{
    private long num1;
    private long num2;
    private long result;
    private int operation;
    private char op;

    public void calculate()
    {
        Console.Write("Enter First Num: ");
        num1 = long.Parse(Console.ReadLine());
        Console.Write("Enter Second Num: ");
        num2 = long.Parse(Console.ReadLine());
        Console.WriteLine("Select Operation:\n1. Add\n2. Sub\n3. Multiply\n4. Division");
        operation = int.Parse(Console.ReadLine());
        if (operation == 1)
        {
            result = num1 + num2;
            op = '+';
        }
        else if (operation == 2)
        {
            result = num1 - num2;
            op = '-';
        }
        else if (operation == 3)
        {
            result = num1 * num2;
            op = '*';
        }
        else if (operation == 4)
        {
            try 
            {
                result = num1 / num2;
                op = '/';
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cant divide by zero");
                return;
            }
        }
        else
        {
            Console.WriteLine("wrong choice");
            return;
        }
        Console.WriteLine($"{num1}{op}{num2} = {result}");
    }
}
