using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _04CovariantReturnTypes
    {
        public void Demo()
        {
            Meat meat = null;
            Spinach spinach = new Spinach();
           // Food food = meat ?? spinach;
        }
    }

    abstract class Food { }
    class Spinach : Food { }
    class Meat : Food { }
    abstract class Animal
    {
        public abstract Food GetFood();
    }

    class Rabbit : Animal
    {
        public override Spinach GetFood()
        {
            return new Spinach();
        }
    }
    class Tiger : Animal
    {
        public override Meat GetFood()
        {
            return new Meat();
        }
    }
    class Cow : Animal
    {
        public override Spinach GetFood()
        {
            return new Spinach();
        }
    }
}
