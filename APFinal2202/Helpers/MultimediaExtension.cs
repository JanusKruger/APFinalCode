using System;
using System.IO;
using System.Web;

namespace APFinal2202.Helpers
{
    public static class MultimediaExtension
    {
        public static byte[] SetContent(this HttpPostedFileBase source)
        {
            var target = new MemoryStream();
            source.InputStream.CopyTo(target);
            return target.ToArray();
        }

        public static string GetContent(this byte[] source)
        {
            var target = Convert.ToBase64String(source);
            return $"data:image/jpg;base64,{target}";
        }
    }
}