class Compte
{

    private decimal _solde = 0;
    public decimal Solde
    {
        get
        {
            return _solde;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Le solde ne peut pas être négatif.");
            }
            _solde = value;
        }
    }

    public Titulaire Titulaire { get; set; }

    // Constructeur
    public Compte(string titulaireNom, string titulairePrenom, string titulaireAdresse, string titulaireCodePostal, string titulaireVille, string titulaireTel, string titulaireEmail, decimal solde)
    {
        _solde = solde;
        Titulaire = new Titulaire(titulaireNom, titulairePrenom, titulaireAdresse, titulaireCodePostal, titulaireVille, titulaireTel, titulaireEmail);
    }   

    public void Afficher()
    {
        Console.WriteLine($"--- Informations du Compte ---");
        Console.WriteLine($"Solde: {_solde} €");
        Titulaire.Afficher();
    }
}
