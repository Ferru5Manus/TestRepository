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

        public void CheckTest(string player1, string player2, string expectedResult)
        {
             WinnerChecker winerChecker = new WinnerChecker();

            var result  = winerChecker.Check(player1,player2);
                
           Assert.Equal(expectedResult,result);
        }

        [Theory]

        [InlineData("Rock" , "Scissors" , "Rock")]
        [InlineData("Paper", "Rock" , "Paper")]
        public void CheckTestTheory(string player1, string player2, string expectedResult)
        {
             WinnerChecker winerChecker = new WinnerChecker();

            var result  = winerChecker.Check(player1,player2);
                
           Assert.Equal(expectedResult,result);
        }

    }
}
