﻿using System;
using System.Collections.Generic;
using System.Linq;
using CassowaryNET.Variables;
using NUnit.Framework;

namespace CassowaryNET.Tests.Variables
{
    [TestFixture]
    public class ObjectiveVariableTests
    {
        #region Helpers

        public abstract class TestBase
        {
            [SetUp]
            public virtual void SetUp()
            {
            }

            [TearDown]
            public virtual void TearDown()
            {
            }

            internal ObjectiveVariable GetTarget()
            {
                var target = new ObjectiveVariable("foo");
                return target;
            }
        }

        #endregion

        [TestFixture]
        public class Constructor_StringTests //: TestBase
        {
            [Test]
            public void can_be_created()
            {
                var target = new ObjectiveVariable("foo");

                Assert.That(target.Name, Is.EqualTo("foo"));

                Assert.That(target.IsDummy, Is.False);
                Assert.That(target.IsExternal, Is.False);
                Assert.That(target.IsPivotable, Is.False);
                Assert.That(target.IsRestricted, Is.False);
            }
        }
    }
}
