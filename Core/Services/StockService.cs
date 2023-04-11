using System;
using System.Linq;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using Microsoft.Extensions.Logging;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Common;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Services
{
    public class StockService : IStock
    {
        private ILogger _logger;

        private GVRBD3Context _context;

        public StockService(GVRBD3Context context)
        {
            this._context = context;
        }

        public Object StockUsuario(int idUsuario, int idCentro)
        {
            Stock stock = new Stock();
            stock.IdCentro = idCentro;
            stock.IdTercero = idUsuario;

            // var listaStock = _context.WtkCambioEstado.Where(x=>x.SidUsuario == idUsuario && x.SidDireccionTercero == idCentro && (x.SidEstado == 12 || x.SidEstado == 13)).ToList();

            // return listaStock;

            List<StockResiduoEspecifico> listaStock = _context.WtkResiduoespecifico
                                                        .Select(item => new StockResiduoEspecifico
                                                        {
                                                            Id = item.Id,
                                                            Nombre = item.Nombre,
                                                            Cantidad = _context.Raees
                                                                            .SelectMany(r => 
                                                                                r.WtkCambioEstado,(parent, child) => new
                                                                                {
                                                                                    parent,
                                                                                    child
                                                                                }
                                                                            )
                                                                            .Where(r => 
                                                                                r.parent.PidRaee == r.child.SidRaee &&  
                                                                                r.parent.SidEstadoRaee == r.parent.SidEstadoRaeeNavigation.PidEstadoRaee && 
                                                                                r.child.SidUsuario == idUsuario &&
                                                                                r.child.SidDireccionTercero == idCentro &&
                                                                                (r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.domicilio ||
                                                                                r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.establecimiento) &&
                                                                                item.Id == r.parent.SidResiduoEspecifico
                                                                            )
                                                                            .Count()
                                                        })
                                                        .ToList();

            listaStock = listaStock.Where(l => l.Cantidad > 0).ToList();
            stock.listaStock = listaStock;

            return stock;
        }

        public Stock GetStock(int idTercero, int idCentro)
        {
            
            try
            {
                Stock stock = new Stock();
                stock.IdCentro = idCentro;
                stock.IdTercero = idTercero;

                List<StockResiduoEspecifico> listaStock = _context.WtkResiduoespecifico
                                                            .Select(item => new StockResiduoEspecifico
                                                            {
                                                                Id = item.Id,
                                                                Nombre = item.Nombre,
                                                                Cantidad = _context.Raees
                                                                                .SelectMany(r => 
                                                                                    r.WtkCambioEstado,(parent, child) => new
                                                                                    {
                                                                                        parent,
                                                                                        child
                                                                                    }
                                                                                )
                                                                                .Where(r => 
                                                                                    r.parent.PidRaee == r.child.SidRaee &&  
                                                                                    r.parent.SidEstadoRaee == r.parent.SidEstadoRaeeNavigation.PidEstadoRaee && 
                                                                                    r.child.SidTercero == idTercero &&
                                                                                    r.child.SidDireccionTercero == idCentro &&
                                                                                    r.parent.SidEstadoRaee == (int)TipoEstadoIdentificacion.entrada &&
                                                                                    r.child.SidEstado == (int)TipoEstadoIdentificacion.entrada &&
                                                                                    r.child.SidEstado != (int)TipoEstadoIdentificacion.salida && 
                                                                                    item.Id == r.parent.SidResiduoEspecifico
                                                                                )
                                                                                .Count()
                                                            })
                                                            .ToList();

                listaStock = listaStock.Where(l => l.Cantidad > 0).ToList();
                stock.listaStock = listaStock;

                return stock;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }
    }
}