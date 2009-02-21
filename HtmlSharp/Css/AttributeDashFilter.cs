﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlSharp.Css
{
    public class AttributeDashFilter : AttributeFilter
    {
        string dash;

        public AttributeDashFilter(string type, string dash)
            : base(type)
        {
            this.dash = dash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                AttributeDashFilter t = (AttributeDashFilter)obj;
                return dash.Equals(t.dash) && base.Equals(obj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ dash.GetHashCode();
        }
    }
}
