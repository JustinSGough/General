///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2018, American Healthtech and CPSI
//
//  File    : ColHit.cs
//
//  Notes   : Search result for finding tables by column name.
//
///////////////////////////////////////////////////////////////////////////////

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Search result for finding tables by column name.
    /// </summary>
    public class ColHit : DtoBase
    {
        public string Column   { get { return _column;  } set { if (value != _column  ) { _column   = value; NotifyPropertyChanged(); } } } string _column = null; 
        public string Table    { get { return _table;   } set { if (value != _table   ) { _table    = value; NotifyPropertyChanged(); } } } string _table  = null; 
        public long   RowCount { get { return _rowCount;} set { if (value != _rowCount) { _rowCount = value; NotifyPropertyChanged(); } } } long _rowCount = 0;
    }
}
