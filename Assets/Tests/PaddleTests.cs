using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class PaddleTests
    {
        [Test]
        public void _0_Creating_Paddle_Sets_Horizontal_Size_To_2()
        {
            Paddle paddle = new Paddle();
            Assert.AreEqual(2, paddle.HorizontalSize);
        }
        [Test]
        public void _1_Creating_Paddle_With_Size_Sets_Horizontal_Size()
        {
            Paddle paddle = new Paddle(4);
            Assert.AreEqual(4, paddle.HorizontalSize);
        }
        [Test]
        public void _2_Paddle_Sets_Color()
        {
            Paddle paddle = new Paddle();
            paddle.SetColor(Color.green);
            Assert.AreEqual(Color.green, paddle.Color);
        }
        [Test]
        public void _3_Paddle_Sets_Position()
        {
            Paddle paddle = new Paddle();
            paddle.Position = new Vector2(2,3);
            Assert.AreEqual(new Vector2(2,3), paddle.Position);
        }
        [Test]
        public void _4_Creating_Paddle_At_Default_Position()
        {
            Paddle paddle = new Paddle();
            Assert.AreEqual(new Vector2(0,-8.75f), (Vector2)paddle.Position);
        }
    }
}
