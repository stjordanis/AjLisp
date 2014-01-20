﻿namespace AjLisp.Tests.Primitives
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AjLisp.Primitives;
    using AjLisp.Language;

    [TestClass]
    public class SubrDotInvokeTests
    {
        [TestMethod]
        public void GetProperty()
        {
            SubrDotInvoke subr = new SubrDotInvoke("Length");
            
            var result = subr.Apply(List.Create(new object[] { "foo" }), null);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void InvokeMethod()
        {
            SubrDotInvoke subr = new SubrDotInvoke("ToString");

            var result = subr.Apply(List.Create(new object[] { 123 }), null);

            Assert.IsNotNull(result);
            Assert.AreEqual("123", result);
        }

        [TestMethod]
        public void InvokeMethodWithArguments()
        {
            SubrDotInvoke subr = new SubrDotInvoke("Substring");

            var result = subr.Apply(List.Create(new object[] { "foobarfoo", 3, 3  }), null);

            Assert.IsNotNull(result);
            Assert.AreEqual("bar", result);
        }
    }
}
