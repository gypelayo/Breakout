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
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        paddle = gameController.paddles[gameController.paddles.Count - 1];

        //Init mouse variables
        moveSpeed = 0.1f;
        rb = GetComponent<Rigidbody2D>();
        position = transform.position;
    }
    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        position = new Vector2(position.x, paddle.Position.y);
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
}
