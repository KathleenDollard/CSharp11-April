using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    public class Person
    {
        public string FirstName { get; init; }
        public string? MiddleName { get; init; }
        public string LastName { get; init; }
    }

    public class Student : Person
    {
        public int Id { get; init; }
    }

    public class Required
    {
        public static void Show()
        {
            var kathleen = new Student
            { FirstName = "Kathleen" };
        }

    }
}
