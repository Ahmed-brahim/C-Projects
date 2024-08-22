public class Maintenance : employee
{
    int HardShip = 100;
    public Maintenance(int id, string name, int loggedhours, int wage) : base(id, name, loggedhours, wage)
    { }
    public override double CalculateTotalSalary()
    {
        return base.CalculateTotalSalary() + HardShip;
    }
    public override string ToString()
    {
        return base.ToString() + $"Hardship: ${HardShip}\nNet Salary: ${CalculateTotalSalary()}";
    }
}
