using System;
using System.Text;
using Challenges.QueueStacks;
using Xunit;

namespace Challenges.Tests.QueueStacks
{
    public class MultiBracketValidationTests
    {
        [Theory]
        [InlineData("{}", true)]
        [InlineData("{", false)]
        [InlineData("(())", true)]
        [InlineData("{{enfj}}", true)]
        [InlineData("{{(yup)})", false)]
        [InlineData("[puy[", false)]
        public void MultiSupportBracing(string brace, bool expected)
        {
            bool result = MultiBracketValidation.braceCheck(brace);

            Assert.Equal(result, expected);
        }
    }
}
