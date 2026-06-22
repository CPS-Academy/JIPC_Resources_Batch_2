// Iterator Design Pattern

/*Node - Next Pointer ----> Node , Next Pointer 
List, Array, Tree 

Tv Remote - Channel Change 
Music Player - Song Change 
Netflix Episode - Episode Change 
Advantages -
1) Internal Structure Hidden
2) Traversal Logic Separated - (SRP)
3) Multiple Traversals


Disadvantages
1) Need Iterator Class
2) Extra Complexity
3) Additional abstraction Layer

*/

public interface IIterator
{
    bool HasNext();
    string Next();
}

public class StudentIterator : IIterator
{
    public List<string> students;
    private int index = 0;

    public StudentIterator(List<string> students)
    {
        this.students = students;
    }

    public bool HasNext()
    {
        return index < students.Count;
    }

    public string Next()
    {
        return students[index++];
    }
}

public class StudentCollection
{
    private List<string> students = new List<string>();
    public void AddStudent(string name)
    {
        students.Add(name);
    }

    public IIterator CreateIterator()
    {
        return new StudentIterator(students);
    }
}
/*class Program 
{
    static void Main(string[] args)
    {
        StudentCollection studentCollection = new StudentCollection();
        studentCollection.AddStudent("John");
        studentCollection.AddStudent("Alice");
        studentCollection.AddStudent("Bob");
        studentCollection.AddStudent("Jane");
        
        IIterator studentIterator = studentCollection.CreateIterator();
        while (studentIterator.HasNext())
        {
            Console.WriteLine(studentIterator.Next());
        }
    }
}*/

// Mediator Design Pattern

/*
 Advantages:
 1) Loose Coupling
 2) Easier to maintain
 3) Reusability
 4) Scalability
 
 
 Disadvantages: 
 1) God Object - Mediator - Risky
 2) All communication in one place - More Complex logic
 3) Single Point of failure
 */

public interface IMediator
{
    void SendMessage(string message, User sender);
}

public class ChatMediator : IMediator
{
    public List<User> users =  new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }
    public void SendMessage(string message, User sender)
    {
        foreach (User user in users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}

public class User
{
    private IMediator mediator;
    public string Name { get; set; }
    public User(IMediator mediator, string name)
    {
        this.mediator = mediator;
        Name = name;
    }

    public void Send(string message)
    {
        mediator.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} Received : {message}");
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        ChatMediator mediator = new ChatMediator();
        
        User user1 = new User(mediator, "John");
        User user2 = new User(mediator, "Jane");
        User user3 = new User(mediator, "Alice");
        User user4 = new User(mediator, "Bob");
        mediator.AddUser(user1);
        mediator.AddUser(user2);
        mediator.AddUser(user3);
        mediator.AddUser(user4);
        
        user1.Send("Hello Everyone");
    }
}*/



// Observer design Pattern

//Subject - Channel 
// Subscribers - Observers

/*
 Advantages
 1) Loose Coupling
 2) Dynamic Subscription
 3) Open Closed Principle
 
 Disadvantages:
 1) Affect Performance - More Observers
 2) Hard to debug
 3) Memory Leaks 
 
 */

public interface IObserver
{
    void Update(string videoTitle);
}

public class Subscriber : IObserver
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void Update(string videoTitle)
    {
        Console.WriteLine($"{this.name} received Notification : {videoTitle}");
    }
}

public class YoutubeChannel
{
    private List<IObserver> observers = new List<IObserver>();

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void UploadVideo(string videoTitle)
    {
        Console.WriteLine($"New video title: {videoTitle}");
        foreach (IObserver observer in observers)
        {
            observer.Update(videoTitle);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        YoutubeChannel youtubeChannel = new YoutubeChannel();
        Subscriber s1 = new Subscriber("John");
        Subscriber s2 = new Subscriber("Alice");
        Subscriber s3 = new Subscriber("Bob");
        
        youtubeChannel.Subscribe(s1);
        youtubeChannel.Subscribe(s2);
        youtubeChannel.Subscribe(s3);
        youtubeChannel.UploadVideo("Observer Pattern 1 Video Tutorial");
        
        youtubeChannel.Unsubscribe(s1);
        youtubeChannel.UploadVideo("Observer Pattern 2 Video Tutorial");

    }
}







