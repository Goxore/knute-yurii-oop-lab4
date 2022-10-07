using System.Reflection;
using static System.Console;

public class Exercise1
{
    public static void Run()
    {
        MyClass cls = new MyClass();
        int[] a = new int[5];
        cls.MyMethod(1, "AAA", true);
        DerivedFromMyClass derived = new DerivedFromMyClass();
        derived.MyMethod(132, "BBB", false);
        Console.ResetColor();
    }
}

public class MyClass
{

    public virtual void MyMethod(int myInt, string myString, bool myBool)
    {

        Random rand = new Random();
        ParameterInfo[] parameters = MethodInfo.GetCurrentMethod().GetParameters();
        foreach (var parameter in parameters)
        {
            Console.ForegroundColor = (ConsoleColor)rand.Next(8, 16);
            WriteLine($"{parameter.ParameterType} {parameter.Name}");
        }
    }
}

public class DerivedFromMyClass : MyClass
{

}
