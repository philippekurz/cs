class Program
{
    private static void Main(string[] args)
    {
        // Déclaration et initialisation d'un tableau de chaînes de caractères
        // Parcours du tableau avec une boucle foreach
        string[] noms = { "Alice", "Bob", "Charlie", "David", "Eve" };
        foreach (string nom in noms)
        {
            Console.WriteLine(nom);
        }

        List<string> prenoms = new List<string> { "Alice", "Bob", "David", "Charlie", "Eve" };
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }

        // Ajouter un élément
        prenoms.Add("Grace");
        prenoms.Add("Frank");

        // Supprimer un élément
        prenoms.Remove("Alice");
        prenoms.Remove("Bob");

        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }

        Console.WriteLine(prenoms.Count);

        // Trier la liste
        prenoms.Sort();
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }

        // Inverser la liste
        prenoms.Reverse();
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }

        // Teste de présence d'un élément
        Console.WriteLine(prenoms.Contains("Charlie"));
        Console.WriteLine(prenoms.Contains("Alice"));

        // Insérer un élément à une position donnée
        prenoms.Insert(2, "Hugo");
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }

        // Accéder à un élément par son index
        Console.WriteLine(prenoms[3]);

        // Chercher l'index d'un élément
        Console.WriteLine(prenoms.IndexOf("Hugo"));


        Dictionary<int, string> clients = new Dictionary<int, string>();
        clients[30] = "Alice";
        clients[25] = "Bob";
        clients[35] = "Charlie";
        clients[40] = "David";
        clients[28] = "Eve";
        clients.Add(32, "Frank");
        clients.Add(29, "Grace");
        foreach (KeyValuePair<int, string> client in clients)
        {
            Console.WriteLine($"Clé : {client.Key}, Valeur : {client.Value}");
        }

    }
}