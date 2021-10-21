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
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void TestSuitSimplePasses()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void TestSuitWithEnumeratorPasses()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

    }
}
