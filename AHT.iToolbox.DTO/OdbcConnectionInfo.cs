using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    public class OdbcConnectionInfo : ConnectionInfo, IConnectionInfo, INotifyPropertyChanged
    {
        public string Name
        {
            get { return _name; }
            set { if (_name != value) { _name = value; NotifyPropertyChanged(); } }
        }
        string _name;

        public string Driver
        {
            get { return _driver; }
            set { if (_driver != value) { _driver = value; NotifyPropertyChanged(); } }
        }
        string _driver;

        public string Database
        {
            get { return _database; }
            set { if (_database != value) { _database = value; NotifyPropertyChanged(); } }
        }
        string _database;

        public override string Db   { get { return Database; } set { _database = value; NotifyPropertyChanged(); }}
        public override string Pass { get { return "99%ltc*72"; } set { ; } }
        public override string User { get { return "ltcuser";   } set { ; } }

        public OdbcConnectionInfo(string name, string driver, string server, string database)
        {
            _name     = name;
            _driver   = driver;
            _server   = server;
            _database = database;
        }

        public OdbcConnectionInfo() { }

        public OdbcConnectionInfo(OdbcConnectionInfo toClone)
        {
            _database            = toClone.Database ;
            DbVersion            = toClone.DbVersion ;
            _driver              = toClone.Driver ;
            EnterpriseIdentifier = toClone.EnterpriseIdentifier;
            _name                = toClone.Name ;
            Pass                 = toClone.Pass ;
            _server              = toClone.Server ;
            User                 = toClone.User ;
        }

        public override bool Equals(object obj)
        {
            return IsEqual(obj);
        }

        bool IsEqual(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            var value = obj as OdbcConnectionInfo;

            bool isEqual = true
                && value.Name == Name
                && value.Database == Database
                && value.Driver == Driver
                && value.Pass == Pass
                && value.Server == Server
                && value.User == User;

            return isEqual;
        }

        public override int GetHashCode()
        {
            unchecked // to keep runtime from complaining about overflow
            {
                const int seed = (int)2166136261;
                const int mult = 16777619;

                int hash = seed;
                hash = (hash * mult) + (Name     ?? "").GetHashCode();
                hash = (hash * mult) + (Database ?? "").GetHashCode();
                hash = (hash * mult) + (Driver   ?? "").GetHashCode();
                hash = (hash * mult) + (Pass     ?? "").GetHashCode();
                hash = (hash * mult) + (Server   ?? "").GetHashCode();
                hash = (hash * mult) + (User     ?? "").GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(OdbcConnectionInfo a, OdbcConnectionInfo b)
        {
            if (object.ReferenceEquals(a, b)) return true;     // both null
            if (object.ReferenceEquals(null, a)) return false; // just a is null

            return a.Equals(b);
        }

        public static bool operator !=(OdbcConnectionInfo a, OdbcConnectionInfo b)
        {
            return !(a == b);
        }

        public new object Clone()
        {
            return new OdbcConnectionInfo(this);
        }
    }
}
