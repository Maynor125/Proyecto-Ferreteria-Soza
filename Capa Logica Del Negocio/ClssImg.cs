using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
 
namespace Capa_de_presentacion
{
   public class ClssImg
    {
        //Convercion de Byte a Imagen.
        public static MemoryStream Byteimg(byte[] array)
        {
            MemoryStream vari = new MemoryStream((byte[])array);
            return vari;
        }

        //Convercion de Imagen a Byte
        public static byte [] imagenbyte(Image Img)
        {
            MemoryStream variimg = new MemoryStream();
            Img.Save(variimg, ImageFormat.Jpeg);
            return variimg.ToArray();
        }
    }
}
