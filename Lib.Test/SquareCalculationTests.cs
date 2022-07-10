using Lib.Shapes;
namespace Lib.Test
{
    [TestClass]
    public class SquareCalculationTests
    {
        #region ������
        /// <summary>
        /// ���� �� ���������� ������� ������������
        /// </summary>
        [TestMethod]
        public void SquareTriangle()
        {
            double Square = new Triangle(1, 2, 3).Square(0);

            Assert.AreEqual(0, Square);
        }
        /// <summary>
        /// ���� �� ������������� ������� ������������
        /// </summary>
        [TestMethod]
        public void NegativeTriangleSides()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, -1, -1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -1, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, -1));
        }
        /// <summary>
        /// ���� �� �� ������������� �����������
        /// </summary>
        [TestMethod]
        public void IsNotRectangularTriangle()
        {
            bool isNotRectangularTriangle = new Triangle(2, 3, 4).IsRectangular();

            Assert.AreEqual(false, isNotRectangularTriangle);
        }
        /// <summary>
        /// ���� �� ������������� �����������
        /// </summary>
        [TestMethod]
        public void IsRectangularTriangle()
        {
            bool isRectangularTriangle = new Triangle(3, 4, 5).IsRectangular();

            Assert.AreEqual(true, isRectangularTriangle);
        }
        /// <summary>
        /// ���� �� ���������� ������� �����
        /// </summary>
        [TestMethod]
        public void SquareCircle()
        {
            double Square = new Circle(1).Square(0);

            Assert.AreEqual(3.141592653589793, Square);
        }
        /// <summary>
        /// ���� �� ������ ����� < 0
        /// </summary>
        [TestMethod]
        public void NegativeCircleRadius()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }
        #endregion
    }
}