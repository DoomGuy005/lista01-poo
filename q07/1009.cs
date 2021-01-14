using System;
class URI1009 {
    public void Salario() {
        string NAME = Console.ReadLine();
        double SALARY = Convert.ToDouble(Console.ReadLine());
        double SOLD = Convert.ToDouble(Console.ReadLine());
        double TOTAL = (SALARY + (0.15 * SOLD));
        Console.WriteLine($"TOTAL = R$ {TOTAL:0.00}");
    }
}