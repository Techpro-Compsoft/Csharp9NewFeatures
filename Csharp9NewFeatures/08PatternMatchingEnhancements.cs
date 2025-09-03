using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _08PatternMatchingEnhancements
    {
        public void Demo()
        {
            var firstClass = new PersonClass("Silver", "Chariot",40);
        }

        public static bool IsTeen(PersonClass person) =>
            person is { Age: >= 13 and <= 19 };

        public static bool IsAdult(PersonClass person) =>
            person is { Age: 18 or (> 18 and not 15) };
    }
}
