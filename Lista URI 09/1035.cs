using System;

class URI1035 {
    public void Teste1() {
        string[] v = Console.ReadLine().Split(@" ".ToCharArray());
        int A = int.Parse(v[0]);
        int B = int.Parse(v[1]);
        int C = int.Parse(v[2]);
        int D = int.Parse(v[3]);
        if (((B > C) && (D > A)) && ((C + D) > (A + B)) && (C > 0 && D > 0) && A % 2 == 0) {
            Console.WriteLine("Valores aceitos");
        }
        else {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}