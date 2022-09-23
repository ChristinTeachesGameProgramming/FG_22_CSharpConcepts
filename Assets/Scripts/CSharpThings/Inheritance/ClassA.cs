public class ClassA 
{
    private int _privateInt;
    protected int _protectedInt;
    public int PublicInt;

    protected const int ConstInt = 100;

    protected static int StaticInt = 200;

    public virtual void Init()
    {
        _privateInt = 1;
    }
}