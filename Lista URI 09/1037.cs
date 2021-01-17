using System;

class URI1037 {
    public void Teste1() {
        double v = double.Parse(Console.ReadLine());
        bool um = (v >= 0 && v <= 25);
        bool dois = (v > 25 && v <= 50);
        bool tres = (v > 50 && v <= 75);
        bool quatro = (v > 75 && v <= 100);
        if (um) { Console.WriteLine("Intervalo [0,25]"); }
        if (dois) { Console.WriteLine("Intervalo (25,50]"); }
        if (tres) { Console.WriteLine("Intervalo (50,75]"); }
        if (quatro) { Console.WriteLine("Intervalo (75,100]"); }
        if (!um && !dois && !tres && !quatro) {Console.WriteLine("Fora de intervalo"); }
    }
}