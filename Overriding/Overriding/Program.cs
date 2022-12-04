/*we use 3 types of keywords in method overriding they are:
	1.virtual
    2.override
    3.base

1.Virtual Keyword
 It tells the compiler that this method can be overridden by derived classes.
2.Override Keyword
 
In the subclass, it tells the compiler that this method is overriding the same named method in the base class.

3.base Keyword

In the subclass, it calls the base class method for overriding functionality.


*/




using System;
using System.Collections.Generic;

namespace Overriding
{
    class baseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class subClass : baseClass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj1 = new subClass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }
}
