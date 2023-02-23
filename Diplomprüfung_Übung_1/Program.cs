using System;

class Program {
    static void Main(string[] args) {
        // Variablen: Deklaration, Instanziierung, Zuweisungen, Datentypen, Sichtbarkeit, Umwandlungen
        int age = 25;
        string name = "John Doe";
        bool isAdult = true;

        // Methoden: Deklaration, Parameter, Rückgabewerte, Aufrufe
        int sum = Add(10, 20);
        Console.WriteLine($"Sum: {sum}");

        // Kontrollstrukturen: Bedingungen, boolsche Algebra, Verzweigungen, Schleifen
        if (age >= 18 && isAdult) {
            Console.WriteLine($"{name} is an adult.");
        } else {
            Console.WriteLine($"{name} is a minor.");
        }

        // Mathematische Funktionen
        int absValue = Math.Abs(-10);
        Console.WriteLine($"Absolute value: {absValue}");

        // Zeichenkettenmanipulationen = Schwerpunkt (Länge, Hinzufügen, Entfernen, Suchen, Ausschneiden)
        string message = "Hello, world!";
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Message length: {message.Length}");

        message = message + " How are you today?";
        Console.WriteLine($"Message: {message}");

        message = message.Remove(5, 7);
        Console.WriteLine($"Message: {message}");

        int index = message.IndexOf("you");
        string subString = message.Substring(index, 3);
        Console.WriteLine($"Substring: {subString}");

        // Anwenden von Arrays und Listen: Deklaration, Instanziierung, Zuweisung, Nutzung
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Numbers array: {string.Join(", ", numbers)}");

        int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        Console.WriteLine($"Matrix: {matrix[0, 1]}");

        List<string> names = new List<string>();
        names.Add("John");
        names.Add("Mary");
        names.Add("Peter");
        Console.WriteLine($"Names list: {string.Join(", ", names)}");

        // Webseiten (oder ähnliche, bekannte Protokolle, Dienste) verbinden, Daten abrufen, Daten senden, abgerufene Daten weiterverarbeiten
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        string response = string.Empty;

        using (var wc = new System.Net.WebClient()) {
            response = wc.DownloadString(apiUrl);
        }

        Console.WriteLine($"API response: {response}");

        // Textdateien erstellen, befüllen, auslesen
        string path = "output.txt";

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(path)) {
            file.WriteLine("This is a test.");
        }

        string content = System.IO.File.ReadAllText(path);
        Console.WriteLine($"File content: {content}");
    }

    static int Add(int a, int b) {
        return a + b;
    }
}
