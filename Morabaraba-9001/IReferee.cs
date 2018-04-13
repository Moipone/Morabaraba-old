using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();  
    }
}
