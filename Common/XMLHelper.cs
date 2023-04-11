using System;
using WeeeTrackerAPI.Entities;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WeeeTrackerAPI.Common
{
    public static class XMLHelper
    {
        public static string GetXML(object solicitud)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(solicitud.GetType());
                MemoryStream memoryStream = new MemoryStream();
                StreamWriter streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8);
                serializer.Serialize(streamWriter, solicitud);
                string xml = System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());

                return xml;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
