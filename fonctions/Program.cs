Console.WriteLine("Fonctions");
// Modèle abstrait d'une fonction
// typeDeRetour NomDeLaFonction (Paremètres)
// {
//     Instructions...
//     return valeurDeRetour
// }


int Additionne(int nbEntier1, int nbEntier2) // Déclaration de la fonction Additionne
{
    return nbEntier1 + nbEntier2;
}

int total = Additionne(2, 3);   //Appel de la fonction Additionne
Console.WriteLine(total);