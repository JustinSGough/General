using AHT.uToolBox.DTO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AHT.uToolBox.DTO
{
    public class XwalkInfoSet : IEnumerable<XwalkInfo>, IEnumerable, ICloneable
    {
        public string Tag { get; set; }
        public string DescriptionTag { get; set; }
        public List<XwalkInfo> Set { get; set; }

        public XwalkInfoSet(string tag, string descriptionTag, int sizeHint = 10)
        {
            Tag = tag;
            DescriptionTag = descriptionTag;
            Set = new List<XwalkInfo>(sizeHint);
        }

        public void Add(XwalkInfo xWalkInfo)
        {
            Set.Add(xWalkInfo);
        }

        public IEnumerator<XwalkInfo> GetEnumerator()
        {
            return Set.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Set.GetEnumerator();
        }

        public object Clone()
        {
            var clone = new XwalkInfoSet(Tag, DescriptionTag, Set.Count);

            foreach (XwalkInfo xwi in Set)
            {
                var innerClone = xwi.Clone() as XwalkInfo;
                clone.Add(innerClone);
            }
            return clone;
        }
    }
}
