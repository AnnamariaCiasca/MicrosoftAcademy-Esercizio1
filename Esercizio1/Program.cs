//Scrivere un programma che consente all'utente di inserire due numeri
//Scegliere che operazione compiere fra i due numeri e stampare il risultato
//L'utente deve poter ricominciare dall'inserimento dei numeri
//finché non sceglie di uscire

using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)

        {
            char continua;

            do
            {

                Console.WriteLine("\nInserire primo numero: ");
                int x = int.Parse((Console.ReadLine()));
                Console.WriteLine($"Hai inserito il numero: {x}");

                Console.WriteLine("\nInserire secondo numero: ");
                int y = int.Parse((Console.ReadLine()));
                Console.WriteLine($"Hai inserito il numero: {y}");


                Console.WriteLine("\nScegli quale operazione compiere: " +
                    "\n a)Addizione" +
                    "\n b)Sottrazione" +
                    "\n c)Moltiplicazione" +
                    "\n d)Divisione\n");

                string scelta = Console.ReadLine();


                switch (scelta)
                {
                    case "a":
                        int somma = x + y;
                        Console.WriteLine($"\nIl risultato dell'addizione {x} + {y} è: {somma} ");

                        break;

                    case "b":
                        int diff = x - y;
                        Console.WriteLine($"\nIl risultato della sottrazione {x} - {y} è: {diff} ");

                        break;

                    case "c":
                        int prodotto = x * y;
                        Console.WriteLine($"\nIl risultato della moltiplicazione {x} * {y} è: {prodotto} ");

                        break;

                    case "d":
                        if (y == 0)
                        {
                            Console.WriteLine($"\nNon è possibile eseguire la differenza perché il dividendo è 0");
                        }
                        else
                        {
                            double divisione = (double)x / y;
                            Console.WriteLine($"\nIl risultato della divisione {x} / {y} è: {divisione} ");
                        }
                        break;

                    default:
                        Console.WriteLine("Scelta errata");
                        break;
                }

                Console.WriteLine("\nContinuare? s/n");
                continua = Console.ReadKey().KeyChar;

            } while (continua == 's' || continua == 'S');


        }
    }
}
