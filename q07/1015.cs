using System;
class URI1015 {
    public void DistanciaP() {
        string[] x = Console.ReadLine().Split(@" ".ToCharArray());
        double x1 = Convert.ToDouble(x[0]);
        double y1 = Convert.ToDouble(x[1]);
        string[] y = Console.ReadLine().Split(@" ".ToCharArray());
        double x2 = Convert.ToDouble(y[0]);
        double y2 = Convert.ToDouble(y[1]);
        double soma = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        double d = Math.Sqrt(soma);
        Console.WriteLine($"{d:0.0000}");
    }
}