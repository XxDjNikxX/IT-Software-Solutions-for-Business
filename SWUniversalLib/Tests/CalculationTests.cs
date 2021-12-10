using NUnit.Framework;
using SWUniversalLib;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// �������� �� ���������� ������
        /// </summary>
        [Test]
        public void getQuantityForProduct_correctAnswer()
        {
            Assert.AreEqual(114148,
                    Calculation.getQuantityForProduct(3, 1, 15, 20, 45));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ������� �����������
        /// </summary>
        [Test]
        public void getQuantityForProduct_correctAnswer�ountZero()
        {
            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(3, 1, 0, 20, 45));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ������� �������
        /// </summary>
        [Test]
        public void getQuantityForProduct_correctLengthZero()
        {
            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(3, 1, 4, 20, 0));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ������� ������
        /// </summary>
        [Test]
        public void getQuantityForProduct_correctHeightZero()
        {
            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(3, 1, 4, 0, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ��������������� ���� ��������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputProductTypeDoesNotExist()
        {
            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(4, 1, 4, 20, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ��������������� ���� ���������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputMaterialTypeDoesNotExist()
        {

            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(2, 3, 4, 20, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � �������������� ����������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputNegativeCount()
        {

            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(4, 1, -1, 20, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ��������������� ������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputNegativeWidth()
        {

            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(4, 1, 4, -1432, 20));
        }
        /// <summary>
        ///  �������� �� ���� ���������� ������ � ������������� �����
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputNegativeLength()
        {

            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(4, 1, 4, 20, -3));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � �������������� ���� ��������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputNegativeProductType()
        {

            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(-1, 1, 4, 20, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ � ������������� ���� ���������
        /// </summary>
        [Test]
        public void getQuantityForProduct_wrongInputNegativeMaterialType()
        {
            Assert.AreEqual(-1,
                    Calculation.getQuantityForProduct(2, -1, 4, 20, 20));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ �� ���������� �����
        /// </summary>
        [Test]
        public void getQuantityForProduct_floatValues()
        {

            Assert.AreEqual(2069,
                    Calculation.getQuantityForProduct(2, 1, 20, 20.5f, 2.0123f));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ �� ���������� ����� ������ �������
        /// </summary>
        [Test]
        public void getQuantityForProduct_smallFloatValues()
        {

            Assert.AreEqual(32,
                    Calculation.getQuantityForProduct(2, 1, 1000, 0.0123f, 1.0123f));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ �� ���������� �����
        /// </summary>
        [Test]
        public void getQuantityForProduct_smallFloatValuesMaterialType2()
        {

            Assert.AreEqual(2066,
                    Calculation.getQuantityForProduct(2, 2, 20, 20.5f, 2.0123f));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ �� ���������� �����
        /// </summary>
        [Test]
        public void getQuantityForProduct_smallFloatValuesAgain()
        {

            Assert.AreEqual(32,
                    Calculation.getQuantityForProduct(2, 1, 1000, 0.0123f, 1.0123f));
        }
        /// <summary>
        /// �������� �� ���� ���������� ������ �� ���������� �����
        /// </summary>
        [Test]
        public void getQuantityForProduct_()
        {

            Assert.AreEqual(14,
                    Calculation.getQuantityForProduct(1, 1, 1000, 0.0123f, 1.0123f));
        }

    }
}