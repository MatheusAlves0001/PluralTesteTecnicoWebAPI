using PluralTesteTecnicoWebAPI.Enum.Context;
using PluralTesteTecnicoWebAPI.Enum.PeopleEnums;

namespace PluralTesteTecnicoWebAPI.Model
{
    public class Person
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public short YearsOld { get; set; }
        public string Municipality { get; set; }       

        public List<Person> PersonsMock(){
            return new List<Person>
            {
                new Person { CPF = "11111111111", Name = "Ana Silva", Gender = Gender.Female, Address = "Rua das Flores, 123", YearsOld = 28, Municipality = "São Paulo", State = "SP" },
                new Person { CPF = "22222222222", Name = "João Pereira", Gender = Gender.Male, Address = "Av. Central, 45", YearsOld = 35, Municipality = "Rio de Janeiro", State = "RJ" },
                new Person { CPF = "33333333333", Name = "Marcos Oliveira", Gender = Gender.Male, Address = "Rua A, 10", YearsOld = 42, Municipality = "Belo Horizonte", State = "MG" },
                new Person { CPF = "44444444444", Name = "Carla Mendes", Gender = Gender.Female, Address = "Rua B, 75", YearsOld = 31, Municipality = "Curitiba", State = "PR" },
                new Person { CPF = "55555555555", Name = "Bruno Santos", Gender = Gender.Male, Address = "Av. Brasil, 500", YearsOld = 26, Municipality = "Porto Alegre", State = "RS" },
                new Person { CPF = "66666666666", Name = "Fernanda Rocha", Gender = Gender.Female, Address = "Rua Nova, 22", YearsOld = 29, Municipality = "Florianópolis", State = "SC" },
                new Person { CPF = "77777777777", Name = "Lucas Nunes", Gender = Gender.Male, Address = "Rua Verde, 88", YearsOld = 33, Municipality = "Salvador", State = "BA" },
                new Person { CPF = "88888888888", Name = "Mariana Castro", Gender = Gender.Female, Address = "Rua Azul, 14", YearsOld = 27, Municipality = "Fortaleza", State = "CE" },
                new Person { CPF = "99999999999", Name = "Paulo Lima", Gender = Gender.Male, Address = "Av. Beira Mar, 300", YearsOld = 40, Municipality = "Recife", State = "PE" },
                new Person { CPF = "10101010101", Name = "Juliana Alves", Gender = Gender.Female, Address = "Rua do Sol, 90", YearsOld = 32, Municipality = "Manaus", State = "AM" },

                new Person { CPF = "12121212121", Name = "Rafael Martins", Gender = Gender.Male, Address = "Rua das Acácias, 12", YearsOld = 36, Municipality = "Belém", State = "PA" },
                new Person { CPF = "13131313131", Name = "Patrícia Gomes", Gender = Gender.Female, Address = "Rua do Norte, 39", YearsOld = 25, Municipality = "Goiânia", State = "GO" },
                new Person { CPF = "14141414141", Name = "Diego Andrade", Gender = Gender.Male, Address = "Rua Oeste, 100", YearsOld = 30, Municipality = "Campo Grande", State = "MS" },
                new Person { CPF = "15151515151", Name = "Letícia Moura", Gender = Gender.Female, Address = "Rua da Paz, 5", YearsOld = 22, Municipality = "Natal", State = "RN" },
                new Person { CPF = "16161616161", Name = "Gabriel Souza", Gender = Gender.Male, Address = "Av. Leste, 200", YearsOld = 41, Municipality = "João Pessoa", State = "PB" },
                new Person { CPF = "17171717171", Name = "Aline Matos", Gender = Gender.Female, Address = "Rua Sul, 13", YearsOld = 34, Municipality = "Aracaju", State = "SE" },
                new Person { CPF = "18181818181", Name = "Ricardo Teixeira", Gender = Gender.Male, Address = "Rua Oeste, 90", YearsOld = 38, Municipality = "Vitória", State = "ES" },
                new Person { CPF = "19191919191", Name = "Daniela Fernandes", Gender = Gender.Female, Address = "Rua Praia, 3", YearsOld = 37, Municipality = "Maceió", State = "AL" },
                new Person { CPF = "20202020202", Name = "Rodrigo Dias", Gender = Gender.Male, Address = "Rua Centro, 77", YearsOld = 44, Municipality = "Teresina", State = "PI" },

                new Person { CPF = "21212121212", Name = "Sabrina Freitas", Gender = Gender.Female, Address = "Rua Lagoa, 11", YearsOld = 23, Municipality = "Cuiabá", State = "MT" },
                new Person { CPF = "22232323232", Name = "Eduardo Barros", Gender = Gender.Male, Address = "Av. Oeste, 81", YearsOld = 39, Municipality = "Porto Velho", State = "RO" },
                new Person { CPF = "23232323232", Name = "Camila Reis", Gender = Gender.Female, Address = "Rua Vitória, 66", YearsOld = 28, Municipality = "Rio Branco", State = "AC" },
                new Person { CPF = "24242424242", Name = "Thiago Farias", Gender = Gender.Male, Address = "Rua Horizonte, 7", YearsOld = 21, Municipality = "Macapá", State = "AP" },
                new Person { CPF = "25252525252", Name = "Bianca Lopes", Gender = Gender.Female, Address = "Av. Pôr do Sol, 120", YearsOld = 30, Municipality = "Boa Vista", State = "RR" },
                new Person { CPF = "26262626262", Name = "Marcelo Batista", Gender = Gender.Male, Address = "Rua Estrela, 9", YearsOld = 45, Municipality = "Palmas", State = "TO" },
                new Person { CPF = "27272727272", Name = "Tatiana Cunha", Gender = Gender.Female, Address = "Rua Nova Era, 60", YearsOld = 33, Municipality = "Santos", State = "SP" },
                new Person { CPF = "28282828282", Name = "Henrique Prado", Gender = Gender.Male, Address = "Av. Oceânica, 212", YearsOld = 29, Municipality = "Niterói", State = "RJ" },
                new Person { CPF = "29292929292", Name = "Nicole Bernardes", Gender = Gender.Female, Address = "Rua da Serra, 15", YearsOld = 27, Municipality = "Campinas", State = "SP" },
                new Person { CPF = "30303030303", Name = "Vitor Lopes", Gender = Gender.Male, Address = "Rua Liberdade, 4", YearsOld = 24, Municipality = "Sorocaba", State = "SP" }
            };
        }

    }
}
