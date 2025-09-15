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

    public void Crediter(decimal montant)
    {
        if (montant < 0)
        {
            throw new ArgumentException("Le montant à créditer ne peut pas être négatif.");
        }
        _solde += montant;
        // Afficher le nouveau solde
        Console.WriteLine($"Nouveau solde après crédit: {_solde} €");
    }

    public void Debiter(decimal montant)
    {
        if (montant < 0)
        {
            throw new ArgumentException("Le montant à débiter ne peut pas être négatif.");
        }
        if (montant > _solde)
        {
            throw new InvalidOperationException("Fonds insuffisants pour débiter ce montant.");
        }

        _solde -= montant;
        // Afficher le nouveau solde
        Console.WriteLine($"Nouveau solde après débit: {_solde} €");
    }

    public void Afficher()
    {
        Console.WriteLine($"--- Informations du Compte ---");
        Console.WriteLine($"Solde: {_solde} €");
        Titulaire.Afficher();
    }
    

}
