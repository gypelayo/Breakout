using NUnit.Framework;

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
    }
}
