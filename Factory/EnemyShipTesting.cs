using System;

//Factory - https://www.youtube.com/watch?v=ub0DXaeV6hA
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace Factory
{
    class EnemyShipTesting
    {
        public static void Main(string[] args)
        {
            // Create the factory object
            var shipFactory = new EnemyShipFactory();
            // Enemy ship object

            EnemyShip theEnemy = null;
            Console.WriteLine("What type of ship? (U / R / B)");
            var userInput = Console.ReadLine().ToLower();
            if (!(userInput == "u" | userInput == "r" | userInput == "b"))
            {
                return;
            }
            var typeOfShip = userInput;
            theEnemy = shipFactory.MakeEnemyShip(typeOfShip);
            if (theEnemy != null)
            {
                DoStuffEnemy(theEnemy);
            }
            else
            {
                Console.Write("Please enter U, R, or B next time");
            }
            Console.ReadKey();
        }

        // Executes methods of the super class
        public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}
