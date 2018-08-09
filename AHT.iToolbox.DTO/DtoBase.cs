using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Data;

namespace AHT.uToolBox.DTO
{
    public class DtoBase : INotifyPropertyChanged
    {
        public const string AhtNull = "NULL";

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.
        /// </summary>
        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool IsNullOrMissing(DataRow r, string column, out string scanText)
        {
            scanText = null;

            try
            {
                if (!r.Table.Columns.Contains(column)) return true;
                object val = r[column];
                if (val == DBNull.Value) return true;
                string s = val as string;
                if (s == null || s == "" || s.ToUpper() == AhtNull) return true;
                scanText = s;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public string ScanString(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            return scanText;
        }

        public Guid ScanGuid(DataRow r, string column)
        {
            string scanText;
            Guid g = default(Guid);
            if (!IsNullOrMissing(r, column, out scanText)) Guid.TryParse(scanText, out g);
            return g;
        }

        public Guid? ScanGuidNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            Guid g = default(Guid);
            if (Guid.TryParse(scanText, out g)) return g;
            return null;
        }

        public int ScanInt(DataRow r, string column)
        {
            string scanText;
            int i = 0;
            if (!IsNullOrMissing(r, column, out scanText)) int.TryParse(scanText, out i);
            return i;
        }

        public int? ScanIntNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            int i = 0;
            if (int.TryParse(scanText, out i)) return i;
            return null;
        }

        public decimal ScanDecimal(DataRow r, string column)
        {
            string scanText;
            decimal d = 0m;
            if (!IsNullOrMissing(r, column, out scanText)) decimal.TryParse(scanText, out d);
            return d;
        }

        public decimal? ScanDecimalNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            decimal d = 0m;
            if (decimal.TryParse(scanText, out d)) return d;
            return null;
        }

        public short ScanShort(DataRow r, string column)
        {
            string scanText;
            short i = 0;
            if (!IsNullOrMissing(r, column, out scanText)) short.TryParse(scanText, out i);
            return i;
        }

        public short? ScanShortNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            short i = 0;
            if (short.TryParse(scanText, out i)) return i;
            return null;
        }

        public byte ScanByte(DataRow r, string column)
        {
            string scanText;
            byte i = 0;
            if (!IsNullOrMissing(r, column, out scanText)) byte.TryParse(scanText, out i);
            return i;
        }

        public byte? ScanByteNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            byte i = 0;
            if (byte.TryParse(scanText, out i)) return i;
            return null;
        }

        public bool ScanBit(DataRow r, string column)
        {
            string scanText;
            bool i = false;
            if (!IsNullOrMissing(r, column, out scanText)) bool.TryParse(scanText, out i);
            return i;
        }

        public bool? ScanBitNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            bool i = false;
            if (bool.TryParse(scanText, out i)) return i;
            return null;
        }

        public DateTime ScanDateTime(DataRow r, string column)
        {
            string scanText;
            DateTime d = default(DateTime);
            if (!IsNullOrMissing(r, column, out scanText)) DateTime.TryParse(scanText, out d);
            return d;
        }

        public DateTime? ScanDateTimeNull(DataRow r, string column)
        {
            string scanText;
            if (IsNullOrMissing(r, column, out scanText)) return null;
            DateTime d = default(DateTime);
            if (DateTime.TryParse(scanText, out d)) return d;
            return null;
        }
    }
}
