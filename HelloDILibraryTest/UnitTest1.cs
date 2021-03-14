using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloDILibrary;
using Moq;
using System.Collections.Generic;
using System;

namespace HelloDILibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SpyMessageWriter spyWriter= new SpyMessageWriter();
            var salutation = new Salutation(spyWriter);
            salutation.Exclaim();
            Assert.AreEqual("Hello DI!", spyWriter.WrittenMessage);
        }

    }
    // Test double class
    public class SpyMessageWriter : IMessageWriter
    {
        public string WrittenMessage { get; private set; }
        public void Write(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException();
            WrittenMessage = message;
        }
    }
}
