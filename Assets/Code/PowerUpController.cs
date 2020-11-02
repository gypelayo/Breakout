using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    [SerializeField]
    private GameObject paddle;

    [SerializeField]
    bool isSpeedBoost;
    [SerializeField]
    bool isPaddleGrower;
    [SerializeField]
    bool isPaddleShrinker;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if (isPaddleGrower)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (isSpeedBoost)
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        if (isPaddleShrinker)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (isSpeedBoost)
            {
                paddle.GetComponent<PaddleController>().setSpeed(15);
                Destroy(gameObject);
            }
            if (isPaddleGrower)
            {
                paddle.transform.localScale = new Vector3(paddle.transform.localScale.x * 1.5f, paddle.transform.localScale.y);
                Destroy(gameObject);
            }
            if (isPaddleShrinker)
            {
                paddle.transform.localScale = new Vector3(paddle.transform.localScale.x / 1.5f, paddle.transform.localScale.y);
                Destroy(gameObject);
            }
        }

    }
}
