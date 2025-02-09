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

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = obj1;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10

        MyClass obj2 = new MyClass(20);
        int val = obj2 + 5;  // This line may cause unexpected behavior
        Console.WriteLine(val); // Output: 25 (This is correct)
        MyClass obj3 = obj2 + 5; // This is a bit unexpected.
        Console.WriteLine(obj3); // Output: 25 (This is correct)

        MyClass obj4 = new MyClass(20);
        int val2 = obj4 + obj2; // This line may cause unexpected behavior
        Console.WriteLine(val2); // Output: 40
        MyClass obj5 = obj4 + obj2; // This is a bit unexpected.
        Console.WriteLine(obj5); // Output: 40

        MyClass obj6 = new MyClass(20);
        MyClass obj7 = obj6 + 5; // Implicit conversion
        Console.WriteLine(obj7.MyProperty); //Output: 25
        MyClass obj8 = 5 + obj6; // Implicit conversion
        Console.WriteLine(obj8.MyProperty); //Output: 25

        MyClass obj9 = new MyClass(10);
        MyClass obj10 = obj9 + new MyClass(5); // Implicit conversion
        Console.WriteLine(obj10.MyProperty); // Output: 15
    }
}