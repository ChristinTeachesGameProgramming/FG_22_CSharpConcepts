public abstract class AbstractClass
{
    public int IntProperty {get; set;}

    public abstract void Init();

    //partial implementation
    public void DoSomething()
    {
        IntProperty *= 3;
    }
}