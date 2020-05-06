using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Challenge
{
    public class ArrayReverseTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3}, new[] { 3, 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1})]
        public void Can_reverse_array_of_numbers(int[] input, int[] expected)
        {
            int[] result = Challenges.ArrayReverse.ReverseArray(input);

            Assert.Equal(expected, result);

            Assert.NotSame(input, result);
        }
    }
}
