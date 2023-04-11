using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;

using System;
using System.Security.Claims;

using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Common;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class StockController : ControllerBase
    {
        private IStock _stockService;
        
        public StockController(IStock stockService)
        {
            _stockService = stockService;               
        }

        [HttpPost]
        public IActionResult GetStock([FromBody] Stock stock)
        {
            try
            {
                Stock resumenStock = _stockService.GetStock(stock.IdTercero, stock.IdCentro);
                if(resumenStock == null)
                    return NotFound(new { stock = Errores.StockNoExiste });

                return Ok(new { stock = resumenStock });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("stock-usuario/{idusuario}/{idCentro}")]
        public IActionResult StockUsuario(int idUsuario, int idCentro)
        {
            var stockUsuario = _stockService.StockUsuario(idUsuario,idCentro);
            return Ok(new {stock = stockUsuario});
        }
    }
}
