using System;

namespace Factory.NotImplemented
{
    public abstract class EnemyShip
    {
        private string _name;
        private double _damage;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public double GetDamage()
        {
            return _damage;
        }

        public void SetDamage(double newDamage)
        {
            _damage = newDamage;
        }

        public void FollowHeroShip()
        {
            Console.WriteLine(GetName() + " is following the hero");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(GetName() + " is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(GetName() + " attacks and does " + GetDamage() + " damage to hero");
        }
    }
}
