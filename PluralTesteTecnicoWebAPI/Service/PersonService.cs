using Microsoft.OpenApi.Extensions;
using PluralTesteTecnicoWebAPI.Context;
using PluralTesteTecnicoWebAPI.DTO;

namespace PluralTesteTecnicoWebAPI.Service
{
    public class PersonService
    {
        private readonly PluralContext _context;
        public PersonService(PluralContext context)
        {
            _context = context;
        }

        public Pagination<PersonDTO> GetAll(string name, int page, int size)
        {
            var persons = _context.Persons;

            if (!string.IsNullOrEmpty(name))
                persons = persons.Where(p => p.Name.Contains(name)).ToList();

            var totalElements = persons.Count();

            persons = persons.Skip(page * size).Take(size).ToList();

            var personToDto = persons.Select(person => new PersonDTO()
            {
                CPF = person.CPF,
                Name = person.Name,
                State = person.State,
                Address = person.Address,
                YearsOld = person.YearsOld,
                Municipality = person.Municipality,
                Gender = person.Gender == Enum.PeopleEnums.Gender.Female ? "Female" : "Male",
            }).ToList();

            return new Pagination<PersonDTO>(personToDto, totalElements);
        }
    }
}
