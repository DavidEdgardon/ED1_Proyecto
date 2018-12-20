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
        private extern static int guardarRutas(String ID, String desde, String hasta, double distancia);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int eliminarRuta(String _id);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int editarRuta(String ID, String nuevo, String desde, String hasta, double distacia);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int CaminoRuta(String desde, String hasta);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int Guardar_Lugares (String ID, double longi, double lati, String lugares);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int borrarLugares(String id);
        [DllImport(DLllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int  editarLugares(String ID, String nuevo, double longi, double lati);


        public static int BorrarLugares(string id)
        {

            return BorrarLugares(id);

        }

        public static int EditarLugares(string ID, string nuevo, double longi, double lati)
        {

            return editarLugares(ID, nuevo, longi, lati);
        }



        public static int  GuardarLugares(string ID, double longi, double lati, string lugares)
        {

            return Guardar_Lugares(ID, longi, lati, lugares);
        }




        public static int GuardarRutas(string id, string desde , string hasta , double distancia)
        {


            return guardarRutas(id, desde, hasta, distancia);
        }


        public static int EliminarRuta (string id)
        {


            return eliminarRuta(id);
        }


        public static int EditarRuta(string ID, string nuevo, string desde, string hasta, double distacia)
        {

            return editarRuta(ID, nuevo, desde, hasta, distacia);

        }

        public static int CaminoRutass(string desde,string hasta)
        {
            return CaminoRuta(desde, hasta);
        }



    }
}
