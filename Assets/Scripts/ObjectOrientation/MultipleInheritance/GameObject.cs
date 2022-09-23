namespace MultipleInheritance
{
    public class GameObject 
    {
        private string _id;

        // Automatic property instead of field
        protected Vector3 Position {get; private set;}

        public void MoveTo(Vector3 newPosition)
        {
            // Evaluate if new pos is valid
            // Set next move target or set position directly
        }

        private void UpdatePosition()
        {
            // Has next move target? Update position towards next move target
        }
    }    
}