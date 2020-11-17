using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMonobehaviour : MonoBehaviour
{
    private Brick brick;
    [SerializeField]
    private int powerupId;
    [SerializeField]
    private GameObject powerupPrefab;
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
        brick.Powerup.Id = powerupId;
        gameController.bricks.Add(brick);
        gameController.numberOfBricks++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {
            gameController.bricks.Remove(brick);
            if (powerupId != 0)
            {
                GameObject powerup = Instantiate(powerupPrefab,transform.position,Quaternion.identity,null);
                powerup.GetComponent<PowerupMonobehaviour>().powerupId=powerupId;
            }
            gameController.account.AddFunds(ValueGained());
            gameController.bricks.Remove(brick);
            gameController.numberOfBricks--;
            Destroy(gameObject);
        }
    }

    private int ValueGained()
    {
        if (brick.Color == Color.magenta)
        {
            return 50;
        }
        if (brick.Color == Color.blue)
        {
            return 100;
        }
        if (brick.Color == Color.green)
        {
            return 150;
        }
        if (brick.Color == Color.red)
        {
            return 200;
        }
        else
        {
            return 0;
        }

    }

}

