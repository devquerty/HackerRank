using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterviewChallenges
{
    public class ArrayLeftRotation
    {
        public int[] RotateLeft1(int rotations, int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array should be a non null with at least one member in it.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("array", "Array should have at least one member in it.");
            }

            if (rotations < 0 || rotations > array.Length)
            {
                throw new ArgumentOutOfRangeException("rotations", "Rotations should be a > 0 and < array.Length.");
            }

            int[] tempArray = new int[rotations];

            Array.Copy(array, tempArray, rotations);

            for (int i = 0; i < array.Length - rotations; i++)
            {
                array[i] = array[i + rotations];
            }

            Array.Copy(tempArray, 0, array, array.Length - rotations, rotations);

            return array;
        }

        public int[] RotateLeft2(int rotations, int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array should be a non null with at least one member in it.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("array", "Array should have at least one member in it.");
            }

            if (rotations < 0 || rotations > array.Length)
            {
                throw new ArgumentOutOfRangeException("rotations", "Rotations should be a > 0 and < array.Length.");
            }

            int[] tempArray = new int[array.Length];

            Array.Copy(array, rotations, tempArray, 0, array.Length - rotations);

            Array.Copy(array, 0, tempArray, array.Length - rotations, rotations);

            return tempArray;
        }

        public int[] RotateLeft(int rotations, int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array should be a non null with at least one member in it.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("array", "Array should have at least one member in it.");
            }

            if (rotations < 0 || rotations > array.Length)
            {
                throw new ArgumentOutOfRangeException("rotations", "Rotations should be a > 0 and < array.Length.");
            }

            var length = array.Length;

            for (int i = 1; i <= rotations; i++)
            {
                var first = array[0];

                for (int j = 0; j < length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[length - 1] = first;

            }

            return array;
        }
    }
}
