public enum Department
{
    IT,
    HR,
    Finance
}

public class Employe
{
    public string? Name{get;set;}
    public Department  department{get;set;}
    public double BaseSalary{get;set;}

}

class EmployeSalaryService
{
    public readonly IDictionary<Department,double> _bonusRates;

    public EmployeSalaryService(IDictionary<Department, double> bonusRates)
    {
        this._bonusRates=bonusRates;
    }

    public void SetBonusRate(Department dept,double rate)
    {
        // if(dept.)
    }
}