using Microsoft.CodeAnalysis;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var assembly = typeof(AssemblyIdentity).Assembly;
            var identity = AssemblyIdentity.FromAssemblyDefinition(assembly);
            var token = identity.PublicKeyToken;
        }
    }
}
