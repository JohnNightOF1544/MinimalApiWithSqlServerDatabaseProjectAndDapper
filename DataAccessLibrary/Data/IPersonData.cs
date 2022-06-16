using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IPersonData
    {
        Task AddPerson(PersonModel person);
        Task DeletePerson(int id);
        Task<IEnumerable<PersonModel>> GetPerson();
        Task<PersonModel> GetPerson(int id);
        Task UpdatePerson(PersonModel person);
    }
}