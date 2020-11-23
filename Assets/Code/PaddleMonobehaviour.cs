using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMonobehaviour : MonoBehaviour
{
    public Paddle paddle;
    public GameController gameController;
    [SerializeField]
    public float moveSpeed;
    public Vector3 mousePosition;
    public Rigidbody2D rb;
    public Vector2 position;
    public bool hasBall;
    public GameObject ballObject;
    public void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        paddle = gameController.paddles[gameController.paddles.Count - 1];
        VariableInit();
    }
    public void Update()
    {
        MouseMovement();
        if (hasBall && Input.GetKeyDown(KeyCode.Mouse0))
        {
            hasBall = false;
            ShootBall();
        }
    }
    public void FixedUpdate()
    {
        rb.MovePosition(position);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {
            other.collider.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            other.collider.GetComponent<Rigidbody2D>().AddForce(ReflectBall(other.transform.position.x - transform.position.x), ForceMode2D.Impulse);
        }
    }

    public void VariableInit()
    {
        moveSpeed = 1f;
        rb = GetComponent<Rigidbody2D>();
        position = transform.position;
        hasBall = true;
        ballObject = transform.GetChild(0).gameObject;
    }
    public void MouseMovement()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        position = new Vector2(position.x, paddle.Position.y);
        paddle.Position = position;
    }
    public void ShootBall()
    {
        ballObject.transform.parent = null;
        ballObject.AddComponent<Rigidbody2D>();
        ballObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        ballObject.GetComponent<Rigidbody2D>().drag = 0;
        ballObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }

    public Vector2 ReflectBall(float distToCenter)
    {
        return (Vector2.up + new Vector2(distToCenter / transform.localScale.x, 0)).normalized * 10;
    }
}
