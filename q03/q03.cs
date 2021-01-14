using System;
class Questao3 {
    public void PerguntarNome() {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Bem-Vindo ao C#, " + nome);
    }
} 