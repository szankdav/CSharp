X x = new X("Márió", 23);

X z = x;

Console.WriteLine($"{x.Name}, {x.Number}");

z.Name = "Alíz";
z.Number = 24;

Console.WriteLine($"{x.Name}, {x.Number}");
Console.WriteLine($"x == z? {x == z}");
Console.WriteLine($"x hashcode: {x.GetHashCode()}");
Console.WriteLine($"z hashcode:  {z.GetHashCode()}");

Y y = new Y("Dávid", 15);
Y w = y;
Y q = y with { Name = "Zoli" };

Console.WriteLine($"{y.Name}, {y.Number}");
Console.WriteLine($"{q.Name}, {q.Number}");
Console.WriteLine($"y == q? {y == q}");

Console.WriteLine($"y hashcode: {y.GetHashCode()}");
Console.WriteLine($"w hashcode:  {w.GetHashCode()}");
Console.WriteLine($"q hashcode:  {q.GetHashCode()}");

Console.ReadKey();

class X
{
    private string name;
    private int number;

    public X(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public string Name { get => name; set => name = value; }
    public int Number { get => number; set => number = value; }


};

record class Y
{
    private string name;
    private int number;

    public Y(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public string Name { get; init; }
    public int Number { get; init; }
};