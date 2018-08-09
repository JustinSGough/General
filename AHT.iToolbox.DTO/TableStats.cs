///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : TableStats.cs
//
//  Notes   : Population stats (row count, etc.) for a table.
//
///////////////////////////////////////////////////////////////////////////////

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AHT.uToolBox.DTO
{
    public class TableStats : INotifyPropertyChanged
    {
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; NotifyPropertyChanged(); }
        }
        string _tableName;

        public int RowCount
        {
            get { return _rowCount; }
            set { _rowCount = value; NotifyPropertyChanged(); }
        }
        int _rowCount;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.
        /// </summary>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
