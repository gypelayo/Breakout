using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool ballReleased;

    [SerializeField]
    private float ballSpeed;
    private GameObject ball;
    void Start()
    {
        ballReleased = false;
        rb = GetComponent<Rigidbody2D>();
        ball = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        transform.position = new Vector2(worldPosition.x, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Mouse0) && !ballReleased)
        {
            ballReleased = true;
            ball.transform.parent = null;
            ball.GetComponent<Rigidbody2D>().AddForce(Vector3.up * ballSpeed, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            collision.collider.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            float distToCenter = collision.transform.position.x - transform.position.x;
            collision.collider.GetComponent<Rigidbody2D>().AddForce((Vector2.up + 2 * new Vector2(distToCenter, 0).normalized).normalized * ballSpeed, ForceMode2D.Impulse);
        }
    }
}
