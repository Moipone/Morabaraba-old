using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public interface IBoard
    {
        IEnumerable<IEnumerable<string>> mills { get; set; }
        IEnumerable<Tile> board { get; set; }

        void generateBoard();

        void updateBoard(Tile tile);
        IEnumerable<IEnumerable<string>> allPossibleMills();

        IEnumerable<string> getNeighbourCells(string pos);
    
    }
}
