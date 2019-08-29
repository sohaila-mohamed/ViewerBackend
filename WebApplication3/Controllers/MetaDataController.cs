using ImageViewer.Bussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class MetaDataController : ApiController
    {
        // GET: api/MetaData
       

        // GET: api/MetaData/5
        public List<InstanceModel> Get()
        {
            //instance of teh class that implements metadata interface , GetMetaData method()
            MockupMetaData MetaData = new MockupMetaData();
            // creat container that hold metadata
            List<InstanceModel> ImageIds = new List<InstanceModel>();
            ImageIds=MetaData.GetMetaadata();
            return ImageIds;
        }

        // POST: api/MetaData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MetaData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MetaData/5
        public void Delete(int id)
        {
        }
    }
}
