namespace ProgettoClasseRubrica;
class Program 
{
    static void Main() 
    {
        Rubrica.CaricaContatti(); 
        Console.WriteLine();

        Console.WriteLine("Benvenuto nella Rubrica, cosa vorresti fare?");
        while (true) 
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Visualizza contatti");
            Console.WriteLine("2. Aggiungi contatto");
            Console.WriteLine("3. Modifica contatto");
            Console.WriteLine("4. Elimina contatto");
            Console.WriteLine("5. Elimina rubrica");
            Console.WriteLine("6. Importa contatti");
            Console.WriteLine("7. Esporta contatti");
            Console.WriteLine("0. Esci");
            Console.Write("Scegli un'opzione: ");

            switch (Console.ReadLine()) 
            {
                case "1":
                    Rubrica.VisualizzaContatti();
                    break;
                case "2":
                    Rubrica.AggiungiContatto();
                    break;
                case "3":
                    Rubrica.ModificaContatto();
                    break;
                case "4":
                    Rubrica.EliminaContatto();
                    break;
                case "5":
                    Rubrica.EliminaRubrica();
                    break;
                case "6":
                    Rubrica.ImportaContatti();
                    break;
                case "7":
                    Rubrica.EsportaContatti();
                    break;
                case "0":
                    return; 
                default:
                    Console.WriteLine("Spiacente, opzione non valida.");
                    break;
            }
        }
    }
}
                