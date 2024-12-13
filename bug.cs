public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass myClass = 10; // Implicit conversion from int to MyClass
        int value = myClass;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10

        //The following may cause unexpected behavior
        MyClass myClass1 = 20;
        MyClass myClass2 = myClass1 + myClass1;
        Console.WriteLine(myClass2); //Output: 40.  Unexpected behavior if you didn't expect addition
        MyClass myClass3 = myClass1++;
        Console.WriteLine(myClass1); //Output: 21
        Console.WriteLine(myClass3); //Output: 20
        
    }
}