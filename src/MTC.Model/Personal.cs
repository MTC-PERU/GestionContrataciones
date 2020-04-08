using System;
using System.Collections.Generic;
using System.Text;

namespace MTC.Model
{
    public class Personal
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
        // Pendiente agregar ubigeo
        //public bool flag_Activo { get; set; }

       // public List<TerminoReferencia> TerminoReferencias { get; set; }
    }
}
