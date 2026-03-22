using DotnetLearning;
using Swapnumbers; // Import the NAMESPACE, not the class

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("main method bata call vako");
        // Now you can call the class inside that namespace
        TypeConversion.MyLogic(); 
        Swapnumbers.Swap.SwapTwoNumbers();
        Swapnumbers.SwapWithoutUsingThirdVariable.SwapTwoNumbers();
    }
}
