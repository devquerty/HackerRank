using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingtheCodingInterviewChallenges.Tests
{
    [TestClass]
    public class ArrayLeftRotationTests
    {
        //For any given array of size X perform N left rotations where N<=X

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Rotations Greater the Array size should not be allowed.")]
        public void RotationsGreaterThenArraySizeShouldThrowArgumentOutOfRangeException()
        {
            var rotations = 7;
            var array = new int[5] { 1, 2, 3, 4, 5 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, array);

            CollectionAssert.AreEqual(array, rotatedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Negative Rotations should not be allowed.")]
        public void NegativeRotationsShouldThrowArgumentOutOfRangeException()
        {
            var rotations = 7;
            var array = new int[5] { 1, 2, 3, 4, 5 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, array);

            CollectionAssert.AreEqual(array, rotatedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Null Input Array should not be allowed.")]
        public void NullArrayShouldThrowArgumentNullException()
        {
            var rotations = 7;

            int[] array = null;

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, array);

            CollectionAssert.AreEqual(array, rotatedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Empty Input Array should not be allowed.")]
        public void EmptyArrayShouldThrowArgumentException()
        {
            var rotations = 7;

            var array = new int[0];

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, array);

            CollectionAssert.AreEqual(array, rotatedArray);
        }

        [TestMethod]
        public void ZeroRotationsShouldReturnSameArray()
        {
            var rotations = 0;

            var inputArray = new int[5] { 1, 2, 3, 4, 5 };

            var expectedArray = new int[5] { 1, 2, 3, 4, 5 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, inputArray);

            CollectionAssert.AreEqual(expectedArray, rotatedArray);
        }

        [TestMethod]
        public void OneRotationsShouldReturnUpdatedArray()
        {
            var rotations = 1;

            var inputArray = new int[5] { 1, 2, 3, 4, 5 };

            var expectedArray = new int[5] { 2, 3, 4, 5, 1 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, inputArray);

            CollectionAssert.AreEqual(expectedArray, rotatedArray);
        }

        [TestMethod]
        public void FourRotationsShouldReturnUpdatedArray()
        {
            var rotations = 4;

            var inputArray = new int[5] { 1, 2, 3, 4, 5 };

            var expectedArray = new int[5] { 5, 1, 2, 3, 4 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, inputArray);

            CollectionAssert.AreEqual(expectedArray, rotatedArray);
        }

        [TestMethod]
        public void RotationsEqualToArrayLengthShouldReturnSameArray()
        {
            var inputArray = new int[5] { 1, 2, 3, 4, 5 };

            var rotations = inputArray.Length;

            var expectedArray = new int[5] { 1, 2, 3, 4, 5 };

            var arrayRotation = new ArrayLeftRotation();

            var rotatedArray = arrayRotation.RotateLeft(rotations, inputArray);

            CollectionAssert.AreEqual(expectedArray, rotatedArray);
        }
    }
}
