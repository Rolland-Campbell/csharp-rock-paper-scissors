using System;

namespace csharp_rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      bool running = true;
      while (running)
      {

        Random randNum = new Random();
        Console.WriteLine(@"
                        1. Rock
                        2. Paper
                        3. Scissors
                Choose your weapon (1-3):
                        ");
        string playerChoice = Console.ReadLine();

        try
        {

          int result = Int32.Parse(playerChoice); //this converts string input from ReadLine to Int.
          if (result < 1 || result > 3)
          {
            Console.WriteLine("Sorry, this is not a choice. \n");
            continue;
          }
          //players choice through a switch.
          switch (result)
          {
            case 1:
              Console.Clear();
              Console.WriteLine("You chose Rock \n");
              break;
            case 2:
              Console.Clear();
              Console.WriteLine("You chose Paper \n");
              break;
            case 3:
              Console.Clear();
              Console.WriteLine("You chose Scissors \n");
              break;
          }

          //The computer choice. Using a switch. 
          int resultComp = randNum.Next(1, 4);
          switch (resultComp)
          {
            case 1:
              Console.WriteLine("The computer chose Rock \n");
              break;
            case 2:
              Console.WriteLine("The computer chose Paper \n");
              break;
            case 3:
              Console.WriteLine("The computer chose Scissors \n");
              break;
          }
          //deciding who wins. 
          if (result == 1 && resultComp == 2 || result == 2 && resultComp == 3 || result == 3 && resultComp == 1)
          {
            Console.WriteLine("You LOSE!");
          }
          else if (result == 1 && resultComp == 3 || result == 2 && resultComp == 1 || result == 3 && resultComp == 2)
          {
            Console.WriteLine("You WIN!");
          }
          else
          {
            Console.WriteLine("It's a TIE");
          }
        }
        catch
        { //If any errors or incorrect inputs happen do this.
          Console.Clear();
          Console.WriteLine("No cheating, Pick a number between 1 and 3.");
        }
      }
    }
  }
}