using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySellStockTests
{
    [TestClass]
    public class BuySellStockTests
    {
        [TestMethod]
        public void TestMaxProfit_BasicCase()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(5, result); // Expected profit is 5
        }

        [TestMethod]
        public void TestMaxProfit_NoProfit()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 7, 6, 4, 3, 1 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(0, result); // No profit possible, expected 0
        }

        [TestMethod]
        public void TestMaxProfit_SingleDay()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 5 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(0, result); // Only one price, no transaction possible, expected 0
        }

        [TestMethod]
        public void TestMaxProfit_ConstantPrices()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 3, 3, 3, 3, 3 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(0, result); // All prices are the same, no profit possible, expected 0
        }

        [TestMethod]
        public void TestMaxProfit_ProfitAtEnd()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 1, 2, 3, 4, 5 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(4, result); // Buy at 1, sell at 5, expected profit 4
        }

        [TestMethod]
        public void TestMaxProfit_ProfitAtStartAndEnd()
        {
            // Arrange
            BuySellStock buySellStock = new BuySellStock();
            int[] prices = { 2, 1, 2, 1, 2 };

            // Act
            int result = buySellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(1, result); // Multiple small profits possible, max profit is 1
        }
    }
}