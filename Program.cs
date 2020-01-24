using System;
using System.Collections.Generic;
using RoS.Models;
using System.Linq;

namespace RiddlesOfTheSphinx
{
  public class Program
  {
    public static void Main()
    {
      Sphinx first = new Sphinx("You can see me in water, but I never get wet. What am I?", "reflection", 1);
      Sphinx second = new Sphinx("The more you take, the more you leave behind. What am I?", "footsteps", 2);
      Sphinx third = new Sphinx("I can fly but have no wings. I can cry but have no eyes. Wherever I go, darkness follows me. What am I?", "clouds", 3);

      List<Sphinx> Riddles = new List<Sphinx>() {first, second, third};

      Console.WriteLine("Welcome to the Sphinx! You are now trapped in my Riddle Chamber and can only be let go if you answer all of my riddles correctly!");
      Console.WriteLine("As soon as you give a wrong answer, you're life will be put to an end at once!");
      Console.WriteLine("Hit 'enter' to start...");
      string start = Console.ReadLine();
      
      string t = "t";
      while(t == "t")
      {
        Console.WriteLine("Riddle " + first.GetOrder() + ". " + first.GetRiddle());
        string answer1 = Console.ReadLine();

        if(first.CheckAnswer(answer1))
        {
          Console.WriteLine("That is correct! Hit enter to see the next question...");
          Console.ReadLine();

          Console.WriteLine(second.GetRiddle());
          string answer2 = Console.ReadLine();

          if(second.CheckAnswer(answer2))
          {
            Console.WriteLine("That is correct! Hit enter to see the next question...");
            Console.ReadLine();

            Console.WriteLine(third.GetRiddle());
            string answer3 = Console.ReadLine();

            if(third.CheckAnswer(answer3))
            {
              Console.WriteLine("Good golley. You got all 3 riddles right. Good job.");
            }
            else
            {
              Console.WriteLine("Nope, you lose. Hit 't' to try again. Or hit enter if you give up.");
              t = Console.ReadLine();
            }
          }
          else
          {
            Console.WriteLine("That is wrong. You lose. Hit 't' to try again. Or hit enter if you give up.");
            t = Console.ReadLine();
          }
        }
        else
        {
          Console.WriteLine("That is wrong. You lose. Hit 't' to try again. Or hit enter if you give up.");
          t = Console.ReadLine();
        }
      }
    }
  }
}
