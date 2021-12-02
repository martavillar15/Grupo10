using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.DBManager.DB
{
    internal class DBManager : IDBManager
    {
        private DBManager() { 
        
        }

        #region METHODS

        public DataSet ExecuteDataSet(string pUser, string pProcedure, object[] pParams)
        {
            try
            {
                //TODO: buena traza con string format
                DataSet result = new DataSet();

                //1.- DataBase connection
                GetConnection();

                //2.- Execute procedure GetClients
                //3.- Mapping select to DataSet





                return result;

            }
            catch(Exception ex)
            {
                //TODO: traza error
                throw;
            }
        }

        public void ExecuteNonQuery(string pUser, string pQuery) 
        {
            try
            {
                //TODO: buena traza

            }
            catch (Exception ex)
            {
                //TODO: traza error ex
                throw;
            }
        }

        //Establish connection with the database
        private void GetConnection()
        {

        }



        #endregion


    }
}
