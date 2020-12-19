using System;
using System.IO;
using Xunit;

namespace TCX.Tests
{
    public class FilesParseTests
    {
        [Fact]
        public void Parser_Parse_File1_ShouldContainTrack()
        {
            var tcxStream = File.OpenRead("./data/file1.tcx");

            var result = TCX.Parser.Parse(tcxStream);
            
            Assert.NotNull(result);
            Assert.NotNull(result.Activities);
            Assert.Single(result.Activities.Activity);
            Assert.NotNull(result.Activities.Activity[0]);
            Assert.NotNull(result.Activities.Activity[0].Lap);
            Assert.Single(result.Activities.Activity[0].Lap);
            Assert.NotNull(result.Activities.Activity[0].Lap[0]);
            Assert.NotNull(result.Activities.Activity[0].Lap[0].Track);
            Assert.True(result.Activities.Activity[0].Lap[0].Track.Count > 20);
        }
    }
}
