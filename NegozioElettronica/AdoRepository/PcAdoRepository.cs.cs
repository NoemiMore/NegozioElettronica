using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.AdoRepository
{
    class PcAdoRepository : IPcDbManager
    {
        // mi connetto ad DB  E le tengo costanti

        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = NegozioElettronica;" +
                                         "Integrated Security = true;";

        const string _discriminator = "Pc";





        public void Delete(Pc pc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "delete from Vehicle where Id = @id";
                command.Parameters.AddWithValue("@id", car.Id);

                command.ExecuteNonQuery();
            }
        }




        public List<Pc> Fetch()
        {
            throw new NotImplementedException();
        }

        public Pc GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pc pc)
        {
            throw new NotImplementedException();
        }

        public void Update(Pc pc)
        {
            throw new NotImplementedException();
        }
    }
}
