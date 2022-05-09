using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        private Command TestCommand;

        public CommandTests()
        {
            TestCommand = new Command()
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }

        public void Dispose()
        {
            TestCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            

            TestCommand.HowTo = "Execute unit tests";
            Assert.Equal("Execute unit tests", TestCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {

            TestCommand.Platform = "xUnit not gUnit";
            Assert.Equal("xUnit not gUnit", TestCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {

            TestCommand.CommandLine = "dotnet test";
            Assert.Equal("dotnet test", TestCommand.CommandLine);
        }
    }
}
