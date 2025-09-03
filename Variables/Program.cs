// Généralités
// c# est case sensitive (console <> Console)
// ; à la fin de chaque instruction
// Le point décimal = .

// Déclaration d'une variable
// Type, Nom, (= Valeur)

// Type string : Chaîne de caractères
string sMessage = "Hello, World!";
Console.WriteLine(sMessage);

// Type int : Entier (32 bits, 2,147,483,647 valeurs possibles)
int iNombre = 42;
Console.WriteLine(iNombre);
// variante uint : unsigned int (32 bits, 4,294,967,295 valeurs possibles)

// Type double : Nombre à virgule flottante (64 bits, 15-16 chiffres significatifs)
double prix = 19.99;
Console.WriteLine(prix);

// Type char : Caractère (16 bits)
char lettre = 'A';
Console.WriteLine(lettre);

// Type bool : Booléen (true ou false)
bool estVrai = true;
Console.WriteLine(estVrai);

var nom = "Philippe";
Console.WriteLine(nom);


sMessage = "Hello, World!";
iNombre = 42;

int i = 10;
int j = i;
Console.WriteLine(j); // 10
i = 20;
Console.WriteLine(j); // 10

// Exercice