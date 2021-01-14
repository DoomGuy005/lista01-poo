using System;
class URI1012 {
    public void Area() {
        string v = Console.ReadLine();
        string[] vsplit = v.Split(" ");
        double A = double.Parse(vsplit[0]);
        double B = double.Parse(vsplit[1]);
        double C = double.Parse(vsplit[2]);
        double pi = 3.14159;
        double TRIANGULO = (A * C)/2;
        double CIRCULO = (pi * (C*C));
        double TRAPEZIO = (((A + B)*C)/2);
        double QUADRADO = (B * B);
        double RETANGULO = (A * B);
        Console.WriteLine($"TRIANGULO: {TRIANGULO:0.000}\nCIRCULO: {CIRCULO:0.000}\nTRAPEZIO: {TRAPEZIO:0.000}\nQUADRADO: {QUADRADO:0.000}\nRETANGULO: {RETANGULO:0.000}");
    }
}