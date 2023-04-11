using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Common;

namespace WeeeTrackerAPI.Entities
{
    public class Residuo
    {
        public int Id { get; set; }
        public int IdTercero { get; set; }
        public int IdCentro { get; set; }
        public int IdResiduo { get; set; }
        public int IdMarca { get; set; }
        public string Fecha { get; set; }
        public string Albaran { get; set; }
        public string Nombre { get; set; }
        public string Etiqueta { get; set; }
        public string DNI { get; set; }
        public string NumSerie{ get; set; }
        public bool Funciona { get; set; }
        public bool Canibalizado { get; set; }
        public string[] Imagenes  { get; set; }
        public TipoEstadoIdentificacion Tipo{ get; set; }
        
        public Coordenada Coordenadas { get; set; }

        public List<Archivo> ListaArchivos { get; set; }

        public Residuo()
        {
            Coordenadas = new Coordenada();
            ListaArchivos = new List<Archivo>();
        }
    }
    public class Coordenada
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}