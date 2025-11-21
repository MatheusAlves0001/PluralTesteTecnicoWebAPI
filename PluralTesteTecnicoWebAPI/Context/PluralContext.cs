using PluralTesteTecnicoWebAPI.Model;

namespace PluralTesteTecnicoWebAPI.Context
{
    public class PluralContext
    {
        public List<Person> Persons { get; set; }
        public PluralContext() {
            Persons = new Person().PersonsMock();
        }

    }
}
