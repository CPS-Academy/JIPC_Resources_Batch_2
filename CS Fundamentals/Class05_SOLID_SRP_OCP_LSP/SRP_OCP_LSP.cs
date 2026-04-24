using System;

/*Why follow SOLID
    Maintainability 
    Resusability
    Testability
    Flexibility & Extensibility
    Reduce Coupling
    */
//Single responsibility Principle
// Violation Code
/*public class OrderService
{
    public void CreateOrder()
    {
        // Business
    }

    public void DeleteOrder()
    {
        // Business
    }

    public void SaveToDatabase()
    {
        // DB Logic
    }

    public void SendEmail()
    {
        // Email Logic
    }
}
// Refactored Code
public class OrderService2
{
    public void CreateOrder()
    {
        // Business
    }

    public void DeleteOrder()
    {
        // Business
    }
}

public class OrderRepository
{
    public void SaveToDatabase()
    {
        // DB Logic
    }
}
public class EmailService
{
    public void SendEmail()
    {
        // Email Logic
    }
}
/*Advantages
    - Maintaiblity
    - Testability
    - Reusability
    - Loose Coupling 
    DisAdvantages   
- More Classes
    - More Dependencies*/

// Open/ Closed Principle
// Violation code

/*public class PaymentService
{
    public void ProcessPayment(string paymentType, double amount)
    {
        if (paymentType == "Cash")
        {
            Console.WriteLine("Payment processed by Cash");
        }
        else if (paymentType == "CreditCard")
        {
            Console.WriteLine("Payment processed by CreditCard");
        }
        else if (paymentType == "PayPal")
        {
            Console.WriteLine("Payment processed by PayPal");
        }
    }
}*/
/*

// Refactored Code
public abstract class Payment
{
    public abstract void ProcessPayment(double amount);
}

public class Cash : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processed by Cash");
    }
}
public class CreditCard : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processed by CreditCard");
    }
}

public class Paypal: Payment{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processed by PayPal");
    }
}*/
/*
Advantages
    - No modification // Safe Side - Few Bugs
    - Easy Feature Addition
    - Better Testing
    - High Scalibility 
Disadvantage
    - More Interface / Class
    - Complexity - Beginners    
*/

    
// Liskov Substitution Principle
/*
    - Permanent employee - Bonus Eligible - (20%) - CalculateBonus
    - Temporary employee - Bonus Eligible - (5%) - CalculateBonus
    - Contractual employee - Bonus Not Eligible - Not CalculateBonus 
*/

// Subtype should not throw new exceptions
// Client should not know about the subtypes
// Derived class should extend without replacing the functionality of old class
 // - Child class should behave exactly like the parent class
// Violation Code
 /*public abstract class Employee
 {
     public int Id { get; set; }
     public string Name { get; set; }
     public abstract bool IsEligibleForBonus();
     public abstract decimal CalculateBonus(decimal amount);
 }

 public class PermanentEmployee : Employee
 {
     public override bool IsEligibleForBonus()
     {
         return true;
     }

     public override decimal CalculateBonus(decimal amount)
     {
        return (amount * 20)/100;
     }
 }
 public class TemporaryEmployee : Employee
 {
     public override bool IsEligibleForBonus()
     {
         return true;
     }

     public override decimal CalculateBonus(decimal amount)
     {
         return (amount * 5)/100;
     }
 }

 public class ContractualEmployee : Employee
 {
     public override bool IsEligibleForBonus()
     {
         return false;
     }

     public override decimal CalculateBonus(decimal amount)
     {
         throw new NotImplementedException();
     }
 }

/*public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new TemporaryEmployee());
        employees.Add(new PermanentEmployee());
        employees.Add(new ContractualEmployee());
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.IsEligibleForBonus());
            Console.WriteLine(employee.CalculateBonus(employee.CalculateBonus(100)));
        }
    }
}*/
// Refactored Code
/*public interface IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public abstract bool IsEligibleForBonus();
}

public interface IEmployeeBonusEligible
{
    public abstract decimal CalculateBonus(decimal amount);
}
public class PermanentEmployee2 : IEmployee, IEmployeeBonusEligible
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsEligibleForBonus()
    {
        return true;
    }

    public decimal CalculateBonus(decimal amount)
    {
        return (amount * 20) / 100;
    }
}
public class TemporaryEmployee2 : IEmployee, IEmployeeBonusEligible
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsEligibleForBonus()
    {
        return true;
    }

    public decimal CalculateBonus(decimal amount)
    {
        return (amount * 5) / 100;
    }
}

public class ContractualEmployee2 : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsEligibleForBonus()
    {
        return false;
    }
}
public class Test
{
    public static void Main()
    {
        List<IEmployee> employees = new List<IEmployee>();
        employees.Add(new TemporaryEmployee2());
        employees.Add(new PermanentEmployee2());
        employees.Add(new ContractualEmployee2());
        
        
        List<IEmployeeBonusEligible> employeeBonus = new List<IEmployeeBonusEligible>();
        employeeBonus.Add(new PermanentEmployee2());
        employeeBonus.Add(new TemporaryEmployee2());
        
        
        foreach (IEmployee employee in employees)
        {
            Console.WriteLine(employee.IsEligibleForBonus());
        }
        foreach (IEmployeeBonusEligible employee in employeeBonus)
        {
            Console.WriteLine(employee.CalculateBonus(100));
        }
    }
}*/