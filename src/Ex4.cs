public class Exercise4
{
    public static void Run()
    {
        System.Console.WriteLine("If you have no license leave field blank");
        System.Console.WriteLine("Insert license key:");
        var key = Console.ReadLine();

        var license = new License(key);
        license.PrintLicense();
    }
}

public class License
{
    public enum AccessLevels
    {
        Free,
        Trial,
        Pro
    }

    private string key;
    private AccessLevels currentAccess;

    public License(string key)
    {
        this.key = key;
    }

    private void HandleKey() => currentAccess = key switch
    {
        "free" => AccessLevels.Free,
        "pro" => AccessLevels.Pro,
        "trial" => AccessLevels.Trial,
        _ => AccessLevels.Free
    };

    public void PrintLicense()
    {
        HandleKey();

        switch (currentAccess)
        {
            case AccessLevels.Free:
                Console.WriteLine("You have a free version");
                break;
            case AccessLevels.Trial:
                Console.WriteLine("You have a trial version");
                break;
            case AccessLevels.Pro:
                Console.WriteLine("You have a pro version");
                break;
        }
    }
}
