using System;
/*
            * Un semplice calcolatore
            * Realizzare un programma che chiede all'utente che tipo di operazione intende
            * svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
            * e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
            * chiede un solo valore e se media chiede 10 valori.
            * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
            * Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
            * */
namespace esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finito = false;
            while(!finito)
            {
                Console.WriteLine("Sceglirer l'operazione da eseguire");
                Console.WriteLine("0-somma 1-prodotto 2-divisione 3-sottrazione 4-potenza 5-media 9-esci dal programma");
                int iChoise = Convert.ToInt32(Console.ReadLine());
                double[] results;
            
                if(iChoise == 0)
                {
                    results = new double[2];
                    for(int i=0; i < results.Length; i++)
                    {
                        Console.WriteLine("inserisci numero:");
                        results[i] = Convert.ToDouble(Console.ReadLine());
                    };
                    double fSomma = results[0] + results[1];
                
                    Console.WriteLine("Risultato: {0} + {1} = {2}", results[0], results[1], fSomma);
                }
                else if(iChoise == 1)
                {
                    results = new double[2];
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine("inserisci numero:");
                        results[i] = Convert.ToDouble(Console.ReadLine());
                    };
                    double fProdotto = results[0] * results[1];

                    Console.WriteLine("Risultato: {0} + {1} = {2}", results[0], results[1], fProdotto);
                }
                else if (iChoise == 2)
                {
                    results = new double[2];
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine("inserisci numero:");
                        results[i] = Convert.ToDouble(Console.ReadLine());
                    };
                    double fDivisone = results[0] / results[1];

                    Console.WriteLine("Risultato: {0} x {1} = {2}", results[0], results[1], fDivisone);
                }
                else if (iChoise == 3)
                {
                    results = new double[2];
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine("inserisci numero:");
                        results[i] = Convert.ToDouble(Console.ReadLine());
                    };
                    double fSottrazione = results[0] - results[1];

                    Console.WriteLine("Risultato: {0} - {1} = {2}", results[0], results[1], fSottrazione);
                }
                else if (iChoise == 4)
                {
                    results = new double[1];
                    Console.WriteLine("Inserisci un numero");
                    results[0] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci la potenza a cui vuoi elevare");
                    double dPotenza = Convert.ToDouble(Console.ReadLine());

                    double dRisultatoPotenza = Math.Pow(results[0], dPotenza);
                    Console.WriteLine("{0} elevato alla {1} da {2}", results[0], dPotenza, dRisultatoPotenza);

                
                }
                else if (iChoise == 5)
                {
                    
                    double dSomma = 0;
                    results = new double[10];
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine("inserisci numero:");
                        results[i] = Convert.ToDouble(Console.ReadLine());
                    };

                    foreach (double element in results)
                    {
                        dSomma =+ element;
                    }
           
                    double dAverage = dSomma / results.Length;
                    Console.WriteLine("la media dei numeri precedentemente inseriti é: {0}", dAverage);
                    
                }
                else if(iChoise == 9)
                {
                    finito = true;
                }
            }
        }
            
    }
}