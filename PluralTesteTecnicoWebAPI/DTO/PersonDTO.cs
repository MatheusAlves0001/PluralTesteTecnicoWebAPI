using PluralTesteTecnicoWebAPI.Enum.PeopleEnums;

namespace PluralTesteTecnicoWebAPI.DTO
{
    public class PersonDTO
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public short YearsOld { get; set; }
        public string Municipality { get; set; }
    }
}
