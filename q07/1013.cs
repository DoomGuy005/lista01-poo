using System;
class URI1013 {
    public void MaiorAB() {
        string s = Console.ReadLine();
        string[] ss = s.Split(@" ".ToCharArray());;
        int a = Convert.ToInt32(ss[0]);
        int b = Convert.ToInt32(ss[1]);
        int c = Convert.ToInt32(ss[2]);
        int maiorAB = ((a + b + Math.Abs(a-b))/2);
        int maiorABC = (maiorAB > c) ? maiorAB : c;
        Console.WriteLine($"{maiorABC} eh o maior");
    }
}