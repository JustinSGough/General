///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : SqlDescriptor.cs
//
//  Notes   : 
//
///////////////////////////////////////////////////////////////////////////////

using System;

namespace AHT.uToolBox.DTO
{
    public class SqlDescriptor
    {
        const bool DefaultImport     = true;
        const bool DefaultExport     = true;
        const bool DefaultCopy       = true;
        const string DefaultDataRule = "";
        const bool DefaultAutoId     = false;

        public string Name;
        public SqlType DataType;
        public object Min;
        public object Max;
        public bool Nullable;
        public bool Import;
        public bool Export;
        public bool Copy;
        public string DataRule;
        public string ErrorMessage { get { return GetError(); } }
        public bool AutoId;

        public SqlDescriptor(
            string name, 
            SqlType dataType, 
            object min, object max, 
            bool nullable, 
            string dataRule = DefaultDataRule,
            bool import = DefaultImport,
            bool export = DefaultExport,
            bool copy = DefaultCopy
        )
        {
            Name     = name;
            DataType = dataType;
            Min      = min;
            Max      = max;
            Nullable = nullable;
            DataRule = dataRule;
            Import   = import;
            Export   = export;
            Copy     = copy;
            AutoId   = DefaultAutoId;
        }

        public SqlDescriptor(
            string name,
            SqlType dataType,
            object min, object max,
            bool nullable,
            bool autoId
        )
        {
            Name     = name;
            DataType = dataType;
            Min      = min;
            Max      = max;
            Nullable = nullable;
            DataRule = DefaultDataRule;
            Import   = DefaultImport;
            Export   = DefaultExport;
            Copy     = DefaultCopy;
            AutoId   = autoId;
        }

        public bool Ok(object val)
        {
            if (DataType == SqlType.Varchar)                                       return Ok(val as string);
            if (DataType == SqlType.Int)                                           return Ok((int?)val);
            if (DataType == SqlType.Bit)                                           return Ok((bool?)val);
            if (DataType == SqlType.Tinyint)                                       return Ok((byte?)val);
            if (DataType == SqlType.Datetime || DataType == SqlType.SmallDatetime) return Ok((DateTime?)val);
            if (DataType == SqlType.Smallint)                                      return Ok((short?)val);
            if (DataType == SqlType.Money || DataType == SqlType.SmallMoney)       return Ok((decimal?)val);
            if (DataType == SqlType.Uniqueidentifier)                              return Ok((Guid?)val);
            return false;
        }

        public bool Ok(int val)
        {
            int? nVal = val;
            return Ok(nVal);
        }

        public bool Ok(int? val)
        {
            if (val == null) return Nullable;
            if (DataType != SqlType.Int && DataType != SqlType.Smallint && DataType != SqlType.Tinyint) return false;
            return (val >= (int)Min && val <= (int)Max);
        }

        public bool Ok(string val)
        {
            if (val == null) return Nullable;
            if (DataType != SqlType.Varchar) return false;
            int len = val.Length;
            return (len >= (int)Min && len <= (int)Max);
        }

        public bool Ok(DateTime? val)
        {
            if (val == null) return Nullable;
            if (DataType != SqlType.Datetime && DataType != SqlType.SmallDatetime) return false;
            return (val >= (System.DateTime)Min && val <= (System.DateTime)Max);
        }

        public bool Ok(Guid? val)
        {
            if (val == null) return Nullable;
            if (DataType != SqlType.Uniqueidentifier) return false;
            return true;
        }

        public bool Ok(bool? val)
        {
            if (val == null) return Nullable;
            return (val == true || val == false);            
        }

        public bool Ok(decimal? val)
        {
            if (val == null) return Nullable;
            if (DataType != SqlType.Money && DataType != SqlType.SmallMoney) return false;
            return (val >= (decimal)Min && val <= (decimal)Max);
        }

        public string GetError()
        {
            const string RangeFormat   = " within the range {1} to {2}. {3}";
            const string LengthFormat  = " between {1} and {2} characters long. {3}";
            const string NullFormat    = "{0} must be blank, NULL or";
            const string NotNullFormat = "{0} must not be blank or NULL and";

            string format = ""
                + ((Nullable) ? NullFormat : NotNullFormat)
                + ((DataType == SqlType.Varchar) ? LengthFormat : RangeFormat);

            string min = Min.ToString();
            string max = Max.ToString();
            string message = string.Format(format, Name, min, max, DataRule ?? string.Empty);

            return message;
        }
    }
}
