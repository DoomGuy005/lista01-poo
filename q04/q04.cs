using System;
class Questao4 {    
    public void Media() {
        Console.WriteLine("Digite a nota do 1º bimestre: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do 2º bimestre: ");
        int n2 = int.Parse(Console.ReadLine());
        int media = (((n1* 2) + (n2 * 3)) / 5);
        Console.WriteLine("Media do aluno: "+ media);
    }
}