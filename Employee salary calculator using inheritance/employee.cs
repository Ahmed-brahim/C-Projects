public class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int LoggedHours;
    public double BasicSalary;
    public int OverTime;
    public int Wage;

    public employee(int id, string name, int loggedHours, int wage)
    {
        Id = id;
        Name = name;
        LoggedHours = loggedHours;
        if (loggedHours < 176)
            loggedHours = 176;
        Wage = wage;
    }
    public double GetBasicSalary()
    {
        return Wage * 176;
    }
    public double GetOverTime()
    { 
        return (LoggedHours - 176) * Wage * 1.25;
    }
    public virtual double CalculateTotalSalary()
    {
        return (GetBasicSalary() + GetOverTime());
    }
    public override string ToString()
    {
        return $"{this.GetType().Name}\n----------\nid: {Id}\nname: {Name}\nlogged hours: {LoggedHours}HRS\nwage: ${Wage}/HR\nbasic salary: {GetBasicSalary()}\nover time: ${GetOverTime()}\n";
    }
}

