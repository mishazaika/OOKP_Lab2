using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOKP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Immutable immutable1 = new Immutable("Max");
            Immutable immutable2 = new Immutable("Sasha");
            Immutable immutable3 = new Immutable("Max");
            Console.WriteLine(immutable1.Equals(immutable2));
            Console.WriteLine(immutable1.Equals(immutable3));
            Console.WriteLine();

            Console.WriteLine(immutable1.GetHashCode());
            Console.WriteLine(immutable2.GetHashCode());
            Console.WriteLine(immutable3.GetHashCode());
            Console.WriteLine();

            Immutable immutable4 = immutable1.clone() as Immutable;
            Console.WriteLine(immutable1.Name);
            Console.WriteLine(immutable4.Name);
            Console.WriteLine();

            Console.WriteLine(immutable1.ToString());
            Console.WriteLine(immutable2.ToString());
            Console.WriteLine(immutable3.ToString());
            Console.WriteLine(immutable4.ToString());
            Console.WriteLine();

            List<Immutable> students = new List<Immutable>();
            students.Add(new Immutable("Artem"));
            students.Add(new Immutable("Vova"));
            students.Add(new Immutable("David"));
            students.Add(new Immutable("Nastya"));
            students.Sort();
            foreach(Immutable stusent in students)
            {
                Console.WriteLine(stusent);
            }

            immutable1.serializable();
        }
    }
}
