public class Exercise3
{
    public static void Run()
    {
        SomeSecondClass sc = new SomeSecondClass();
        System.Console.WriteLine(sc.field);
    }
}

public class SomeClass
{
   public string field = "abc";
}

public class SomeSecondClass : SomeClass
{
   public string field = "123";
}

public class SomeThirdClass : SomeClass
{
   string field = "098";
}

public class SomeFourthClass : SomeClass
{
   string field = "567";
}
