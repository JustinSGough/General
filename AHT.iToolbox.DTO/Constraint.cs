///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2018, American Healthtech and CPSI
//
//  File    : Constraint.cs
//
//  Notes   : Represents a primary-foreign relationship between tables.
//
///////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Represents a primary-foreign relationship between tables.
    /// </summary>
    public class Constraint : DtoBase
    {
        public string Name            { get { return _name;     } set { if (value != _name    ) { _name     = value; NotifyPropertyChanged(); } } } string _name     = null;
        public string FkTable         { get { return _fkTable;  } set { if (value != _fkTable ) { _fkTable  = value; NotifyPropertyChanged(); } } } string _fkTable  = null; 
        public List<string> FkColumns { get { return _fkColumn; } set { if (value != _fkColumn) { _fkColumn = value; NotifyPropertyChanged(); } } } List<string> _fkColumn = new List<string>();
        public string PkTable         { get { return _pkTable;  } set { if (value != _pkTable ) { _pkTable  = value; NotifyPropertyChanged(); } } } string _pkTable  = null;
        public List<string> PkColumns { get { return _pkColumn; } set { if (value != _pkColumn) { _pkColumn = value; NotifyPropertyChanged(); } } } List<string> _pkColumn = new List<string>();
    }
}
