using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    [SerializeField]
    private GameObject paddle;
    [SerializeField]
    private GameObject ball;

    [SerializeField]
    bool isSpeedBoost;
    [SerializeField]
    bool isPaddleGrower;
    [SerializeField]
    bool isPaddleShrinker;
    [SerializeField]
    bool isBallMultipler;
    private LevelController levelController;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        levelController = GameObject.FindGameObjectWithTag("LevelController").GetComponent<LevelController>();
        if (isPaddleGrower)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        else if (isSpeedBoost)
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        else if (isPaddleShrinker)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if (isBallMultipler)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
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
            else if (isPaddleGrower)
            {
                paddle.transform.localScale = new Vector3(paddle.transform.localScale.x * 1.5f, paddle.transform.localScale.y);
                Destroy(gameObject);
            }
            else if (isPaddleShrinker)
            {
                paddle.transform.localScale = new Vector3(paddle.transform.localScale.x / 1.5f, paddle.transform.localScale.y);
                Destroy(gameObject);
            }
            else if (isBallMultipler)
            {
                levelController.numberOfBalls++;
                GameObject instantiatedBall = Instantiate(ball, transform.position, Quaternion.identity, null);
                instantiatedBall.GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.right).normalized * paddle.GetComponent<PaddleController>().GetBallSpeed(), ForceMode2D.Impulse);
                Destroy(gameObject);
            }
        }

    }
}
