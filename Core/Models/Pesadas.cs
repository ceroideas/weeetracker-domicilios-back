using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Pesadas
    {
        public int PidPesada { get; set; }
        public DateTime Fecha { get; set; }
        public string SidCertificado { get; set; }
        public float Peso { get; set; }
        public int? SidFraccion { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccion { get; set; }
        public string SidCertificadoSubordinado { get; set; }

        public Certificados SidCertificadoNavigation { get; set; }
        public DireccionesTercero SidDireccionNavigation { get; set; }
        public Fracciones SidFraccionNavigation { get; set; }
        public Terceros SidTerceroNavigation { get; set; }
    }
}
