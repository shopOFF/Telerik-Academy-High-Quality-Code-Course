﻿namespace RotatingWalkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CellTests
    {
        private Cell firstCell = new Cell(1, 2);
        private Cell secondCell = new Cell(2, 1);

        [TestMethod]
        public void AWhenAddingTwoCells_ShouldReturnANewCellWithCorrectXAndYValues()
        {
            Cell resultingCell = this.firstCell + this.secondCell;

            Assert.AreEqual(3, resultingCell.X, "resultingCell.X should be equal to firstCell.X + secondCell.X");
            Assert.AreEqual(3, resultingCell.Y, "resultingCell.Y should be equal to firstCell.Y + secondCell.Y");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingTwoCells_WhenEitherOfTheOperandsIsNull_ShouldThrowAnArgumentNullException()
        {
            Cell test = this.firstCell + null;
        }
    }
}