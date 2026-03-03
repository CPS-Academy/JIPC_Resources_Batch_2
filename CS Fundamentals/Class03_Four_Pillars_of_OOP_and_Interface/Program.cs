using System;

//Abstraction
abstract class Vehicle
{
    public string Brand { get; set; }
    public abstract void Drive();

    public void Stop()
    {
        Console.WriteLine($"{Brand} is stopping");
    }
}

class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine($"{Brand} Car is driving");
    }
}

class Bike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine($"{Brand} Bike is driving");
    }
}


class Program
{
    public static void Main()
    {
        Vehicle myCar = new Car() { Brand = "Toyota" };
        myCar.Drive();
        myCar.Stop();
        
        Vehicle myBike  = new Bike() { Brand = "Honda" };
        myBike.Drive();
        myBike.Stop();
    }
}

// Polymorphism

/*public class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{this.name} is making a sound");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name){}
}
class Cat : Animal
{
    public Cat(string name) : base(name){}
}

class Program
{
    public static void Main()
    {
        Cat cat = new Cat("Cat 1");
        Dog dog = new Dog("Dog 1");
        
        
        cat.MakeSound();
        dog.MakeSound();
    }
}*/

/*class Calculator()
{
    public void Add(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    public void Add(int a, int b)
    {

    }

    public void Add(int a, int b, int c)
    {

    }

    public void Add(int a, int b, int c, int d)
    {

    }
}*/




// Inheritance
/*class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name} is Eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is Sleeping");
    }
}

class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
    }
    public void Bark()
    {
        Console.WriteLine($"{Name} is Barking");
    }
}*/

/*class BlackDog : Dog
{
    public void BlackDogBehavior()
    {
        Console.WriteLine($"{Name} is Black dog");
    }
}*/

/*class Cat : Animal
{
    public void Meaw()
    {
        Console.WriteLine($"{Name} is Meowing");
    }
}

class Program
{
    public static void Main()
    {
        Dog dog = new Dog("Dog 1");
        //dog.Name = "Dog";
        dog.Eat();
        dog.Sleep();
        dog.Bark();
        
        Cat cat = new Cat();
        cat.Name = "Cat";
        cat.Eat();
        cat.Sleep();
        cat.Meaw();
        
        BlackDog blackDog = new BlackDog();
        blackDog.Name = "Black dog";
        blackDog.Eat();
        blackDog.Sleep();
        blackDog.Bark();
        blackDog.BlackDogBehavior();
    }
}*/



/* Encapsulation
 class BankAccount
{
    private double Balance;
    private string AccountHolder;

    public BankAccount(string name, double initialBalance)
    {
        AccountHolder = name;
        if (initialBalance >= 0)
        {
            Balance = initialBalance;
        }
        else
        {
            Balance = 0;
        }
    }

    public string GetAccountHolderName()
    {
        return AccountHolder;
    }
    public double GetAccountBalance()
    {
        return Balance;
    }

    public void Deposit(double amount)
    {
        if (amount >= 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}");
        }
        else
        {
            Console.WriteLine("Deposited negative amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount >= 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}");
        }
        else
        {
            Console.WriteLine("Invalid Withdrawn amount");
        }
    }
}
class Program
{
    public static void Main()
    {
        BankAccount bankAccount = new BankAccount("Subhashis", 2000.0);
        bankAccount.Deposit(100.0);
        bankAccount.Withdraw(200.0);

        Console.WriteLine($"Account HOlder: {bankAccount.GetAccountHolderName()}");
        Console.WriteLine($"Account Balance: {bankAccount.GetAccountBalance()}");
    }
}*/



/*
 * Defination
 * Advantages
 * Disadvantages
 * Use Case
 * Code
 * Types
 * Example
*/




