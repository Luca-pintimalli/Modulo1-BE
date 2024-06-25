List<(string Name, double Price)> menu = new List<(string, double)>
        {
            ("Coca Cola 150 ml", 2.50),
            ("Insalata di pollo", 5.20),
            ("Pizza Margherita", 10.00),
            ("Pizza 4 Formaggi", 12.50),
            ("Pz patatine fritte", 3.50),
            ("Insalata di riso", 8.00),
            ("Frutta di stagione", 5.00),
            ("Pizza fritta", 5.00),
            ("Piadina vegetariana", 6.00),
            ("Panino Hamburger", 7.90)
        };

List<int> order = new List<int>();
const double serviceFee = 3.00;

while (true)
{
    Console.Clear();
    Console.WriteLine("==============MENU==============");
    for (int i = 0; i < menu.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {menu[i].Name} (€ {menu[i].Price:F2})");
    }
    Console.WriteLine("11: Stampa conto finale e conferma");
    Console.WriteLine("==============MENU==============");

    Console.Write("Seleziona un'opzione: ");
    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 11)
    {
        if (choice == 11)
        {
            // Stampa il conto finale
            PrintReceipt(menu, order, serviceFee);
            break;
        }
        else
        {
            order.Add(choice - 1);
            Console.WriteLine($"{menu[choice - 1].Name} aggiunto al tuo ordine.");
        }
    }
    else
    {
        Console.WriteLine("Opzione non valida. Riprova.");
    }

    Console.WriteLine("Premi un tasto per continuare...");
    Console.ReadKey();
}
    

    static void PrintReceipt(List<(string Name, double Price)> menu, List<int> order, double serviceFee)
{
    Console.Clear();
    Console.WriteLine("==============CONTO FINALE==============");

    double total = 0.0;
    foreach (int itemIndex in order)
    {
        var item = menu[itemIndex];
        Console.WriteLine($"{item.Name} - € {item.Price:F2}");
        total += item.Price;
    }

    total += serviceFee;
    Console.WriteLine("========================================");
    Console.WriteLine($"Servizio al tavolo: € {serviceFee:F2}");
    Console.WriteLine($"Totale: € {total:F2}");
    Console.WriteLine("========================================");
    Console.WriteLine("Grazie per il tuo ordine!");

    Console.WriteLine("Premi un tasto per uscire...");
    Console.ReadKey();
}