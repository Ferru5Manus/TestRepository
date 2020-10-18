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
            WinerChecker winerChecker = new WinerChecker();

            var result  = winerChecker.Check("Rock","Scissor");
                
           Assert.Equal("Rock",result);
        }
        [Fact]
        public void Test2()
        {
            WinerChecker winerChecker = new WinerChecker();

            var result  = winerChecker.Check("Rock","Paper");
                
            Assert.Equal("Paper",result);
        }

         [Fact]
        public void Test3()
        {
            WinerChecker winerChecker = new WinerChecker();

            var result  = winerChecker.Check("Rockkk","Paper");
                
            Assert.Equal(Exception,result);
        }
    }
}
