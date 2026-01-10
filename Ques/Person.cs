

public class Person
{
    public string? Name{get;set;}
    public string? Addres{get;set;}
    public int Age{get;set;}
    
}

public class PersonImplementation
{
    public string GetName(IList<Person> people)
    {
        string res=" ";
        foreach(var person in people)
        {
            res+=person.Name+" "+person.Addres+" ";
        }
        return res;
    }

    public double Average(IList<Person> people)
    {
        double count=0;
        double total=0;
        foreach(var i in people)
        {
            total+=i.Age;
            count++;
        }

        return total/count;
    }

    public int Max(IList<Person> people)
    {
        int max=0;
        foreach(var i in people)
        {
            if (i.Age > max)
            {
                max=i.Age;
            }
            else
            {
                continue;
            }
        }
        return max;
    }
}