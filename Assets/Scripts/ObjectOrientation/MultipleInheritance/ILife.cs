namespace MultipleInheritance
{
    public interface ILife
    {
        // Interface cannot have fields but properties work
        public int Life {get; set;}

        void TakeDamage(int damage);
    }
}