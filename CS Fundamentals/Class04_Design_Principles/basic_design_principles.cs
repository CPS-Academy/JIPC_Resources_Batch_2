using System;
//YAGNI
// Bad Code
public class User
{
    public string name;
    public string emailAddress;
    // Unnecessary method
    public void SendWelcomeEmail()
    {
        
    }

    public void GenerateReferralCode()
    {
        
    }
}
// Good 
public class User2
{
    public string name;
    public string emailAddress;
}
// Bad
public class PaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Payment processed");
    }
    // Unnecessary method
    public void ApplyDiscount(double amount)
    {
        
    }

    public void SendReceiptByEmail()
    {
        
    }
}
// Good 
public class PaymentProcessor2
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Payment processed");
    }
}



// KISS
// Bad Code

// 1,2,3,5,8 ====
// 2+8=10
int GetEvenNumbersSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0 && numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}
// Good
int GetEvenNumbersSum2(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}


// DRY
// Bad Code
public class UserManager
{
    public void PrintAdmin()
    {
        Console.WriteLine("Name: Subhashis");
        Console.WriteLine("Password: Password");
        Console.WriteLine("Role: Admin");
    }
    public void PrintUser()
    {
        Console.WriteLine("Name: User");
        Console.WriteLine("Password: Password");
        Console.WriteLine("Role: User");
    }
}
// Good Code
public class UserManager2
{
    public void PrintDetails(string name, string password, string role)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Password: {password}");
        Console.WriteLine($"Role: {role}");
    }
}


// Interface
public interface IPayment 
{
    void Pay(double amount);
}

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Credit card payment");
    }
}
public class PaypalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paypal payment");
    }
}


interface IVehicle
{
    public void Start();
    public void Stop();
}

abstract class Vehicle
{
    public abstract void Start();
    public abstract void Stop();

    public void Run()
    {
        Console.WriteLine("Run");
    }
}

class Car : IVehicle
{
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike started");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stopped");
    }
    public void Run()
    {
        Console.WriteLine("Run");
    }
}
class Program
{
    public static void Main()
    {
       
    }
}

