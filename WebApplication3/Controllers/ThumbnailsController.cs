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
     
    
       
    public class ThumbnailsController : ApiController
    {
        


        // GET: api/Thumbnails/1
        
        public HttpResponseMessage Get(string ID)
        {
   
            Bitmap BigImage = new Bitmap(@"C:\Users\Sohila\Desktop\InternProjectsample\"+ID+".png");
            MemoryStream memoryStream = new MemoryStream();
            BigImage.Save(memoryStream, ImageFormat.Png);
            HttpResponseMessage ResponseMsg = new HttpResponseMessage();
            ResponseMsg.Content = new ByteArrayContent(memoryStream.ToArray());
            ResponseMsg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
            return ResponseMsg;



        }

        // POST: api/Thumbnails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Thumbnails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Thumbnails/5
        public void Delete(int id)
        {
        }
    }
}
