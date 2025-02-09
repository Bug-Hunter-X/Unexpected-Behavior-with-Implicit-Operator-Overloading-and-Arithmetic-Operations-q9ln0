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

    // Add explicit operator overloads for better control and clarity.
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }

    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }

    public static MyClass operator +(int a, MyClass b)
    {
        return new MyClass(a + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; 
        int value = obj1;   
        Console.WriteLine(value); // Output: 10

        MyClass obj2 = new MyClass(20);
        MyClass obj3 = obj2 + 5; 
        Console.WriteLine(obj3.MyProperty); // Output: 25

        MyClass obj4 = new MyClass(20);
        MyClass obj5 = obj4 + obj2; 
        Console.WriteLine(obj5.MyProperty); // Output: 40

        MyClass obj6 = new MyClass(20);
        MyClass obj7 = obj6 + 5; 
        Console.WriteLine(obj7.MyProperty); // Output: 25

        MyClass obj8 = 5 + obj6; 
        Console.WriteLine(obj8.MyProperty); // Output: 25

        MyClass obj9 = new MyClass(10);
        MyClass obj10 = obj9 + new MyClass(5); 
        Console.WriteLine(obj10.MyProperty); // Output: 15
    }
}