using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    class Piece : IPiece
    {
        public Status Status => throw new NotImplementedException();

        public Symbol Symbol => throw new NotImplementedException();

        public int Position => throw new NotImplementedException();

        public void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
