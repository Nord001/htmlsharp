﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlSharp.Css
{
    public class NegationFilter : SelectorFilter
    {
        SelectorFilter filter;

        public NegationFilter(SelectorFilter filter)
        {
            this.filter = filter;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                NegationFilter t = (NegationFilter)obj;
                return filter.Equals(t.filter);
            }
        }

        public override int GetHashCode()
        {
            return filter.GetHashCode();
        }
    }
}
