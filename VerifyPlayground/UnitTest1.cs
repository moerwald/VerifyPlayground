using ClassLibrary1;
using System;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace VerifyPlayground
{
    [UsesVerify]
    public class UnitTest1
    {
        [Fact]
        public Task Test()
        {
            var person = ClassBeingTested.FindPerson();
            return Verifier.Verify(person);
        }
    }
}
