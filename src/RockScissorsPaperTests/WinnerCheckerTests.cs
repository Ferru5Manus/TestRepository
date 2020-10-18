using System;
using Xunit;
using RockScissorsPaperLib;
using WinnerChecker = RockScissorsPaperLib.WinnerChecker;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
       [Fact]
        public void Test1()
        {
            WinnerChecker winerChecker = new WinnerChecker();

            var result  = winerChecker.Check("Rock","Scissor");
                
           Assert.Equal("Rock",result);
        }
        [Fact]
        public void Test2()
        {
            WinnerChecker winerChecker = new WinnerChecker();

            var result  = winerChecker.Check("Rock","Paper");
                
            Assert.Equal("Paper",result);
        }
    }
}
