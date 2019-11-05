using System;

namespace GuessingGame
{
  class Logic {
    static int UserInput;
     static void Start() {
        Console.WriteLine("Greetings! Please provide a number in the range of 1 - 100:");
        const dynamic input = Console.ReadLine();
        if(input < 1 || input > 100) {
        Console.WriteLine("Invalid input.");
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
