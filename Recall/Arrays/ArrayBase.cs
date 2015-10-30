﻿// The MIT License (MIT)

// Copyright (c) 2015 Ben Abelshausen

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace Recall.Arrays
{
    /// <summary>
    /// Abstract representation of an array.
    /// </summary>
    public abstract class ArrayBase<T> : IDisposable
    {
        /// <summary>
        /// Returns the length of this array.
        /// </summary>
        public abstract long Length { get; }
        
        /// <summary>
        /// Resizes this array.
        /// </summary>
        /// <param name="size"></param>
        public abstract void Resize(long size);

        /// <summary>
        /// Gets or sets the element at the given index.
        /// </summary>
        public abstract T this[long idx] { get; set; }

        /// <summary>
        /// Disposes of all resources associated with this array.
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// Copies all the data over from the given array to this array.
        /// </summary>
        /// <param name="array">The array to copy to.</param>
        public virtual void CopyFrom(ArrayBase<T> array)
        {
            this.CopyFrom(array, 0, 0, array.Length);
        }

        /// <summary>
        /// Copies all the data over from the given array to this array.
        /// </summary>
        /// <param name="array">The array to copy to.</param>
        /// <param name="count">The number of elements to copy.</param>
        public virtual void CopyFrom(ArrayBase<T> array, long count)
        {
            this.CopyFrom(array, 0, 0, count);
        }

        /// <summary>
        /// Copies all the data over from the given array to this array.
        /// </summary>
        /// <param name="array">The array to copy to.</param>
        /// <param name="index">The index to copy to.</param>
        /// <param name="start">The start index to copy from.</param>
        /// <param name="count">The number of elements to copy.</param>
        public virtual void CopyFrom(ArrayBase<T> array, long index, long start, long count)
        {
            for (int idx = 0; idx < count; idx++)
            {
                this[index + idx] = array[start + idx];
            }
        }
    }
}