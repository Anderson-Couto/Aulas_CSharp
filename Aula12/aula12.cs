using System;

class Aula12{
    static void Main(){

        // > < >= <= == !=

        int nota;

        Console.WriteLine("Qual foi a nota do aluno?");
        nota=int.Parse(Console.ReadLine());

        if(nota >= 7){
            Console.WriteLine("Aprovado");
        } else {
            Console.WriteLine("Reprovado");
        }

    }
}