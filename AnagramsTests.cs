using AnagramProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AnagramsTesting
{
    [TestClass]
    public class AnagramTest
    {
        [Fact]
        public void Validate_Anagram()
        {
            Anagram obj = new Anagram();

            string[] words = new string[9] { "kinship", "enlist", "boaster", "fresher", "sinks ", "crepitus", "paste", "punctilio", "sunders" };
            string[] words2 = new string[9] { "pinkish", "inlets", "boaters", "refresh", "skins ", "cuprites", "pates", "unpolitic", "undress" };

            bool value = obj.Anagram1(words[1],words2[2]);

            Assert.IsTrue(value);
        }

    }
}