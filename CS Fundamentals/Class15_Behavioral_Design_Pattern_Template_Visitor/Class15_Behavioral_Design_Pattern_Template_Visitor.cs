// Template Design Pattern 
// Example
// TeaMaker
// CoffeeMaker
// GreenTeaMaker
// BlackCoffeeMaker
abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddIncredients();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boil water");
    }

    private void PourInCup()
    {
        Console.WriteLine("Pour in cup");
    }

    protected abstract void AddIncredients();
    protected abstract void Brew();
}

class Tea : Beverage
{
    protected override void AddIncredients()
    {
        Console.WriteLine("Adding Lemon");
    }

    protected override void Brew()
    {
        Console.WriteLine("Brewing Tea");
    }
}

class Coffee : Beverage
{
    protected override void AddIncredients()
    {
        Console.WriteLine("Adding Milk & Sugar");
    }

    protected override void Brew()
    {
        Console.WriteLine("Brewing Coffee");
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        Beverage tea = new Tea();
        tea.Prepare();
        
        Console.WriteLine();
        Beverage coffee = new Coffee();
        coffee.Prepare();
    }
}*/

// Visitor Pattern

// Tax Department
// Objects - Car, House, Bank Account
// Visitors - TaxCalculator, Insurance Calculator, Report Generator, Auditor


interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}

interface IItem
{
    void Accept(IVisitor visitor);
}

class Book : IItem
{
    public string Name { get; set; }
    public int Price { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

class Fruit : IItem
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

class PriceVisitor : IVisitor
{
    public void Visit(Fruit fruit)
    {
        Console.WriteLine($"Fruit {fruit.Name}, Weight: {fruit.Weight}");
    }
    public void Visit(Book book)
    {
        Console.WriteLine($"Book {book.Name}, Price: {book.Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IItem[] items = new IItem[]
        {
            new Fruit { Name = "Apple", Weight = 2 },
            new Fruit { Name = "Banana", Weight = 3 },
            new Book { Name = "C# Book", Price = 500 }
        };
        IVisitor visitor = new PriceVisitor();
        foreach (IItem item in items)
        {
            item.Accept(visitor);
        }
    }
}