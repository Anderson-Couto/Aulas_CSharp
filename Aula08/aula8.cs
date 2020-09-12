using System;

class Aula08{
    static void Main(){
        int vl1, vl2, soma;
        //string nome;

        /*
        Console.Write("Digite seu nome: ");
        nome=Console.ReadLine();
        Console.Write(nome);
        */

        Console.Write("Digite o primeiro valor: ");
        vl1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        vl2=Convert.ToInt32(Console.ReadLine());
        soma=vl1+vl2;

        Console.Write("A soma é : {0}", soma);


    }
}