class HCF 
{
    public static void hcfoftwonumbers(int a ,int b)
    {
        while (b != 0)
        {
            int temp=b;
            b=a % b;
            a=temp;
        }
        Console.WriteLine(a);
    }
}