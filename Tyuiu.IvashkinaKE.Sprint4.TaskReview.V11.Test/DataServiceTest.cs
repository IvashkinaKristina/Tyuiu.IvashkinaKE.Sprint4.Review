using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint4.TaskReview.V11.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.TaskReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "56789012";
            DataService ds = new DataService();
            double res = ds.Calculate(rows, columns, str);
            int wait = 4;
        }
    }
}
