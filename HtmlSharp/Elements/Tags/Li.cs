using System;
using System.Collections.Generic;

namespace HtmlSharp.Elements.Tags
{
    public class LI : Tag, IAllowsNesting
    {
        public IEnumerable<Type> NestingBreakers { get { return new Type[] { typeof(UL), typeof(OL) }; } }

        public string Class { get { return this["class"]; } }

        public string Dir { get { return this["dir"]; } }

        public string Id { get { return this["id"]; } }

        public string Lang { get { return this["lang"]; } }

        public string Onclick { get { return this["onclick"]; } }

        public string Ondblclick { get { return this["ondblclick"]; } }

        public string Onkeydown { get { return this["onkeydown"]; } }

        public string Onkeypress { get { return this["onkeypress"]; } }

        public string Onkeyup { get { return this["onkeyup"]; } }

        public string Onmousedown { get { return this["onmousedown"]; } }

        public string Onmousemove { get { return this["onmousemove"]; } }

        public string Onmouseout { get { return this["onmouseout"]; } }

        public string Onmouseover { get { return this["onmouseover"]; } }

        public string Onmouseup { get { return this["onmouseup"]; } }

        public string Style { get { return this["style"]; } }

        public string Title { get { return this["title"]; } }

        public string Type { get { return this["type"]; } }

        public string Value { get { return this["value"]; } }

        public LI()
            : this(new Element[0])
        {
        }

        public LI(params Element[] children)
            : base(children)
        {
            ResetsNesting = true;
            TagName = "li";
        }
    }
}