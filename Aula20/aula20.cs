using System;

class Aula20{

    static void Main(){

        int i=1;
        double n = 30;

        while (true)
        {
            n=2*n-(i*i-5);
            Console.WriteLine("{0} - {1}",n,i);
            if(n<0){
                Console.WriteLine(n);
                break;
            }
            i++;
        }

    }

}