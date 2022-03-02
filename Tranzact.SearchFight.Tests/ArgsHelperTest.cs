using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transact.SearchFight.ConsoleUI.Helper;
using Xunit;

namespace Tranzact.SearchFight.Tests
{
    public class ArgsHelperTest
    {
        [Fact]
        public void ExtractArgs_IncludeQuotedArg()
        {
            // Arrange
            string stringArgs = ".net java \"java script\"";
            // Act
            var args = ArgsHelper.ExtractArgs(stringArgs);
            // Assert
            Assert.Equal(3, args.Count);
        }
    }
}
