// Classe "normale"
class Ville
{
    // Constructeur par défaut (optionnel, car implicite si non défini)
    // Signature : public NomDeLaClasse
    public Ville(string nom, string codePostal)
    {
        Nom = nom;
        CodePostal = codePostal;
    }
    public Ville(string nom)
    {
        Nom = nom;
        CodePostal = "";
    }
    public Ville()
    {
        Nom = "";
        CodePostal = "";
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

// Classe Program (représente le programme avec son point d'entrée)
class Program
{
    // Point d'entrée du programme : méthode statique appelée Main qui retourne void
    static void Main(string[] args)
    {
        Console.WriteLine("Début");

        // Instanciation (créer un objet) d'un objet de classe Ville
        //Ville Avignon = new Ville("Avignon", "84000");
        Ville Avignon = new Ville(codePostal: "84000", nom: "Avignon");

        // A partir d'ici, on peut utiliser l'objet Avignon

        // Utilisation de la méthode public Afficher de l'objet maVille
        Avignon.Afficher();

        // Impossible car la méthode est private
        //Avignon.Test();

        // Instanciation (créer un objet) d'un objet de classe Ville
        Ville Marseille = new Ville();

        // A partir d'ici, on peut utiliser l'objet maVille
        Marseille.Nom = "Marseille";        // Affectation du nom
        Marseille.CodePostal = "13000";   // Affectation du CodePostal

        // Utilisation de la méthode public Afficher de l'objet maVille
        Marseille.Afficher();

        Ville Paris = new Ville("Paris");
        Paris.CodePostal = "75000";
        Paris.Afficher();
        Paris.Population = 112200000;
        Console.WriteLine(Paris.Population);

        // Appel de la méthode statique Bonjour() sur la classe
        Ville.Bonjour();

        Console.WriteLine(Ville.Region);
    }
}