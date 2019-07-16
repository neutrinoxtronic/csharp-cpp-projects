using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Floorplan_Cost_Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      bool run = true;
      while (run)
      {
        double totalarea = CalculateTotalArea();

        Console.WriteLine("Would you like to calculate the associated costs as well? [y/n]");
        string calculateCost = Console.ReadLine();

        if(calculateCost.ToLower() == "y")
        {
          CalculateTotalCost(totalarea);
        }

        Console.WriteLine("\nWould you like to calculate another area? [y/n]");
        string calculateAnotherArea = Console.ReadLine();

        if(calculateAnotherArea.ToLower() == "n")
        {
          return;
        }
      }
      
    }

    static double CalculateTotalArea()
    {
      Console.WriteLine("\nStarting Area Calculator...\n");
      Console.WriteLine("How many rectangles (R), Trianges (T) and Ellipses (E) does your area have and what are the sizes of each?");
      Console.WriteLine("Input your answer in the following format: R(x1,y1) -R(x2,y2) ... T(b1, h1) -T(b2,h2) ... E(r1, r1) -E(r2, r2)");
      Console.WriteLine("Please note all units shall be in meters. \n");

      string instruction = Console.ReadLine();
      string pattern1 = "[-]*[RTE]\\(\\d+\\s*,\\s*\\d+\\)";
      string pattern2 = "\\d+";
      string matchValue;
      char matchType;
      List<string> num_list = new List<string>();
      double sumArea = 0;

      // Call Matches method without specifying any options.
      Match match = Regex.Match(instruction, pattern1);
      while (match.Success) 
      {

        matchValue = match.Groups[0].Captures[0].Value;

        if(matchValue[0] == '-' )
        {
          matchType = matchValue[1];
        }

        else 
        {
          matchType = matchValue[0];
        }

        num_list = NumListGenerator(matchValue, pattern2);

        switch(matchType)
        {
          case 'R':
            if(matchValue[0] == '-' )
              {
                sumArea -= Rect(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }
              else
              {
                sumArea += Rect(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }
            break;

          case 'T':
            if(matchValue[0] == '-' )
              {
                sumArea -= Triangle(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }
              else
              {
                sumArea += Triangle(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }

            break;

          case 'E':
            if(matchValue[0] == '-' )
              {
                sumArea -= Ellipse(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }
              else
              {
                sumArea += Ellipse(Int32.Parse(num_list[0]), Int32.Parse(num_list[1]));
              }
            
            break;

          default:
            Console.WriteLine("Invalid Input. Try Again\n");
            break;
        }

        match = match.NextMatch();

      }  
      
      // sumArea = CalculateShapeArea();
      sumArea = Math.Round(sumArea, 2);
      Console.WriteLine($"\nThe total area of your floorplan is {sumArea}m^2.\n");

      return sumArea;
    }

    static List<string> NumListGenerator(string matchValue, string pattern)
    {

      List<string> list = new List<string>();
      Match match = Regex.Match(matchValue, pattern);
      while (match.Success) 
      {
        list.Add(match.Groups[0].Captures[0].Value);
        match = match.NextMatch();
      };
      
      return list;   
    }

    static void CalculateTotalCost(double area){
      Console.WriteLine("What currency would you like to use to calculate the total cost of the property? [USD/GBP/..]  ");
      string currency = Console.ReadLine();

      Console.WriteLine("\nWhat is the price of the property per square meter?  ");
      double rate = Convert.ToDouble(Console.ReadLine());

      if (area != 0) {
        double cost = rate * area;
      	cost = Math.Round(cost, 2);
        area = Math.Round(area, 2);
      	Console.WriteLine($"\nThe total cost of your floorplan with the area of {area}m^2 is {cost} {currency}.\n");  
      }

      else
      {
        Console.WriteLine("\nCalculated area is 0. Are you sure you are inputting your data correctly?");
      }

    }
    
    static double Rect(double length, double width){
      return length * width;
    }
    
    static double Ellipse(double radius1, double radius2){
      return Math.PI * radius1 * radius2;
    }
    
    static double Triangle (double bottom, double height){
      return 0.5 * bottom * height;
    }
  }
}
