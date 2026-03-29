namespace OverloadingConcept
{
    class Overloading
    {
        public int add(int a, int b) => a + b;
        public int add(int a, int b, int c)=> a + b + c;

    }
}

//overriding concept 
namespace overriding{
    class  A
    {
        public virtual int  calc(int a , int b)=>a*b;
    }
    class B : A
    {
        public override int calc(int a , int b)=>a*b;
    }
}