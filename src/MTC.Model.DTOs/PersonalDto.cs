using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MTC.Model.DTOs
{
    //public abstract class PersonalBaseDto
    //{
    //    [Required]
    //    public string Nombres { get; set; }
    //    [Required]
    //    public string Apellido_Paterno { get; set; }
    //    [Required]
    //    public string Apellido_Materno { get; set; }
    //    public string Direccion { get; set; }
    //    public string Perfil { get; set; }
    //    public string Experiencia_General { get; set; }
    //    public string Experiencia_Especifica { get; set; }
    //    public bool EsCoordinador { get; set; }
    //    [Required]
    //    public string Dni { get; set; }
    //    [Required]
    //    public string Ruc { get; set; }
    //    [Required]
    //    public string Email { get; set; }
    //    [Required]
    //    public string CCI { get; set; }
    //    [Required]
    //    public string Nro_Celular { get; set; }
    //}

    public class PersonalCreateDto 
    {
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellido_Paterno { get; set; }
        [Required]
        public string Apellido_Materno { get; set; }
        public string Direccion { get; set; }
        public string Perfil { get; set; }
        public string Experiencia_General { get; set; }
        public string Experiencia_Especifica { get; set; }
        public bool EsCoordinador { get; set; }
        [Required]
        public string Dni { get; set; }
        [Required]
        public string Ruc { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CCI { get; set; }
        [Required]
        public string Nro_Celular { get; set; }
    }



    public class PersonalUpdateDto 
    {
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellido_Paterno { get; set; }
        [Required]
        public string Apellido_Materno { get; set; }
        public string Direccion { get; set; }
        public string Perfil { get; set; }
        public string Experiencia_General { get; set; }
        public string Experiencia_Especifica { get; set; }
        public bool EsCoordinador { get; set; }
        [Required]
        public string Dni { get; set; }
        [Required]
        public string Ruc { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CCI { get; set; }
        [Required]
        public string Nro_Celular { get; set; }
    
    }

    public class PersonalDto  
    {
        public int PersonalId { get; set; }
        
        public string Nombres { get; set; }
        
        public string Apellido_Paterno { get; set; }
        
        public string Apellido_Materno { get; set; }
        public string Direccion { get; set; }
        public string Perfil { get; set; }
        public string Experiencia_General { get; set; } 
        public string Experiencia_Especifica { get; set; }
        public bool EsCoordinador { get; set; }
        
        public string Dni { get; set; }
        
        public string Ruc { get; set; }
        
        public string Email { get; set; }
        
        public string CCI { get; set; }
        
        public string Nro_Celular { get; set; }

        //public ICollection<TerminoReferencia> TerminoReferencias { get; set; }


    }
}
