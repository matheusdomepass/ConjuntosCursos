using System;

namespace ConjuntosCursos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> curso1 = new HashSet<int>();
            HashSet<int> curso2 = new HashSet<int>();
            HashSet<int> curso3 = new HashSet<int>();

            Console.Write("Quantos estudantes no Curso1?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               int id = int.Parse(Console.ReadLine());
               curso1.Add(id);               
            }
            Console.Write("Quantos estudantes no Curso2?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                curso2.Add(id);
            }
            Console.Write("Quantos estudantes no Curso3?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                curso3.Add(id);
            }

            HashSet<int> list = new HashSet<int>(curso1);
            list.UnionWith(curso2);
            list.UnionWith(curso3);
            Console.WriteLine("Total de estudantes: " + list.Count);
        }
    }
}