using System;

//Factory - https://www.youtube.com/watch?v=ub0DXaeV6hA
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace Factory
{
    class EnemyShipTesting
    {
        public static void Main(String[] args)
        {
            // Create the factory object
            EnemyShipFactory shipFactory = new EnemyShipFactory();
            // Enemy ship object
            EnemyShip theEnemy = null;
           Console.WriteLine("What type of ship? (U / R / B)");
            string userInput = Console.ReadLine();
            if (userInput == "U" | userInput == "R" | userInput == "B")
            {
                String typeOfShip = userInput;
                theEnemy = shipFactory.makeEnemyShip(typeOfShip);
                if (theEnemy != null)
                {
                    doStuffEnemy(theEnemy);
                }
                else Console.Write("Please enter U, R, or B next time");

                Console.ReadKey();
            }
        }

        // Executes methods of the super class
        public static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }
    }
}
