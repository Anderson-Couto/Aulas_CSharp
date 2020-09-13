using System;

class Aula14{

    static void Main(){
        
        int nota;

        Console.WriteLine("Qual foi a nota do Aluno?");
        nota=int.Parse(Console.ReadLine());
        
        if ((nota>100)|(nota<0)){
            Console.WriteLine("Nota inválida.");
        }else{
            if (nota>=50) {
                if(nota>=75){
                    Console.WriteLine("Nota {0}. Aprovado.", nota);
                }else{
                    Console.WriteLine("Nota {0}. Recuperação.", nota);
                }
            }else{
                Console.WriteLine("Nota {0}. Reprovado.", nota);
            }
        }      
    }
}
