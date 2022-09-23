public class ClassD : Interface1, Interface2
{
    private int _intField;
    public int IntProperty { get => _intField; set => _intField = value;}

    private string _stringField;
    public string StringProperty { get => _stringField; set => _stringField = value;}

    public void DoSomething()
    {
        _intField *= 3;
    }

    public void DoSomethingInterface2()
    {
        _stringField.Replace("Hello", "Goodbye");
    }

    public void Init()
    {
        _intField = 3;
    }

    public void InitInterface2()
    {
        _stringField = "Hello Interface2!";
    }
}