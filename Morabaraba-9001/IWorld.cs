using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public interface IWorld 
    {
        IBoard board  { get; set; }
        IPlayer player1 { get; set; }
        IPlayer player2 { get; set; }
        IReferee referee { get; set; }


    }
}