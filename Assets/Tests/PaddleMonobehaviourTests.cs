using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PaddleMonobehaviourTests
    {
        [Test]
        public void ShootBall_Sets_Ball_Parent_To_Null()
        {
            GameObject testPaddle = new GameObject();
            testPaddle.AddComponent<Rigidbody2D>();

            GameObject ball = new GameObject();
            ball.transform.parent = testPaddle.transform;

            PaddleMonobehaviour paddleMonobehaviour = testPaddle.AddComponent<PaddleMonobehaviour>();

            paddleMonobehaviour.VariableInit();
            paddleMonobehaviour.ShootBall();

            Assert.AreEqual(null, ball.transform.parent);
        }

        [Test]
        public void ShootBall_Adds_Vertical_Velocity_To_Ball()
        {
            GameObject testPaddle = new GameObject();
            testPaddle.AddComponent<Rigidbody2D>();

            GameObject ball = new GameObject();
            ball.transform.parent = testPaddle.transform;

            PaddleMonobehaviour paddleMonobehaviour = testPaddle.AddComponent<PaddleMonobehaviour>();

            paddleMonobehaviour.VariableInit();
            paddleMonobehaviour.ShootBall();

            Assert.AreEqual(0, ball.GetComponent<Rigidbody2D>().velocity.x);
            Assert.AreNotEqual(0, ball.GetComponent<Rigidbody2D>().velocity.y);
        }

        [Test]
        public void ReflectBall_Calculates_New_Direction_Of_Movement()
        {
            GameObject testPaddle = new GameObject();
            PaddleMonobehaviour paddleMonobehaviour = testPaddle.AddComponent<PaddleMonobehaviour>();
            float distToCenter = 1;
            Assert.AreEqual((Vector2.up + new Vector2(distToCenter / testPaddle.transform.localScale.x, 0)).normalized * 10, paddleMonobehaviour.ReflectBall(distToCenter));
        }
    }
}
