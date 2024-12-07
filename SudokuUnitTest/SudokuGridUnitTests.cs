using SudokuLib;

namespace SudokuUnitTest
{
    public class SudokuGridTests
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void DefaultCtor_SudokuGridCtorCall_DefaultGridAllZeros()
        {
            // arrange, act, assert
            var sudokuGrid = new SudokuGrid();

            int[][] target = [[0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0],
                              [0, 0, 0, 0, 0, 0, 0, 0, 0]];

            Assert.AreEqual(target, sudokuGrid.Grid);
        }
    }
}