// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using MicrosoftLearn;
using Puzzle;
using Tests;


namespace Myapp
{

    internal class Program
  {
    private static int OverloadPlusMethod(int x, int y)
    {
      return x + y;
    }

    private static double OverloadPlusMethod(double x, double y)
    {
      return x + y;
    }

    // class Card
    // {
    //   public void DoSomething()
    //   {
    //     Console.WriteLine(helperMethod());
    //   }
    //   private string helperMethod()
    //   {
    //     return "Hello Jimmy from private helperMethod()";
    //   }
    // }
   
    
    // class Todo
    // {
    //   public string Description { get; set; } = String.Empty;
    //   public int EstimatedHours { get; set; }
    //   public  StatusEnum Status { get; set; }
    // }

   
    // enum StatusEnum
    // {
    //   NotStarted,
    //   InProgress,
    //   OnHold,
    //   Completed,
    //   Deleted
    // }
    static void Main(string[] args)
    {
    
      //info Imported METHODS & FUNCTIONS
      // BeginnerClass.Hello();
      //  Easy.FizzBuzz(2,4,7);
      // BeginnerClass.UnderstandArrays();
      // BeginnerClass.IfDecisionStatement();
      // BeginnerClass.IterationStatement();
      // BeginnerClass.PrintReversedString("Hallåpppåååå");

      //info Overload
      // int myNum1 = OverloadPlusMethod(1, 2);
      // double myNum2 = OverloadPlusMethod(1.2, 2.3);

      //info Coding test
      // string inputValue = "The quick brown fox jumps over the lazy dog";
      // Console.WriteLine($"CodingTest.isPangram: {CodingTest.isPangram(inputValue)}");

      //info, CLASSES & OBJECTS
      Person alien = new Person() 
      {
        Age = 235, 
        Gender = "male & female", 
        HairLength = HairLengthEnum.Bald, 
        HairColor="Gray", 
        NumberArms = 5, 
        NumberLegs = 4
      };
      
      Person clone1 = new();
      clone1.Gender = "male";
      clone1.NumberLegs = 4;
      clone1.HairColor = "black";

      Person baby = new Person();
      // Console.WriteLine(baby.Age);

      //info How to create new Intiance + Initialize values
      Person clone4 = new Person 
      {
        Age = 3, 
        Gender = "male", 
        HairLength = HairLengthEnum.Bald, 
        HairColor="Green", 
        NumberArms = 5, 
        NumberLegs = 4
      };

      //! change property value with other instance
      Person clone2 = clone1;
      // Console.WriteLine($"clone1 IsAlien?: {clone1.IsAlien()}"); // True
      clone2.NumberLegs = 2;
      // Console.WriteLine($"clone1 IsAlien?: {clone1.IsAlien()}"); // False
      // How to remove "handle", instance/reference 
      clone2 = null;
      

      //info Scope & Accessibility Modifiers
      // Console.WriteLine($"string s: {s}");
      // HelperFunc();
      Card myCard = new Card();
      // myCard.DoSomething();

      //info Object initializer (no constructor needed)
      Book myBook = new Book() {Title = "Title Book", Author = "Jimmy auth", ISBN = "0-000-0000-0"};
      Book myBook1 = new Book() {Title = "Spring", Author = "Spring", ISBN = "1-111-1111-1"};

      //info Generic List<T> Array[...]
      List<Book> myBookList = [myBook, myBook1];
      // myList.Add(clone1); //! ERROR myList can only contain type Book

      //info Object initializer (no constructor needed)
      Car myCar = new Car() { Make = "Nissa", Model = "GT-R", VIN = "N0"};
      Car myCar1 = new Car() { Make = "Toyota", Model = "Supra", VIN = "T1"};

      //info Generic Dictionary<TKey, TValue> {key: value}
      Dictionary<string, Car> myDictionary = new()
      {
          { myCar.VIN, myCar },
          { myCar1.VIN, myCar1 },
          // { myBook.ISBN, myBook }, //! ERROR myDictionary can only contain type Car
      };

      //info Collection initializer
      List<Car> carCollection = new List<Car>()
      {
        new Car {Make="Toyota", Model="Prius", VIN="T12"},
        new Car {Make="Volvo", Model="v70", VIN="V1"},
      };

      //info Enum(erations)
      // List<Todo> myTodos = new List<Todo>() 
      // {
      //   new Todo {Description ="Walk My Dog", EstimatedHours = 1, Status = StatusEnum.Completed},
      //   new Todo {Description ="Dishes", EstimatedHours = 1, Status = StatusEnum.OnHold},
      //   new Todo {Description ="Walk", EstimatedHours = 2, Status = StatusEnum.NotStarted},
      //   new Todo {Description ="Homework", EstimatedHours = 2, Status = StatusEnum.Deleted},
      //   new Todo {Description ="Shopping", EstimatedHours = 2, Status = StatusEnum.InProgress},
      // };

      // //info Switch Statement
      // foreach (var todo in myTodos)
      // {
      //   switch (todo.Status)
      //   {
      //     case StatusEnum.NotStarted:
      //       Console.ForegroundColor = ConsoleColor.Red;
      //       break;
      //     case StatusEnum.OnHold:
      //       Console.ForegroundColor = ConsoleColor.Yellow;
      //       break;
      //     case StatusEnum.InProgress:
      //       Console.ForegroundColor = ConsoleColor.Blue;
      //       break;
      //     case StatusEnum.Completed:
      //       Console.ForegroundColor = ConsoleColor.Green;
      //       break;
      //     case StatusEnum.Deleted:
      //       Console.ForegroundColor = ConsoleColor.White;
      //       break;
      //     default:
      //       break;
      //   }
      //   Console.WriteLine(todo.Description);
      // }
      //info Better Todo

      // Declare MyTodoList
      List<string> myTodoList = new List<string>();
      bool isOn = true;
      while (isOn)
      {

      Console.WriteLine("Here are your options for TodoList:");
      Console.WriteLine("0 - exit");
      Console.WriteLine("1 - View todos");
      Console.WriteLine("2 - Add todo");
      Console.WriteLine("3 - Delete todo");

      string userInput = Console.ReadLine();

      //info make string to int
      bool optionParseResult = int.TryParse(userInput, out int optionId);
      Console.WriteLine(userInput);
      if(!optionParseResult)
      {
        Console.WriteLine("This option is not valid, try again.");
        continue;
      }
      //info EXIT Todo App
        if(optionId == 0)
      {
        isOn = false;
        break;
      }
      //info VIEW all Todos
        if(optionId == 1)
      {
        Console.WriteLine("Your Todos");
        foreach(string todoItem in myTodoList)
        {
          Console.WriteLine(todoItem);
        }
        
      }
      //info Add TodoItem
      else if(optionId == 2)
      {
        Console.WriteLine("Enter new Todo item to list.");
        string newTodoListItem = Console.ReadLine();
        //Todo: validate input
        myTodoList.Add(newTodoListItem);

      }
      else
      {

      }
      }
      Console.WriteLine("Thanks for Using my Todo App");

    } // END static void Main

    // ? BLOCK SCOPE in C#
    private static string s = "string";

    static void HelperFunc()
    {
      Console.WriteLine($"string s access from HelperFunc: {s}");
    }

  }
  

}
