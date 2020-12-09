using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ArrayManager<T>
    {
        public T[] Create(int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("Length must be greater than or equal to zero");

            return new T[length];
        }

        public T[] Increase(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null");

            Array.Resize(ref array, array.Length + 1);

            return array;
        }

        public T[] Decrease(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null");

            Array.Resize(ref array, array.Length - 1);

            return array;
        }

        public T[] Append(T[] array, T value)
        {
            if (array == null)
                throw new ArgumentNullException("Argument cannot be null.");

            array = Increase(array);
            array[array.Length - 1] = value;

            return array;
        }
    }
}
