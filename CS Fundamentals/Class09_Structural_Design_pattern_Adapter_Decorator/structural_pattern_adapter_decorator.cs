// Structural Pattern
// Adapter Design Pattern
// JSON -> XML
// Integrate Legacy Application
// Third API Integration
// OLD Interface to NEW ones

/*Advantages
 1. Legacy Code reuse
 2. Improves Code flexibility
 3. Easy Integration for third party APIS
*/ 
/* Disadvantages
 1. Layer add - So more complex
 2. Too many adapters
 3. Hard to debug
 */
using System;
using System.Xml;
using System.Xml.Linq;

public interface IDataProcessor
{
 void ProcessData(string processedData);
}

public class JsonDataProcessor : IDataProcessor
{
 public void ProcessData(string jsonData)
  {
    // jsonData process
    Console.WriteLine(jsonData);
  }
}

public class XMLDataProvider
{
 public string GetXMLData()
 {
  XDocument xmlDoc = new XDocument(
   new XElement("User",
    new XElement("Name", "Subhashis"),
    new XElement("Password", "1234"),
    new XElement("Age", 20)
    )
  );
  return xmlDoc.ToString();
 }
}

public class XmlToJsonAdapter : IDataProcessor
{
  private XMLDataProvider _xmlDataProvider;

  public XmlToJsonAdapter(XMLDataProvider xmlDataProvider)
  {
   _xmlDataProvider = xmlDataProvider;
  }

  public void ProcessData(string processedData)
  {
   string xmlData = _xmlDataProvider.GetXMLData();
   XDocument doc = System.Xml.Linq.XDocument.Parse(xmlData);
   string convertedJson = Newtonsoft.Json.JsonConvert.SerializeXNode(doc,
    Newtonsoft.Json.Formatting.Indented, true);
   Console.WriteLine(convertedJson);
  }
  
}

/*class Program
{
 static void Main()
 {
  
 }
}*/









// Decorator
/* Use case
1. Logging, Validation Mechanism
2. UI Components (Scrollbars, Borders)
3. Pricing System(Tax, Discount)
4. Security Layer(Login- Extra Auth)
*/
/* Advantage
 1. OCP Follow
 2. SRP Folow
 3. Add Behaviors dynamically at runtime
*/
/*Disadvantages
 1. More class 
 2. Hard to understand
 3. Debugging becomes difficult
 4. Order of decorator may affect behavior
*/
public interface ICoffee
{
 string GetDescription();
 double GetCost();
}

public class SimpleCoffee : ICoffee
{
 public string GetDescription()
 {
  return "Simple Coffee";
 }

 public double GetCost()
 {
  return 100.0;
 }
}

public abstract class CoffeeDecorator :ICoffee 
{
 public ICoffee _decoratedCoffee;

 public CoffeeDecorator(ICoffee coffee)
 {
  _decoratedCoffee = coffee;
 }

 public virtual string GetDescription()
 {
  return _decoratedCoffee.GetDescription();
 }

 public virtual double GetCost()
 {
  return _decoratedCoffee.GetCost();
 }
}

public class MilkDecorator : CoffeeDecorator
{
 public MilkDecorator(ICoffee coffee) : base(coffee)
 {
  
 }
 public override string GetDescription()
 {
  return _decoratedCoffee.GetDescription() + " With Milk";
 }
 public override double GetCost()
 {
  return _decoratedCoffee.GetCost() + 100;
 }
}
public class SugarDecorator : CoffeeDecorator
{
 public SugarDecorator(ICoffee coffee) : base(coffee)
 {
  
 }
 public override string GetDescription()
 {
  return _decoratedCoffee.GetDescription() + " With Sugar";
 }
 public override double GetCost()
 {
  return _decoratedCoffee.GetCost() + 150;
 }
}

public class Program
{
 public static void Main(string[] args)
 {
  ICoffee coffee = new SimpleCoffee();
  Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()}");
  coffee = new MilkDecorator(coffee);
  Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()}");
  coffee = new SugarDecorator(coffee);
  Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()}");
  
  
  ICoffee coffee1 = new SimpleCoffee();
  Console.WriteLine($"{coffee1.GetDescription()} - {coffee1.GetCost()}");
  coffee1 = new SugarDecorator(coffee1);
  Console.WriteLine($"{coffee1.GetDescription()} - {coffee1.GetCost()}");
  coffee1 = new MilkDecorator(coffee1);
  Console.WriteLine($"{coffee1.GetDescription()} - {coffee1.GetCost()}");
 }
}