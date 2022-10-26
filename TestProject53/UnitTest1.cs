namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(20, Kata.MinUnfairness(new int[] { 30, 100, 1000, 150, 60, 250, 10, 120, 20 }, 3));
            Assert.AreEqual(90, Kata.MinUnfairness(new int[] { 30, 100, 1000, 150, 60, 250, 10, 120, 20 }, 5));
            Assert.AreEqual(1, Kata.MinUnfairness(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }, 10));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }, 9));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 10));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 1, 1, -1 }, 2));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 1, 1 }, 2));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 30, 100, 1000, 150, 60, 250, 10, 120, 20 }, 1));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { 30, 100, 1000, 150, 60, 250, 10, 120, 20 }, 0));
            Assert.AreEqual(0, Kata.MinUnfairness(new int[] { }, 0));
        }
    }
}