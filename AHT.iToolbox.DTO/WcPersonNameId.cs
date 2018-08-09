///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © TODO_COPYRIGHT_YEAR, TODO_COPYRIGHT_HOLDER
//
//  File    : WcPersonNameId.cs
//
//  Notes   : WorkCenter person name with Person ID.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// WorkCenter person name with Person ID.
    /// </summary>
    public class WcPersonNameId : DtoBase, INotifyPropertyChanged
    {
        public string Name
        {
            get { return _name; }
            set { if (_name != value) { _name = value; NotifyPropertyChanged(); } }
        }
        string _name;

        public long PersonId
        {
            get { return _personId; }
            set { if (_personId != value) { _personId = value; NotifyPropertyChanged(); } }
        }
        long _personId;

        public int PersonIdentificationId
        {
            get { return _personIdentificationId; }
            set { if (_personIdentificationId != value) { _personIdentificationId = value; NotifyPropertyChanged(); } }
        }
        int _personIdentificationId;

        public WcPersonNameId(string name, long personId, int personIdentificationId)
        {
            _name = name;
            _personId = personId;
            _personIdentificationId = personIdentificationId;
        }
    }
}
