using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ArrayManager
    {
        public int[] Create(int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("Length must be greater than or equal to zero");

            return new int[length];
        }

        public int[] Increase(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null");

            Array.Resize(ref array, array.Length + 1);

            return array;
        }

        public int[] Decrease(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null");

            Array.Resize(ref array, array.Length - 1);

            return array;
        }

        public int[] Append(int[] array, int value)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null.");

            array = Increase(array);
            array[array.Length - 1] = value;

            return array;
        }

        public int[] Shift(int[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null.");

            for (var i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            return array;
        }

        public int[] Remove(int[] array, int value)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null.");

            if (array.Length == 0)
                return array;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    array = Shift(array, i);
                    array = Decrease(array);
                }
            }

            return array;
        }
    }
}
