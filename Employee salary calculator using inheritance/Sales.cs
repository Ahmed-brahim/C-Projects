public class Sales : employee
{
    double Commission;
    double SalesVolume;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="commission">commission in percentage</param>
    public Sales(int id, string name, int loggedHours, int wage, double commission, double Salesvolume) : base(id, name, loggedHours, wage)
    {
        Commission = commission / 100;
        if (Commission < 0) Commission = 0;
        this.SalesVolume = Salesvolume;
    }
    public override double CalculateTotalSalary()
    {
        return base.CalculateTotalSalary() + (Commission * SalesVolume);
    }
    public override string ToString()
    {
        return base.ToString() + $"Sales: ${SalesVolume}\nCommission: {Commission}\nbonus: ${Commission * SalesVolume}\n Net Salary: ${CalculateTotalSalary()}";
    }
}
