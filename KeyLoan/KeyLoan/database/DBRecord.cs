using KeyLoan.models;
using KeyLoan.utils;
using MySql.Data.MySqlClient;
using System.Data;

namespace KeyLoan.database
{
    internal class DBRecord : DBConnection
    {
        public DBRecord() { }

        public DataTable GetAllRecords()
        {
            DataTable dataTable = null;
            try
            {
                string query = "SELECT record.id as Id, date_record as Fecha, start_time as Hora_inicio, end_time as Hora_fin, " +
                                "employee.fullname AS Empleado, key_room.name AS Llave, status AS Estado FROM record, employee, key_room WHERE " +
                                "employee.document = record.employee_id AND key_room.id = record.key_id ORDER By id DESC";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(mySqlCommand);
                dataTable = new DataTable();
                mySqlAdapter.Fill(dataTable);
                mySqlAdapter.Dispose();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener los registros: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public Record GetRecord(int id)
        {
            Record record = null;
            try
            {
                string query = "SELECT date_record, start_time, end_time, employee_id, key_id, status " +
                                "FROM record WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    record = new Record();
                    record.Id = id;
                    record.DateRecord = reader["date_record"].ToString();
                    record.StartTime = reader["start_time"].ToString();
                    record.EndTime = reader["end_time"].ToString();
                    record.EmployeeId = Convert.ToInt64(reader["employee_id"].ToString());
                    record.KeyId = Convert.ToInt32(reader["key_id"].ToString());
                    record.Status = reader["status"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener el registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return record;
        }
        public bool Insert(Record record)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO record VALUES (null, @date_record, @start_time, @end_time, @employee_id, @key_id, @status)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                // Agregar parámetros para evitar inyección SQL
                mySqlCommand.Parameters.AddWithValue("@date_record", record.DateRecord);
                mySqlCommand.Parameters.AddWithValue("@start_time", record.StartTime);
                mySqlCommand.Parameters.AddWithValue("@end_time", record.EndTime);
                mySqlCommand.Parameters.AddWithValue("@employee_id", record.EmployeeId);
                mySqlCommand.Parameters.AddWithValue("@key_id", record.KeyId);
                mySqlCommand.Parameters.AddWithValue("@status", record.Status);
                mySqlCommand.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al insertar el registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                string query = "DELETE FROM record WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@id", id);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al eliminar el registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool Update(Record record)
        {
            bool result = false;
            try
            {
                string query = "UPDATE record SET date_record = @date_record, start_time = @start_time, end_time = @end_time, " + 
                                "employee_id = @employee_id, key_id = @key_id, status = @status WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@date_record", record.DateRecord);
                mySqlCommand.Parameters.AddWithValue("@start_time", record.StartTime);
                mySqlCommand.Parameters.AddWithValue("@end_time", record.EndTime);
                mySqlCommand.Parameters.AddWithValue("@employee_id", record.EmployeeId);
                mySqlCommand.Parameters.AddWithValue("@key_id", record.KeyId);
                mySqlCommand.Parameters.AddWithValue("@status", record.Status);
                mySqlCommand.Parameters.AddWithValue("@id", record.Id);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al actualizar el registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
    }
}
