namespace ClassInheritance
{
    public class GameObject 
    {
        private string _id;
        protected Vector3 _position;

        public void MoveTo(Vector3 newPosition)
        {
            // Set the next move target. Or update position directly.
        }

        public Vector3 GetPosition()
        {
            return _position;
        }

        private void UpdatePosition()
        {
            // Internal function to move over time.
        }
    }    
}
