using ImageViewer.Bussines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ImageViewerController : ApiController
    {
        // GET: api/ImageViewer
       
        // GET: api/ImageViewer/5
        public HttpResponseMessage Get(string ID)
        {
            IMetadata meadata = new MockupMetaData();
            //read full image file from constant path in bitmap
            Bitmap image = new Bitmap(@"C:\Users\Sohila\Desktop\InternProjectsample\"+ID+".png");
            //Send to client 
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            HttpResponseMessage ReponseMsg = new HttpResponseMessage();
            ReponseMsg.Content = new ByteArrayContent(memoryStream.ToArray());
            ReponseMsg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
            return ReponseMsg;

        }
        // POST: api/ImageViewer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ImageViewer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ImageViewer/5
        public void Delete(int id)
        {
        }
    }
}
