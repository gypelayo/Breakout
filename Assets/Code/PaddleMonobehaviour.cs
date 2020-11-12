using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMonobehaviour : MonoBehaviour
{
    private Paddle paddle;
    private GameController gameController;
    [SerializeField]
    private float moveSpeed;
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 position;
    private bool hasBall;
    private GameObject ballObject;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        paddle = gameController.paddles[gameController.paddles.Count - 1];
        VariableInit();
    }
    private void Update()
    {
        MouseMovement();
        if (hasBall && Input.GetKeyDown(KeyCode.Mouse0))
        {
            hasBall = false;
            ShootBall();
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
    private void OnDestroy()
    {
        gameController.paddles[gameController.paddles.Count - 2].IsActive = true;
        gameController.paddles.Remove(paddle);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {

        }
    }

    private void VariableInit()
    {
        moveSpeed = 1f;
        rb = GetComponent<Rigidbody2D>();
        position = transform.position;
        hasBall = true;
        ballObject = transform.GetChild(0).gameObject;
    }
    private void MouseMovement()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        position = new Vector2(position.x, paddle.Position.y);
        paddle.Position = position;
    }
    private void ShootBall()
    {
        ballObject.transform.parent = null;
        ballObject.AddComponent<Rigidbody2D>();
        ballObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        ballObject.GetComponent<Rigidbody2D>().drag = 0;
        ballObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
