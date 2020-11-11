using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BrickTests
    {
        [Test]
        public void _0_Cretating_New_Brick_Sets_Size_To_2()
        {
            Brick brick = new Brick();
            Assert.AreEqual(2, brick.Size);
        }
        [Test]
        public void _1_Creating_New_Brick_With_Size_3_Sets_Size_3()
        {
            Brick brick = new Brick(3);
            Assert.AreEqual(3, brick.Size);
        }
    }
}
