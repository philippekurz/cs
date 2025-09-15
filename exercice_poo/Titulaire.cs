class Titulaire
{
    private string _id;
    private string _nom;
    private string _prenom;
    private string _adresse;
    private string _codePostal;
    private string _ville;
    private string _tel;
    private string _email;
    public string ID
    {
        get
        { return _id; }
        set
        { _id = value; }
    }

    public string Nom
    {
        get
        { return _nom; }
        set
        { _nom = value; }
    }
    public string Prenom
    {
        get
        { return _prenom; }
        set
        { _prenom = value; }
    }
    public string Adresse
    {
        get
        { return _adresse; }
        set
        { _adresse = value; }
    }
    public string CodePostal
    {
        get
        { return _codePostal; }
        set
        { _codePostal = value; }
    }
    public string Ville
    {
        get
        { return _ville; }
        set
        { _ville = value; }
    }
    public string Tel
    {
        get
        { return _tel; }
        set
        { _tel = value; }
    }
    public string Email
    {
        get
        { return _email; }
        set
        { _email = value; }
    }

    // Constructeur
    public Titulaire(string nom, string prenom, string adresse, string codePostal, string ville, string tel, string email)
    {

        _id = Guid.NewGuid().ToString();
        _nom = nom;
        _prenom = prenom;
        _adresse = adresse;
        _codePostal = codePostal;
        _ville = ville;
        _tel = tel;
        _email = email;
    }

    public void Afficher()
    {
        Console.WriteLine($"--- Informations du Titulaire ---");
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Nom: {_nom}");
        Console.WriteLine($"Prénom: {_prenom}");
        Console.WriteLine($"Adresse: {_adresse}, {_codePostal} {_ville}");
        Console.WriteLine($"Tel: {_tel}");
        Console.WriteLine($"Email: {_email}");
    }
}