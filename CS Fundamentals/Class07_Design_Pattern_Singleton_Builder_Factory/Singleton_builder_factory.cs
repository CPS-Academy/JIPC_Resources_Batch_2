/*public class Singleton
{
    private static Singleton _instance;
    private Singleton()
    {
        
    }
    public static Singleton GetInstance()
    {
        if(_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}
class Program
{
    static void Main()
    {
        var obj1 = Singleton.GetInstance();
        var obj2 = Singleton.GetInstance();
        
        Console.WriteLine(obj1 == obj2);
    }
}*/
/*
 Builder

    -Complex object creation
    - UI Form builders
    - API request builders 
    - Configration Object
*/
/*public class Computer
{
    public string CPU{get;set;}
    public string GPU{get;set;}
    public string RAM{get;set;}
    public string Storage{get;set;}
    public void Show()
    {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, GPU: {GPU}, Storage:{Storage}");
    }
}
public interface IComputerBuilder
{
    void SetCPU();
    void SetGPU();
    void SetRAM();
    void SetStorage();
    Computer GetComputer();
}
public class GamingComputerBuilder: IComputerBuilder
{
    private Computer _computer = new Computer();
    public void SetCPU()
    {
        _computer.CPU = "Intel i9";
    }

    public void SetGPU()
    {
        _computer.GPU = "RTX 4090";
    }

    public void SetRAM()
    {
        _computer.RAM = "32GB";
    }

    public void SetStorage()
    {
        _computer.Storage = "1TB SSD";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
class User()
{
    public void BuildComputer(IComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetRAM();
        builder.SetGPU();
        builder.SetStorage();
    }
}
class Program
{
    static void Main()
    {
        User user = new User();
        IComputerBuilder builder = new GamingComputerBuilder();
        user.BuildComputer(builder);
        Computer computer = builder.GetComputer();
        computer.Show();
    }
}*/

public interface INotification
{
    void Send(string message);
}
public class EmailNotification: INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}
public class SMSNotification: INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}
public class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type switch
        {
            "Email" => new EmailNotification(),
                "SMS" => new SMSNotification(),
                _ => throw new ArgumentException("Invalid notification Type")
        };
    }
}

class Program
{
    static void Main()
    {
        INotification notification = NotificationFactory.CreateNotification("Email");
        notification.Send("Hello Factory Pattern");
    }
}

//https://refactoring.guru/design-patterns
// 
// https://github.com/bethrobson/Head-First-Design-Patterns/tree/master/src/headfirst/designpatterns
// 
// Design patterns : elements of reusable object-oriented software - Book
// Head First Design Patterns - Book
// https://www.youtube.com/watch?v=IFe6gdNUDAg&list=PLhfxuQVMs-nxlIlZon5tkhI5X-lE2UG4K
// https://www.youtube.com/watch?v=v9ejT8FO-7I&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc
