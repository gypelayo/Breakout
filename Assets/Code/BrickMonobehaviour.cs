using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMonobehaviour : MonoBehaviour
{
    public Brick brick;
    [SerializeField]
    public int powerupId;
    [SerializeField]
    public GameObject powerupPrefab;
    public IGameController gameController;
    public void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        BrickSetup();
    }

    public void BrickSetup()
    {
        brick = new Brick();
        brick.BrickGameObject = gameObject;
        brick.Powerup.Id = powerupId;
        gameController.bricks.Add(brick);
        gameController.numberOfBricks++;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {
            BallCollisionHandler();
        }
    }

    public int ValueGained()
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

    public void BallCollisionHandler()
    {
        gameController.bricks.Remove(brick);
        if (powerupId != 0)
        {
            GameObject powerup = Instantiate(powerupPrefab, transform.position, Quaternion.identity, null);
            powerup.GetComponent<PowerupMonobehaviour>().powerupId = powerupId;
        }
        gameController.account.AddFunds(ValueGained());
        gameController.numberOfBricks--;
        Destroy(gameObject);
    }

}

