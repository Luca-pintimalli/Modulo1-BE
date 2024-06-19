namespace TerzaProva;

class Program
{
    static void Main(string[] args)
    {


 
        BankAccount a1 = new BankAccount("Pino", 1000); //Andiamo a creare un nuovo Account Pino , che ha 2000€

        try
        {
            BankAccount a2 = new BankAccount("Pimo", 0);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); 
        }

        try
        {
            a1.Deposit(500);
            a1.WithDraw(1000);
            a1.WithDraw(1000);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }

}
   

