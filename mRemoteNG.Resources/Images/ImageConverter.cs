using System.Drawing;

namespace mRemoteNG.Resources
{
    public static class ImageConverter
    {
        /// <summary>
        /// Draws an Icon from a Bitmap
        /// </summary>
        /// <param name="SVGString"></param>
        /// <returns></returns>
        public static Icon GetImageAsIcon(Bitmap bitmap)
        {
            var icon = Icon.FromHandle(bitmap.GetHicon());

            return icon;
        }
    }
}
