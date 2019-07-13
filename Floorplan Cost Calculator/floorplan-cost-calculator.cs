using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
			CalculateTotalCost();
    }
    
    static void CalculateTotalCost(){
      Console.WriteLine("Select from one of the following plans:");
      Console.WriteLine("Teotihaucan");
      Console.WriteLine("Taj Mahal");
      Console.WriteLine("Al-Masjid al-haram");
      string plan = Console.ReadLine();
      double area = 0;
      double cost = 0;
      switch (plan){
        case "Teotihaucan":
          area = Rect(1500, 2500) + 0.5* Circle(375) + Triangle(750, 500);
          break;
        case "Taj Mahal":
          area = Rect(1500, 2500) + 0.5* Circle(375) + Triangle(750, 500);
          break;
        case "Al-Masjid al-haram":
          area = Rect(1500, 2500) + 0.5* Circle(375) + Triangle(750, 500);
          break;
        default:
          Console.WriteLine("Please select a valid floorplan");
          CalculateTotalCost();
          break;
      }
      
      if (area != 0) {
        cost = 180 * area;
      	cost = Math.Round(cost, 2);
      	Console.WriteLine($"The total cost of the {plan} is {cost} pesos");  
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
