using System;
using TestFrameworks;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void TestBugDodges(bool didDodge, bool shouldBeDead)
        {

            Bug bug = new Bug();
            Raygun gun = new Raygun();

            if (didDodge)
            {
                bug.Dodge();
            }

            gun.FireAt(bug);

            if (shouldBeDead)
            {
                Assert.True(bug.IsDead());
            }
            else
            {
                Assert.False(bug.IsDead());
            }
    }
    }
}
