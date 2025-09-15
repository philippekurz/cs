// Classe "normale"
class Ville
{
    // Constructeur par défaut (optionnel, car implicite si non défini)
    // Signature : public NomDeLaClasse
    public Ville(string nom, string codePostal)
    {
        Nom = nom;
        _codePostal = codePostal;
    }
    public Ville(string nom)
    {
        Nom = nom;
        _codePostal = "";
    }
    public Ville()
    {
        Nom = "";
        _codePostal = "";
    }

    // Données de la classe : Propriétés / Attributs
    // Accesseurs get (lecture)/set (écriture)

    // Propriété par defaut (auto-implémenté)
    public string Nom { get; set; }

    // Propriété manuellement implémentée
    private string _codePostal;
    public string CodePostal
    {
        get { return _codePostal; }
        set { _codePostal = value; }
    }

    private int _population = 1000;
    public int Population
    {
        // Getter
        get
        {
            return _population;
        }
        // Setter
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La population ne peut pas être négative");
            }
            else if (value > 10000000)
            {
                throw new ArgumentException("La population est trop grande");
            }
            _population = value;
        }
    }
    
    public static string? Region = "PACA";
    // Comportements de la classe : Méthodes (fonctions)
    public void Afficher()
    {
        Console.WriteLine($"{this.CodePostal} {this.Nom} {Region}");
        Test();
    }
    // Méthode privée (private) utilisable uniquement dans la classe
    private void Test()
    {
        Console.WriteLine("Test");
    }

    // Méthode statique (utilisable sans instancier d'objet)
    public static void Bonjour()
    {
        Console.WriteLine($"Bonjour, je suis une ville de la région {Region}");
    }
}
