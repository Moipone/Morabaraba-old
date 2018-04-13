﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public enum Status { captured, active }
    public interface IPlayer
    {  
        string symbol { get; set; }
        string Phase { get; set; }
        IEnumerable<string> getLastPosPlayer { get; set; }

        IEnumerable<string> millsFormed { get; set; }
    }
}
