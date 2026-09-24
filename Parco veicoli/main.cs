#!/usr/bin/env dotnet
#:include *.cs
#:property Nullable=disable

class Program
{
    static void Main()
    {
        Flotta flotta = new Flotta();
        int scelta;

        do
        {
            Console.WriteLine("1. Inserisci Auto");
            Console.WriteLine("2. Inserisci Camion");
            Console.WriteLine("3. Visualizza flotta");
            Console.WriteLine("4. Costo totale manutenzione");
            Console.WriteLine("5. Esci");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: // Aggiungi auto
                    Console.Write("Targa: ");
                    string targaA = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marcaA = Console.ReadLine();
                    Console.Write("Modello: ");
                    string modelloA = Console.ReadLine();
                    Console.Write("Chilometri: ");
                    double kmA = double.Parse(Console.ReadLine());
                    Console.Write("Numero porte: ");
                    int porte = int.Parse(Console.ReadLine());
                    flotta.AggiungiVeicolo(new Auto(targaA, marcaA, modelloA, kmA, porte));
                    break;

                case 2: //aggiungi camion
                    Console.Write("Targa: ");
                    string targaC = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marcaC = Console.ReadLine();
                    Console.Write("Modello: ");
                    string modelloC = Console.ReadLine();
                    Console.Write("Chilometri: ");
                    double kmC = double.Parse(Console.ReadLine());
                    Console.Write("Capacità di carico: ");
                    double carico = double.Parse(Console.ReadLine());
                    flotta.AggiungiVeicolo(new Camion(targaC, marcaC, modelloC, kmC, carico));
                    break;

                case 3: //visualizza flotta
                    flotta.VisualizzaFlotta();
                    break;
                    
                case 4: //calcola costo totale manutenzione
                    Console.WriteLine($"Costo totale manutenzione: {flotta.CalcolaCostoTotaleManutenzione():F2} €");
                    break;
            }
        } while (scelta != 5);
    }
}
