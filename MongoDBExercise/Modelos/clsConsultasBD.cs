using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    /// <summary>
    /// Contiene consultas para poder manipular la base de datos.
    /// </summary>
    public static class clsConsultasBD
    {
        /// <summary>
        /// Obtiene todas las computadoras de la base de datos.
        /// </summary>
        /// <returns> Lista de computadoras.</returns>
        public static List<clsComputadoraModelo> ObtenerTodasComputadoras()
        {
            var Computadoras = clsConexionMongo.ObtenerColeccion();
            List<clsComputadoraModelo> lstComputadoras = Computadoras.Find(d => true).ToList();
            return lstComputadoras;
        }

        /// <summary>
        /// Inserta una computadora en la base de datos.
        /// </summary>
        /// <param name="oComputadora">Objeto de la computadora a insertar.</param>
        public static void InsertarComputadora(clsComputadoraModelo oComputadora)
        {
            var Computadoras = clsConexionMongo.ObtenerColeccion();
            Computadoras.InsertOne(oComputadora);
        }
        
        /// <summary>
        /// Actualiza una computadora de la base de datos.
        /// </summary>
        /// <param name="oComputadora">Objeto de la computadora a actualizar.</param>
        public static void ActualizarComputadora(clsComputadoraModelo oComputadora)
        {
            var Comptuadoras = clsConexionMongo.ObtenerColeccion();
            Comptuadoras.ReplaceOne( d => d.sNombreComputadora == oComputadora.sNombreComputadora, oComputadora );
        }

        /// <summary>
        /// Eliminar una computadora de la base de datos.
        /// </summary>
        /// <param name="oComputadora">Objeto de la computadora a eliminar.</param>
        public static void EliminarComputadora(clsComputadoraModelo oComputadora)
        {
            var Computadoras = clsConexionMongo.ObtenerColeccion();
            Computadoras.DeleteOne( d => d.sNombreComputadora == oComputadora.sNombreComputadora );
        }

        /// <summary>
        /// Buscar una computadora en la base de datos.
        /// </summary>
        /// <param name="sNombreComputadora">Nombre de la computadora a buscar.</param>
        /// <returns>Objeto de la computadora en caso de existir, de lo contrario el valor será nulo.</returns>
        public static clsComputadoraModelo BuscarComputadora(string sNombreComputadora)
        {
            try
            {
                var Computadoras = clsConexionMongo.ObtenerColeccion();
                clsComputadoraModelo oComputadora = Computadoras.Find( d => d.sNombreComputadora == sNombreComputadora ).First();
                return oComputadora;
            }catch(Exception ex)
            {
                return null;
            } 
        }
    }
}
