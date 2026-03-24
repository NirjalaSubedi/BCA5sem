using DotnetLearning;
using Swapnumbers; // Import the NAMESPACE, not the class
using namedisplay;
using fetchprofile;
using HCFFinding;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("main method bata call vako");
        //TypeConversion.MyLogic(); 
        //Swapnumbers.Swap.SwapTwoNumbers();
        //Swapnumbers.SwapWithoutUsingThirdVariable.SwapTwoNumbers();
        //YourName.DisplayName();
        //ResumeBuilder.GenerateResume("nirjala","c#");
        SwaptwoString.SwapString();
        HCF.hcfoftwonumbers(22,4);
        HCF.hcfusingforloop();



    }
}
