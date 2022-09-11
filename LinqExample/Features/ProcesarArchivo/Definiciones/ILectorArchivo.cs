using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample.Features.ProcesarArchivo.Definiciones
{
    public interface ILectorArchivo
    {
        public ArrayList Leer(string Ruta);
    }
}
