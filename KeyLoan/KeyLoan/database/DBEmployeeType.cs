using KeyLoan.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoan.database
{
    internal class DBEmployeeType : DBConnection
    {
        public DBEmployeeType() : base() 
        { }

        public DataTable GetAllEmployeeTypes()
        {
            DataTable dataTable = null;
            try
            {
                string query = "SELECT id, description from employee_type";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(mySqlCommand);
                dataTable = new DataTable();
                mySqlAdapter.Fill(dataTable);
                mySqlAdapter.Dispose();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener los tipos de empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
    }
}
