// Abstract Factory
/*
 Cross Platform UI Systems
 Database Providers
 Payment Systems
 Theming Systems
 */
/*public interface IFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
}

public interface IButton
{
    void Render();
}
public interface ICheckBox
{
    void Check();
}

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows Button is rendered");
    }
}
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Mac Button is rendered");
    }
}
public class WindowsCheckbox : ICheckBox
{
    
    public void Check()
    {
        Console.WriteLine("Windows Checkbox is rendered");
    }
}
public class MacCheckbox : ICheckBox
{
    public string Name => "Mac Checkbox";
    public void Check()
    {
        Console.WriteLine("Mac Checkbox is rendered");
    }
}

public class WindowsFactory : IFactory
{
    public string Name => "Windows Factory";
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox() => new WindowsCheckbox();
}
public class MacFactory : IFactory
{
    public IButton CreateButton()=> new MacButton();

    public ICheckBox CreateCheckBox() => new MacCheckbox();
}

public class Program
{
    public static void Main(string[] args)
    {
        
        IFactory windowsFactory = new WindowsFactory();
        //Console.WriteLine(windowsFactory.Name);
        IButton windowsButton = windowsFactory.CreateButton();
        windowsButton.Render();
        IFactory macFactory = new MacFactory();
        ICheckBox macCheckbox = macFactory.CreateCheckBox();
        macCheckbox.Check();
    }
}*/


// Prototype 
// Class A - instanceA
// Class B - instanceB

public abstract class Shape
{
    public string Color { get; set; }
    public abstract Shape Clone();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle()
        {
            Color = "Red",
            Radius = 5.5
        };
        Circle circle2 = (Circle)circle1.Clone();
        Console.WriteLine($"Circle 1- Color: {circle1.Color}  Radious: {circle1.Radius}");
        Console.WriteLine($"Circle 2- Color: {circle2.Color}  Radious: {circle2.Radius}");
        circle2.Radius = 6;
        Console.WriteLine($"Circle 2- Color: {circle2.Color}  Radious: {circle2.Radius}");
    }
}

//https://github.com/quyenly13/books/blob/master/Head%20First%20Design%20Patterns.pdf
//https://github.com/GunterMueller/Books-3/blob/master/Design%20Patterns%20Elements%20of%20Reusable%20Object-Oriented%20Software.pdf