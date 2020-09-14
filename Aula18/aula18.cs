using System;

class Aula18{
    static void Main(){

        double[,] matriz=new double[3,3];

        for (int i = 0; i < matriz.GetLength(0); i++){
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                matriz[i,j] = Math.Pow(((i+j)*(i-j)),2);
                Console.Write(matriz[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }   
}