using System.ComponentModel.DataAnnotations;

namespace MTC.Model.DTOs
{
    public class UsuarioCreateDto
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        [Required]
        public string DNI { get; set; }
        [Required]
        public string RUC { get; set; }
    }

    public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        
        public string Nombre { get; set; }
        
        public string ApellidoPaterno { get; set; }
        
        public string ApellidoMaterno { get; set; }
        
        public string DNI { get; set; }
        
        public string RUC { get; set; }
    }
}
