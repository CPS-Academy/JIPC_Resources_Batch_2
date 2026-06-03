/*Subject - Bank Account
    Proxy - ATM Card
    Client - Customer
    
    
    Subject - CEO
    Proxy - Receptionlist
    Client - Visitor
    
Employee- Security Guard - Office Building*/
// Proxy Design Pattern
public interface IBankAccount
{
    void ShowBalance();
    void Withdraw(double amount);
}

public class RealBankAccount : IBankAccount
{
    private double _balance;
    public RealBankAccount(double balance)
    {
        _balance = balance;
    }
    public void ShowBalance()
    {
        Console.WriteLine("Current Balance "+_balance);
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
        Console.WriteLine("Current Balance "+_balance);
        Console.WriteLine("Withdrawn "+amount);
    }
}

public class BankAccountProxy : IBankAccount
{
    private readonly RealBankAccount _realBankAccount;
    private readonly string _userRole;
    public BankAccountProxy(double balance, string userRole)
    {
        _realBankAccount = new RealBankAccount(balance);
        _userRole = userRole;
    }

    public void ShowBalance()
    {
        _realBankAccount.ShowBalance();
    }

    public void Withdraw(double amount)
    {
        if (_userRole != "Admin")
        {
            Console.WriteLine("Access Denied");
            return;
        }
        _realBankAccount.Withdraw(amount);
    }
}
/*class Program
{
    static void Main()
    {
        IBankAccount userAccount = new BankAccountProxy(1000, "User");
        IBankAccount adminAccount = new BankAccountProxy(2000, "Admin");
        
        userAccount.ShowBalance();
        userAccount.Withdraw(200);
        
        adminAccount.ShowBalance();
        adminAccount.Withdraw(500);
    }
}
*/




// Bridge Design Pattern
/*Payment Type - Credit card, Debit card, Wallet
    Payment Gateways - Stripe
    
    Type add - UPI
    Gateway Change - Paypal

Without Bridge
    CardStripePayment
    CardPalpalPayment
    UPIStripePayment
    UPIPayPalPayment
    
With Bridge
    Payment Method - (Abstraction)
    Payment Gateway - (Implementation)
    
    
    User - Payment Method - Gateway - Bank

*/

public interface IPaymentGatway
{
    void ProcessPayment(double amount);
}
// Implementation
public class StripeGatwateway : IPaymentGatway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing {amount} via stripe");
    }
}
public class PaypalGatwateway : IPaymentGatway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing {amount} via paypal");
    }
}
// Abstraction
public abstract class PaymentMethod
{
    public IPaymentGatway _gateway;

    public PaymentMethod(IPaymentGatway gateway)
    {
        _gateway = gateway;
    }

    public abstract void Pay(double amount);
}

public class CardPayment : PaymentMethod
{
    public CardPayment(IPaymentGatway _gateway) : base(_gateway){}
    public override void Pay(double amount)
    {
        Console.WriteLine("Card Payemnt");
        _gateway.ProcessPayment(amount);
    }
}
public class UPIPayment : PaymentMethod
{
    public UPIPayment(IPaymentGatway _gateway) : base(_gateway){}
    public override void Pay(double amount)
    {
        Console.WriteLine("UPI Payemnt");
        _gateway.ProcessPayment(amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentMethod p1 = new CardPayment(new StripeGatwateway());
        p1.Pay((500));
        PaymentMethod p2 = new UPIPayment(new PaypalGatwateway());
        p2.Pay((1000));
    }
}






