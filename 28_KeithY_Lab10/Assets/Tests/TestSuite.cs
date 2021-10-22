﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(100, 90, "-");
            Assert.AreEqual(result, 10);
        }

        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(100, 90, "-");
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(4, 3, "*");
            Assert.AreEqual(result, 12);
        }

        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            yield return null;

            result = Calculator.CalculatePair(4, 3, "*");
            Assert.AreEqual(result, 12);
        }

        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(1000, 200, "/");
            Assert.AreEqual(result, 5);
        }

        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(1000, 200, "/");
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestSquareRoot()
        {
            result = Mathf.Sqrt(25);
            Assert.AreEqual(result, 5);
        }

        [UnityTest]
        public IEnumerator TestUnitySquareRoot()
        {
            yield return null;

            result = Mathf.Sqrt(25);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(5, 2, "Math.Pow");
            Assert.AreEqual(result, 0.0f);
        }

        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "Math.Pow");
            Assert.AreEqual(result, 0.0f);
        }
    }
}
