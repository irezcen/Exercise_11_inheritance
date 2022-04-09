using System;

namespace C1_labolatorium_genetyczne_hierarchia_dziedziczeniea_
{
    class Program
    {
        static void Main(string[] args)
        {
            WGS test1 = new WGS(20, 5);
            Console.WriteLine(test1.Cost);
            Console.WriteLine(test1.AproxTme);
            test1.ChooseNumbersOfGenes(200);
            Console.WriteLine(test1.Cost + " " + test1.result.Count);
            test1.ChooseNumbersOfGenes(150);
            Console.WriteLine(test1.Cost + " " + test1.result.Count);
            Sanger test2 = new Sanger(20, 5);
            test2.ChooseGene(4);
            Console.WriteLine(test2.Cost);
            test1.ChooseMethod(2);
            test1.kindOfCircumstance[0] = "rybosomy produkują dwa razy więcej białek";
            Console.WriteLine(test1.AproxTme + " " + test1.Cost);
            Console.WriteLine(test1.kindOfCircumstance[0]);
            test1.result[2] = true;
            Console.WriteLine(test1.result[2] + " " + test1.result[148]);
        }
    }
}
