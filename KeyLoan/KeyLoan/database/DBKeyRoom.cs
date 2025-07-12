using KeyLoan.models;
using KeyLoan.utils;
using MySql.Data.MySqlClient;
using System.Data;

namespace KeyLoan.database
{
    internal class DBKeyRoom :  DBConnection
    {
        public DBKeyRoom() : base() 
        {
        }

        public DataTable GetAllKeys()
        {
            DataTable dataTable = null;
            try
            {
                string query = "SELECT id, name as Nombre, room as Aula, count as Cantidad, " +
                                "observation AS Observación FROM key_room ORDER By id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(mySqlCommand);
                dataTable = new DataTable();
                mySqlAdapter.Fill(dataTable);
                mySqlAdapter.Dispose();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener las llaves: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public KeyRoom GetKey(int id)
        {
            KeyRoom key = null;
            try
            {
                string query = "SELECT id, name, room, count, observation FROM key_room WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    key = new KeyRoom();
                    key.Id = id;
                    key.Name = reader["name"].ToString();
                    key.Room = reader["room"].ToString();
                    key.Count = Convert.ToInt32(reader["count"].ToString());
                    key.Observation = reader["observation"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al obtener la llave: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return key;
        }
        public bool Insert(KeyRoom key)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO key_room VALUES (null, @name, @room, @count, @observation)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                // Agregar parámetros para evitar inyección SQL
                mySqlCommand.Parameters.AddWithValue("@name", key.Name);
                mySqlCommand.Parameters.AddWithValue("@room", key.Room);
                mySqlCommand.Parameters.AddWithValue("@count", key.Count);
                mySqlCommand.Parameters.AddWithValue("@observation", key.Observation);
                mySqlCommand.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al insertar la llave: " + ex.Message);
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
                string query = "DELETE FROM key_room WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@id", id);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al eliminar la llave: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool Update(KeyRoom key)
        {
            bool result = false;
            try
            {
                string query = "UPDATE key_room SET name = @name, room = @room, count = @count, observation = @observation " +
                                    "WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand(query, GetConnection());
                mySqlCommand.Parameters.AddWithValue("@name", key.Name);
                mySqlCommand.Parameters.AddWithValue("@room", key.Room);
                mySqlCommand.Parameters.AddWithValue("@count", key.Count);
                mySqlCommand.Parameters.AddWithValue("@observation", key.Observation);
                mySqlCommand.Parameters.AddWithValue("@id", key.Id);
                mySqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageUtils.showErrorMessage("Error al actualizar la llave: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
    
    }
}
