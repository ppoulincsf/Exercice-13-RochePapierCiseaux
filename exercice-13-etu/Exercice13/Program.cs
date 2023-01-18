using System;
using System.Reflection.Metadata.Ecma335;

namespace Exercice13
{
  public class Program
  {
    // Déclarez ici les constantes nécessaires au programme 
    // *** Les coups possibles - roche, papier et ciseaux
    // *** Les options de jeu possibles - jouer ou quitter
    // *** Les gagnants possibles - joueur1, joueur2 ou partie nulle.


    public static void Main(string[] args)
    {
      int playerChoice = 0; // Vous pourrez utiliser la constante appropriée lorsque vous l'aurez déclarée.


      // Étape 1.1): demander le choix au joueur
      // Vous devez:
      // - Faire l'appel de la fonction PromptInt ici et placer le résultat dans la variable playerChoice


      // Étape 1.2): générer un choix pour l'adversaire
      // Vous devez:
      // - Faire l'appel de la fonction GenerateRandom et placer le résultat dans la variable opponentChoice


      // Étape 1.3): déterminer le gagnant
      // Vous devez:
      // - Faire l'appel de la fonction DetermineWinner et placer le résultat dans la variable winner de type int


      // Étape 1.5): afficher les résultats
      // Vous devez:
      // - Faire l'appel de la fonction ShowGameResults en lui passant les paramètres appropriés.


      // Dernière étape: demander au joueur s'il souhaite continuer ou non
      // Vous devez:
      // - Faire l'appel à la fonction PromptInt et placer le résultat dans la variable 
      //   playerChoice


      // Assurez-vous de placer tout le code qui précéde dans une boucle pour faire en sorte que le joueur
      // puisse jouer tant qu'il n'entre pas "quitter" à la fin.


    }

    public static int PromptInt(string prompt)
    {
      // A COMPLÉTER
      return 0;
    }

    public static int GenerateRandom(int min, int max)
    {
      // A COMPLÉTER
      return 0;
    }

    public static int DetermineWinner(int player1Choice, int player2Choice)
    {
      // A COMPLÉTER
      return 0;
    }

    public static string ChoiceToText(int playerChoice)
    {
      string textValue = "";

      // A COMPLÉTER
      return textValue;
    }

    public static void ShowGameResults(int player1Choice, int player2Choice, int winner)
    {
      // Permet d'effacer le contenu de la console
      Console.Clear();
      // A COMPLÉTER
      
    }
  }
}
