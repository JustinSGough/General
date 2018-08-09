///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © TODO_COPYRIGHT_YEAR, TODO_COPYRIGHT_HOLDER
//
//  File    : LtcWcDuplicatePersonMapping.cs
//
//  Notes   : Ltc person with cono+resno and duplicate links to WorkCenter 
//          : person rows.
//
///////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Ltc person with cono+resno and duplicate links to WorkCenter person rows.
    /// </summary>
    public class LtcWcDuplicatePersonMapping : DtoBase, INotifyPropertyChanged
    {
        public string LtcName
        {
            get { return _ltcName; }
            set { if (_ltcName != value) { _ltcName = value; NotifyPropertyChanged(); } }
        }
        string _ltcName;

        public string LtcConoResno
        {
            get { return _ltcConoResno; }
            set { if (_ltcConoResno != value) { _ltcConoResno = value; NotifyPropertyChanged(); } }
        }
        string _ltcConoResno;

        public List<WcPersonNameId> WcPeopleNamesIds
        {
            get { return _wcPeople; }
            set { if (_wcPeople != value) { _wcPeople = value; NotifyPropertyChanged(); } }
        }
        List<WcPersonNameId> _wcPeople;

        public LtcWcDuplicatePersonMapping()
        {
            _wcPeople = new List<WcPersonNameId>();
        }

        public LtcWcDuplicatePersonMapping(string conoResno, string name)
        {
            _ltcName = name;
            _ltcConoResno = conoResno;
            _wcPeople = new List<WcPersonNameId>();
        }
    }
}
