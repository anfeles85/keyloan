using KeyLoan.models;
using KeyLoan.utils;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KeyLoan.database
{
    internal class DBEmployee : DBConnection
    {
        public DBEmployee() : base()
        {
            
        }
        public DataTable GetAllEmployees()
        {
            DataTable dataTable = null;
            try
            {
                string query = "SELECT document as Documento, fullname as Nombre, address as Dirección, phone as Teléfono, " +
                                "description AS Tipo FROM employee, employee_type WHERE employee.type_id = employee_type.id ORDER By document";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(mySqlCommand);
                dataTable = new DataTable();  
                mySqlAdapter.Fill(dataTable);
                mySqlAdapter.Dispose();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener los empleados: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public Employee GetEmployee(long document)
        {
            Employee employee = null;
            try
            {
                string query = "SELECT document, fullname, address, phone, employee_type.id " +
                                "FROM employee, employee_type WHERE document = @document AND employee.type_id = employee_type.id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@document", document);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    employee = new Employee();
                    employee.Document = Convert.ToInt64(reader["document"].ToString());
                    employee.Fullname = reader["fullname"].ToString();
                    employee.Address = reader["address"].ToString();
                    employee.Phone = reader["phone"].ToString();
                    employee.Type = Convert.ToInt32(reader["id"].ToString());
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener el empleados: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return employee;
        }
        public bool Insert(Employee employee)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO employee VALUES (@document, @fullname, @address, @phone, @type)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                // Agregar parámetros para evitar inyección SQL
                mySqlCommand.Parameters.AddWithValue("@document", employee.Document);
                mySqlCommand.Parameters.AddWithValue("@fullname", employee.Fullname);
                mySqlCommand.Parameters.AddWithValue("@address", employee.Address);
                mySqlCommand.Parameters.AddWithValue("@phone", employee.Phone);
                mySqlCommand.Parameters.AddWithValue("@type", employee.Type);
                mySqlCommand.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al insertar el empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool Delete(long document)
        {
            bool result = false;
            try
            {
                string query = "DELETE FROM employee WHERE document = @document";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@document", document);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool Update(Employee employee)
        {
            bool result = false;
            try
            {
                string query = "UPDATE employee SET fullname = @fullname, address = @address, phone = @phone, type_id = @type "+
                                    "WHERE document = @document";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());                
                mySqlCommand.Parameters.AddWithValue("@fullname", employee.Fullname);
                mySqlCommand.Parameters.AddWithValue("@address", employee.Address);
                mySqlCommand.Parameters.AddWithValue("@phone", employee.Phone);
                mySqlCommand.Parameters.AddWithValue("@type", employee.Type);
                mySqlCommand.Parameters.AddWithValue("@document", employee.Document);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al actualizar el empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
    }
}
