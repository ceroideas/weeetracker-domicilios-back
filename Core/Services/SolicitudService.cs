using System;
using System.Linq;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;
using WeeeTrackerAPI.Core.Interfaces;
using ServiceEcoapp;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Common;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WeeeTrackerAPI.Services
{
    public class SolicitudService : ISolicitud
    {
        IConfiguration _config;
        CabeceraSoap _cabecera;
        ServiciosSoapClient _client;
        IUserService _userService;
        IResiduo _residuo;
        IResiduoEspecifico _residuoEspecifico;
        IFracciones _fraccion;
        ITiposContenedor _tipoContenedor;

        private GVRBD3Context _context;

        public SolicitudService(
            IConfiguration config, 
            IUserService userService, 
            IResiduo residuo, 
            IResiduoEspecifico residuoEspecifico,
            IFracciones fraccion,
            ITiposContenedor tipoContenedor,
            GVRBD3Context context)
        {
            _config = config;
            _cabecera = ServiceEcoAppConfig.GetCabeceraEcoApp(_config);
            _client = ServiceEcoAppConfig.GetClientEcoApp();

            _context = context;
            _userService = userService;
            _residuoEspecifico = residuoEspecifico;
            _residuo = residuo;
            _fraccion = fraccion;
            _tipoContenedor = tipoContenedor;

        }

        public async Task<XElement> GetSolicitudes(SolicitudFiltros solicitud)
        {
            try
            {
                //*****************************************************************************************************************************************
                //Descripci�n: Se obtendr�n las 10 �ltimas solicitudes de recogida(ordenadas por c�digo de solicitud) de un derteminado Origen.
                //*****************************************************************************************************************************************

                XMLObtenerSolicitudesOrigenResponse response = await _client.XMLObtenerSolicitudesOrigenAsync(_cabecera, solicitud.idTercero, solicitud.idCentro);

                return response.XMLObtenerSolicitudesOrigenResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<XMLRecepcionSolicitudesResponse> AltaSolicitudAsync(Entities.Solicitudes solicitudes)
        {
            try
            {

                //*****************************************************************************************************************************************
                //Descripci�n: Registro de nuevas solicitudes de recogida y asignaci�n de Operador Log�stico. 
                //La solicitud se guardar� en estado CON y, en caso de ser asignada, pasar� a estado ASG. 
                //Los posibles estados de una solicitud son los siguientes:
                //*****************************************************************************************************************************************

                string xml = XMLHelper.GetXML(solicitudes);
                if (!String.IsNullOrEmpty(xml))
                {
                    XMLRecepcionSolicitudesResponse response = await _client.XMLRecepcionSolicitudesAsync(_cabecera,xml);

                    return response;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CambioFechaEstimadaResponse> ValidacionSolicitud(SolicitudValidacion solicitud)
        {
            try
            {
                //*****************************************************************************************************************************************
                //Descripci�n: Actualiza la fecha de atenci�n de una solicitud y su estado a �ATN�.
                //*****************************************************************************************************************************************

                CambioFechaEstimadaResponse response = await _client.CambioFechaEstimadaAsync(_cabecera, solicitud.codSolicitud, solicitud.fechaRec);

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entities.Solicitudes SetDatosSolicitudesAlta(int idUsuario, SolicitudFiltros solicitud)
        {
            try
            {
                WtkUsuario usuario = _userService.getUsuarioById(idUsuario);
                if (usuario == null)
                    return null;

                Entities.Solicitudes solicitudes = new Entities.Solicitudes();
                Solicitud solicitudAlta = new Solicitud();

                solicitudAlta.fecha = DateTime.Today;
                solicitudAlta.codigoExt = string.Empty;
                solicitudAlta.albaranOrigen = solicitud.Albaran;
                solicitudAlta.terceroOri = usuario.SidTercero;
                solicitudAlta.tipoTerceroOri = usuario.SidTipoTercero; 
                solicitudAlta.direOri = solicitud.idCentro; 
                solicitudAlta.descripcion = Constantes.ObservAltaEcoapp;
                solicitudAlta.observaciones = solicitud.Observaciones;

                if (solicitud.ListaResiduosEspecificos.Count > 0)
                {                    
                    int cont = 0;
                    linea[] lineas = new linea[0];

                    foreach (SolicitudResiduoEspecifico residuo in solicitud.ListaResiduosEspecificos)
                    {
                        ResiduosEspecificos residuosEspecifico = _residuoEspecifico.getResiduoEspecificoById(residuo.IdResiduo);
                        if (residuosEspecifico != null)
                        {
                            Array.Resize(ref lineas, cont+1);

                            linea linea = new linea();

                            linea.frac = (int)residuosEspecifico.SidFraccion;
                            linea.res = (int)residuosEspecifico.SidResiduo;
                            linea.resEspe = residuo.IdResiduo;
                            linea.tipoCont = Constantes.SidTipoContenedor;
                            linea.uni = residuo.Unidades;
                            linea.kil = (int)residuosEspecifico.PesoEstimado * linea.uni;
                            linea.observaciones = string.Empty;

                            lineas[cont] = linea;

                            cont++;
                        }
                    }

                    solicitudAlta.lineas = lineas;
                }

                solicitudes.solicitud = solicitudAlta;

                return solicitudes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudConsulta> SetDatosSolicitudConsulta(string xml)
        {
            try
            {
                List<SolicitudConsulta> lista = new List<SolicitudConsulta>();

                using (XmlReader nodeReader = XmlReader.Create(new StringReader(xml.ToString())))
                {
                    nodeReader.MoveToContent();

                    XElement xRoot = XElement.Load(nodeReader, LoadOptions.SetLineInfo);

                    var listaSolicitudes = xRoot.Elements("solicitud");
                    foreach (var item in listaSolicitudes)
                    {
                        SolicitudConsulta solicitud = new SolicitudConsulta();

                        solicitud.cod = item.Element("cod").Value;
                        solicitud.descripcion = item.Element("descripcion").Value;
                        solicitud.fechaSolicitud = !string.IsNullOrEmpty(item.Element("fechaSolicitud").Value) ? item.Element("fechaSolicitud").Value : string.Empty;
                        solicitud.fechaAnulacion = !string.IsNullOrEmpty(item.Element("fechaAnulacion").Value) ? item.Element("fechaAnulacion").Value : string.Empty;
                        solicitud.fechaRecogida = !string.IsNullOrEmpty(item.Element("fechaRecogida").Value) ? item.Element("fechaRecogida").Value : string.Empty;
                        solicitud.albaranOrigen = item.Element("albaranOrigen").Value;
                        solicitud.nombreTerceroAsignado = item.Element("nombreTerceroAsignado").Value;
                        solicitud.observaciones = item.Element("observaciones").Value;
                        solicitud.est = item.Element("est").Value;

                        var listaLineas = item.Elements("lineas").Elements("linea");

                        if (listaLineas != null)
                        {
                            int cont = 0;
                            linea[] lineas = new linea[0];

                            foreach (var linea in listaLineas)
                            {
                                Array.Resize(ref lineas, cont + 1);

                                linea lineaSolicitud = new linea();

                                lineaSolicitud.frac = Convert.ToInt32(linea.Element("frac").Value);
                                Fracciones fraccion = _fraccion.getFraccionById(lineaSolicitud.frac);
                                if (fraccion != null)
                                    lineaSolicitud.fracNombre = fraccion.Nombre;

                                if (linea.Element("res").Value != string.Empty)
                                {
                                    lineaSolicitud.res = Convert.ToInt32(linea.Element("res").Value);
                                    Residuos residuo = _residuo.getResiduoById(lineaSolicitud.res);
                                    if (residuo != null)
                                    {
                                        lineaSolicitud.resNombre = residuo.Nombre;
                                    }
                                }
                                else
                                {
                                    lineaSolicitud.resNombre = lineaSolicitud.fracNombre;
                                }

                                if (linea.Element("resEspe").Value != string.Empty)
                                {
                                    lineaSolicitud.resEspe = Convert.ToInt32(linea.Element("resEspe").Value);
                                    ResiduosEspecificos residuoEspecifico = _residuoEspecifico.getResiduoEspecificoById(lineaSolicitud.resEspe);
                                    if (residuoEspecifico != null)
                                    {
                                        lineaSolicitud.resEspeNombre = residuoEspecifico.Nombre;
                                    }
                                }
                                else
                                {
                                    lineaSolicitud.resEspeNombre = lineaSolicitud.fracNombre;
                                }

                                lineaSolicitud.tipoCont = Convert.ToInt32(linea.Element("tipoCont").Value);
                                TiposContenedor tipoContenedor = _tipoContenedor.getTipoContenedorById(lineaSolicitud.tipoCont);
                                if (tipoContenedor != null)
                                    lineaSolicitud.tipoContNombre = tipoContenedor.Nombre;

                                lineaSolicitud.uni = Convert.ToInt32(linea.Element("uni").Value);
                                lineaSolicitud.kil = Convert.ToInt32(linea.Element("kil").Value);

                                lineas[cont] = lineaSolicitud;

                                cont++;
                            }

                            solicitud.linea = lineas;
                        }
                        
                        lista.Add(solicitud);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}