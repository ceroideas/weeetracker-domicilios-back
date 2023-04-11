using System;
using WeeeTrackerAPI.Entities;
using System.IO;
using System.Drawing;

namespace WeeeTrackerAPI.Common
{
    public static class FileHelper
    {
        public static void SaveImage(string sourcePath, string destPath, Archivo datosArchivo)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(datosArchivo.ArchivoCodificado);

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    string sourceFile = String.Format("{0}{1}", sourcePath, datosArchivo.Nombre);
                    string destFile = String.Format("{0}{1}", destPath, datosArchivo.Nombre);

                    image = Image.FromStream(ms);
                    image.Save(sourceFile);

                    File.Copy(sourceFile, destFile,true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
