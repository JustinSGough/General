using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.uToolBox.DTO
{
    public class SqlVal
    {
        public SqlDescriptor Desc;
        public object Val;

        public SqlVal(SqlDescriptor d, object v)
        {
            Desc = d;
            Val = v;
        }

        public override string ToString()
        {
            return Val.ToString();
        }
    }
}
