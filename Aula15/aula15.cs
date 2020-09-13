using System;

class Aula15{

    static void Main(){
        
        int tempo=0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG à Vitória/ES");
        Console.WriteLine("Escolha o Transporte:\n(a) Avião\n(b)ônibus\n(c)Carro");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a': case 'A':
                tempo=50;
                break;
            case 'b':
                tempo=480;
                break;
            case 'c':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }

        if(tempo<0){
            Console.WriteLine("Viagem indisponível");
        }else{
            Console.WriteLine("O tempo de viagem será {0} minutos", tempo);
        }
    }
}