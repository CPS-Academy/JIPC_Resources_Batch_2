// Command Design Pattern

//Tv Remote Control
// Power on / off 
// volume up / down

/* Purpose
- Decouple the sender of a request from the reciever
- Encapsulate actions as objects
- Undo/redo functionality provide


Remote control - Inovoke 
Button press - Command 
TV - Receiver 
*/


public interface ICommand
{
    void Execute();
}
// Receiver 
public class BankAccount
{
    private decimal _balance;
    public BankAccount(decimal intialBalance)
    {
        _balance = intialBalance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"{amount} deposited");
        Console.WriteLine($"Balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Not enough money");
        }
        else
        {
            _balance -= amount;
            Console.WriteLine($"{amount} Withdrawn");
            Console.WriteLine($"Balance: {_balance}");
        }
    }
}

public class DepositCommand : ICommand
{
    private BankAccount _bankAccount;
    private decimal _amount;

    public DepositCommand(BankAccount bankAccount,decimal amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }
    public void Execute()
    {
        _bankAccount.Deposit(100); 
    }
}

public class WithdrawCommand : ICommand
{
    private BankAccount _bankAccount;
    private decimal _amount;

    public WithdrawCommand(BankAccount bankAccount, decimal amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }

    public void Execute()
    {
        _bankAccount.Withdraw(_amount);
    }
}

public class ATM
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
    public void ExecuteTransaction()
    {
        _command.Execute();
    }
}

/*public class Program
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount(1000);
        ATM atm = new ATM();
        ICommand deposit = new DepositCommand(bankAccount, 100);
        ICommand withdraw = new WithdrawCommand(bankAccount, 200);
        atm.SetCommand(deposit);
        atm.ExecuteTransaction();
        
        atm.SetCommand(withdraw);
        atm.ExecuteTransaction();
        
    }
}*/


// Chain of Responsibilty


// A - B - C - D 

public abstract class LeaveApprover
{
    protected LeaveApprover nextApprover;

    public void SetNextApprover(LeaveApprover nextApprover)
    {
        nextApprover = nextApprover;
    }

    public abstract void ApproveLeave(int days);
}
// Team Lead
public class TeamLeader: LeaveApprover
{
    public override void ApproveLeave(int days)
    {
        if (days <= 2)
        {
            Console.WriteLine($"Team Leader Approrver {days} days leave");
        } else if (nextApprover != null)
        {
            nextApprover.ApproveLeave(days);
        }
    }
}

public class Manager : LeaveApprover
{
    public override void ApproveLeave(int days)
    {
        if (days <= 7)
        {
            Console.WriteLine($"Manager Approver {days} days leave");
        }
        else if (nextApprover != null)
        {
            nextApprover.ApproveLeave(days);
        }
    }
}

public class Director : LeaveApprover
{
    public override void ApproveLeave(int days)
    {
        if (days <= 30)
        {
            Console.WriteLine($"Director Approver {days} days leave");
        }
        else
        {
            Console.WriteLine($"Leave Request for {days} days rejected");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        LeaveApprover teamLeader = new TeamLeader();
        LeaveApprover manager = new Manager();
        LeaveApprover director = new Director();
        teamLeader.SetNextApprover(manager);
        manager.SetNextApprover(director);
        
        teamLeader.ApproveLeave(1);
        teamLeader.ApproveLeave(5);
        teamLeader.ApproveLeave(15);
        teamLeader.ApproveLeave(40);
        
    }
}