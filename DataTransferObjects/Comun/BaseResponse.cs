namespace DataTransferObjects.Comun
{
    public abstract class BaseResponse
    {
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
        public string Pila { get; set; }
    }
}