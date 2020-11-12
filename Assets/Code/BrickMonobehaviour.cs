using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMonobehaviour : MonoBehaviour
{
    private GameController gameController;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Brick newBrick = new Brick();
        newBrick.BrickGameObject = gameObject;
        gameController.bricks.Add(newBrick);
        gameController.numberOfBricks++;
    }
}

