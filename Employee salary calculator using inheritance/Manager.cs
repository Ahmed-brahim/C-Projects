public class Manager : employee
{
    public int allowancce;
    public Manager(int id, string name, int loggedHours, int wage):base(id,name,loggedHours,wage) 
    {
    }
    private double getAllowance()
    {
        return (GetBasicSalary() + GetOverTime()) * 0.05;
    }
    public override double CalculateTotalSalary()
    {
        return base.CalculateTotalSalary() + getAllowance();
    }
    public override string ToString()
    {
        return base.ToString() +$"Allowance: ${getAllowance()}\nnet salary: ${CalculateTotalSalary()}";
    }
}

