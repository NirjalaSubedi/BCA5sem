namespace namedisplay;
class YourName
{
    public static void DisplayName()
    {
        Console.WriteLine("Enter your name");
        String name=Console.ReadLine();
        Console.WriteLine($"Hello {name}");
    }
}