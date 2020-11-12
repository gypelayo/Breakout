using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMonobehaviour : MonoBehaviour
{
    private Brick brick;
    private GameController gameController;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        BrickSetup();
    }

    private void BrickSetup()
    {
        brick = new Brick();
        brick.BrickGameObject = gameObject;
        gameController.bricks.Add(brick);
        gameController.numberOfBricks++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {
            gameController.bricks.Remove(brick);
            Destroy(gameObject);
        }
    }

}

