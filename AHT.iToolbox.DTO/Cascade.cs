///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2018, American Healthtech and CPSI
//
//  File    : Cascade.cs
//
//  Notes   : Linked chain of join/dependency relationships between tables.
//
///////////////////////////////////////////////////////////////////////////////

using System.Linq;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Linked chain of join/dependency relationships between tables.
    /// </summary>
    public class Cascade : Constraint
    {
        public long    RowCount  { get{ return _rowCount;  } set {if (value != _rowCount) { _rowCount  = value; NotifyPropertyChanged();}}} long    _rowCount = 0;
        public Cascade LinkJoin  { get{ return _linkJoin;  } set {if (value != _linkJoin) { _linkJoin  = value; NotifyPropertyChanged();}}} Cascade _linkJoin  = null;
        public Cascade() { }

        public Cascade(Constraint c)
        {
            Name     = c.Name      ;
            FkTable  = c.FkTable   ;
            PkTable  = c.PkTable   ;
            FkColumns = c.FkColumns.Select(x => x).ToList();
            PkColumns = c.PkColumns.Select(x => x).ToList();
        }
    }
}
