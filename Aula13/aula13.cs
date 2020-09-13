using System;

class Aula13{

    static void Main(){
        
        int nota=4;

        if(nota>=8){
            Console.WriteLine("Aprovado");
        }
        else if(nota>=5) {
            Console.WriteLine("Recuperação");
        } else {
            Console.WriteLine("Reprovado");
        }
    }
}