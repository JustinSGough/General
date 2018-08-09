using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AHT.uToolBox.DTO.Licensing
{
    public class BaseNode
    {
        [XmlAttribute]
        public Guid Id { get; set; }

        public BaseNode()
        {
            Id = Guid.NewGuid();
        }
    }
}
