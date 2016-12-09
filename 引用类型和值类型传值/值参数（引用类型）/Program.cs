using System;

/// <summary>
/// 最难理解的传值方式！（出错）
/// 见书66页
/// 引用类型作为值参数进行传值
/// </summary>


class MyClass
{
    public int Val = 20;
}

class Program
{
    static void RefAsParameter1(MyClass f1)
    {
        //传统方式，对形参进行修改，实参内容也会变化，指向同一位置
        f1.Val = 50;
        Console.WriteLine("After member assignment:    {0}", f1.Val);
        //新建一个实参引用类型（形参），不能访问实参的数据
        f1 = new MyClass();
        Console.WriteLine("After new object creation:  {0}", f1.Val);
    }

    static void RefAsParameter2(MyClass f1)
    {
        f1 = new MyClass();
        Console.WriteLine("After new object creation:  {0}", f1.Val);

        //只是对新建的引用类型（形参）的数据进行修改，并没有修改实参数
        f1.Val = 50;
        Console.WriteLine("After member assignment:    {0}", f1.Val);
    }



    static void Main()
    {
        MyClass a1 = new MyClass();
        Console.WriteLine("Before method call:         {0}", a1.Val);
        RefAsParameter1(a1);
        Console.WriteLine("After method call:          {0}", a1.Val);
        Console.WriteLine("———————————————");
        MyClass a2 = new MyClass();
        Console.WriteLine("Before method call:         {0}", a2.Val);
        RefAsParameter2(a2);
        Console.WriteLine("After method call:          {0}", a2.Val);
    }
}
