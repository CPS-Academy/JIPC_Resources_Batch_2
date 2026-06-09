/*
Facade Design Pattern
Advantages: 
1. Reduces complexity
2. Improved Maintainability
3. Provides Clean API/ Interface
4. Reduces tight coupling


Disadvantages:
1. Can become God object
2. Extra abstraction layer
3. Risk of hiding important features
*/

/*InventoryService - CheckStock()
PaymentService - Pay()
ShippingService - Ship()
NotificationService - Notify()*/

// Subsystem  1
class InventoryService
{
    public bool CheckStock(string item)
    {
        /// Main logic
        Console.WriteLine($"Checking stock for {item}");
        return true;
    }
}
// Subsystem 2
class PaymentService
{
    public void Pay(string user)
    {
        Console.WriteLine($"Payment processed for {user}");
    }
}
// Subsystem 3
class ShippingService
{
    public void Ship(string item)
    {
        Console.WriteLine($"Shipping for {item}");
    }
}
// Subsystem 4
class NotificationService
{
    public void Notify(string user)
    {
        Console.WriteLine($"Email sent to {user}");
    }
}


// Facade
class OrderFacade
{
    private InventoryService _inventoryService;
    private PaymentService _paymentService;
    private ShippingService _shippingService;
    private NotificationService _notificationService;
    public OrderFacade()
    {
        _inventoryService = new InventoryService();
        _paymentService = new PaymentService();
        _shippingService = new ShippingService();
        _notificationService = new NotificationService();
    }
    
    public void PlaceOrder(string user, string item)
    {
        Console.WriteLine($"Placing order for {user}");
        if (_inventoryService.CheckStock(item))
        {
            _paymentService.Pay(user);
            _shippingService.Ship(item);
            _notificationService.Notify(user);
        }
        Console.WriteLine($"Order placed {item}");
    }
}
/*class Program
{
    static void Main(string[] args)
    {
        OrderFacade orderFacade = new OrderFacade();
        orderFacade.PlaceOrder("Subhashis", "Laptop");
    }
}*/


// Flyweight  Design Pattern
// Intrinsic State - Which is common for everyone(Shared)
// Extrinsic State - Which is different (Come from outside)
/*
 Advantages:
 1. Reduces Memory 
 2. Improve Performance
 3. Reuse Object
 4. Useful for large system
 
 Disadvantages:
 1. Hard to debug and maintain
 2. Not necessary for the small project
 3. Tight Coupling - Complex design
 */

class Tree
{
    private string type; // Intrinsic State

    public Tree(string type)
    {
        this.type = type;
    }
    public void Display(int x , int y) // Extrinsic 
    {
        Console.WriteLine($"{type} Tree Position: {x}, {y}");
    }
}
class TreeFactory
{
    private static Dictionary<string, Tree> treeList = new Dictionary<string, Tree>();

    public static Tree GetTree(string type)
    {
        if (!treeList.ContainsKey(type))
        {
            treeList[type] = new Tree(type);
            Console.WriteLine($"Tree Created {type}");
        }
        return treeList[type];
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        Tree t1 = TreeFactory.GetTree("Type 1");
        t1.Display(10, 20);
        Tree t2 = TreeFactory.GetTree("Type 2");
        t2.Display(20, 30);
        Tree t3 = TreeFactory.GetTree("Type 1");
        t3.Display(30, 40);
    }
}*/

// Composite Design Pattern
/*
 Folder -
    File
    Folder-
        File 
        File 
        Folder- 
            File 


CEO 
    - Manager
        - Team lead
            - Employee
            
Menu 
    - Sub Menu
        - Items
        - Sub Menu
            - Items
    Items

 */

public abstract class OrganizationUnit
{
    private string _name;
    public OrganizationUnit(string name)
    {
        _name = name;
    }

    public abstract int GetBudget();

    public virtual void AddUnit(OrganizationUnit unit)
    {
        Console.WriteLine($"Adding {unit}");
    }

    public virtual void RemoveUnit(OrganizationUnit unit)
    {
        Console.WriteLine($"Removing {unit}");
    }
}

public class Employee : OrganizationUnit
{
    private int _salary;
    private string _name;

    public Employee(string name, int salary) : base(name)
    {
        _salary = salary;
        _name = name;
    }

    public override int GetBudget()
    {
        Console.WriteLine($"Employee {_name} - Salary: {_salary}");
        return _salary;
    }
}

public class Department : OrganizationUnit
{
    private List<OrganizationUnit> _units = new List<OrganizationUnit>();
    public string _name;
    public Department(string name) : base(name)
    {
        _name = name;
    }
    public override void AddUnit(OrganizationUnit unit)
    {
        _units.Add(unit);
    }

    public override void RemoveUnit(OrganizationUnit unit)
    {
        _units.Remove(unit);
    }

    public override int GetBudget()
    {
        Console.WriteLine($" Department {_name} - Total Employee: {_units.Count}");
        int totalBudget = 0; //_units.Sum(unit => unit.GetBudget());
        foreach (var unit in _units)
        {
            totalBudget += unit.GetBudget();
        }
        Console.WriteLine($"Budget: {totalBudget}");
        return totalBudget;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var john = new Employee("John", 25000);
        var bob = new Employee("Bob", 30000);
        var alice = new Employee("Alice", 35000);
        var subhashis = new Employee("Subhashis", 40000);
        
        var devTeam =new Department("DevTeam");
        var qaTeam = new Department("QATeam");
        
        var companyTeam = new Department("CompanyTeam");
        
        devTeam.AddUnit(john);
        devTeam.AddUnit(bob);
        
        qaTeam.AddUnit(alice);
        
        companyTeam.AddUnit(subhashis);
        companyTeam.AddUnit(devTeam);
        companyTeam.AddUnit(qaTeam);
        
        //Console.WriteLine(companyTeam.GetBudget());
        //Console.WriteLine(devTeam.GetBudget());
        //Console.WriteLine(qaTeam.GetBudget());
        Console.WriteLine(subhashis.GetBudget());
    }
}

/*Company-
    Subhashis
    DevTeam
        - John
        - Bob 
    QATeam
        - Alice
    
*/