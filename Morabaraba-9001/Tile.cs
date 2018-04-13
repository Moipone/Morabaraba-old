using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public class Tile : ITile
    {
        public Tile()
        {

        }

        public string position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPiece condition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
