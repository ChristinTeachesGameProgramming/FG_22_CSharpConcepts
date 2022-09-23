namespace MultipleInheritance 
{
    public class Enemy : GameObject, ILife
    {
        public int Life { get; set; } = 50;

        public void Shoot() 
        {
            // Pew, pew
        }

        public void TakeDamage(int damage) 
        {
            // :'(
        }
    }
}