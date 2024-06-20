using System;

namespace Esercizio4;

internal class Program
{
    static char Choice()
    {
        //answer è una variabile di tio carateere singolo 
        char answer;
        do //inizio ciclo
        {
            //vado a leggere il prossimo carattere da tastiera come se fosse un numero
            int c = Console.Read();
            //converto in un carattere
            answer = (char)c;
            //il ciclo si ripete fino a quando answer è >=1 e <=5

        } while (answer < '1' || answer > '5');
        Console.ReadLine();
        return answer; 

    }

    static char Menu()
    {
        string[] items = { "Login", "Logout", "Verifica", "Elenco accessi", "esci " };
        string title = "operazioni".PadLeft(25, '=').PadRight(42, '=');
        Console.WriteLine(title);
        for (int i = 0; i< items.Length; i++)
        {
            Console.WriteLine($"{i + 1}.\t{items[i]}");
        }
        Console.WriteLine("".PadLeft(title.Length, '='));
        Console.Write("scegli:");
        return Choice();
    }

    static Utente inputUtente()
    {
        Console.Write("Username : "); string username = Console.ReadLine();
        Console.Write("Password:"); string password = Console.ReadLine();
        Console.Write("Conferma password"); string confirm = Console.ReadLine();
        return new Utente { Confirmation = confirm, Password = password, Username = username };

    }



    static void Main(string[] args)
    {
        char choice;
        while ((choice = Menu()) != '5')
        {
            switch (choice)
            {
                case  '1': Login.Loggin(inputUtente()); break;
                case  '2': Login.Logout(); break;
                case  '3': Login.isLoggedIn(); break;
                case  '4': Login.PrintLogin(); break;
            }
        }
        Console.WriteLine("Hello, World!");
    }
}

