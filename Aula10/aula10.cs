using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){
        
        DiasSemana ds1 = DiasSemana.Domingo;
        Console.WriteLine(ds1);

        DiasSemana ds2 = (DiasSemana)3;
        Console.WriteLine(ds2);

        int ds3 = (int)DiasSemana.Sexta;
        Console.WriteLine(ds3);

    }
}