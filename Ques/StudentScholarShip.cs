public delegate bool IsELigibleForScholarShip(Student std);

public class Student
{
    public int RollNo{get;set;}
    public string? Name{get;set;}
    public int Marks{get;set;}
    public char SPortsGrade{get;set;}

    public static string GetEligibleStudents(List<Student> studentsList,IsELigibleForScholarShip isELigible)
    {
        List<string> eligible=new List<string>();
        foreach(var std in studentsList)
        {
            if (isELigible(std))
            {
                eligible.Add(std.Name);
            }
        }
        return string.Join(", ",eligible);
        
    }
}

public class Program1
{
    public static bool ScholarShipEligibility(Student std)
    {
        bool marksCondition=std.Marks>80;
        bool gradeConndition=std.SPortsGrade=='A';
        return marksCondition&&gradeConndition;
    }
}