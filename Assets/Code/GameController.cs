using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<Brick> bricks;
    public List<Paddle> paddles;
    public int numberOfPaddlesLeft;
    public int numberOfBricks = 0;
    private void Awake()
    {
        numberOfPaddlesLeft = 5;
        bricks = new List<Brick>();
        paddles = new List<Paddle>();
        for (int i = 0; i < numberOfPaddlesLeft; i++)
        {
            Paddle paddle = new Paddle();
            paddles.Add(paddle);

            if (i == numberOfPaddlesLeft - 1)
            {
                paddle.IsActive = true;
            }
        }

    }
}
