using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MapaProyecto1
{
    class BackEnd
    {

        private const string DLllFilePath = @"C:\\Users\\ASUS\\Desktop\\Dll test2\\Debug\\Dll test2.dll";
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int guardarRutas(double ID, double longi, double lati, String lugar);


        public static int GuardarRutas(double ID, double longi, double lati, string lugar)

        {
           return guardarRutas(ID, longi, lati, lugar);


        }
    }
}