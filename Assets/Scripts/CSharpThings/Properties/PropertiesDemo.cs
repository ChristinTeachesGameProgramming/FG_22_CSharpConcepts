public class PropertiesDemo 
{
    public void Init()
    { 
        var properties = new Properties();
        int someInt;

#region field

        properties.PublicFieldInt = 1;
        someInt = properties.PublicFieldInt;

#endregion

#region field with Setter and Getter function

        properties.SetPrivateFieldInt(2);
        someInt = properties.GetPrivateFieldInt();

#endregion

#region property

        properties.PropertyInt = 3;
        someInt = properties.PropertyInt;

#endregion

#region auto-property

        properties.AutoPropertyInt = 5;
        someInt = properties.AutoPropertyInt;

#endregion

#region property with expression-bodied members

        properties.PropertyExpressionInt = 6;
        someInt = properties.PropertyExpressionCalculation;

#endregion

#region auto-property private set

        // properties.AutoPropertyIntPrivateSet = 6;
        someInt = properties.AutoPropertyIntPrivateSet;

#endregion

#region readonly

        // properties.ReadOnlyFieldInt = 7;
        someInt = properties.ReadOnlyFieldInt;
        
#endregion
    }
}