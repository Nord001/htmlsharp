using System;
using System.Collections.Generic;

namespace HtmlSharp.Elements.Tags
{
    public class Img : Tag
    {
        public string Align { get { return this["align"]; } }

        public string Alt { get { return this["alt"]; } }

        public string Border { get { return this["border"]; } }

        public string Class { get { return this["class"]; } }

        public string Dir { get { return this["dir"]; } }

        public string Height { get { return this["height"]; } }

        public string Hspace { get { return this["hspace"]; } }

        public string Id { get { return this["id"]; } }

        public string Ismap { get { return this["ismap"]; } }

        public string Lang { get { return this["lang"]; } }

        public string Longdesc { get { return this["longdesc"]; } }

        public string Name { get { return this["name"]; } }

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

        public string Src { get { return this["src"]; } }

        public string Style { get { return this["style"]; } }

        public string Title { get { return this["title"]; } }

        public string Usemap { get { return this["usemap"]; } }

        public string Vspace { get { return this["vspace"]; } }

        public string Width { get { return this["width"]; } }

        public Img()
            : this(new Element[0])
        {
        }

        public Img(params Element[] children)
            : this(new TagAttribute[0], children)
        {
        }

        public Img(params TagAttribute[] attributes)
            : this(attributes, new Element[0])
        {
        }

        public Img(IEnumerable<TagAttribute> attributes, params Element[] children)
            : base(attributes, children)
        {
            IsSelfClosing = true;
            TagName = "img";
        }
    }
}