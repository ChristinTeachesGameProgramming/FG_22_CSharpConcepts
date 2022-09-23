namespace MultipleInheritance 
{
    public class Player : GameObject, ILife
    {
        public string Name {set; get;}
        public int Life { get; set; } = 100;

        public void Shoot() {}

        public void TakeDamage(int damage)
        {
            // Calculates damage and reduce life. Play animation.
        }
    }
}