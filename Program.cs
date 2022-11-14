// See https://aka.ms/new-console-template for more information
using DemoCLI;

#region Variable en générale
//string message = "Hello, World!";

//ConsoleAvancee.WriteLineVertical(message);

//Exemple ex = new Exemple();

//ex.AfficheYLocal();
//ex.AfficheYMembre(); 
#endregion

#region Manipulation string
//string prenom = "Samuel";
//string nom = "Legrain";
//bool isFemalle = false;
//message = $@"Bienvenu{((isFemalle)?"e":"")}:
//{prenom} {nom}"; 
#endregion

#region Boxing/Unboxing
//object[] inventaire = new object[3];

//inventaire[0] = "potion";
//inventaire[1] = 52;
//inventaire[2] = true;

//foreach (var item in inventaire)
//{
//    if(item is int)
//        Console.WriteLine((int)item + 5);
//    else if(item is string)
//        Console.WriteLine($"Voici ce qu'il y a dans mon inventaire : {item}");
//    else
//        Console.WriteLine($"Cet item n'est ni string, ni int...");
//} 
#endregion

#region Exercices
/*Exo1*/
//string s1 = Console.ReadLine();
//string s2 = Console.ReadLine();

//int i = int.Parse(s1) + int.Parse(s2);
//Console.WriteLine(i);

/*Exo2*/
//string s1 = Console.ReadLine();
//string s2 = Console.ReadLine();

//int.TryParse(s1, out int i);

//int j;
//bool b_j = int.TryParse(s2, out j);

//Console.WriteLine(i + j);
#endregion

#region Pierre-papier-Ciseaux

Console.WriteLine(@"Veuillez choisir entre ces 3 propositions:
1. Pierre
2. Papier
3. Ciseaux");
string choix = Console.ReadLine();
bool choix_valide = int.TryParse(choix, out int choix_joueur);

if (choix_valide)
{
    switch (choix_joueur)
    {
        case 1:
            Console.WriteLine("Pierre");
            break;
        case 2:
            Console.WriteLine("Papier");
            break;
        case 3:
            Console.WriteLine("Ciseaux");
            break;
        default:
            choix_valide = false;
            break;
    }
    if (choix_valide)
    {
        Random RNG = new Random();
        int choix_cpu = RNG.Next(1, 4);
        switch (choix_cpu)
        {
            case 1:
                Console.WriteLine("Pierre");
                break;
            case 2:
                Console.WriteLine("Papier");
                break;
            case 3:
                Console.WriteLine("Ciseaux");
                break;
        }
        if (choix_cpu == choix_joueur) Console.WriteLine("Match null");
        else if ((choix_joueur == 1 && choix_cpu == 2) || (choix_joueur == 2 && choix_cpu == 3) || (choix_joueur == 3 && choix_cpu == 1)) Console.WriteLine("Perdu...");
        else Console.WriteLine("Bravo!");
    }
}
if (!choix_valide)
{
    Console.WriteLine($"{choix} n'est pas un choix valide...");
}

#endregion