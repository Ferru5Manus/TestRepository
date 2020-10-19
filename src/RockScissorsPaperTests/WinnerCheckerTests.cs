using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
       [Fact]
        public void Test1()
        {
            WinnerChecker winerChecker = new WinnerChecker();

            var result  = winerChecker.Check("Rock","Scissors");
                
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
