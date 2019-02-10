namespace DataTransferObjects.Request
{
    public class FiltroComunRequest
    {
        public string Filtro { get; set; }
        public int Id { get; set; }

        public FiltroComunRequest()
        {
            Filtro = string.Empty;
        }
    }
}