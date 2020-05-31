using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Библиотека;

namespace Тест
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_2_6_9()
        {
            string actError, expError="Нет корней";
            double[] expResult = new double[0];
            int a = 2, b = 6, c = 9;
            double[] actResult = Class1.Mathing(a, b,c,out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение ошибке("+actError+") не совпадает с ожидаемым" + expError);
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i< expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], actResult[i]);
            }
            

        }
    }
}
