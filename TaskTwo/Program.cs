
/* == TASK ==
 * 
 * Try to simulate the dependency in a struct,
 * and an override of a virtual method
 * 
 * class Base
 * {
 *     public virtual string GetInfo()
 *     {
 *         return "Base class";
 *     }
 * }
 * 
 * class A : Base
 * {
 *     public override string GetInfo()
 *     {
 *         return "A class";
 *     }
 * }
 *   
 * ...
 *   
 * Base b = new A();
 * b.GetInfo();
 */

/* == ANSWER ==
 * 
 * I guess I should use an interface
 * with GetInfo method implementation
 */

using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            IBase b = new A();
            Console.WriteLine(b.GetInfo());
        }
    }
}
