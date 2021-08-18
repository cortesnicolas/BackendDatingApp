namespace API.Helpers
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            // Si el tamaño de la pagina sobre pasa los 50,
            // se seteara al maximo por pagina (50)
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}