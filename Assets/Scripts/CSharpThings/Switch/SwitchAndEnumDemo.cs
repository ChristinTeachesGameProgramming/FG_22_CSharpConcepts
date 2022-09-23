using UnityEngine;

public partial class SwitchAndEnumDemo 
{
    private enum NumberSequences
    {
        Even,
        Odd,
        Fibonacci,
        //new types here
    }

    private void LogNumberSequenceType()
    {
        var sequence = NumberSequences.Even;

        switch(sequence)
        {
            case NumberSequences.Even:
                Debug.Log("NumberSequences.Even");
                break;
            case NumberSequences.Odd:
                Debug.Log("NumberSequences.Odd");
                break;
            case NumberSequences.Fibonacci:
                Debug.Log("NumberSequences.Bool");
                break;
            default:
                Debug.Log($"Not a valid sequence: {sequence}");
                break;
        }
    }

    private void LogInt()
    {
        var intValue = 3;

        switch (intValue)
        {
            case 1:
                Debug.Log("1");
                break;
            case 2:
                Debug.Log("2");
                break;
            case 3:
                Debug.Log("3");
                break;
            default:
                Debug.Log($"Int value not expected: {intValue}");
                break;
        }
    }
}