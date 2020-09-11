using System;

class Aula06{
    static void Main(){

        int n1=10, n2=20, n3=30;

        Console.WriteLine("{0},\n\t{1},\n{2}\n",n1,n2,n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda = valorCompra*(1+lucro);

        Console.WriteLine("Produto.......:{0,15}",produto);
        Console.WriteLine("Val. Compra...:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro.........:{0,15:p}",lucro);
        Console.WriteLine("Val. Venda....:{0,15:c}",valorVenda);

    }
}