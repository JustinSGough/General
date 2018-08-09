using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace AHT.uToolBox.DTO.Licensing
{
    [XmlRoot]
    public class LicenceBucket
    {
        public DateTime Date { get; set; }
        public List<DbVersion> DbVersions { get; set; }

        public LicenceBucket()
        {
            DbVersions = new List<DbVersion>();
        }
    }
}
