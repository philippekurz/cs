//Exercice1

int age = 20;
string prenom = "Pierre";
double taille = 1.75;
Console.WriteLine($"{prenom}, {age} ans, {taille} m");

//Exercice2

Console.Write("Veuillez entrer un nombre : ");
string nombre = Console.ReadLine();
int n = Convert.ToInt32(nombre);
int Total = n * 2;
Console.WriteLine(Total);


    //Exercice3

    int A = 5;
    int B = 10;

    int somme = A + B;
    Console.WriteLine("La somme de A et B est : " + somme);

    int difference = A - B;
    Console.WriteLine("La différence entre A et B est : " + difference);

    int produit = A * B;
    Console.WriteLine("Le produit de A et B est : " + produit);

    double quotient = (double)A / B;
    Console.WriteLine("Le quotient de A et B est : " + quotient);


    //Exercice 4
    Console.Write("Veuillez entrer un nombre : ");
    string pairouimp = Console.ReadLine();
    int i = Convert.ToInt32(pairouimp);
    if (i % 2 == 0)
    {
        Console.WriteLine("Le nombre est pair.");
    }
    else
    {
        Console.WriteLine("Le nombre est impair.");
    }


//Exercice 5
Console.Write("Veuillez entrer votre âge : ");
string ageStr = Console.ReadLine();
int ageInt = Convert.ToInt32(ageStr);
if (ageInt < 18)
{
    Console.WriteLine("Vous êtes mineur.");
}
else
{
    Console.WriteLine("Vous êtes majeur.");
}

//Exercice 6

Console.Write("Veuillez entrez le 1er nombre : ");
int nb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Veuillez entrez le 2ème nombres : ");
int nb2 = Convert.ToInt32(Console.ReadLine());
if (nb1 < nb2)
{
    Console.WriteLine("Le deuxième nombre est plus grand que le premier.");
}
else if (nb1 > nb2)
{
    Console.WriteLine("Le premier nombre est plus grand que le deuxième.");
}
else
{
    Console.WriteLine("Les deux nombres sont égaux.");
}

//Exercice 7
Console.WriteLine("Veuillez entrez le jour de la semaine voulu entre 1 et 7 : ");
int jour = Convert.ToInt32(Console.ReadLine());
switch (jour)
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    case 3:
        Console.WriteLine("Mercredi");
        break;
    case 4:
        Console.WriteLine("Jeudi");
        break;
    case 5:
        Console.WriteLine("Vendredi");
        break;
    case 6:
        Console.WriteLine("Samedi");
        break;
    case 7:
        Console.WriteLine("Dimanche");
        break;
    default:
        Console.WriteLine("Jour invalide.");
        break;
}

//Exercice 8
Console.Write("Veuillez entrez le 1er nombre : ");
int nb3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Veuillez entrez le 2ème nombres : ");
int nb4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Veuillez choisir l'opération : ");
char op = Console.ReadLine()[0];
switch (op)
{
    case '+':
        Console.WriteLine(nb3 + nb4);
        break;
    case '-':
        Console.WriteLine(nb3 - nb4);
        break;
    case '*':
        Console.WriteLine(nb3 * nb4);
        break;
    case '/':
        if (nb4 != 0)
        {
            Console.WriteLine(nb3 / nb4);
        }
        else
        {
            Console.WriteLine("Erreur : Division par zéro.");
        }
        break;
    default:
        Console.WriteLine("Opération invalide.");
        break;
}

//Exercice 9
Console.WriteLine("Veuillez choisir une note entre 0 et 20 :");
int note = Convert.ToInt32(Console.ReadLine());
switch (note)
{
    case int p when (p >= 17 && p <= 20):
        Console.WriteLine("Excellent");
        break;
    case int p when (p >= 14 && p < 16):
        Console.WriteLine("Bien");
        break;
    case int p when (p >= 10 && p < 13):
        Console.WriteLine("Moyen");
        break;
    case int p when (p >= 0 && p < 10):
        Console.WriteLine("Insuffisant");
        break;
    default:
        Console.WriteLine("Note invalide.");
        break;
}

//Exercice 10

Console.WriteLine("1. Dire Bonjour");
Console.WriteLine("2. Dire Au revoir");
Console.WriteLine("3. Quitter");

Console.Write("Choisissez une option : ");
int menu = Convert.ToInt32(Console.ReadLine());

switch (menu)
{
    case 1:
        Console.WriteLine("Bonjour");
        break;

    case 2:
        Console.WriteLine("Au revoir");
        break;

    case 3:
        Console.WriteLine("Vous avez quitté");
        break;

    default:
        Console.WriteLine("Erreur : option invalide.");
        break;
}