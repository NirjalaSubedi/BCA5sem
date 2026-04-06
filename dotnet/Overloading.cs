using System.ComponentModel.DataAnnotations;

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

namespace inheritancePractice
{
    public class Shape
    {
        protected float length;
        protected float breadth;
        public Shape(float length, float breadth)
        {
            this.length= length;
            this.breadth= breadth;
        }
        public void Display()
        {
            Console.WriteLine($"Length and Breadth:{length*breadth}");
        }
    }

    public class Square : Shape
    {
        public Square(float side) : base(side, side)
        {
            
            Display();
        }
      
    }
}