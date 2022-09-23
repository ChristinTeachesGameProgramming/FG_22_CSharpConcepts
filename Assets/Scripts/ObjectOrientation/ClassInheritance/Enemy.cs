namespace ClassInheritance
{
    public class Enemy : GameObject
    {
        // class field with a default value
        private int _life = 100;

        public void TakeDamage(int damage)
        {
            // 😥
        }

        public void Shoot()
        {
            // Pew, pew
        }
    }
}