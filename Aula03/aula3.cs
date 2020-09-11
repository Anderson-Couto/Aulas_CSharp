using System;

class Aula03{
    static void Main(){
        //variaveis locais
        byte n1=10; //entre 0 e 255
        int num=-10;
        char letra='c'; //apenas 1 caractere
        float valor=5.3f;
        string nome="Anderson";

        var aux=nome;

        Console.WriteLine("Valor das variaveis: " + aux + ". . .");


        int num1, num2, soma;

        num1=10;
        num2=2;
        soma = num1 + num2;

        Console.WriteLine("A soma é:" + soma + ". . .");
        Console.WriteLine("A multiplicação é: " + num1*num2 + ". . .");



    }
}