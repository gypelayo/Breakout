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
        [Test]
        public void _7_Default_Brick_Position_Is_X0_Y0()
        {
            Brick brick = new Brick();
            Assert.AreEqual(new Vector2(0, 0), brick.Position);
        }
        [Test]
        public void _8_Setting_Brick_Position_Changes_Position()
        {
            Brick brick = new Brick();
            brick.Position = new Vector2(2,0);
            Assert.AreEqual(new Vector2(2, 0), brick.Position);
        }
        [Test]
        public void _9_Brick_Has_Gameobject_Associated()
        {
            Brick brick = new Brick();
            brick.BrickGameObject = CreateGameObjectWithSpriteRenderer();
            Assert.AreNotEqual(null, brick.BrickGameObject);
        }
        [Test]
        public void _A_BrickGameobject_Has_SpriteRenderer()
        {
            Brick brick = new Brick();
            brick.BrickGameObject = CreateGameObjectWithSpriteRenderer();
            Assert.AreNotEqual(null, brick.BrickGameObject.GetComponent<SpriteRenderer>());
        }
        [Test]
        public void _B_BrickGameObject_SpriteRenderer_Is_Of_Brick_Color()
        {
            Brick brick = new Brick(Color.red);
            brick.BrickGameObject = CreateGameObjectWithSpriteRenderer();
            Assert.AreEqual(Color.red, brick.BrickGameObject.GetComponent<SpriteRenderer>().color);
        }
        [Test]
        public void _C_Can_Change_Brick_Color_And_SpriteRenderer()
        {
            Brick brick = new Brick(Color.red);
            brick.BrickGameObject = CreateGameObjectWithSpriteRenderer();
            brick.SetColor(Color.green);
            Assert.AreEqual(Color.green, brick.Color);
            Assert.AreEqual(Color.green, brick.GetSpriteRenderer().color);
        }
        [Test]
        public void _D_BrickGameObject_Is_Of_Brick_Size()
        {
            Brick brick = new Brick(Color.red);
            brick.BrickGameObject = CreateGameObjectWithSpriteRenderer();
            Assert.AreEqual(brick.BrickGameObject.transform.localScale.x, brick.Size);
        }
        public GameObject CreateGameObjectWithSpriteRenderer()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<SpriteRenderer>();
            return gameObject;
        }
    }
}
