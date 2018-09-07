using System;

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
        doStuffEnemy(ufoShip);
        Console.WriteLine("\n");
        // -----------------------------------------
        // This allows me to make the program more dynamic
        // It doesn't close the code from being modified
        // and that is bad!
        // Defines an input stream to watch: keyboard
            
            Console.WriteLine("What type of ship? (U or R)");
            string enemyShipOption = Console.ReadLine();

            if (enemyShipOption == "U"){
            theEnemy = new UFOEnemyShip();
        } else if (enemyShipOption == "R"){
            theEnemy = new RocketEnemyShip();
        } else {
            theEnemy = new BigUFOEnemyShip();
        }
            doStuffEnemy(theEnemy);
            Console.ReadKey();
            // --------------------------------------------
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
