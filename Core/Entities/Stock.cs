using System.Collections.Generic;

namespace WeeeTrackerAPI.Entities
{
    public class Stock
    {
        public int IdCentro { get; set; }
        public int IdTercero { get; set; }

        public List<StockResiduoEspecifico> listaStock { get; set; }

        public Stock()
        {
            listaStock = new List<StockResiduoEspecifico>();
        }
    }

    public class StockResiduoEspecifico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}