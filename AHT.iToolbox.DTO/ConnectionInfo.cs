using System;
using System.Linq;
using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    public class ConnectionInfo : DtoBase, IConnectionInfo, INotifyPropertyChanged
    {
        public virtual string  ConnectionString { get { return MakeConnectionString(this); } }

        public virtual string Db
        {
            get { return _db; }
            set { if (_db != value) { _db = value; NotifyPropertyChanged(); } }
        }
        string _db;

        public virtual decimal DbVersion
        {
            get { return _dbVersion; }
            set { if (_dbVersion != value) { _dbVersion = value; NotifyPropertyChanged(); } }
        }
        decimal _dbVersion;

        public virtual Guid EnterpriseIdentifier
        {
            get { return _enterpriseIdentifier; }
            set { if (_enterpriseIdentifier != value) { _enterpriseIdentifier = value; NotifyPropertyChanged(); } }
        }
        Guid _enterpriseIdentifier;

        public virtual string Pass
        {
            get { return _pass; }
            set { if (_pass != value) { _pass = value; NotifyPropertyChanged(); } }
        }
        string _pass;

        public virtual string Server
        {
            get { return _server; }
            set { if (_server != value) { _server = value; NotifyPropertyChanged(); }}
        }
        protected string _server;

        public virtual string User
        {
            get { return _user; }
            set { if (_user != value) { _user = value; NotifyPropertyChanged(); }}
        }
        string _user;


        protected string connStringBase = "Data Source={0};Initial Catalog={1};user id={2};Pwd={3}";

        public ConnectionInfo()
        {
            Server = string.Empty;
            Db = string.Empty;
            User = string.Empty;
        }

        public ConnectionInfo(
            string db,
            decimal dbVersion,
            Guid enterpriseIdentifier,
            string pass,
            string server,
            string user
            )
        {
            Db                   = db;
            DbVersion            = dbVersion;
            EnterpriseIdentifier = enterpriseIdentifier;
            Pass                 = pass;
            Server               = server;
            User                 = user;
        }

        public ConnectionInfo(ConnectionInfo toClone)
        {
            Db                   = toClone.Db;
            DbVersion            = toClone.DbVersion;
            EnterpriseIdentifier = toClone.EnterpriseIdentifier;
            Pass                 = toClone.Pass;
            Server               = toClone.Server;
            User                 = toClone.User;
        }

        private string MakeConnectionString(DTO.IConnectionInfo ci)
        {
            return string.Format(connStringBase, ci.Server, ci.Db, ci.User, ci.Pass);

        }

        public string FindInConnectionString(string item)
        {
            return FindInConnectionString(ConnectionString, item);
        }

        public static string FindInConnectionString(string connectionString, string item)
        {
            if (string.IsNullOrEmpty(connectionString)) return string.Empty;

            foreach (string val in connectionString.Split(';'))
            {
                if (val.StartsWith(item.ToLower()) || val.StartsWith(item.ToUpper()))
                {
                    var list = val.Split('=').ToList();
                    list.RemoveAt(0);

                    return string.Join("=", list);
                }
            }
            return string.Empty;
        }

        public object Clone()
        {
            return new ConnectionInfo(this);
        }
    }
}
