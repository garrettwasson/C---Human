using System;
using OOPHuman.Classes;

namespace OOPHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Human player1 = new Human("Zekehart");
            Human player2 = new Human("Slash", 4, 2, 2, 120);
            
            player1.Stats();
            player2.Stats();

            player1.Attack(player2);
            player1.Stats();
            player2.Stats();
        }
    }
}
