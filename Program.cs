using System;

class URI
{
    static void Main(string[] args)
    {
        string palavra1, palavra2, palavra3;

        string[] vet = Console.ReadLine().Split(' ');
        palavra1 = (vet[0]);
        palavra2 = (vet[1]);
        palavra3 = (vet[2]);

       
        if (palavra1 == "vertebrado" )
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
               else if (palavra3 == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
        } 
        if (palavra2 == "mamifero")
        {
            if (palavra3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (palavra3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
        }
       if ((palavra1 == "invertebrado"))
        {
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (palavra3 == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
        }
        if (palavra2 == "anelideo")
        {
            if (palavra3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (palavra3 == "onivoro")
            {
                Console.WriteLine("");
            }
        }
    }
}