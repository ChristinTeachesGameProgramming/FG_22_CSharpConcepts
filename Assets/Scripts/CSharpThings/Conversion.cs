using UnityEngine;

public class ConversionDemo
{
    private int intField = 1;

    public void Demo()
    {
        //automatic String conversion
        Debug.Log("intField: " + intField); // intField: 1
        Debug.Log($"intField: {intField}");
        Debug.Log("intField: " + intField.ToString()); // intField: 1

        string intToString = intField.ToString();

        float intToFloat = (float)intField; // 1.0f
        intToFloat += 0.3f;
        intField = (int)intToFloat; // 1.3f = 1 or 2?
        intField = Mathf.FloorToInt(intToFloat); // 1
        intField = Mathf.CeilToInt(intToFloat); // 2

        var classDInstance = new ClassD();
        var classDInterface1 = classDInstance as Interface1;
        if(classDInterface1 != null)
        {
            classDInterface1.Init();
        }
        classDInterface1?.Init();
    }
}