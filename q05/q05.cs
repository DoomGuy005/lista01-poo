using System;
class Questao5 {
    public void Calcula() {
        Console.WriteLine("Digite a base e a altura do retângulo: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int area = (a * b);
        int perimetro = ((b * 2) + (a * 2));
        double diagonal = Math.Sqrt((a*a) + (b*b));
        Console.WriteLine("Área = {0} - Perímetro = {1} - Diagonal = {2}", area, perimetro, diagonal.ToString("0.00"));
    }
}