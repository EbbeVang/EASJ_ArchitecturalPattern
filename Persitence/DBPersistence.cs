using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelClassLibrary;

namespace Persitence
{
    public class DBPersistence : ITapasService
    {
        private SqlConnection _connection;
        private readonly static DBPersistence _instance = new DBPersistence();

        public static DBPersistence Instance
        {
            get { return _instance; }
        }

        private DBPersistence()
        {
            String connectionString = @"Data Source=(localdb)\Projects;Initial Catalog=TapasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }


        public List<Tapas> GetAllTapas()
        {
            String sql = "select * from Tapas";
            SqlCommand sqlCommand = new SqlCommand(sql,_connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Tapas> tapasList = new List<Tapas>();
            while (reader.Read())
            {
                Tapas tapas = new Tapas();
                tapas.TapasNo = reader.GetInt32(0);
                tapas.Name = reader.GetString(1);
                tapas.Price = Convert.ToDouble(reader.GetDecimal(2));

                tapasList.Add(tapas);
            }

            reader.Close();
            return tapasList;

        }
    }
}
