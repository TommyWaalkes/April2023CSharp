using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    //Rock Paper Scissor is a game used to resolve conflict 
    //Rock beats Scissors 
    //Paper Beats Rock 
    //Scissors beats Paper
    public enum RockPaperScissors
    {
        Rock,
        Paper,
        Scissors
    }
    internal class RPSPlayer
    {
        IRPSPicker picker; 

        //The goal here is to allow any player to use any approach for RPS 
        public RPSPlayer(IRPSPicker picker)
        {
            this.picker = picker;
        }

        public RockPaperScissors PickRPS()
        {
            //This abstracts this functionality entirely over into the interface hiearchy
            return picker.ChoosesRPS();
        }
    }
}
