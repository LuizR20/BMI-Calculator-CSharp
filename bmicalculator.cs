using System;

public class Calculator
{
  public static void Main (string[] args)
  {
    Console.WriteLine("=== BMI Calculator ===");
    Console.WriteLine(" ");
    Console.WriteLine("To start, please, enter your weight (Kg)");
    double weight = Convert.ToDouble(Console.ReadLine().Replace(",", "."));
    
    Console.WriteLine(" ");
    Console.WriteLine("Perfect, now, enter your height (m)");
    double height = Convert.ToDouble(Console.ReadLine().Replace(",", "."));
    
    double BMI = weight / (height * height);
    
    Console.WriteLine(" ");
    Console.WriteLine($"Your BMI is {BMI:F2}");
   
    if (BMI <= 18.5)
    {
      Console.WriteLine("Category: Underweight");
    }
    else if (BMI <= 24.9)
    {
      Console.WriteLine("Category: Normal weight");
    }
    else if (BMI <= 29.9)
    {
      Console.WriteLine("Category: Overweight");
    }
    else if (BMI <= 34.9)
    {
      Console.WriteLine("Category: Obesity (Grade 1)");
    }
    else if (BMI <= 39.9)
    {
      Console.WriteLine("Category: Obesity (Grade 2)");
    }
    else if (BMI > 39.9)
    {
      Console.WriteLine("Category: Obesity (Grade 3/ Morbid)");
    }
  }
}