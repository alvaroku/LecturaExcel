using ClosedXML.Excel;
using LinqExample.Features.ProcesarArchivo.Definiciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample.Features.ProcesarArchivo.Implementaciones
{
    public class LectorAcrhivo : ILectorArchivo
    {
        public ArrayList Leer(string Ruta)
        {
            ArrayList datos = new ArrayList();

            XLWorkbook ArchivoExcel = new XLWorkbook(Ruta);//ruta del libro excel
            var HojaExcel = ArchivoExcel.Worksheet(1);//hojas del libro        

            foreach (IXLRow fila in HojaExcel.Rows())//recorrer las filas
            {
                ArrayList row = new ArrayList();
                row.Add(fila.Cell(1).GetValue<String>());
                row.Add(fila.Cell(2).GetValue<String>());
                row.Add(fila.Cell(3).GetValue<String>());
                row.Add(fila.Cell(4).GetValue<String>());
                row.Add(fila.Cell(5).GetValue<String>());
                row.Add(fila.Cell(6).GetValue<String>());
                datos.Add(row);
            }
            return datos;
        }
    }
}
