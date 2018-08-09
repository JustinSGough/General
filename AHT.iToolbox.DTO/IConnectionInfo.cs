using System;

namespace AHT.uToolBox.DTO
{
    public interface IConnectionInfo : IDtoBase, ICloneable
    {
        string ConnectionString { get; }
        string Db { get; set; }
        decimal DbVersion { get; set; }
        Guid EnterpriseIdentifier { get; set; }
        string Pass { get; set; }
        string Server { get; set; }
        string User { get; set; }
    }
}