using SQLIte_API_Test.Models;
using System.Data;

namespace SQLIte_API_Test.Repositories.PersonRepository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPeopleById(int id);

        Person AddPerson(Person person);

        Task UpdatePerson(Person person);

        Task DeletePersonById(int id);
    }
}
