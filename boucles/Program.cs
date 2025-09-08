// for quand on connait à l'avance le nombre d'itérations (boucle pour)
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("boucle for terminée");

// while, quand on ne connait pas à l'avance le nombre d'itérations (boucle tant que)
int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}
Console.WriteLine("boucle while terminée");

// do ... while, variante de while quie exécute au moins une fois le code de la boucle
int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 10);
Console.WriteLine("boucle do while terminée");

// foreach, pour itérer sur les collections (tableaux, listes, dictionnaires, etc.) (pour chaque)
int[] entiers = { 1, 31, 154, 5, 26 };
foreach (int element in entiers) {
    Console.WriteLine(element); 
}
Console.WriteLine("boucle foreach entiers terminée");

string[] chaines = { "Bonjour", "Hello World", "Comment ça va" };
foreach (string element in chaines) {
    Console.WriteLine(element); 
}
Console.WriteLine("boucle foreach chaînes terminée");



