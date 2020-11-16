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
            Destroy(gameObject);
        }
    }

}

