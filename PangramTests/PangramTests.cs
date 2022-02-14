using NUnit.Framework;
using Pangram;

namespace PangramTests
{
    public class Tests
    {
        [TestCase("The quick brown fox jumps over the lazy dog", true)]
        [TestCase("The Quick brown foX ju.!mps over the lazy dog ..", true)]
        [TestCase("abc", false)]
        [TestCase("", false)]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", true)]        
        [Category("PangramTests")]
        public void PangramTests(string input, bool expected)
        {
            Assert.AreEqual(expected, Program.IsPangram(input));
        }
    }
}