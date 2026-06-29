// State Design Pattern 
/*
- Red - Stop 
- Yellow - Wait 
- Green - Go 

- No card - Insert Card Allowed
- Card Insert - Enter Pin 
- Pin Correct - Withdraw Money 

- No Coin - Cannot dispense 
- Coin insert - Select Product 
- Product Selected - Dispense Item 
*/

interface IState
{
    void Handle();
}
class RedState: IState
{
    public void Handle()
    {
        Console.WriteLine("Red Light -> STOP");
    }
}
class YellowState: IState
{
    public void Handle()
    {
        Console.WriteLine("Yellow Light -> Wait");
    }
}
class GreenState : IState
{
    public void Handle()
    {
        Console.WriteLine("Green Light -> Go");
    }
}

class TrafficLight
{
    private IState _state;
    public void SetState(IState state)
    {
        _state = state;
    }
    public void Request()
    {
        _state.Handle();
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();
        light.SetState(new RedState());
        light.Request();
        
        light.SetState(new YellowState());
        light.Request();
        
        light.SetState(new GreenState());
        light.Request();
    }
}*/

// Strategy Design Pattern 

/*
 Payment System 
 - Credit Card
 - Paypal
 - Bkash / Nagad 
 
 Navigation app
 - Car Route
 - Bike route 
 - Walking Route
 - Bus Route 
 */

interface IPaymentStrategy
{
    void Pay(int amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}

class PaypalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal");
    }
}

class BkashPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Bkash");
    }
}

class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }
    public void PayAmount(int amount)
    {
        _paymentStrategy.Pay(amount);
    }
}
/*class Program
{
    static void Main(string[] args)
    {
        PaymentContext paymentContext = new PaymentContext();
        paymentContext.SetPaymentStrategy(new BkashPayment());
        paymentContext.PayAmount(100);
        
        paymentContext.SetPaymentStrategy(new PaypalPayment());
        paymentContext.PayAmount(200);
        
        paymentContext.SetPaymentStrategy(new CreditCardPayment());
        paymentContext.PayAmount(300);
    }
}*/

/*

        State                 vs       Strategy
Focus - State Transition      -        Algorithm Selection 
Who decides - Context itself  -        Client
Purpose - Change Behavior based on state - Choose Algorithm

*/


// Memento Design Pattern


class Memento
{
    public string State { get; set; }
    public Memento(string state)
    {
        State = state;
    }
}

class Document
{
    public string Text { get; set; }

    public Memento Save()
    {
        return new Memento(Text);
    }
    public void Restore(Memento memento)
    {
        Text = memento.State;
    }
}

class History
{
    private Stack<Memento> _history = new Stack<Memento>();

    public void Save(Memento memento)
    {
        _history.Push(memento);
    }

    public Memento Undo()
    {
        if (_history.Count > 0)
        {
            return _history.Pop();
        }

        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Document doc = new Document();
        History history = new History();
        doc.Text = "Hello";
        history.Save(doc.Save());
        
        doc.Text = "Hello World";
        history.Save(doc.Save());
        
        doc.Text = "Hello World!!!";
        history.Save(doc.Save());
        
        Console.WriteLine("Current Text "+doc.Text);
        // Undo
        Memento previous = history.Undo();
        if (previous != null)
        {
            doc.Restore(previous);
            Console.WriteLine("After Undo Top element= " + doc.Text);
        }
        // Undo again
        previous = history.Undo();
        if (previous != null)
        {
            doc.Restore(previous);
            Console.WriteLine("After Second Undo Top Element= " + doc.Text);
        }
        // Undo again
        previous = history.Undo();
        if (previous != null)
        {
            doc.Restore(previous);
            Console.WriteLine("After Third Undo Top Element= " + doc.Text);
        }
        
    }
}