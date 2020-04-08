using System;
using System.Collections.Generic;
using System.Text;

namespace MTC.Model
{
    public class TerminoReferencia
    {
        public int Id { get; set; }
        public string Objeto { get; set; }
        public string FinalidadPublica { get; set; }
        public string DuracionServicio { get; set; }
        public string FormaPago { get; set; }
        public decimal Sueldo{ get; set; }
        public decimal ImporteTotal { get; set; }
        public int NumRequerimiento { get; set; }
        public string NumOrdenServicio { get; set; }
        public int NumSIAF { get; set; }
        public DateTime FechaInicio { get; set; }
        public string DocRetencion { get; set; }
        public string DocSunedu { get; set; }
        public string DocSeguro { get; set; }




        //public Personal Personal { get; set; }
        //public int PersonalId { get; set; }

    }
}
