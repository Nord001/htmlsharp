﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using HtmlSharp.Elements.Tags;
using HtmlSharp.Elements;

namespace HtmlSharp.Tests
{
    /// <summary>
    /// Summary description for CssSelectorTests
    /// </summary>
    [TestClass]
    public class CssSelectorTests
    {
        Document doc;
        public CssSelectorTests()
        {
            HtmlParser parser = new HtmlParser();
            doc = parser.Parse(File.ReadAllText("Simple.html"));
        }

        [TestMethod]
        public void TestTypeSelector()
        {
            var tag = doc.Find("p");
            Assert.AreEqual(new P(new HtmlText() { Value = "It will be used in tests." }), tag);
        }

        [TestMethod]
        public void TestFindFail()
        {
            var tag = doc.Find("form");
            Assert.IsNull(tag);
        }

        [TestMethod]
        public void TestDescendantCombinator()
        {
            var tag = doc.Find("html p");
            Assert.AreEqual(new P(new HtmlText() { Value = "It will be used in tests." }), tag);
        }

        [TestMethod]
        public void TestChildCombinator()
        {
            var tag = doc.Find("html > p");
            Assert.IsNull(tag);
            tag = doc.Find("body > p");
            Assert.AreEqual(new P(new HtmlText() { Value = "It will be used in tests." }), tag);
        }
    }
}
