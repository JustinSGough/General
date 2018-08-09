using AHT.uToolBox.DTO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AHT.uToolBox.DTO
{
    public class XwalkSet : IEnumerable<Xwalk>, ICloneable
    {
        public string Tag { get; set; }
        public string DescriptionTag { get; set; }
        public List<Xwalk> Set { get; set; }

        public XwalkSet(string tag, string descriptionTag, int sizeHint = 10)
        {
            Tag = tag;
            DescriptionTag = descriptionTag;
            Set = new List<Xwalk>(sizeHint);
        }

        public void Add(Xwalk xWalk)
        {
            Set.Add(xWalk);
        }

        public IEnumerator<Xwalk> GetEnumerator()
        {
            return Set.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Set.GetEnumerator();
        }

        public object Clone()
        {
            var clone = new XwalkSet(Tag, DescriptionTag, Set.Count);

            foreach (Xwalk xwi in Set)
            {
                var innerClone = xwi.Clone() as Xwalk;
                clone.Add(innerClone);
            }
            return clone;
        }

    }
}
