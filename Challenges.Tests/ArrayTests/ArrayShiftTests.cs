using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayShiftTests
    {
        [Fact]
        public void Can_shift_into_even_length()
        {
            int[] input = new[] { 1, 2, 4, 5 };

            int[] result = Array.InsertShiftArray.ArrayShift(input, 3);

            Assert.Equal(new[] { 1, 2, 3, 4, 5, }, result);
        }

        [Fact]
        public void Can_shift_into_odd_length()
        {

            int[] input = new[] { 1, 2, 3, 5, 6 };

            int[] result = Array.InsertShiftArray.ArrayShift(input, 4);

            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6}, result);
        }
    }
}
