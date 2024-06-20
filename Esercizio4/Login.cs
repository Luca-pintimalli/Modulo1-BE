using System;
namespace Esercizio4
{
	internal static  class Login
	{  //UTENTE LOGGATO
		public static Utente loggedUser { get; private set; }
		//ULTIMI 10 LOGIN 
		private static DateTime[] lastLogin = new DateTime[10];
		//CONTATORE LOGIN EFFETUATI
		private static int lastLoginCount = 0;

		//registra nell'elenco login un nuovo accesso 
		private static void RegisterLogin()
		{

			//nel caso ci fossero già 10 login 
			if(lastLoginCount == 10)
			{

				//elimina il primo dei 10 login per far posto all'ultimo 
				for(int i = 1; i<10; i++ ) { lastLogin[i - 1] = lastLogin[i]; }

			}

			//registro data login 
			lastLogin[lastLoginCount] = DateTime.Now;
			//nel caso ci fossero meno di 10 login vado ad aumentarli nel contatore una volta fatto un nuovo login 
			if(lastLoginCount < 10 ) { lastLoginCount++; }
		}



		//stampa i login dall'elenco 
		public static void PrintLogin()
		{
			Console.WriteLine("Ultimo login dell'utente :");
			//stampa i login in ordine inverso 
			for(int i = lastLoginCount - 1; i>=0; i--)
			{
				Console.WriteLine($"{i + 1} \t{lastLogin[i]}");
			}
		}


		//Login utente 
		public static bool Loggin(Utente utente)
		{
			//faccio una verifica x capure sel'utente  sia già autenticato , 
			if (loggedUser != null)
			{
				Console.WriteLine("utente già autentificato");
				return false; 
			}
			//controllo psw e conferma psw siano uguali 
			if(utente.Password == utente.Confirmation)
			{
				//registro l'utente autenticato 
				loggedUser = new Utente { Confirmation = utente.Confirmation, Password = utente.Password, Username = utente.Username };
				RegisterLogin();
				Console.WriteLine($"Utente {loggedUser.Username} autenticato");
				return true; 


			}
			Console.WriteLine("Le password non concidono");
			return false; 
		}


		//logout
		public static bool Logout()
		{
			//se l'utente non si è loggato
			if(loggedUser == null)
			{
				Console.WriteLine("nessun utente autentificato");
				return false;

			}
			//effettua logout 
			loggedUser = null;
			return true; 
		}


		public static bool isLoggedIn()
		{
			if (loggedUser == null)
			{
				Console.WriteLine("nessun utente autentificato");
				return false;
			}
			Console.WriteLine($"Utente autentificato alle ore {lastLogin[lastLoginCount - 1 ]: T } del {lastLogin[lastLoginCount - 1 ] : D}");
			return true; 
		}
		
	}
}

