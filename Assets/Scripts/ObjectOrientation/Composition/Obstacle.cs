namespace Compostion 
{
    public class Obstacle 
    {
        private GameObject _gameObject;

        public void Destroy() {}

        // Another way to implement the composition relation: With an expression body instead of a full one
        // Learn more at: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
        public void MoveTo (Vector3 newPosition) => _gameObject.MoveTo(newPosition);
    }
}