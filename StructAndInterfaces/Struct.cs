public struct Customer :ICustomer2
{
    private int _id;
    private string? _name;
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            this._id=value;
        }
    }

    public string Name { get => this._name; set => this._name = value; }
    public Customer()
    {
        System.Console.WriteLine("ok");
    }
    public Customer(int id,string name)
    {
        this.Id=id;
        this.Name=name;
    }

    public void PrintDetails()
    {
        System.Console.WriteLine($"Id: {this._id}, Name: {this._name}");
    }

    public void GetName()
    {
        System.Console.WriteLine("Interface method called");
    }

    public void GetName2()
    {
        System.Console.WriteLine("Second method from parent interface                                                                                                               ");
    }
}