namespace PluralTesteTecnicoWebAPI.DTO
{
    public class Pagination<T>
    {
        public List<T> Data { get; set; }
        public int TotalElements { get; set; }

        public Pagination(List<T> data, int totalElements) { 
            Data = data;
            TotalElements = totalElements;
        }
    }
}
