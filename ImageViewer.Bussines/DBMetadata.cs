using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer.Bussines
{
    class DBMetadata : IMetadata 
    {
        public List<InstanceModel> GetMetaadata() {
            List<InstanceModel> IDsList = new List<InstanceModel>();
            return IDsList;
        }
        
    }
}
