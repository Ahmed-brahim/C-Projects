using System.Runtime.InteropServices;

namespace Employee_salary_calculator_using_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager(1, "Ahmed Ibrahim", 176, 10);
            Maintenance ma1 = new Maintenance(2, "Salim", 185, 9);
            Sales s1 = new Sales(3, "reem", 176, 8, 5, 10000);
            Developer d1 = new Developer(4, "Mariem", 180, 14, true);
            employee[] employees = { m1, ma1, s1, d1 };
            foreach (var e in employees)
            {
                Console.WriteLine("------------------------------------------------\n");
                Console.WriteLine(e);
            }
        }
    }
}
