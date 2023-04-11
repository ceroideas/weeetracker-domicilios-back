using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class IndicadoresDireccionTerceroFraccion
    {
        public int PidIndicadorDireccionTerceroFraccion { get; set; }
        public int Mes { get; set; }
        public int Trimestre { get; set; }
        public int Anyo { get; set; }
        public DateTime Fecha { get; set; }
        public int SidDireccionTercero { get; set; }
        public int SidFraccion { get; set; }
        public int NumRaeetratado { get; set; }
        public int NumRaeerecogido { get; set; }
        public int NumRaeerecogidoCanibalizado { get; set; }
        public double SumVidaRaee { get; set; }
        public double SumVidaRaeetercero { get; set; }
        public double SumTrazabilidadTercero { get; set; }
        public int NumCertificadosRecogida { get; set; }
        public int NumRaeeperdidos { get; set; }
        public int NumRaeeconFoto { get; set; }
        public int NumRaeelecturas { get; set; }
        public double SumDistanciaHastaTratamiento { get; set; }
        public double SumDistanciaHastaTratamientoTramos { get; set; }
        public int NumRaeetratadoComoPlanta { get; set; }
        public double SumVidaRaeetratadoComoPlanta { get; set; }
        public int NumRaeetratadoComoPlantaCanibalizado { get; set; }
        public double SumDistanciaHastaTratamientoComoPlanta { get; set; }
        public double SumDistanciaHastaTratamientoTramosComoPlanta { get; set; }
        public int NumRaeerecogidoInicial { get; set; }

        public DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public Fracciones SidFraccionNavigation { get; set; }
    }
}
