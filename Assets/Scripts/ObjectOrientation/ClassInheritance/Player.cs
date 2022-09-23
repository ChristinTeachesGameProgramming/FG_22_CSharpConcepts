using System;

namespace ClassInheritance
{
    public class Player : GameObject
    {
        private string _name;
        private int _life = 100;

        public void TakeDamage(int damage)
        {
            // Calculates damage and reduce life. Play animation.
        }

        internal void SetName(string name)
        {
            _name = name;
        }

        public void Shoot()
        {
            // Pew, pew
        }
    }
}