using System;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        public string Check(string a , string b)
        {
            if(a =="Rock" || a =="Paper" || a =="Scissors")
            {
                
            }
            else
            {
                throw new Exception();
            }
            if(b =="Rock" || b =="Paper" || b =="Scissors")
            {
                 
            }
            else
            {
                throw new Exception();
            }

            if(a != b)
            {
                if((a == "Rock" && b == "Scissors")||(a == "Scissors" && b == "Rock"))
                {
                    return "Rock";

                }
                
                if((a == "Rock" && b == "Paper")||(a == "Paper" && b == "Rock"))
                {
                    return "Paper";
                }
                

                if((a == "Paper" && b == "Scissors")||(a == "Scissors" && b == "Paper"))
                {
                    return "Scissors";
                }
               
            }
            else
            {
                return "Ничья";
            }
<<<<<<< HEAD
=======

>>>>>>> a8534c0a56ad121ec755547e4a565ec98fa8cde0
            return "";
        }
    }
}
