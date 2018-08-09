using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.uToolBox.DTO
{
    public class Xwalk : ICloneable
    {
        public XwalkInfo Source { get; set; }
        public XwalkInfo Target { get; set; }
        public string Operation { get; set; }

        public Xwalk(XwalkInfo source, XwalkInfo target, string operation)
        {
            Source = source.Clone() as XwalkInfo;
            Target = target.Clone() as XwalkInfo;
            Operation = operation;
        }

        public object Clone()
        {
            var sourceClone = Source.Clone() as XwalkInfo;
            var targetClone = Target.Clone() as XwalkInfo;
            var x = new Xwalk(sourceClone, targetClone, Operation);
            return x;
        }
    }
}
