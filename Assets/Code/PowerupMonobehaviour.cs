using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupMonobehaviour : MonoBehaviour
{
    public int powerupId;
    [SerializeField]
    private GameObject ballPrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.transform.childCount != 0)
            {
                other.GetComponent<PaddleMonobehaviour>().ShootBall();
            }
            ApplyEffect(powerupId, other);
            Destroy(gameObject);
        }
    }
    private void ApplyEffect(int powerupId, Collider2D other)
    {
        switch (powerupId)
        {
            case 1:
                other.transform.localScale = new Vector2(4, 0.5f);
                break;
            case 2:
                other.transform.localScale = new Vector2(1, 0.5f);
                break;
            case 3:
                GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
                foreach (GameObject ball in balls)
                {
                    GameObject instantiatedBall = Instantiate(ballPrefab, ball.transform.position, Quaternion.identity, null);
                    instantiatedBall.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
                }
                break;

        }
    }
}
