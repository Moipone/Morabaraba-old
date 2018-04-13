using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{

    public enum Symbol { CB, CW }
    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        Status Status { get; }
        Symbol Symbol { get; }
        int Position { get; }
        void Move(int destination);
    }
}
