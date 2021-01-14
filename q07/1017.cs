using System;
class URI1017 {
    public void Gasto() {
        int t = Convert.ToInt32(Console.ReadLine());
        int vm = Convert.ToInt32(Console.ReadLine());
        double d = (vm * t);
        double q = (d / 12);
        Console.WriteLine($"{q:0.000}");
    }
}