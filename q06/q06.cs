using System;
class Questao6 {
    public void CalcularDistancia() {
        Console.WriteLine("Digite o horário no formato HH:MM:SS: ");
        string horario = Console.ReadLine();
        int h = 3600 * int.Parse(horario.Substring(0, 2));
        int m = 60 * int.Parse(horario.Substring(3, 2));
        int s = h + m + int.Parse(horario.Substring(6, 2));
        ulong distancia = Convert.ToUInt64(s) * 300000;
        Console.WriteLine(distancia);
    }
}