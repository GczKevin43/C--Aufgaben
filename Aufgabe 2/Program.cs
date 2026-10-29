using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie die Anzahl Tage des Monats ein:");
        string input = Console.ReadLine();

        int tage;

        if (!int.TryParse(input, out tage))
        {
            Console.WriteLine("Fehler: Ganzzahl erwartet");
        }
        else if (tage < 28 || tage > 31)
        {
            Console.WriteLine("Fehler: Zahl zwischen 28 und 31 erwartet");
        }
        else
        {
            int sekunden = tage * 24 * 60 * 60;
            Console.WriteLine("Anzahl Sekunden: " + sekunden);
        }
    }
}