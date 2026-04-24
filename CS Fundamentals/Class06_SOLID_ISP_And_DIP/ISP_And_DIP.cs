// I- Interafce Segration Principle


public interface IAnimal
{
    void Eat();
    void Fly();
    void Swim();
}
public interface IFlyer
{
    void Fly();
}

public interface IEater
{
    void Eat();
}

public interface ISwimmer
{
    void Swim();
}

public class Dog : IEater, ISwimmer
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Swim()
    {
        throw new NotImplementedException();
    }
}

public class Bird : IEater, IFlyer
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }
}

public class Fish : IEater, ISwimmer
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Swim()
    {
        throw new NotImplementedException();
    }
}

public class Customer
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public Customer(string fullName, string phoneNumber)
    {
        FullName = fullName;
        PhoneNumber = phoneNumber;
    }
}

public class ShoppingCart
{
    public double TotalAmount{get; set; }
    public Customer Customer {get;set;}
    public ShoppingCart(double totalAmount, Customer customer)
    {
        TotalAmount = totalAmount;
        Customer = customer;
    }
}

public class SmsService
{
    public void SendSms(string text, string phoneNumber)
    {
        Console.WriteLine(text);
        Console.WriteLine(phoneNumber);
        Console.WriteLine("Sending SMS via BL");
    }
}
public class CheckoutService
{
    private SmsService _smsService;

    public CheckoutService()
    {
        _smsService = new SmsService();
    }
    private void SendConfirmationSMS(ShoppingCart shoppingCart)
    {
        string message = "Confirmation Done";
        _smsService.SendSms(message, shoppingCart.Customer.PhoneNumber);
    }

    public void Checkout(ShoppingCart shoppingCart)
    {
        SendConfirmationSMS(shoppingCart);
    }

}
// D- Dependency Inversion Principle
/*
public class Program
{
    public static void Main()
    {
        var customer = new Customer("Subhashis", "+8801712345678");
        var shoppingCart = new ShoppingCart(1000, customer);
        var checkoutService = new CheckoutService();
        checkoutService.Checkout(shoppingCart);
    }
}*/

// Refactored
public class NewSmsService
{
    private ISMSProvider _smsProvider;

    public NewSmsService(ISMSProvider smsProvider)
    {
        _smsProvider = smsProvider;
    }
    public void SendSms(string text, string phoneNumber)
    {
        _smsProvider.SendSms(text, phoneNumber);
    }
}
public class NewCheckoutService
{
    private NewSmsService _newSmsService;

    public NewCheckoutService(NewSmsService newSmsService)
    {
        _newSmsService = newSmsService;
    }
    private void SendConfirmationSMS(ShoppingCart shoppingCart)
    {
        string message = "Confirmation Done";
        _newSmsService.SendSms(message, shoppingCart.Customer.PhoneNumber);
    }

    public void Checkout(ShoppingCart shoppingCart)
    {
        SendConfirmationSMS(shoppingCart);
    }

}
public class Program
{
    public static void Main()
    {
        var customer = new Customer("Subhashis", "+8801712345678");
        var shoppingCart = new ShoppingCart(1000, customer);
        ISMSProvider smsProvider = new GpSmsProvider();
        var smsService = new NewSmsService(smsProvider);
        var checkoutService = new NewCheckoutService(smsService);
        checkoutService.Checkout(shoppingCart);
    }
}
public interface ISMSProvider
{
    void SendSms(string text, string phoneNumber);
}

public class GpSmsProvider : ISMSProvider
{
    public void SendSms(string text, string phoneNumber)
    {
        Console.WriteLine("Send SMS via GP");
    }
}
public class BlSmsProvider : ISMSProvider
{
    public void SendSms(string text, string phoneNumber)
    {
        Console.WriteLine("Send SMS via BL");
    }
}
public class RobiSmsProvider : ISMSProvider
{
    public void SendSms(string text, string phoneNumber)
    {
        Console.WriteLine("Send SMS via Robi");
    }
}