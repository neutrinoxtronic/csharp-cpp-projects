using System;

namespace CreatureConstructor
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the ASCII Art Creature Constructor!");
      Console.WriteLine("Construct a random creature? [y/n]");
      string random = Console.ReadLine();
      if (random == "y")
      {
				RandomMode();
      }
      else
      {
        Console.WriteLine("Choose any of the following:");
        Console.WriteLine("head: [monster/ghost/bug]");
        string head = Console.ReadLine();
        Console.WriteLine("body: [monster/ghost/bug]");
        string body = Console.ReadLine();
        Console.WriteLine("feet: [monster/ghost/bug]");
        string feet = Console.ReadLine();
        BuildACreature(head, body, feet);   
      }
      
    }
    
    static void BuildACreature(string head, string body, string feet)
    {
      Console.WriteLine(head);
      Random randomNumber = new Random();
      int headNum;
      int bodyNum;
      int feetNum;
      
      if (head == "")
      {
        headNum = randomNumber.Next(1,4);
      }
      else 
      {
        headNum = TranslateToNumber(head);
      }
      
      if (body == "")
      {
        bodyNum = randomNumber.Next(1,4);
      }
      else  
      {
        bodyNum = TranslateToNumber(body);
      }
      
      if (feet == "")
      {
        feetNum = randomNumber.Next(1,4);
      }
      else
      {
        feetNum = TranslateToNumber(feet);
      }
      
      SwitchCase(headNum, bodyNum, feetNum);
    }
    
    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);
      SwitchCase(head, body, feet);
    }
    
    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
          MonsterHead();
          break;
        case 2:
          GhostHead();
          break;
        case 3:
          BugHead();
          break;
      }
      switch(body)
      {
        case 1:
          MonsterBody();
          break;
        case 2:
          GhostBody();
          break;
        case 3:
          BugBody();
          break;
      }
      switch(feet)
      {
        case 1:
          MonsterFeet();
          break;
        case 2:
          GhostFeet();
          break;
        case 3:
          BugFeet();
          break;  
      }
    }
    
    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "monster":
          return 1;
          break;
        case "ghost":
          return 2;
          break;
        case "bug":
          return 3;
          break;
        default:
          return 1;
          break;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
