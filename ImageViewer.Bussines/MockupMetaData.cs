using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer.Bussines
{
   public class MockupMetaData : IMetadata
    {
        public List<InstanceModel> GetMetaadata()
        {
            List<InstanceModel>  IDsList = new List<InstanceModel>();
            IDsList.Add(new InstanceModel { Id=  "im_0013_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0014_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0015_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0016_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0017_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0018_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0019_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0020_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0021_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0022_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0023_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0024_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0025_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0026_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0027_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0028_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0029_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0030_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0031_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0032_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0033_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0034_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0035_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0036_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0038_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0039_bak - copy.dcm.small" });
            IDsList.Add(new InstanceModel { Id = "im_0040_bak - copy.dcm.small" });
            return IDsList;
        }
    }
}
