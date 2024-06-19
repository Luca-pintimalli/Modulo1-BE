using System;
namespace TerzaProva
{
	internal class BankAccount
	{

	  private static int LastAccountNumber = 0 ;

	  public string Owner { get; set; }

	  public int Number { get; private set ;}

	  public DateTime LastOperation { get; private set; }

	  public decimal Amount { get; private set; }

	

	  public BankAccount(string owner, decimal initialAmount)
		{
		//VERIFICHIAMO CHE PER APRIRE IL CONTO SERVONO ALMENO 1000€
		if (initialAmount < 1000)
			throw new ArgumentException("Per aprire il conto servono almeno 1000€");
		Owner = owner;
		Number = ++LastAccountNumber;
		Deposit(initialAmount);

		}
	

	  public virtual void Deposit(decimal amount)
	  {
		//QUESTO METODO GESTISCE IL DEPOSITO 
		LastOperation = DateTime.Now;//INSERISCO LA DATA CORRENTE 
		amount += amount;//AGGIUNGE IL VALORE DA DEPOSITARE AL SALDO 
		Console.WriteLine($"Deposito di {amount} euro effetuato");
		Console.WriteLine(Describe());

	  }




	  public virtual void WithDraw(decimal amount)
        {     //STESSA COSA PER VERSARE MA ESSENDO CHE DOBBIAMO PRELEVARE DOBBIAMO LANCIARE UN ERRORE NEL CASO L'UTENTE VUOLE RITIRARE + DEL DOVUTO 

            if (Amount < amount)
			throw new ArgumentException("Fondi non sufficenti");
		LastOperation = DateTime.Now;
		amount -= amount;
		Console.WriteLine($"Prelievo di {amount} euro effetuato");
		Console.WriteLine(Describe());
	}

	  public string Describe()
	{
			return $"CONTO CORRENTE N.{Number:08} intestato a {Owner}\n\tSaldo : {Amount} euro";

	}

    }
}

