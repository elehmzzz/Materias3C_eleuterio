using Materias.ejemplo1;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Materias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia matematicas = new Materia();
            matematicas._p1 = 10;
            matematicas._p2 = 8;
            matematicas._p3 = 10;
            Console.WriteLine(matematicas.calPromedio());
        }
    }
}
