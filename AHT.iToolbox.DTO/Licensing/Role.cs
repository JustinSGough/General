///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and American Healthtech and CPSI
//
//  File    : Role.cs
//
//  Notes   : Serializable role for use in the security info file.
//
///////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Xml.Serialization;

namespace AHT.uToolBox.DTO.Licensing
{
    public class Role : BaseNode
    {
        [XmlAttribute]
        public string Name { get; set; }

        public List<Nav> NavItems { get; set; }

        public Role() : base()
        {
            SetDefaults();
        }

        public Role(string name) : base()
        {
            SetDefaults();
            Name = name;
        }

        void SetDefaults()
        {
            Name = "Role";
            NavItems = new List<Nav>();
        }
    }
}
