using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode.Tests
{
    [TestClass()]
    public class SameTreeTests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            var p = BinaryTreeHelper.BuildTree([1, 2, 3]);
            var q = BinaryTreeHelper.BuildTree([1, 2, 3]);
            bool expected = true;
            var actual = new SameTree().IsSameTree(p!, q!);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsSameTreeTest2()
        {
            var p = BinaryTreeHelper.BuildTree([1, 2]);
            var q = BinaryTreeHelper.BuildTree([1, null, 2]);
            bool expected = false;
            var actual = new SameTree().IsSameTree(p!, q!);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsSameTreeTest3()
        {
            var p = BinaryTreeHelper.BuildTree([1, 2, 1]);
            var q = BinaryTreeHelper.BuildTree([1, 1, 2]);
            bool expected = false;
            var actual = new SameTree().IsSameTree(p!, q!);
            Assert.AreEqual(expected, actual);
        }
    }
}