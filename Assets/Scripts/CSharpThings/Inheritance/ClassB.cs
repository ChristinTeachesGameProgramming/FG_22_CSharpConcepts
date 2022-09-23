public class ClassB : ClassA
{
    public ClassB()
    {
        int someInt;
        
        // someInt = base._privateInt;

        someInt = base._protectedInt;
        base._protectedInt = 1;

        someInt = base.PublicInt;
        base.PublicInt = 2;

        if(someInt >= ClassA.ConstInt){}
        // ClassA.ConstInt = 300;
        // ClassB.ConstInt = 300;

        if (someInt >= ClassA.StaticInt) { }
        ClassA.StaticInt = 400;
        ClassB.StaticInt = 500;
    }

    public override void Init()
    {
        base.Init();
        // do class specific setup for B
    }
}