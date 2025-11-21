using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PluralTesteTecnicoWebAPI.Enum.Context
{
    public enum Ordenation
    {
        [Display(Name = "asc")]
        Asc = 0,
        [Display(Name = "desc")]
        Desc = 1
    }
}
