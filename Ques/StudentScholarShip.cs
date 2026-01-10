public delegate bool IsELigibleForScholarShip(Student std);

public class Student
{
    public int RollNo{get;set;}
    public string? Name{get;set;}
    public int Marks{get;set;}
    public char SPortsGrade{get;set;}

    public static string GetEligibleStudents(List<Student> studentsList,IsELigibleForScholarShip isELigible)
    {
        
    }
}

public class Program1
{
    public static bool ScholarShipEligibility(Student std)
    {
        
    }
}