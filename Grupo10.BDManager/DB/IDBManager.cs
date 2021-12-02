using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.DBManager.DB
{
    public interface IDBManager
    {
        /// <summary>
        /// This method allows to execute a store procedure and store that information in a DataSet
        /// <paramref name="pUser"/>
        /// <paramref name="pProcedure"/>
        /// <paramref name="pParams"/>
        /// <returns> This method return a DataSet </returns>
        /// </summary>
        DataSet ExecuteDataSet(string pUser, string pProcedure, object[] pParams);
        void ExecuteNonQuery(string pUser, string pQuery);

        /* TODO
         - Incluir más llamadas:
            * Opcion de volcar una tabla directamente en bbdd
            * Timeout
            * Queries con abrir y cerrar transaccion
         */




    }
}
