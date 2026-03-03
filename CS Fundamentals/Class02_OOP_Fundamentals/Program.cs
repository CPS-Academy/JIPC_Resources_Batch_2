using System;

namespace CPS;

public class Car
{
    public string Brand; // property
    public int Speed;    // property

    public Car()
    { // Constructor

    }

    public Car(int speed)
    { // Constructor
        Speed = speed;
    }

    public Car(string brand, int Speed)
    { // Constructor
        this.Speed = Speed;
        this.Brand = brand;
    }

    public void Drive()
    { // method
        Console.WriteLine("Car is Driving");
    }

    public int GetSpeed()
    { // method
        return Speed;
    }
}

// public
// private
// protected

class Program
{
    static void Main()
    {
        /*Car bmwCar = new Car();
        Console.WriteLine($"Brand: {bmwCar.Brand}");
        Console.WriteLine(bmwCar.Speed);

        Car bmwCarWithSpeed = new Car(100);
        Console.WriteLine($"Brand: {bmwCarWithSpeed.Brand}");
        Console.WriteLine(bmwCarWithSpeed.Speed);

        Car bmwCarWithBrandAndSpeed = new Car("BMW", 50);
        //bmwCarWithBrandAndSpeed.Brand = "BMW";
        Console.WriteLine($"Brand: {bmwCarWithBrandAndSpeed.Brand}");
        Console.WriteLine(bmwCarWithBrandAndSpeed.Speed);
        bmwCar.Brand = "BMW";*/

        Dog testDog = new Dog();
        testDog.MakeSound();
        testDog.Eat();
    }
}

public class Person
{
    protected string Name;
    public string email;
    public string phoneNumber;
}

public class Teacher : Person
{

}

public class Student : Person
{
    public int RollNumber;

    public Student(string name)
    {
        this.Name = name;
    }
}

public class Animal
{

}

public abstract class AbstractAnimal
{
    public abstract void MakeSound();

    //public abstract void Eat();
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

public class Dog : AbstractAnimal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }

    // public void Eat(){
    // Console.WriteLine("Dog is eating");
    // }
}

public sealed class SealedClass
{
    public void Test()
    {

    }
}

public class TestClass
{

}

/*
Class
Property
Method
Different of class
- Concrete
- Abstract
- Sealed
- Partial
Inherit class
Constructor
Object
Accessmodifer
*/