using Dapper;
using SQLIte_API_Test.Models;
using System.Data;
using System.Data.SQLite;

namespace SQLIte_API_Test.Repositories.PersonRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;
        private readonly IConfiguration _config;

        public PersonRepository(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("Default");
        }

        public IEnumerable<Person> GetPeople()
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string sql = "select * from Person";
                var people = connection.Query<Person>(sql);
                return people;
            }
        }

        public Person GetPeopleById(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string sql = "select * from Person where Id=@id";
                var person = connection.QueryFirstOrDefault<Person>(sql, new { @id });
                return person;
            }
        }

        public Person AddPerson (Person person)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string sql = @"insert into person (FirstName,LastName) values (@Firstname,@LastName);
                            SELECT last_insert_rowid()";
                int createdId = connection.ExecuteScalar<int>(sql, new
                {
                    person.FirstName,
                    person.LastName
                });
                person.Id = createdId;
                return person;
            }
        }

        public async Task UpdatePerson (Person person)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string sql = @"uptade Person set FirstName=@FirstName,LastName=@LastName where Id=@Id";
                connection.Execute(sql, new { person });
            }
        }

        public async Task DeletePersonById (int id)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string sql = @"delete from Person where Id=@id";
                connection.Execute(sql, new { id });
            }
        }
    }
}
