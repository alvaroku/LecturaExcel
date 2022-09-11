using LinqExample.Features.ProcesarArchivo.Definiciones;
using LinqExample.Features.ProcesarArchivo.Implementaciones;
using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "Archivo.xlsx";
            Console.WriteLine(File.Exists(Path));

            ILectorArchivo _ILectorArchivo = new LectorAcrhivo();

            var DatosLeidos = _ILectorArchivo.Leer(Path);

             foreach(ArrayList dato in DatosLeidos)
            {
                Console.WriteLine($"{dato[0]} {dato[1]} {dato[2]}");
            }                   
        }
    }
}
