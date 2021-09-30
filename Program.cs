using System;

namespace Spaceman
{
  class Program
  {
    static void Main(string[] args)
    {
      Game g = new Game();
      g.greet();
    
      do 
      {
        g.display();
        g.ask();
      } while (!(g.didWin() || g.didLose()));
      
      if(g.didWin())
      {
        Console.WriteLine("Hooray! You saved the person!");
      }
      else {
        Console.WriteLine("Oh no! The UFO just flew away with another person!");
      }
    }
  }
}