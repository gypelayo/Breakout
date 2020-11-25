using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BrickMonobehaviourTests
    {
        GameObject brickGameObject;
        BrickMonobehaviour brickMonobehaviour;
        IGameController gameController;

        [SetUp]
        public void Setup()
        {
            // Setup will work as the start method inside the testing monobehaviour

            //Game Controller Setup
            gameController = Substitute.For<IGameController>();
            gameController.bricks = new List<Brick>();
            gameController.paddles = new List<Paddle>();
            gameController.numberOfPaddlesLeft = 5;
            gameController.Awake();

            //Brick Setup
            brickGameObject = new GameObject();
            brickGameObject.AddComponent<SpriteRenderer>();
            brickMonobehaviour = brickGameObject.AddComponent<BrickMonobehaviour>();
            brickMonobehaviour.powerupId = 1;
            brickMonobehaviour.gameController = gameController;
            brickMonobehaviour.BrickSetup();
        }

        [Test]
        public void ValueGained_Is_Correct()
        {
            brickMonobehaviour.brick.Color = Color.magenta;
            Assert.AreEqual(50, brickMonobehaviour.ValueGained());
        }
    }
}
