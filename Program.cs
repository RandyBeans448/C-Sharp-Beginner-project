using System;

namespace NumberGuesser {
  class Program {
    static void Main(string[] args) {

      GetAppInfo();

      GreetUser();

      while (true) {
        //Create random number
        Random random = new Random();

        //Set starting number
        int correctNumber = random.Next(1, 11);

        //Init guess
        int guess = 0;

        //Ask user for number
        Console.WriteLine("Guess a number between 1 and 10");

        while (guess != correctNumber) {
          //Get users input
          string inputNumber = Console.ReadLine();

          //Make sure its a number
          if (!int.TryParse(inputNumber, out guess)) {

            PrintColorMessage(ConsoleColor.Red, "That is not a number, please use an actual number");

            //Keep going
            continue;
          }

          //Cast to int and put it in Guess
          guess = Int32.Parse(inputNumber);

          //Match guess to correct number
          if (guess != correctNumber) {
     
            PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");    

          } else {

            PrintColorMessage(ConsoleColor.Cyan, "You are correct, well done!");   

            //Ask to play again
            Console.WriteLine("Play again? [Y or N]");

            //Get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y") {
              continue;
            } else if (answer == "N") {
              return;
            } else {
              return;
            }
          }
        }
      }
    }

    static void GetAppInfo() {
      //Set up app vars
      string appName = "Number Guesser";
      string appVersion = "1.0.0";
      string appAuthor = "Dominic Bishop";
      string codeSource = "Brad Traversy";

      //Change text to green
      Console.ForegroundColor = ConsoleColor.Green;

      //App info printed
      Console.WriteLine("{0} Version {1} by {2}: Orginal code from {3}.", appName, appVersion, appAuthor, codeSource);

      //Text colour reset
      Console.ResetColor();
    }

    static void GreetUser() {
      //Asking users name
      Console.WriteLine("What is your name?");

      //Get user input
      string inputName = Console.ReadLine();

      //Prints players name
      Console.WriteLine("Hello {0}, lets play Number Guesser!", inputName);
    }

    static void PrintColorMessage(ConsoleColor color, string message) {
             //Change colour to Red
            Console.ForegroundColor = color;

            //Try again prompt
            Console.WriteLine(message);

            //Text colour reset
            Console.ResetColor();
    }
    
  }
}