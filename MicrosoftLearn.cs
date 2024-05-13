namespace MicrosoftLearn;
public class BeginnerClass
{
    public static void Hello()
    {
        Console.WriteLine("Hello there from namespace MicrosoftLearn !");
            
    }

    public static void UnderstandArrays()
    {
        string [] familyNames = new string[4];
        familyNames[0] = "Jimmy";
        familyNames[1] = "Vanessa"; 
        familyNames[2] = "Sean"; 
        familyNames[3] = "Melody"; 
        foreach (var name in familyNames)
        {
            Console.WriteLine(name);
        }

        string[] cars = new string[] {"Audi", "BMW", "Volvo"};
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    public static void IfDecisionStatement()
    {
    bool isGoing = true;
    while(isGoing)
    {
        Console.Write("Choose a door: 1, 2, 3. ");

        string userValue = Console.ReadLine();
        string message;

        if(userValue == "1")
        {
        message = "Gratzz";
        isGoing  = false;
        }
        else if(userValue == "2" || userValue == "3")
        {
        message = userValue == "2" ? "Lose" : "Try again!";
        }
        else
        {
        message = "Check your input.";
        }
        Console.WriteLine(message);
    }
    
    }

    public static void IterationStatement()
    {
    int years = 20;
    for (int i = 0; i < years; i++) 
    {
        Console.WriteLine($" {i + 1} Hipp hipp hurra! ");
    }
    }

    private static string ReverseString(string message)
    {
    char[] messageArray = message.ToCharArray();
    Array.Reverse(messageArray);
    return String.Concat(messageArray);
    }
    
    public static void PrintReversedString(string toReverse)
    {
    Console.WriteLine(ReverseString(toReverse));
    }

     

}

//info Enum(erations)
public enum HairLengthEnum
{
    Long,
    Short,
    Bald
}

public class Person
{
    public string Gender { get; set; }
    public int NumberLegs { get; set; }
    public int NumberArms { get; set; }
    public string HairColor { get; set; }
    public HairLengthEnum HairLength { get; set; }
    public int Age { get; set; }
    public bool IsAlien()
    {
        return NumberLegs > 2 || NumberArms > 2;
    }

    // Constructor for default values
    public Person()
    {
        this.Gender = "mix";
        this.NumberLegs = 2;
        this.NumberArms = 2;
        this.HairColor = "Brown";
        this.Age = 0;
        this.HairLength = HairLengthEnum.Short;
    }
    // Overloaded constructor
    public Person(string gender, int numberLegs, int numberArms, string hairColor, int age, HairLengthEnum hairLength)
    {
        this.Gender = gender;
        this.NumberLegs = numberLegs;
        this.NumberArms = numberArms;
        this.HairColor = hairColor;
        this.Age = age;
        this.HairLength = hairLength;
    }
}

public class Book
    {
      public string Title { get; set; } = string.Empty;
      public string Author { get; set; } = string.Empty;
      public string ISBN { get; set; } = string.Empty;
    }

public class Card
    {
      public void DoSomething()
      {
        Console.WriteLine(helperMethod());
      }
      private string helperMethod()
      {
        return "Hello Jimmy from private helperMethod()";
      }
    }

class Car
   {
    public string Make { get; set; } = string.Empty;
    public string Model { get; set;} = string.Empty;
    public string VIN { get; set; } = string.Empty;
   }