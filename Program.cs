// See https://aka.ms/new-console-template for more information
using DIKUCanteen;

static void Main(string[] args)
{
    // Opretter kantinen
    Canteen kantine = new Canteen("DIKU Kantine", 2);
    Console.WriteLine("Antal kopper i kantinen inden nogen handlinger: " + kantine.Cups);

    // Opretter studerende
    Student studerende1 = new Student("Jonas", "Studerende", 21);
    Student studerende2 = new Student("Adam", "Studerende", 20);
    Student studerende3 = new CanteenBoardMember("MinH", "KantineBestyrelsesMedlem", 19);


    // Demonstrere at studerende tager kopper, når der er tilgængelige kopper
    Console.WriteLine("\nFørste forsøg på at tage en kop:");
    studerende1.TakeCup(kantine);
    Console.WriteLine("Antal kopper i kantinen efter første forsøg: " + kantine.Cups);

    Console.WriteLine("\nAndet forsøg på at tage en kop:");
    studerende2.TakeCup(kantine);
    Console.WriteLine("Antal kopper i kantinen efter andet forsøg: " + kantine.Cups);

    // Prøve at tage kopper, når der ikke er nogen tilgængelige
    Console.WriteLine("\nForsøg på at tage kopper, når person allerede har en");
    studerende1.TakeCup(kantine);
    Console.WriteLine("Antal kopper i kantinen efter forsøg på at tage kopper, når person allerede har en " + kantine.Cups);
    
    Console.WriteLine("\nForsøg på at tage kopper, når der ikke er nogen tilgængelige men personen er et kantinebestyrelsesmedlem og køber 10 og tager 1.");
    studerende3.TakeCup(kantine);
    Console.WriteLine("\nAntal kopper i kantinen efter der ikke var flere og katninebestyrelsesmedlemet købte 10 og tog 1. Kopper:" + kantine.Cups);

    // Købe kopper med et kantinebestyrelsesmedlem
    Console.WriteLine("\nKøbe kopper med et kantinebestyrelsesmedlem:");
    CanteenBoardMember bestyrelsesmedlem1 = new CanteenBoardMember("Lars", "Kantinebestyrelsesmedlem", 30);
    bestyrelsesmedlem1.BuyCup(kantine);
    Console.WriteLine("Antal kopper i kantinen efter at købe kopper med et kantinebestyrelsesmedlem: " + kantine.Cups);

    // Vis den endelige tilstand af kantinen
    Console.WriteLine("\nEndelig tilstand af kantinen:");
    Console.WriteLine(kantine);
    Console.WriteLine("\nFærdig ohh yayyyy:)!");

}
Main(new String[0]);
