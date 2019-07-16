using System;

namespace Floorplan_Cost_Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      double totalarea = CalculateArea();
      CalculateTotalCost(totalarea);
    }

    static double CalculateArea()
    {
      Console.WriteLine("Starting Area Calculator...");
      Console.WriteLine("How many rectangles (R), Trianges (T) and Circles (C) does your area have and what are the sizes of each?");
      Console.WriteLine("Input your answer in the following format: R(x1,y1) R(x2,y2) ... T(b1, h1) T(b2,h2) ... C(r1) C(r2)");
      Console.WriteLine("Please note all units shall be in meters");
      string instruction = Console.ReadLine();
      string pattern1 = "[RTC]\(\d+\s*,\s*\d+\)";
      string pattern2 = "\d+";
      double sumArea = 0;

      // Match match = Regex.Match("Item 3: #item3#", "#[^#]+#");
      // if (match.Success) {
      //     Console.WriteLine(match.Captures[0].Value); // Will output "#item3#"
      
      // Call Matches method without specifying any options.
      foreach (Match match1 in Regex.Matches(instruction, pattern1))
      {
        switch(match1.value[0])
        {
          case "R":
            break;
            num_list = NumListGenerator(Match match1, string pattern2);
            sumArea += Rect(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
          case "T":
            break;
            num_list = NumListGenerator(Match match1, string pattern2);
            sumArea += Triangle(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
          case "C":
            break;
            num_list = NumListGenerator(Match match1, string pattern2);
            sumArea += Circle(Int32.Parse(num_list[0]));
          default:
            Console.WriteLine("Invalid Input. Try Again");
            break;
        }
      }
      
      Console.WriteLine($"The total area of your floorplan is {sumArea}.");
    }

    static List<string> NumListGenerator(Match match, string pattern)
    {
      List<string> list = new List<string>;
      foreach (Match match2 in Regex.Matches(match.value[0], pattern))
        list.Add(match2.value);

      return list;   
    }

    static void CalculateTotalCost(double area){
      Console.WriteLine("What currency would you like to use to calculate the total of the property?")
      char currency = Console.ReadLine();

      Console.WriteLine("What is the price of the property per square meter?");
      double rate = Console.ReadLine();

      if (area != 0) {
        cost = rate * area;
      	cost = Math.Round(cost, 2);
      	Console.WriteLine($"The total cost of your floorplan with the area of {area}m is {cost}{currency}");  
      }

    }
    
    static double Rect(double length, double width){
      return length * width;
    }
    
    static double Circle(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }
    
    static double Triangle (double bottom, double height){
      return 0.5 * bottom * height;
    }
  }
}
