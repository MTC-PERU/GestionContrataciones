namespace MTC.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string  ApellidoPaterno { get; set; }
        public string  ApellidoMaterno { get; set; }

        public string DNI { get; set; }
        public string RUC { get; set; }
    }
}
