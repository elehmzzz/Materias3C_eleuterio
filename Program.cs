using Materias.ejemplo1;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Materias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia POO = new Materia();
            Materia BaseDatos = new Materia("Base de datos",9,10,8);

            Console.WriteLine(POO.Impresion());
            Console.WriteLine(BaseDatos.Impresion());
        }
    }
}
