using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public List<Brick> bricks;
    public List<Paddle> paddles;
    [SerializeField]
    public int numberOfPaddlesLeft;
    public int numberOfBricks = 0;
    [SerializeField]
    private GameObject paddlePrefab;
    public Account account;
    [SerializeField]
    private Text balanceText;
    [SerializeField]
    private Text paddlesText;
    private void Awake()
    {
        account = new Account();
        account.AddFunds(PlayerPrefs.GetInt("Account Balance"));
        Cursor.visible = false;

        numberOfPaddlesLeft = 5;

        bricks = new List<Brick>();
        paddles = new List<Paddle>();

        CreatePaddleList();
        SpawnNewPaddle();
    }

    private void Update()
    {
        balanceText.text = account.Balance.ToString() + "$";
        paddlesText.text = numberOfPaddlesLeft.ToString();
    }
    public void SpawnNewPaddle()
    {
        GameObject firstPaddle = Instantiate(paddlePrefab, paddles[numberOfPaddlesLeft - 1].Position, Quaternion.identity, transform);
        firstPaddle.GetComponent<SpriteRenderer>().color = paddles[numberOfPaddlesLeft - 1].Color;
    }
    private void CreatePaddleList()
    {
        for (int i = 0; i < numberOfPaddlesLeft; i++)
        {
            Paddle paddle = new Paddle();
            paddles.Add(paddle);

            if (i == numberOfPaddlesLeft - 1)
            {
                paddle.IsActive = true;
            }
        }
    }
    public void LoosePaddle()
    {
        paddles.RemoveAt(paddles.Count - 1);
        numberOfPaddlesLeft--;
    }
}
