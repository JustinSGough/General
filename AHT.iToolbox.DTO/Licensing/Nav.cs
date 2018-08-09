using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AHT.uToolBox.DTO.Licensing
{
    public class Nav : BaseNode
    {
        public const int MaxNavTreeDepth = 10;

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public Permissions Permissions
        {
            get { return ComputePermissions(); }
            set { _permissions = value; }
        }
        Permissions _permissions;

        [XmlAttribute]
        public InheritMode InheritMode { get; set; }

        public Nav Parent { get; set; }
        public List<Nav> Kids { get; set; }

        public Nav()
        {
            SetDefaults();
        }

        public Nav(string name)
        {
            SetDefaults();
            Name = name;
        }

        public override string ToString()
        {
            string t = string.Format(
                "Name:{0}, Permissions:{1}, InheritMode:{2}, Parent:{3}, Kids:{4}",
                Name, Permissions, InheritMode,
                (Parent != null) ? Parent.Name : "null",
                Kids.Count);
            return t;
        }

        void SetDefaults()
        {
            Name = "Nav";
            Permissions = Permissions.All;
            InheritMode = InheritMode.Inherit;
            Kids = new List<Nav>();
        }

        Permissions ComputePermissions()
        {
            int depth = 0;
            Permissions computedPermissions = ComputePermissions(this, ref depth);
            return computedPermissions;
        }

        Permissions ComputePermissions(Nav n, ref int depth)
        {
            if (++depth > MaxNavTreeDepth) throw new Exception("Nav tree depth cannot be greater than MaxNavTreeDepth");

            Permissions computedPermissions = Permissions.None;

            if (n.InheritMode == InheritMode.Override || n.Parent == null)
            {
                computedPermissions = n._permissions;
            }
            else if (n.InheritMode == InheritMode.Inherit)
            {
                computedPermissions = ComputePermissions(n.Parent, ref depth);
            }

            return computedPermissions;
        }
    }
}
