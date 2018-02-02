using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterviewChallenges.Tests
{
    [TestClass]
    public class AnagramFinderTests
    {

        [TestMethod]
        public void SameStringsAreAnagramWithZeroDeletions()
        {
            var str1 = "abc";
            var str2 = "abc";

            var expectedResult = 0;

            var anagramFinder = new AnagramFinder();

            var actualResult = anagramFinder.FindDeletions(str1, str2);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void DiffStringsAreAnagramWithThreeDeletions()
        {
            var str1 = "abcxyz";
            var str2 = "abc";

            var expectedResult = 3;

            var anagramFinder = new AnagramFinder();

            var actualResult = anagramFinder.FindDeletions(str1, str2);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void DiffStringsAreAnagramWithSixDeletions()
        {
            var str1 = "abcxyz";
            var str2 = "aabcbb";

            var expectedResult = 6;

            var anagramFinder = new AnagramFinder();

            var actualResult = anagramFinder.FindDeletions(str1, str2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
