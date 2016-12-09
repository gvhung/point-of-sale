using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Helpers
{
    class ImageHelper
    {
        public static Image GetImageFromBytes(byte[] Args)
        {
            Image Res = null;
            try
            {
                MemoryStream ms = new MemoryStream(Args);
                Res = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Res;
        }
    }
}
