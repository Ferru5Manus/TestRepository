using System;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        public string Check(string a , string b)
        {
            if(a!="Rock" || a!="Paper" || a!="Scissors")
            {
                return Exeption;
            }
            if(b!="Rock" || b!="Paper" || b!="Scissors")
            {
                return Exeption;
            }

            if(a != b)
            {
                if((a == "Rock" && b == "Scissors")||(a == "Scissors" && b == "Rock"))
                return "Rock";

                if((a == "Rock" && b == "Paper")||(a == "Paper" && b == "Rock"))
                return "Paper";

                if((a == "Paper" && b == "Scissors")||(a == "Scissors" && b == "Paper"))
                return "Scissors";
               
            }
            else
            {
                return "Ничья";
            }
        }
    }
}
