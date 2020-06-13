using System;

class Program
{
    static void Main(string[] args) {
        // Testübergabewert
        int testwert = 125;

        // Ausgabe
        Console.WriteLine("Eingabewert: " + testwert);
        Console.WriteLine(); // Leerzeile

        Console.WriteLine("Ausgabe via dezimalZuAll:");
        Zahlensysteme.dezimalZuAll(testwert);

        Console.WriteLine(); // Leerzeile
        Console.WriteLine("Ausgabe via direktem Aufruf:");
        Console.Write("dezimalZuDual: ");
        Console.WriteLine(Zahlensysteme.dezimalZuDual(testwert));
        Console.Write("dezimalZuOcta: ");
        Console.WriteLine(Zahlensysteme.dezimalZuOcta(testwert));
        Console.Write("dezimalZuHex: ");
        Console.WriteLine(Zahlensysteme.dezimalZuHex(testwert));
    }
}


static class Zahlensysteme
{
    public static void dezimalZuAll(int Dezimalzahl) {
        Console.Write("dezimalZuDual: ");
        Console.WriteLine(dezimalZuDual(Dezimalzahl));
        Console.Write("dezimalZuOcta: ");
        Console.WriteLine(dezimalZuOcta(Dezimalzahl));
        Console.Write("dezimalZuHex: ");
        Console.WriteLine(dezimalZuHex(Dezimalzahl));
    }

    public static string dezimalZuDual(int Dezimalzahl) {
        // Verwende interne Methode um redundanz zu minimieren
        return dezimalZuBasis(Dezimalzahl, 2);
    }

    public static string dezimalZuOcta(int Dezimalzahl) {
        // Verwende interne Methode um redundanz zu minimieren
        return dezimalZuBasis(Dezimalzahl, 8);
    }

    public static string dezimalZuHex(int Dezimalzahl) {
        // Verwende interne Methode um redundanz zu minimieren
        return dezimalZuBasis(Dezimalzahl, 16);
    }

    private static string dezimalZuBasis(int Dezimalzahl, int Basis) {
        string output = " (^" + Basis + ")";

        // Ziffern für die Ausgabe festlegen. Bis zu 16 werden im Hexadezimalsystem benötigt
        char[] ziffer = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        // Umwandlung der Zahl mithilfe des Restwertverfahrens
        while (Dezimalzahl > 0) {
            // Die Ausgangszahl wird durch die Basis geteilt

            // Der Rest stellt die aktuelle Ziffer dar
            int aktuelleZiffer = Dezimalzahl % Basis;

            // Ziffer dem Ausgabestring vorne anhängen
            output = ziffer[aktuelleZiffer] + output;

            // Die verbleibende Ganzzahl wird für den nächsten Durchlauf verwendet
            // Integer speichert nur die Ganzzahl, deshalb reicht diese Operation
            Dezimalzahl = Dezimalzahl / Basis;
        }

        return output;
    }

}

