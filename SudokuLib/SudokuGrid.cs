using System.Text;

namespace SudokuLib
{
    public class SudokuGrid
    {
        private const int SIZE = 9;

        public SudokuGrid()
        {
            _grid = new int[SIZE][];
            for (int i = 0; i < SIZE; i++)
            {
                _grid[i] = [0, 0, 0, 0, 0, 0, 0, 0, 0];
            }

        }

        public SudokuGrid(int[][] grid)
        {
            this._grid = grid;
        }

        private int[][] _grid;
        public int[][] Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }


        public override string ToString()
        {
            StringBuilder sb = new();
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    sb.Append(_grid[i][j]);
                    if (j != SIZE-1) sb.Append(", ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
