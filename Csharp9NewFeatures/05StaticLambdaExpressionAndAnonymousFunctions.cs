using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _05StaticLambdaExpressionAndAnonymousFunctions
    {
        public void Demo()
        {
            int requiredAge = 30;
            var students = new List<PersonClass>()
            {
                new PersonClass("Hermit", "Purple", 27),
                new PersonClass("Test", "Green", 55),
            };

            var highScoreStudents =
                students.Where( x => x.Age > requiredAge);
            var highScoreStudentsStatic =
                students.Where(static x => x.Age > 30);
        }
    }
}
