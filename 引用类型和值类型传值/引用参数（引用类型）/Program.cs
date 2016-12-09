using System;
/// <summary>
///引用类型的参数按照引用参数的方法传值
///所谓引用参数，即使得形参和实参一致
/// </summary>

class MyClass
{
    public int Val = 20;
}

class Program
{
    static void RefAsParameter(ref MyClass f1)
    {
        // Assign to the object member.
        f1.Val = 50;
        Console.WriteLine("After member assignment:    {0}", f1.Val);

        // Create a new object and assign it to the formal parameter.
        f1 = new MyClass();
        Console.WriteLine("After new object creation:  {0}", f1.Val);
    }

    static void Main(string[] args)
    {
        MyClass a1 = new MyClass();

        Console.WriteLine("Before method call:         {0}", a1.Val);
        RefAsParameter(ref a1);
        Console.WriteLine("After method call:          {0}", a1.Val);
    }
}
