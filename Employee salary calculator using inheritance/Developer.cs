public class Developer:employee
{
    bool TaskFinished = false;

    public Developer(int id, string name, int loggedHours, int wage, bool taskFinished) : base(id, name, loggedHours, wage)
    {
        TaskFinished = taskFinished;
    }
    public double GetBonus()
    {
        return TaskFinished ? (0.03 * base.CalculateTotalSalary()) : 0;
    }
    public override double CalculateTotalSalary()
    {
        return base.CalculateTotalSalary()+ GetBonus();
    }
    public override string ToString()
    {
        return base.ToString() + $"Task Completed :{(bool)TaskFinished}\nBonus: ${GetBonus()}\nNet Salary: ${CalculateTotalSalary()}";
    }
}