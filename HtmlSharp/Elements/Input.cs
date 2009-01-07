﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlSharp.Elements
{
    public class Input : Tag
    {
        public Input()
        {
            Name = "input";
            IsSelfClosing = true;
        }
    }
}