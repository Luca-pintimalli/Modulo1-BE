namespace SecondaProva;

 class Persona
{
    //ATTRIBUTI CLASSI  
    string nome = "";
    string cognome = "";
    int  eta;

    //proprieta' delle classi
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cognome
    {
        get { return cognome; }
        set { cognome = value; }

    }
    public int Eta
    {
        get { return eta; }
        set { eta = value; }
    }

    //METODI DELLA CLASSE

    public string GetNome()
    {
        return nome;
    }

    public string GetCognome()
    {
        return cognome;
    }

    public int GetEta()
    {
        return eta;

    }

    public string GetDettagli()
    {
        return $"Nome:{nome}, Cognome:{cognome}, Eta:{eta}";
    }
    

}

class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona();
        p.Nome = "Mario";
        p.Cognome = "Verdi";
        p.Eta = 30;

        Console.WriteLine(p.GetNome());
        Console.WriteLine(p.GetCognome());
        Console.WriteLine(p.GetEta());
        Console.WriteLine(p.GetDettagli());
    }
}

