using System;
class MainClass {
  public static void Main (string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        int vm = Convert.ToInt32(Console.ReadLine());
        double d = (vm * t);
        double q = (d / 12);
        Console.WriteLine($"{q:0.000}");
  }
}