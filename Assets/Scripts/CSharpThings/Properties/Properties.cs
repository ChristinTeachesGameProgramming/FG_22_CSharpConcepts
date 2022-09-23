public class Properties
{
    /*
     * A spacer for the demo
    */
    public Properties() {}

#region public field 

    public int PublicFieldInt = 0;

#endregion
    
#region field with Setter and Getter function

// Set = Assign a value to a field, Get = get the field value
    private int _privateFieldInt = 0;
    
    public void SetPrivateFieldInt(int intValue)
    {
        _privateFieldInt = intValue;
    }

    public int GetPrivateFieldInt()
    {
        return _privateFieldInt;
    }

#endregion

#region property

    private int _propertyInt = 0;
    public int PropertyInt 
    {
        get
        {
            return _propertyInt;
        }
        set
        {
            _propertyInt = value;
        }
    }

#endregion

#region property with expression-bodied members

// {} function body, => expression body
    private int _propertyExpressionInt = 0;
    public int PropertyExpressionInt
    {
        get => _propertyExpressionInt;
        set => _propertyExpressionInt = value;
    }

    public int PropertyExpressionCalculation => _propertyExpressionInt * 2;

#endregion

#region auto-property

    public int AutoPropertyInt {get; set;} = 0;

#endregion

#region auto-property private set

// access modifier must be more limited than property access modifier
    public int AutoPropertyIntPrivateSet {get; private set;} = 0;

    // public Properties(int intValue)
    // {
    //     AutoPropertyIntPrivateSet = intValue;
    // }

    //expression bodied contructor
    // public Properties(int intValue) => AutoPropertyIntPrivateSet = intValue;

    public void TryToSetAutoPropertyInt() 
    // private void TryToSetAutoPropertyInt() 
    {
        AutoPropertyIntPrivateSet = 3;
    }

#endregion

#region readonly

    public readonly int ReadOnlyFieldInt = 0;

    public Properties(int intValue)
    {
        ReadOnlyFieldInt = intValue;
    }

    private void TryToSetInt() 
    {
        // ReadOnlyFieldInt = 3;
    }
    
#endregion
}
