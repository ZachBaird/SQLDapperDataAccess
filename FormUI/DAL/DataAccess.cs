using FormUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using FormUI.Helpers;

namespace FormUI.DAL
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("SampleDB")))
            {
                return connection.Query<Person>($"dbo.spPeople_GetByLastName @LastName", new { LastName = lastName }).ToList();                
            }
        }

        public List<Person> GetAllPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("SampleDB")))
            {
                return connection.Query<Person>("dbo.spPeople_GetAll").ToList();
            }
        }

        public void AddPerson(string firstName, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("SampleDB")))
            {
                var newPerson = new Person
                {                    
                    FirstName = firstName,
                    LastName = lastName
                };

                var people = new List<Person>();
                people.Add(newPerson);

                connection.Execute("dbo.spPeople_Insert @FirstName, @LastName", 
                        people);
            }
        }
    }
}
