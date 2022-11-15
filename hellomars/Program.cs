using System;

namespace snallWeeks_lab_firstDotNetApp
{
    class Program
  {
    private static string greet(string namePassedIn)
    {
      return "Welcome to SALT, "+ namePassedIn;
    }
    static void Main(string[] args)
    {
      Console.Write("What is your name? ");
      var name = Console.ReadLine();
      
      string greeting = greet(name);
      //------------------------------------------------
      DateTime startDate = new DateTime(2023,01,09,0,0,0);
      //-------------------------------------------------
      DateTime todaysDate = DateTime.Now;
      TimeSpan value = startDate.Subtract(todaysDate);
      
      //-------------------------------------------------
      Console.WriteLine("\n" + greeting);
      Console.WriteLine("When does that course start? " + startDate.ToString("yyyy/MM/dd"));
      Console.WriteLine("Today it is {0} days left until the course starts",Math.Round(value.TotalDays));
    }
  }
}
