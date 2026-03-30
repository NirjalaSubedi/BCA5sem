using DotnetLearning;
using Swapnumbers; // Import the NAMESPACE, not the class
using namedisplay;
using fetchprofile;
using HCFFinding;
using OverloadingConcept;
using overriding;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("main method bata call vako");
        //TypeConversion.MyLogic(); 
        //Swapnumbers.Swap.SwapTwoNumbers();
        //Swapnumbers.SwapWithoutUsingThirdVariable.SwapTwoNumbers();
        //YourName.DisplayName();
        //ResumeBuilder.GenerateResume("nirjala","c#");
        //SwaptwoString.SwapString();
        //HCF.hcfoftwonumbers(22,4);
        //HCF.hcfusingforloop();
        Overloading oL = new Overloading();
        Console.WriteLine($" a + b + c :{oL.add(1,2,4)}");
        Console.WriteLine($" a + b :{oL.add(1,4)}");

        A inheritance = new A();
        Console.WriteLine($" a * b:{inheritance.calc(1,2)}");

        Hello h = new Hello();
        


    }
}
