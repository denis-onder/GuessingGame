using System;

namespace GuessingGame
{
  class Logic {
    private int UserInput;
    private int Result = 10;
     public void Start() {
      /**
       * Ask for user input
       * If the input is not valid, call this method again
       * Otherwise, go ahead and proceed on with the game.
       */
        Console.WriteLine("Greetings! Please provide a number in the range of 1 - 100:");
        int input = int.Parse(Console.ReadLine());
        if(input < 1 || input > 100) {
        Console.WriteLine("Invalid input.");
        Start();
      } else {
        UserInput = input;
        Guess();
      }
    }
    private bool Guess() {
      if(UserInput == Result) {
        return true;
      }
      return false;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      new Logic().Start();
    }
  }
}
