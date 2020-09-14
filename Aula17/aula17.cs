using System;

class Aula17{
    static void Main(){
        Console.Clear();

        int[] n=new int[5];
        int[] num=new int[5]{0, 2, 4, 6, 8};
        int[] lista={1, 2, 3, 4, 5};

        for (int i = 0; i < n.Length; i++){
            n[i] = num[i]*lista[i];
            Console.WriteLine("{0}",n[i]);
        }

        Console.WriteLine("{0}{1}{2}{3}{4}",n[0],n[1],n[2],n[3],n[4]);

    }
}