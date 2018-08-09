using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AHT.uToolBox.DTO
{
    public enum SqlType
    {
        None,
        Bit,
        Varchar,
        Int,
        Money,
        SmallMoney,
        Uniqueidentifier,
        Tinyint,
        Datetime,
        SmallDatetime,
        Smallint,
        Real,
        Image,
    }

    public static class TypeExtensions
    {
        public static SqlType AsSqlType(this Type type)
        {
            
            if (type == typeof(bool    )) return SqlType.Bit;
            if (type == typeof(string  )) return SqlType.Varchar;
            if (type == typeof(int     )) return SqlType.Int;
            if (type == typeof(Int16   )) return SqlType.Smallint;
            if (type == typeof(Byte    )) return SqlType.Tinyint;
            if (type == typeof(decimal )) return SqlType.Money;
//          if (type == typeof(decimal )) return SqlType.SmallMoney;
            if (type == typeof(Guid    )) return SqlType.Uniqueidentifier;
            if (type == typeof(DateTime)) return SqlType.Datetime;
//          if (type == typeof(DateTime)) return SqlType.SmallDatetime;
            if (type == typeof(Byte[]  )) return SqlType.Image;
            if (type == typeof(Single))   return SqlType.Real;
            if (type == typeof(Double))   return SqlType.Real;

            return SqlType.None;
        }
    }
}
