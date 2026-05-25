using DotnetLearning;
using Swapnumbers; // Import the NAMESPACE, not the class
using namedisplay;
using fetchprofile;
using HCFFinding;
using OverloadingConcept;
using overriding;
using properties;
using inheritancePractice;
using ExceptionHandlingDemo;
using MyExtensions;


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
        //Overloading oL = new Overloading();
        //Console.WriteLine($" a + b + c :{oL.add(1,2,4)}");
        //Console.WriteLine($" a + b :{oL.add(1,4)}");

        //A inheritance = new A();
        // Console.WriteLine($" a * b:{inheritance.calc(1,2)}");

        // Hello h = new Hello();

        // GetSet s1=new GetSet();
        
        //Square mySquare = new Square(5.0f);
        //mySquare.Display();

    // Use Namespace.Class.Method
        //ExceptionHandlingDemo.Program.ExceptionHandling();
        //MyExtensions.StringExtensions.WordCount(" my name is nirjala");

    string nam = "my name is nirjala";

    string titleCaseNam = nam.GetTitleCase();

    Console.WriteLine($"Original: {nam}");
    Console.WriteLine($"Title Case: {titleCaseNam}"); 


    }
}

