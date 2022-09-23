using UnityEngine;

// Types as enums in a code smell, make them classes instead
public class NumberSequenceTypeDemo 
{
    public abstract class NumberSequence 
    {
        public abstract void LogType();
    }

    public class EvenNumbers : NumberSequence
    {
        public override void LogType()
        {
            Debug.Log("NumberSequences.Even");
        }
    }

    public class OddNumbers : NumberSequence
    {
        public override void LogType()
        {
            Debug.Log("NumberSequences.Odd");
        }
    }

    public class FibonacciNumbers : NumberSequence
    {
        public override void LogType()
        {
            Debug.Log("NumberSequences.Fibonacci");
        }
    }
}