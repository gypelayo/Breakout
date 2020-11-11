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
        [Test]
        public void _2_New_Brick_Default_Color_Is_Grey()
        {
            Brick brick = new Brick();
            Assert.AreEqual(Color.grey, brick.Color);
        }
        [Test]
        public void _3_Creating_New_Brick_With_Color_Red_Sets_It_Red()
        {
            Brick brick = new Brick(Color.red);
            Assert.AreEqual(Color.red, brick.Color);
        }
        [Test]
        public void _4_Creating_New_Brick_With_Color_And_Size()
        {
            Brick brick = new Brick(3, Color.red);
            Assert.AreEqual(3, brick.Size);
            Assert.AreEqual(Color.red, brick.Color);
        }
        [Test]
        public void _5_Setting_Brick_Color_Changes_Color()
        {
            Brick brick = new Brick();
            brick.Color = Color.red;
            Assert.AreEqual(Color.red, brick.Color);
        }
        [Test]
        public void _6_Setting_Brick_Size_Changes_Size()
        {
            Brick brick = new Brick();
            brick.Size = 3;
            Assert.AreEqual(3, brick.Size);
        }
    }
}
