///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : XwalkInfo.cs
//
//  Notes   : Bindable data for one side of a crosswalk.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Bindable data for one side of a crosswalk.
    /// </summary>
    public class XwalkInfo : INotifyPropertyChanged, ICloneable
    {
        public string Description
        {
            get { return _description; }
            set { _description = value; NotifyPropertyChanged(); }
        }
        string _description;

        public string Code
        {
            get { return _code; }
            set { _code = value; NotifyPropertyChanged(); }
        }
        string _code;

        public SqlType CodeType
        {
            get { return _codeType; }
            set { _codeType = value; NotifyPropertyChanged(); }
        }
        SqlType _codeType;

        public XwalkInfo(
            SqlType codeType,
            string code,
            string description)
        {
            _description    = description;
            _code           = code;
            _codeType       = codeType;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName.
        /// parameter causes the property name of the caller to be substituted as an argument.
        /// </summary>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public object Clone()
        {
            var clone = new XwalkInfo(
                _codeType, 
                _code, 
                _description);
            return clone;
        }
    }
}
