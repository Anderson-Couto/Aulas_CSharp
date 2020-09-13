using System;

class Aula16{

    static void Main(){

        inicio:
        Console.Clear();
        
        Console.WriteLine("Bem Vindo! Para onde deseja ir?");
        
        Console.WriteLine("(a)Caso A\n(b)Caso A");
        char opcao=char.Parse(Console.ReadLine());

        switch(opcao){
            case 'a':
                goto casoA;
            case 'b':
                goto casoB;
            default:
                goto casoDef;
        }

        casoA:
        Console.WriteLine("Bem Vindo ao Caso A");
        goto casoDef;

        casoB:
        Console.WriteLine("Bem Vindo ao Caso B");
        goto casoDef;


        casoDef:
        Console.WriteLine("Deseja voltar ao início? s/n");
        char opcao2=char.Parse(Console.ReadLine());
        if(opcao2=='s'){
            goto inicio;
        }else{
            Console.WriteLine("Tchau");
        }
    }
}