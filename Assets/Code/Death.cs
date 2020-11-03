using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    [SerializeField]
    private LevelController levelController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            levelController.numberOfBalls--;

            if (levelController.numberOfBalls == 0)
            {
                RespawnPaddle(collision);
            }
            else
            {
                Destroy(collision.collider.gameObject);
            }
        }
    }

    private void RespawnPaddle(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
        Destroy(transform.parent.GetChild(0).gameObject);
        GameObject temp = Instantiate(playerPrefab, transform.parent.position, Quaternion.identity, transform.parent);
        temp.transform.SetAsFirstSibling();


    }
}
