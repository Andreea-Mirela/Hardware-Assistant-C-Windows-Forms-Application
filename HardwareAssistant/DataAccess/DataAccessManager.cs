using HardwareAssistant.Constants;
using System;
using System.Configuration;

namespace HardwareAssistant.DataAccess
{
    public static class DataAccessManager
    {
        //Metoda GetDataAccess returneaza o instanta a unei clase ce implementeaza interfata IDataAccess;
        public static IDataAccess GetDataAccess()
        {
            //se citeste parametrul din fisierul de configurare
            string dataSourceType = ConfigurationManager.AppSettings["DataSourceType"];

            IDataAccess dataAccess;//se declara o variabila de tipul interfata idataccess
            switch (dataSourceType)
            {
                case DataSourceType.Json://daca valoarea parametrului este json se instantiaza variabila de tip IDataAccess cu clasa JsonDataAccess
                    dataAccess = new JsonDataAccess();
                    break;

                case DataSourceType.Sql://daca valoarea parametrului este sql se instantiaza variabila de tip IDataAccess cu clasa SqlDataAccess
                    dataAccess = new SqlDataAccess();
                    break;

                default://daca valoarea parametrului nu e nici json nici sql se arunca eroarea 
                    throw new Exception($"Data source type '{dataSourceType}' is not recognized. Please set one of the following values: 'Json', 'Sql'.");
            }

            return dataAccess;//se returneaza instanta creata anterior
        }
    }
}
