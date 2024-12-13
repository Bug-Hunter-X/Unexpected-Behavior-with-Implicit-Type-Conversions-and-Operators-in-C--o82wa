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

    // Explicitly define the + operator for MyClass
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }

    public static MyClass operator ++(MyClass a)
    {
        return new MyClass(a.MyProperty + 1);
    }

    public override string ToString()
    {
        return MyProperty.ToString();
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass myClass = 10; // Implicit conversion from int to MyClass
        int value = myClass;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10

        // Now, with the overloaded +, the behavior is predictable
        MyClass myClass1 = 20;
        MyClass myClass2 = myClass1 + myClass1; 
        Console.WriteLine(myClass2); // Output: 40
        MyClass myClass3 = myClass1++;
        Console.WriteLine(myClass1); // Output: 21
        Console.WriteLine(myClass3); // Output: 20
    }
}