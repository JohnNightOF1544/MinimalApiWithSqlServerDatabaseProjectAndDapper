using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class PersonData : IPersonData
    {
        private readonly ISqlDataAccess _db;

        public PersonData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<PersonModel>> GetPerson() =>
            _db.LoadData<PersonModel, dynamic>(storedProcedure: "dbo.spPerson_GetAll", new { });

        public async Task<PersonModel> GetPerson(int id)
        {
            var results = await _db.LoadData<PersonModel, dynamic>(
                storedProcedure: "dbo.spPerson_Get",
                new { Id = id });

            return results.FirstOrDefault();
        }

        public Task AddPerson(PersonModel person) =>
            _db.SaveData(storedProcedure: "dbo.spPerson_Add", new
            {
                
                person.Firstname,
                person.Middlename,
                person.Lastname,
                person.Birthdate,
                person.Address,
                person.Active
            });

        public Task UpdatePerson(PersonModel person) =>
            _db.SaveData(storedProcedure: "dbo.spPerson_update", person );

        public Task DeletePerson(int id) =>
            _db.SaveData(storedProcedure: "dbo.spPerson_Delete", new { Id = id });
    }
}
