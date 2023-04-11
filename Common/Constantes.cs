using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeeeTrackerAPI.Common
{
    public enum Claims
    {
        Id,
        Login,
        Tercero,
        TipoTercero,
        Estado,
        Perfiles,
        Centros,
        Residuos,
        Marcas
    }
    public class Errores
    {
        //---------------------------------------------------------------------------------------------------------
        //CÓDIGOS DE ERROR DE LA API

        public const string UsuarioNoValido = "Usuario no válido";
        public const string UsuarioNoAutorizado = "Usuario no autorizado";

        public const string EtiquetaNoExiste = "Etiqueta no existe";
        public const string EtiquetaAlta = "Error al dar de alta la etiqueta";

        public const string EntradaNoExiste = "Residuo sin entrada";
        public const string EntradaAlta = "Error al dar de alta la entrada";
        public const string EntradaOk = "Entrada dada de alta con éxito";

        public const string SalidaNoExiste = "Residuo sin salida";
        public const string SalidaAlta = "Error al dar de alta la salida";
        public const string SalidaOk = "Salida dada de alta con éxito";

        public const string StockNoExiste = "No existe stock";

        public const string ResiduoNoExiste = "No existen residuos";

        public const string SolicitudConsultaNoValido = "No se han podido obtener las solicitudes de ECOAPP";
        public const string SolicitudConsultaXML = "Error al parsear el XML de datos obtenidos en ECOAPP";
        public const string SolicitudAlta = "Error al dar de alta la solicitud";
        public const string SolicitudValidacion = "Error al validar la solicitud";

        //---------------------------------------------------------------------------------------------------------
        //CÓDIGOS DE ERROR ECOAPP

        //I35 Recepción de Solicitudes de Recogida

        public const string ECOAPP_I35_1 = "Problemas al conectar con la base de datos";
        public const string ECOAPP_I35_2 = "Error en la autentificación de la cabecera";
        public const string ECOAPP_I35_3 = "Falta alguno de los datos obligatorios";
        public const string ECOAPP_I35_4 = "Alguno de los datos recibidos es incorrecto";
        public const string ECOAPP_I35_5 = "Se ha producido cualquier otro error";
        public const string ECOAPP_I35_6 = "Existe otra solicitud con la misma fecha, origen y fracción";
        public const string ECOAPP_I35_7 = "Los datos de la línea no están activos";

        //I27 Cambio de Fecha de Atención

        public const string ECOAPP_I27_0 = "Actualización se ha realizado de manera correcta";
        public const string ECOAPP_I27_1 = "Problemas al conectar con la base de datos";
        public const string ECOAPP_I27_2 = "Error en la autentificación de la cabecera";
        public const string ECOAPP_I27_3 = "Cualquier otra excepción";
        public const string ECOAPP_I27_4 = "Identificador recibido está vacío";
        public const string ECOAPP_I27_5 = "Se ha producido un error al actualizar";
        public const string ECOAPP_I27_6 = "El tercero que intenta modificar no es el OL asignado";
        public const string ECOAPP_I27_7 = "El parámetro recibido no es del tipo correcto (Fecha)";
        public const string ECOAPP_I27_8 = "No se ha encontrado la solicitud";
    }
    public class Constantes
    {
        public const int Estado = 0;
        public const int SidPaisCodigoRaee = 84;
        public const int SidTipoContenedor = 91;
        public const int SidTipoEtiqueta = 0;
        public const int SidSig = 8410708;
        public const string ObservAltaEcoapp = "Solicitud creada desde Weee Tracker";

        public const string PathImageFormat = "{0}_{1}_{2}{3}";
        public const string ImageExtension = ".png";
    }
    public enum Funciona
    {
        NoFunciona = 1,
        Funciona = 2
    }
    public enum TipoEstadoIdentificacion
    {
        domicilio = 12,
        establecimiento = 13,
        entrada = 14,
        salida = 15
    }
    
    public enum TipoEstadoSolicitud
    {
        CON = 1, //"Confirmada"
        ANU = 2, //"Anulada"
        ASG = 3, //"Asignada"
        REC = 4 //"Recogida"
    }
    public enum TipoArchivo
    {
        PIC = 1,
        SIG = 2
    }
}
