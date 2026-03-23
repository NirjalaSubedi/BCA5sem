using System.Text;
namespace Swapnumbers
{
    class Swap{
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("lets swap two numbers using another variable\n");
            int num1=6,num2=9,num3;
            Console.WriteLine("num1\t"+num1+"\tnum2\t"+num2+"\n");
            num3=num2;
            num2=num1;
            Console.WriteLine("num1\t"+num3+"\tnum2\t"+num2);


        }
    }
    class SwapWithoutUsingThirdVariable
    {
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("lets swap two numbers without using another variable\n");
            int num1=6,num2=9;
            Console.WriteLine("num1\t"+num1+"\tnum2\t"+num2+"\n");
            num1=num1^num2;
            num2=num1^num2;
            num1=num1^num2;
            Console.WriteLine("num1\t"+num1+"\tnum2\t"+num2);
        }
    }

    class SwaptwoString
    {
        public static void SwapString()
        {   string str1="nirjala";
            string str2="subedi";
            str1=str1+str2;
            str2=str1.Substring(0,str1.Length-str2.Length);
            str1=str1.Substring(str2.Length);
            Console.WriteLine($"after swaping {str1}{str2}");

        }
    }
}