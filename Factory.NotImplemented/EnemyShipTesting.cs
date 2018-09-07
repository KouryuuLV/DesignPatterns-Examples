using System;

//Factory - https://www.youtube.com/watch?v=ub0DXaeV6hA
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace Factory.NotImplemented
{
public class EnemyShipTesting
    {
    public static void Main(String[] args)
        {
        EnemyShip theEnemy = null;
        // Old way of creating objects
        // When we use new we are not being dynamic
        EnemyShip ufoShip = new UFOEnemyShip();
        DoStuffEnemy(ufoShip);
        Console.WriteLine("\n");
        // -----------------------------------------
        // This allows me to make the program more dynamic
        // It doesn't close the code from being modified
        // and that is bad!
        // Defines an input stream to watch: keyboard
            
            Console.WriteLine("What type of ship? (U or R)");
            var enemyShipOption = Console.ReadLine();

            switch (enemyShipOption.ToLower())
            {
                case "u":
                    theEnemy = new UFOEnemyShip();
                    break;
                case "r":
                    theEnemy = new RocketEnemyShip();
                    break;
                default:
                    theEnemy = new BigUFOEnemyShip();
                    break;
            }
            DoStuffEnemy(theEnemy);
            Console.ReadKey();
        }
    // Executes methods of the super class
    public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
        anEnemyShip.displayEnemyShip();
        anEnemyShip.followHeroShip();
        anEnemyShip.enemyShipShoots();
        }
    }
}
