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

    //One player represents all players, without that we'd need to make a whole new player with the picking method tied to them. 
    internal class RPSPlayer
    {
        public string Name { get; set; } 
        IRPSPicker picker;
        INamer namer; 

        //The goal here is to allow any player to use any approach for RPS 
        public RPSPlayer(IRPSPicker picker, INamer namer)
        {
            this.picker = picker;
            this.namer = namer;

            Name = namer.PickName();
        }

        public RockPaperScissors PickRPS()
        {
            //This abstracts this functionality entirely over into the interface hiearchy
            return picker.ChooseRPS();
        }
    }
}
