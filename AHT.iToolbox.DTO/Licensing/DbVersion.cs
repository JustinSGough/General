using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AHT.uToolBox.DTO.Licensing
{
    public class DbVersion : BaseNode
    {
        [XmlAttribute] public string     VersionMin { get; set; }
        [XmlAttribute] public string     VersionMax { get; set; }
                       public List<Role> Roles      { get; set; }
        [XmlIgnore   ] public Version    MinVersion { get; set; }
        [XmlIgnore   ] public Version    MaxVersion { get; set; }

        public DbVersion() : base()
        {
            SetDefaults();
        }

        public DbVersion(string versionMin, string versionMax) : base()
        {
            SetDefaults();
            MinVersion = new Version(versionMin); // throws exception if is in bad format
            MaxVersion = new Version(versionMax); // throws exception if is in bad format
            VersionMin = versionMin;
            VersionMax = versionMax;
        }

        public bool Matches(Version version)
        {
            bool matches;
            matches = (version >= MinVersion && version <= MaxVersion);
            return matches;
        }

        public bool Includes(string version)
        {
            bool matches = false;

            try
            {
                var v = new Version(version);
                matches = Matches(v);
            }
            catch
            {
            }

            return matches;
        }

        void SetDefaults()
        {
            MinVersion = new Version(0, 0, 0, 0);
            MaxVersion = new Version(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
            VersionMin = MinVersion.ToString();
            VersionMax = MaxVersion.ToString();
            Roles = new List<Role>();
        }


    }
}
